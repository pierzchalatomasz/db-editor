using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DB_Editor.DB_Connection;
using System.Windows.Forms;

namespace DB_Editor.DB_Handlers
{
    using QueryResult = List<Dictionary<string, string>>;
    static class Table
    {
        //jezeli jakas metoda nie dziala, to przed wywolaniem dodaj
        //DB_Connection.DBConnectionManager.Connect();
        private static MySqlCommand command_;
        static Table()
        {
            command_ = new MySqlCommand();
            command_.Connection = DBConnectionManager.Connection;
        }
        #region Methods

        #region ColumnManipulateMethods
        //mozna uzywac zarowno z nazwa bazy danych, jak i bez, np:
        //Table.DropColumn("Nazwa_tabeli", "nazwa_kolumny_do_usuniecia", "nazwa_bazy_danych");
        //Table.DropColumn("Nazwa_tabeli", "nazwa_kolumny_do_usuniecia");
        public static OperationResult AddColumn(string tableName, ColumnStructureCreator colm, string posName = "", string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                if (posName != "" || posName != "FIRST")
                    posName = "AFTER " + posName;
                command_.CommandText = "ALTER TABLE " + dbName + tableName + " ADD " + colm.ToString() + posName + ";";
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
        //zalozylem, ze zmiany moga byc wieksze, anizeli tylko zmiana nazwy, stad jedna metoda ogarnie sie wiecej zmian naraz
        public static OperationResult ChangeColumn(string tableName, string oldColumnName, ColumnStructureCreator newColumn, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                command_.CommandText = "ALTER TABLE " + dbName + tableName + " CHANGE " + oldColumnName + " " + newColumn.ToString() + ";";
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
        public static OperationResult DropColumn(string tableName, string columnName, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                command_.CommandText = "ALTER TABLE " + dbName + tableName + " DROP COLUMN " + columnName + ";";
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
        public static OperationResult MoveColumn(string tableName, ColumnStructureCreator colm, string posName, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                if (posName != "FIRST")
                    posName = "AFTER " + posName;
                command_.CommandText = "ALTER TABLE " + dbName + tableName + " CHANGE " + colm.ToString() + posName + ";";
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

        #region KeyMethods
        public static OperationResult AddPrimaryKey(string tableName, string columnName, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                command_.CommandText = "ALTER TABLE " + dbName + tableName + " ADD PRIMARY KEY(" + columnName + ");";
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
        //ColumnStructureCreator colm = new ColumnStructureCreator("pole1", "int", true, true, "", true );
        // Table.DropPrimaryKey("nazwa3", colm, "ok");
        public static OperationResult DropPrimaryKey(string tableName, ColumnStructureCreator colm, string dbName)
        {
            try
            {
                colm.Primary_Key = false;
                colm.Extra = false;
                ChangeColumn(tableName, colm.Field, colm, dbName);
                OpenConnection();
                CheckDbName(ref dbName);
                command_.CommandText = "ALTER TABLE " + dbName + tableName + " DROP PRIMARY KEY;";
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

        public static OperationResult AddForeignKey(string tableName, string fieldName, string referencedTable, string referencedField, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                command_.CommandText = "ALTER TABLE " + dbName + tableName + " ADD FOREIGN KEY(" + fieldName + ") REFERENCES " + dbName + referencedTable + "(" + referencedField + ");";
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
        public static OperationResult DropForeignKey(string tableName, string fieldName, string dbName = "")
        {
            try
            {
                CheckDbName(ref dbName);
                string tmp = GetConstraintName(tableName, fieldName);

                OpenConnection();
                command_.CommandText = "ALTER TABLE " + dbName + tableName + " DROP FOREIGN KEY " + tmp + ";";
                command_.Connection = DBConnectionManager.Connection;
                //sprawdzic, czy powyzsze mozna usunac
                command_.ExecuteNonQuery();

                command_.CommandText = "ALTER TABLE " + dbName + tableName + " DROP KEY " + fieldName + ";";
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
        //przykladowo:
        //List<List<string>> tmpListOfList2 = new List<List<string>>();
        //DB_Connection.DBConnectionManager.Connect();
        //tmpListOfList2 = Table.GetRecords("oko", "i");
        //foreach (var list in tmpListOfList2)
        //{
        //    foreach (var str in list)
        //        Console.Write(str + " ");
        //    Console.Write("\n");
        //}
        public static List<List<string>> GetFirstPageOfRecords(string tableName, string dbName = "")
        {
            try
            {
                return GetPageOfRecordsByIndex(0, tableName, dbName);           
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
        public static int GetAmountOfPages(string tableName, string dbName = "")
        {
            try
            {
                CheckDbName(ref dbName);
                string tmp = "SELECT count(*) FROM " + dbName + tableName + ";";

                command_ = new MySqlCommand(tmp, DB_Connection.DBConnectionManager.Connection);
                DB_Connection.DBConnectionManager.Connection.Open();

                MySqlDataReader reader = command_.ExecuteReader();
                int result = 0;
                while (reader.Read())
                {
                    result = Int32.Parse(reader.GetString(0));
                }
                return (int)Math.Ceiling(result / 50.0);
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
        public static List<List<string>> GetPageOfRecordsByIndex(int index, string tableName, string dbName = "")
        {
            try
            {
                CheckDbName(ref dbName);
                string tmp = "SELECT * FROM " + dbName + tableName + " limit " + index * 50 + ", 50;";
                List<List<string>> tmpListOfList = new List<List<string>>();
                List<string> tmpList = new List<string>();

                command_ = new MySqlCommand(tmp, DB_Connection.DBConnectionManager.Connection);

                DB_Connection.DBConnectionManager.Connection.Open();

                MySqlDataReader reader = command_.ExecuteReader();
                int ColumnCount = reader.FieldCount;
                while (reader.Read())
                {
                    for (int i = 0; i < ColumnCount; i++)
                    {
                        if (!reader.IsDBNull(i))
                            tmpList.Add(reader.GetString(i));
                        else
                            tmpList.Add("");
                    }
                    tmpListOfList.Add(new List<string>(tmpList));
                    tmpList.Clear();
                }

                return tmpListOfList;
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
            DBConnectionManager.Connect();
            DBConnectionManager.Connection.Open();
        }
        private static string GetConstraintName(string tableName, string fieldName)
        {
            DBConnectionManager.Connect();
            QueryResult result = DBConnectionManager.Query("SELECT constraint_name FROM information_schema.key_column_usage WHERE table_name = \"" + tableName + "\" and column_name = \"" + fieldName + "\";");
            DBConnectionManager.Connection.Close();
            return result[0].First().Value;
        }
        #endregion

        #endregion
    }
}

