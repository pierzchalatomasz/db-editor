using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DB_Editor.DB_Connection;

namespace DB_Editor.DB_Handlers
{
    static class Database
    {
        #region Methods
        //przeprowadzic walidacje niedozwolonych znakow/nazw?
        public static OperationResult CreateDatabase(string dbName)
        {
            try
            {
                OpenConnection();
                MySqlCommand comm = new MySqlCommand("CREATE DATABASE " + dbName + ";", DBConnectionManager.Connection);
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
        public static OperationResult DropDatabase(string dbName)
        {
            try
            {
                OpenConnection();
                MySqlCommand comm = new MySqlCommand("DROP DATABASE " + dbName + ";", DBConnectionManager.Connection);
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
        
        //przykladowo:
        //Database.CreateTable("nazwatabeli", new TableStructureCreator("nazwapola", "nazwatypu");
        public static OperationResult CreateTable(string tableName, List<ColumnStructureCreator> tab)
        {
            try
            {
                OpenConnection();
                string tmp = "CREATE TABLE " + tableName + "(";
                foreach (var i in tab)
                {
                    tmp += i.ToString();
                    tmp += ", ";
                }
                tmp += ");";
                MySqlCommand comm = new MySqlCommand(tmp, DBConnectionManager.Connection);
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
        public static OperationResult DropTable(string tableName)
        {
            try
            {
                OpenConnection();
                MySqlCommand comm = new MySqlCommand("DROP TABLE " + tableName + ";", DBConnectionManager.Connection);
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
        public static OperationResult RenameTable(string oldName, string newName)
        {
            try
            {
                OpenConnection();
                MySqlCommand comm = new MySqlCommand("RENAME TABLE " + oldName + "TO " + newName + ";", DBConnectionManager.Connection);
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
        public static OperationResult RenameDatabase(string dbOldName, string dbNewName)
        {
            return new OperationResult(false, new Exception());//will dump db -> create new one -> import to new
        }
        //import
        //export
        //kopiowanie
        //porowownywanie
        #endregion


        private static void OpenConnection()
        {
            DBConnectionManager.Connect();
            DBConnectionManager.Connection.Open();
        }
        

        #endregion
    }
}
