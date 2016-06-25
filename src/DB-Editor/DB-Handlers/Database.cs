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
        private static MySqlCommand command_;
        private static string dbName_;
        static Database()
        {
            command_ = new MySqlCommand();
            command_.Connection = DBConnectionManager.Connection;
        }

        #region Methods

        #region DatabaseManipulateMethods
        public static OperationResult CreateDatabase(string dbName)
        {
            try
            {
                DBConnectionManager.Connection.Open();
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
            dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
            return DropDatabase(dbName_);
        }
        public static OperationResult DropDatabase(string dbName)
        {
            try
            {
                DBConnectionManager.Connection.Open();
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
        public static OperationResult RenameDatabase(string dbOldName, string dbNewName)
        {
            try
            {
                DBConnectionManager.Connection.Open();
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
        public static OperationResult CreateTable(string tableName, List<ColumnStructureCreator> list, List<Tuple<string, string, string>> foreignKeys = null)
        {
            try
            {
                dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
                DBConnectionManager.Connection.Open();
                CheckDbName(ref dbName_);
                string tmp = "CREATE TABLE " + dbName_ + tableName + " (";
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
        public static OperationResult DropTable(string tableName)
        {
            try
            {
                dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
                DBConnectionManager.Connection.Open();
                CheckDbName(ref dbName_);
                MySqlCommand comm = new MySqlCommand("DROP TABLE " + dbName_ + tableName + ";", DBConnectionManager.Connection);
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
        public static OperationResult RenameTable(string oldName, string newName)
        {
            try
            {
                dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
                DBConnectionManager.Connection.Open();
                CheckDbName(ref dbName_);
                command_.CommandText = "RENAME TABLE " + dbName_ + oldName + " TO " + dbName_ + newName + ";";
                Console.WriteLine(command_.CommandText);
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
        public static List<string> GetFieldNamesFromTable(string tableName)
        {
            try
            {
                dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
                CheckDbName(ref dbName_);
                string tmp = "DESC " + dbName_ + tableName + ";";
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
        public static List<ColumnStructureCreator> GetColumnStructureCreatorsFromTable(string tableName)
        {
            try
            {
                dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
                CheckDbName(ref dbName_);
                command_.CommandText = "DESC " + dbName_ + tableName + ";";
                DB_Connection.DBConnectionManager.Connection.Open();

                MySqlDataReader reader = command_.ExecuteReader();

                List<ColumnStructureCreator> listOfClmnStrcCrtr;
                listOfClmnStrcCrtr = new List<ColumnStructureCreator>();
                string[] tmpStrings = new string[2];
                char[] delimiterChar = new char[1] { '(' };
                ColumnStructureCreator tmps = new ColumnStructureCreator();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {                     
                        switch(reader.GetName(i))
                        {
                            case "Field": tmps.Field = reader[i].ToString();
                                break;
                            case "Type":
                                {
                                    tmpStrings = reader[i].ToString().Split(delimiterChar);
                                    tmps.Type = tmpStrings[0];
                                    tmps.TypeLength = tmpStrings[1].TrimEnd(')');
                                }
                                break;
                            case "Null":
                                {
                                    if (reader[i].ToString() == String.Empty)
                                        tmps.NullValue = true;
                                    else
                                        tmps.NullValue = false;
                                } 
                                break;
                            case "Key":
                                {
                                    if (reader[i].ToString() != String.Empty)
                                        tmps.Primary_Key = true;
                                    else
                                        tmps.Primary_Key = false;
                                }
                                break;  
                            case "Default": tmps.Default = reader[i].ToString();
                                break;
                            case "Extra":
                                {
                                    if (reader[i].ToString() != String.Empty)
                                        tmps.Extra = true;
                                    else
                                        tmps.Extra = false;
                                }                         
                                break;                               
                        }               
                    }
                    listOfClmnStrcCrtr.Add(tmps);
                    tmps = new ColumnStructureCreator();
                }
                return listOfClmnStrcCrtr;
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
        #endregion

        #endregion
    }
}

