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
        private static string server_ = "localhost";
        private static string username_ = "root";
        private static string password_ = "";
        private static string database_ = "";

        public static string ServerUrl
        {
            set
            {
                server_ = value;
            }
        }

        public static string Username
        {
            set
            {
                username_ = value;
            }
        }

        public static string Password
        {
            set
            {
                password_ = value;
            }
        }
        
        public static string DatabaseName
        {
            get
            {
                return database_;
            }
            set
            {
                database_ = value;
            }
        }
        public static void Connect()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = server_;
                builder.UserID = username_;
                builder.Password = password_;
                if (database_ != "")
                {
                    builder.Database = database_;
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

        public static void Connect(string server, string username, string password, string database)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = server;
                builder.UserID = username;
                builder.Password = password;
                builder.Database = database;

                dbConnection_ = new MySqlConnection(builder.ToString());
            }
            catch (MySqlException e)
            {
                // Emit event here
                Console.WriteLine(e.Message);
            }
        }

        public static List<Dictionary<string, string>> Query(string query)
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
