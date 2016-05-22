using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DB_Editor.DB_Connection;

namespace DB_Editor.DB_Handlers
{
    static class Record
    {
        #region Methods
        /// <summary>
        /// Methods alters one value in row.
        /// </summary>
        /// <param name="tableName">Name of the table</param>
        /// <param name="Change">Tuple of field name and its changed value</param>
        /// <param name="OldRecord">Table of tuples with all field names and their old values</param>
        /// <param name="dbName">Optional, database name</param>
        /// <returns></returns>
        public static OperationResult ChangeRowValue(string tableName,Tuple<string, string> Change, Tuple<string, string>[] OldRecord, string dbName = "")
        {
            try
            {
                OpenConnection();
                CheckDbName(ref dbName);
                string tmp = "";
                tmp += "UPDATE " + dbName + tableName + " SET " + Change.Item1 + " = \"" + Change.Item2 + "\" WHERE ";
                foreach (var pair in OldRecord)
                    tmp += pair.Item1 + " = \"" + pair.Item2 + "\" AND ";

                tmp = tmp.Substring(0, tmp.Length - 5);
                tmp += ";";
                MySqlCommand command_ = new MySqlCommand(tmp, DBConnectionManager.Connection);
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
