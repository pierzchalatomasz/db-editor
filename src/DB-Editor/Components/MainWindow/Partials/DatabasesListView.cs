using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Events;

namespace DB_Editor.Components.MainWindow.Partials
{
    public partial class DatabasesListView : UserControl
    {
        public event EventHandler DatabaseAdd;

        public event EventHandler DatabaseDelete;

        public event EventHandler CurrentlyUsedDatabaseDelete;


        public DatabasesListView()
        {
            InitializeComponent();
            DatabaseAdd += DatabaseAddHandler;
            DatabaseDelete += DatabaseDeleteHandler;
            CurrentlyUsedDatabaseDelete += CurrentlyUsedDatabaseDeleteHandler;
        }

        public void Init()
        {
            DisplayDatabasesList();
        }

        public static string DatabaseNameToAction
        {
            get;
            private set;
        }

        private void databasesList_DoubleClick(object sender, EventArgs e)
        {
            DB_Connection.DBConnectionManager.DatabaseName = databasesList.SelectedItem.ToString();
            StateChangeRequestEventArgs eventArgs = new StateChangeRequestEventArgs("TablesListing");
            StateChangeRequestEvents.FireStateChangeRequest(this, eventArgs);
        }


        private void DisplayDatabasesList()
        {
            databasesList.Items.Clear();

            List<string> databases = DB_Handlers.Database.GetDatabases();
            foreach (var database in databases)
            {
                databasesList.Items.Add(database);
            }
        }

        private void addNewDatabase_Click(object sender, EventArgs e)
        {
            DatabaseNameToAction = newDatabaseName.Text;

            DatabaseAdd.Invoke(sender, e);
            newDatabaseName.Text = "";
            DisplayDatabasesList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(DB_Connection.DBConnectionManager.DatabaseName == "")
            {
                DB_Connection.DBConnectionManager.DatabaseName = DB_Connection.DBConnectionManager.DatabaseName;
            }
            else
            {
                DB_Connection.DBConnectionManager.DatabaseName = DB_Connection.DBConnectionManager.DatabaseName;
            }
            if (databasesList.SelectedIndex != -1)
            {
                DatabaseNameToAction = databasesList.SelectedItem.ToString();

                if (databasesList.SelectedItem.ToString() == DB_Connection.DBConnectionManager.DatabaseName)
                {
                    if (MessageBox.Show("Are you sure you want to delete " + databasesList.SelectedItem.ToString() + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        databasesList.SelectedIndex = -1;
                        CurrentlyUsedDatabaseDelete.Invoke(sender, e);
                        DB_Connection.DBConnectionManager.DatabaseName = "";
                        DB_Connection.DBConnectionManager.Connect();
                    }
                }
                else if (MessageBox.Show("Are you sure you want to delete " + databasesList.SelectedItem.ToString() + "?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        DatabaseDelete.Invoke(sender, e);
                

                DisplayDatabasesList();
                databasesList.SelectedIndex = -1;
            }
        }

        public void DatabaseAddHandler(object sender, EventArgs e)
        {
            DB_Handlers.OperationResult tmp = DB_Handlers.Database.CreateDatabase(DatabaseNameToAction);
            if (tmp.Exception.Message != "QUERY Ok")
                MessageBox.Show("Error! " + tmp.Exception.Message + " Try again.", "Database Add Error");
            DB_Connection.DBConnectionManager.Connection.Close();
        }

        public void DatabaseDeleteHandler(object sender, EventArgs e)
        {
            DB_Handlers.OperationResult tmp = DB_Handlers.Database.DropDatabase(DatabaseNameToAction);
            if (tmp.Exception.Message != "QUERY Ok")
                MessageBox.Show("Error! " + tmp.Exception.Message + " Try again.", "Database Delete Error");
            DB_Connection.DBConnectionManager.Connection.Close();
        }

        public void CurrentlyUsedDatabaseDeleteHandler(object sender, EventArgs e)
        {
            StateChangeRequestEventArgs eventArgs = new StateChangeRequestEventArgs("Welcome");
            StateChangeRequestEvents.FireStateChangeRequest(this, eventArgs);
            DB_Handlers.OperationResult tmp = DB_Handlers.Database.DropDatabase(DatabaseNameToAction);
            if (tmp.Exception.Message != "QUERY Ok")
                MessageBox.Show("Error! " + tmp.Exception.Message + " Try again.", "Database Delete Error");
            DB_Connection.DBConnectionManager.Connection.Close();
        }
    }
}
