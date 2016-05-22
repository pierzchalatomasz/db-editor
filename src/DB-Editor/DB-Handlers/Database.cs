﻿using System;
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
        private static MySqlCommand command_;
        static Database()
        {
            command_ = new MySqlCommand();
            command_.Connection = DBConnectionManager.Connection;
        }
        #region Methods
        //przeprowadzic walidacje niedozwolonych znakow/nazw?
        public static OperationResult CreateDatabase(string dbName)
        {
            try
            {
                OpenConnection();
                command_.CommandText = "CREATE DATABASE " + dbName + ";";
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
        public static OperationResult DropDatabase(string dbName)
        {
            try
            {
                OpenConnection();
                command_.CommandText = "DROP DATABASE " + dbName + ";";
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
        //List<ColumnStructureCreator> tmp2 = new List<ColumnStructureCreator>();
        //ColumnStructureCreator clmstr = new ColumnStructureCreator("nazwapola", "int");
        //ewentualnie uzywac w takiej postaci w .Add
        //tmp2.Add(new ColumnStructureCreator("nazwapola", "int"));
        //Database.CreateTable("nazwatabeli3", tmp2);

        //z kluczem glownym, przy testach jezeli jest klucz, to NIE moze byc default ustawiony
        //List<ColumnStructureCreator> clm = new List<ColumnStructureCreator>();
        //clm.Add(new ColumnStructureCreator("nazwapola", "int", false, false, "", true));
        //Database.CreateTable("nazwatabeli", clm);

        //z kluczami obcymi (pojedynczymi), przy testach pamietac by wszystkie pola byly ze soba zgodne
        //List<Tuple<string, string, string>> foreignkis = new List<Tuple<string, string, string>>();
        // foreignkis.Add(Tuple.Create("nazwapola", "nazwatabeli2", "nazwapola"));
        // Database.CreateTable("nazwatabeli", clm, foreignkis);

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
                OpenConnection();
                string tmp = "CREATE TABLE " + tableName + " (";
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
                command_.CommandText = "RENAME TABLE " + oldName + "TO " + newName + ";";
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

