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
        //jezeli jakas metoda nie dziala, to przed wywolaniem dodaj
        //DB_Connection.DBConnectionManager.Connect();
        #region Methods

        /// <summary>
        /// Methods alters one value in row.
        /// </summary>
        /// <param name="tableName">Name of the table</param>
        /// <param name="Change">Tuple of field name and its changed value</param>
        /// <param name="OldRecord">Table of tuples with all field names and their old values</param>
        /// <param name="dbName">Optional, database name</param>
        /// <returns></returns>
        public static OperationResult ChangeRowValue(string tableName, Tuple<string, string> Change, Tuple<string, string>[] OldRecord, string dbName = "")
        {
            try
            {
                DBConnectionManager.Connection.Open();
                CheckDbName(ref dbName);
                string tmp = "";
                tmp += "UPDATE " + dbName + tableName + " SET " + Change.Item1 + " = \"" + Change.Item2 + "\" WHERE ";
                foreach (var pair in OldRecord)
                    tmp += pair.Item1 + " = \"" + pair.Item2 + "\" AND ";

                tmp = tmp.Substring(0, tmp.Length - 5);
                tmp += ";";
                MySqlCommand command_ = new MySqlCommand(tmp, DBConnectionManager.Connection);
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
        //List<string[]> oko = new List<string[]>();
        //string[] ok2 = new string[] {"id", "nieid"};
        //string[] ok3 = new string[] { "fuu2", "foo3" };
        //oko.Add(ok2);
        //oko.Add(ok3);
        //Record.InsertRowValue("stringtable", ok2, oko, "ok");
        public static OperationResult InsertRowValue(string tableName, string[] ColumnNames, List<string[]> Values, string dbName = "")
        {
            try
            {
                DBConnectionManager.Connection.Open();
                CheckDbName(ref dbName);
                string tmp = "";
                tmp += "INSERT INTO " + dbName + tableName + " (";
                foreach (string columnName in ColumnNames)
                    tmp += columnName + ", ";
                tmp = tmp.Substring(0, tmp.Length - 2);
                tmp += ") VALUES ";

                foreach (var stringArrays in Values)
                {
                    tmp += "(";
                    foreach (var stringArray in stringArrays)
                    {
                        tmp += "\"" + stringArray + "\", ";
                    }
                    tmp = tmp.Substring(0, tmp.Length - 2);
                    tmp += "), ";
                }
                tmp = tmp.Substring(0, tmp.Length - 2);
                tmp += ";";

                MySqlCommand command_ = new MySqlCommand(tmp, DBConnectionManager.Connection);
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
        
        //tabela w ktorej jest pole, ktore jest auto_increment oraz nazwa bazy danych
        //w ktorej tabelka sie znajduje, zabezpiecza to przed dwoma tabelkami o tej samej nazwie
        //w roznych bazach danych
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
