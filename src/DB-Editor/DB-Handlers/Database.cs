using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DB_Editor.DB_Connection;

namespace DB_Editor.DB_Handlers
{
    using QueryResult = List<Dictionary<string, string>>;
    static class Database
    {
        //jezeli jakas metoda nie dziala, to przed wywolaniem dodaj
        //DB_Connection.DBConnectionManager.Connect();
        private static MySqlCommand command_;
        static Database()
        {
            command_ = new MySqlCommand();
            command_.Connection = DBConnectionManager.Connection;
        }
        
        #region Methods

        #region DatabaseManipulateMethods

        //przykladowo:
        //List<ColumnStructureCreator> tmp2 = new List<ColumnStructureCreator>();
        //ColumnStructureCreator clmstr = new ColumnStructureCreator("nazwapola", "int");
        //ewentualnie uzywac w takiej postaci w .Add
        //tmp2.Add(new ColumnStructureCreator("nazwapola", "int"));
        //Database.CreateTable("nazwatabeli3", tmp2);

        //z kluczem glownym, przy testach jezeli jest klucz, to NIE moze byc default ustawiony
        //List<ColumnStructureCreator> clm = new List<ColumnStructureCreator>();
        //clm.Add(new ColumnStructureCreator("nazwapola", "int", false, false, "", true));
        //Database.CreateTable("nazwatabeli", clm);

        //z kluczami obcymi (pojedynczymi), przy testach pamietac by wszystkie pola byly ze soba zgodne
        //List<Tuple<string, string, string>> foreignkis = new List<Tuple<string, string, string>>();
        // foreignkis.Add(Tuple.Create("nazwapola", "nazwatabeli2", "nazwapola"));
        // Database.CreateTable("nazwatabeli", clm, foreignkis);
        public static OperationResult CreateDatabase(string dbName)
        {
            try
            {
                OpenConnection();
                command_.CommandText = "CREATE DATABASE " + dbName + ";";
                command_.ExecuteNonQuery();

                return new OperationResult(true, new Exception("QUERY Ok"));
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }
        }
        
        public static OperationResult DropDatabase()
        {
            return DropDatabase(DB_Connection.DBConnectionManager.DatabaseName);
        }
        public static OperationResult DropDatabase(string dbName)
        {
            try
            {
                OpenConnection();
                command_.CommandText = "DROP DATABASE " + dbName + ";";
                command_.ExecuteNonQuery();
                return new OperationResult(true, new Exception("QUERY Ok"));
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }
        }
        
        //przykladowo:
        //DB_Connection.DBConnectionManager.Connect();
        // DB_Connection.DBConnectionManager.Connection.Open();
        //Database.RenameDatabase("ok", "supernowanazwa");
        public static OperationResult RenameDatabase(string dbOldName, string dbNewName)
        {
            try
            {
                OpenConnection();
                List<string> tablesNames = new List<string>();
                Database.CreateDatabase(dbNewName);
                tablesNames = Database.GetTablesFromDatabase(dbOldName);
                CheckDbName(ref dbOldName);
                CheckDbName(ref dbNewName);
                string tmp = "RENAME TABLE ";
                
                foreach (string tableName in tablesNames)
                {
                    tmp += dbOldName + tableName + " TO " + dbNewName + tableName + ", ";
                }
                tmp = tmp.Substring(0, tmp.Length - 2);

                command_.CommandText = tmp + ";";
                command_.ExecuteNonQuery();

                dbOldName = dbOldName.Substring(0, dbOldName.Length - 1);
                Database.DropDatabase(dbOldName);

                return new OperationResult(true, new Exception("QUERY Ok"));
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }
        }

        #endregion

        #region TableManipulateMethods
        /// <summary>
        /// Methods for creating table in database;
        /// </summary>
        /// <param name="tableName">Name of the table</param>
        /// <param name="list"> List of columns in new table</param>
        /// <param name="foreignKeys"> List of foreign key tuples, where id1 = field name in tableName, id2 = referenced tableName, id3 = field name in referenced table</param>
        /// <returns></returns>
        public static OperationResult CreateTable(string tableName, List<ColumnStructureCreator> list, List<Tuple<string, string, string>> foreignKeys = null, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                string tmp = "CREATE TABLE " + dbName + tableName + " (";
                foreach (var i in list)
                {
                    tmp += i.ToString();
                    tmp += ", ";
                }
                if (foreignKeys != null)
                {
                    foreach (var foreignKeyTupl in foreignKeys)
                    {
                        tmp += "FOREIGN KEY (" + foreignKeyTupl.Item1 + ") REFERENCES " + foreignKeyTupl.Item2 + "(" + foreignKeyTupl.Item3 + ") ,";
                    }
                }
                tmp = tmp.Substring(0, tmp.Length - 2);
                tmp += ");";
                command_.CommandText = tmp;
                command_.ExecuteNonQuery();
                return new OperationResult(true, new Exception("QUERY Ok"));
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }
        }
        public static OperationResult DropTable(string tableName, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                MySqlCommand comm = new MySqlCommand("DROP TABLE " + dbName + tableName + ";", DBConnectionManager.Connection);
                comm.ExecuteNonQuery();
                return new OperationResult(true, new Exception("QUERY Ok"));
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }
        }
        public static OperationResult RenameTable(string oldName, string newName, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                command_.CommandText = "RENAME TABLE " + dbName + oldName + "TO " + newName + ";";
                command_.ExecuteNonQuery();
                return new OperationResult(true, new Exception("QUERY Ok"));
            }
            catch (Exception e)
            {
                return new OperationResult(false, e);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }
        }
        #endregion

        #region GetSomethingFromDatabaseMethods
        public static List<string> GetDatabases()
        {
            try
            {
                string tmp = "SHOW DATABASES;";
                List<string> tmpList = new List<string>();
                QueryResult res = DB_Connection.DBConnectionManager.Query(tmp);

                foreach (var i in res)
                {
                    tmpList.Add(i.First().Value);
                }
                return tmpList;
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }
        }
        public static List<string> GetTablesFromDatabase(string dbName)
        {
            try
            {
                string tmp = "SHOW TABLES IN " + dbName + ";";
                List<string> tmpList = new List<string>();
                QueryResult res = DB_Connection.DBConnectionManager.Query(tmp);
                
                foreach(var i in res)
                {
                    tmpList.Add(i.First().Value);
                }
                return tmpList;
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }       
        }
        public static List<string> GetFieldNamesFromTable(string tableName, string dbName = "")
        {
            try
            {
                CheckDbName(ref dbName);
                string tmp = "DESC " + dbName + tableName + ";";
                List<string> tmpList = new List<string>();
                QueryResult res = DB_Connection.DBConnectionManager.Query(tmp);

                foreach (var i in res)
                {
                    tmpList.Add(i.First().Value);
                }
                return tmpList;
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message);
            }
            finally
            {
                DBConnectionManager.Connection.Close();
            }     
        }
        #endregion

        #region PrivateMethods
        private static void CheckDbName(ref string dbName)
        {
            if (dbName != "")
                dbName = dbName + ".";
        }
        private static void OpenConnection()
        {
            //DBConnectionManager.Connect();
            DBConnectionManager.Connection.Open();
        }
        #endregion
        
        #endregion
    }
}

