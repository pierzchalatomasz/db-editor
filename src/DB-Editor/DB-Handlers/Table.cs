using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DB_Editor.DB_Connection;

namespace DB_Editor.DB_Handlers
{
    static class Table
    {
        #region Methods
               
        public static OperationResult AddColumn(string tableName, ColumnStructureCreator colm, string posName = "")
        {
            try
            {
                OpenConnection();
                if (posName != "" || posName != "FIRST")
                    posName = "AFTER " + posName;
                MySqlCommand comm = new MySqlCommand("ALTER TABLE " + tableName + " ADD " + colm.ToString() + posName +  ";", DBConnectionManager.Connection);
                comm.ExecuteNonQuery();
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
        public static OperationResult ChangeColumn(string tableName, string oldColumnName, ColumnStructureCreator newColumn)
        {
            try
            {
                OpenConnection();
                MySqlCommand comm = new MySqlCommand("ALTER TABLE " + tableName + " CHANGE " + oldColumnName + " " + newColumn.ToString() + ";", DBConnectionManager.Connection);
                comm.ExecuteNonQuery();
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
        public static OperationResult DropColumn(string tableName, string columnName)
        {
            try
            {
                OpenConnection();
                MySqlCommand comm = new MySqlCommand("ALTER TABLE " + tableName + " DROP COLUMN " + columnName + ";", DBConnectionManager.Connection);
                comm.ExecuteNonQuery();
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

        #region NotImplementedMethodsYet
        
        public static OperationResult MoveColumn(string column)
        {
            return new OperationResult();
        }
        #endregion
        private static void OpenConnection()
        {
            DBConnectionManager.Connect();
            DBConnectionManager.Connection.Open();
        }
        #endregion
    }
}
