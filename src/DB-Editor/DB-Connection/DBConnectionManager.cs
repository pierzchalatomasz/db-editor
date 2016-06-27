using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;

namespace DB_Editor.DB_Connection
{
    using QueryResult = List<Dictionary<string, string>>;

    static class DBConnectionManager
    {
        private static MySqlConnection dbConnection_;

        public static MySqlConnection Connection
        {
            get
            {
                return dbConnection_;
            }
        }
       
        #region ProtszyConnector_DlaTestow

        public static string ServerUrl
        {
            private get;
            set;
        }

        public static string Username
        {
            get;
            set;
        }

        public static string Password
        {
            private get;
            set;
        }

        public static string DatabaseName
        {
            get;
            set;
        }
        
        public static void Connect()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = ServerUrl;
                builder.UserID = Username;
                builder.Password = Password;
                builder.AllowZeroDateTime = true;
                builder.ConvertZeroDateTime = true;
                if (DatabaseName!= "")
                {
                    builder.Database = DatabaseName;
                }

                dbConnection_ = new MySqlConnection(builder.ToString());
            }
            catch (MySqlException e)
            {
                // Emit event here
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        public static QueryResult Query(string query)
        {
            QueryResult results = new QueryResult();

            try
            {
                MySqlCommand command = new MySqlCommand(query, dbConnection_);

                dbConnection_.Open();

                MySqlDataReader reader = command.ExecuteReader();
                results = GetQueryResult(reader);

                dbConnection_.Close();
            }
            catch (MySqlException e)
            {
                // Emit event here
                Console.WriteLine(e.Message);
            }

            return results;
        }

        public static bool IsConnected()
        {
            if (dbConnection_ != null)
            {
                return true;
            }

            return false;
        }

        public static void TryLogIn()
        {
            dbConnection_.Open();
            dbConnection_.Close();
        }

        private static QueryResult GetQueryResult(MySqlDataReader reader)
        {
            QueryResult results = new QueryResult();

            while (reader.Read())
            {
                Dictionary<string, string> row = new Dictionary<string, string>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[reader.GetName(i)] = reader.GetValue(i).ToString();
                }

                results.Add(row);
            }

            return results;
        }
    }
}
