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
    static class Table
    {
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
                DBConnectionManager.Connection.Close();
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
                DBConnectionManager.Connection.Close();
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
                DBConnectionManager.Connection.Close();
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
                DBConnectionManager.Connection.Close();
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
                DBConnectionManager.Connection.Close();
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
                DBConnectionManager.Connection.Close();
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
                DBConnectionManager.Connection.Close();
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
                command_.ExecuteNonQuery();

                command_.CommandText = "ALTER TABLE " + dbName + tableName + " DROP KEY " + fieldName + ";";     
                command_.ExecuteNonQuery();

                DBConnectionManager.Connection.Close();
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

        private static string GetConstraintName(string tableName, string fieldName)
        {
            DBConnectionManager.Connect();
            QueryResult result = DBConnectionManager.Query("SELECT constraint_name FROM information_schema.key_column_usage WHERE table_name = \"" + tableName + "\" and column_name = \"" + fieldName + "\";");
            DBConnectionManager.Connection.Close();
            return result[0].First().Value;
        }

        #endregion

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
        #endregion
    }
}

