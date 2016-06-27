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
    static class Record
    {
        private static string dbName_;
        private static MySqlCommand command_;
        static Record()
        {
            command_ = new MySqlCommand();
            command_.Connection = DBConnectionManager.Connection;
        }

        #region Methods

        /// <summary>
        /// Methods alters one value in row.
        /// </summary>
        /// <param name="tableName">Name of the table</param>
        /// <param name="OldValues">Tuple of field name and its changed value</param>
        /// <param name="OldRecord">Table of tuples with all field names and their old values</param>
        /// <param name="dbName">Optional, database name</param>
        /// <returns></returns>
        /// 
        public static OperationResult ChangeRowValue(string tableName, Dictionary<string, string> OldValues, Dictionary<string, string> StuffToChange)
        {
            try
            {
                dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
                DBConnectionManager.Connection.Open();
                CheckDbName(ref dbName_);
                string tmp = "";
                tmp += "UPDATE " + dbName_ + tableName + " SET ";

                foreach (var item in StuffToChange)
                {
                    tmp += item.Key + " = \"" + item.Value + "\", ";
                }

                tmp = tmp.Substring(0, tmp.Length - 2);
                tmp += " WHERE ";

                foreach (var item in OldValues)
                {
                    tmp += item.Key + " = \"" + item.Value + "\" AND ";
                }
                tmp = tmp.Substring(0, tmp.Length - 5);
                tmp += ";";

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
        public static OperationResult InsertRowValue(string tableName, List<string> ColumnNames, List<string> Values)
        {
            try
            {
                dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
                DBConnectionManager.Connection.Open();
                CheckDbName(ref dbName_);
                string tmp = "";
                tmp += "INSERT INTO " + dbName_ + tableName + " (";
                foreach (string columnName in ColumnNames)
                    tmp += columnName + ", ";
                tmp = tmp.Substring(0, tmp.Length - 2);
                tmp += ") VALUES (";

                foreach (string value in Values)
                {
                    if (value == "NULL")
                        tmp += value + ", ";
                    else
                        tmp += "\"" + value + "\", ";
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
        public static int GetNextIndex(string tableName, string dbName)
        {
            try
            {
                string tmp = "SELECT auto_increment FROM information_schema.tables where table_name = \"";
                tmp += tableName + "\" AND table_schema = \"" + dbName + "\";";
                QueryResult res = DBConnectionManager.Query(tmp);
                return Int32.Parse(res[0].First().Value);
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
        public static OperationResult DeleteRow(string tableName, Dictionary<string, string> pairs)
        {
            try
            {
                dbName_ = DB_Connection.DBConnectionManager.DatabaseName;
                DBConnectionManager.Connection.Open();
                CheckDbName(ref dbName_);
                string tmp = "";
                tmp += "DELETE FROM " + dbName_ + tableName + " WHERE ";
                foreach (var item in pairs)
                {
                    if (item.Value == "")
                        tmp += item.Key + " IS NULL AND ";
                    else
                        tmp += item.Key + " = \"" + item.Value + "\" AND ";
                }
                tmp = tmp.Substring(0, tmp.Length - 5);
                tmp += ";";

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
