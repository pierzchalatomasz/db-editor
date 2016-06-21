using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Events;
using DB_Editor.Components.MainWindow.States.TablesListing;

namespace DB_Editor.Components.MainWindow
{
    public partial class View : Form
    {
        private Presenter presenter_;

        public event EventHandler DatabaseAdd;
        public event EventHandler DatabaseChanged;
        public event EventHandler DatabaseDelete;
        public event EventHandler CurrentlyUsedDatabaseDelete;

        public static string DatabaseNameToAction
        {
            get;
            private set;
        }

        public View()
        {
            InitializeComponent();
            presenter_ = new Presenter(this);
            presenter_.Init();

            DisplayDatabasesList();
        }

        public void DisplayStateChange()
        {
            rightPanel.Controls.Clear();
            presenter_.ActiveState.Control.Height = rightPanel.Height;
            presenter_.ActiveState.Control.Width = rightPanel.Width;
            presenter_.ActiveState.Control.AutoScroll = true;
            presenter_.ActiveState.Control.Show();
            rightPanel.Controls.Add(presenter_.ActiveState.Control);
            RightPanelTitle.Text = presenter_.ActiveState.Name;

            UpdateButtons();
        }

        private void ToggleButtonVisibility(Button button, string anotherState)
        {
            if (anotherState != null)
            {
                button.Show();
            }
            else
            {
                button.Hide();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            StateChangeRequestEventArgs args = new StateChangeRequestEventArgs(presenter_.ActiveState.NextState);
            StateChangeRequestEvents.FireStateChangeRequest(sender, args);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StateChangeRequestEventArgs args = new StateChangeRequestEventArgs(presenter_.ActiveState.PrevState, StateOrder.Prev);
            StateChangeRequestEvents.FireStateChangeRequest(sender, args);
        }

        private void UpdateButtons()
        {
            SetButtonText();
            ToggleButtonVisibility(buttonNext, presenter_.ActiveState.NextState);
            ToggleButtonVisibility(buttonBack, presenter_.ActiveState.PrevState);
        }

        private void SetButtonText()
        {
            if (presenter_.ActiveState.ButtonText != null)
            {
                buttonNext.Text = presenter_.ActiveState.ButtonText;
            }
        }

        private void databasesList_DoubleClick(object sender, EventArgs e)
        {
            DB_Connection.DBConnectionManager.DatabaseName = databasesList.SelectedItem.ToString();
            DatabaseChanged.Invoke(sender, e);
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
            if (databasesList.SelectedIndex != -1)
            {
                DatabaseNameToAction = databasesList.SelectedItem.ToString();
                if(databasesList.SelectedItem.ToString() == DB_Connection.DBConnectionManager.DatabaseName)
                {
                    if (MessageBox.Show("Are you sure you want to delete " + databasesList.SelectedItem.ToString() + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        databasesList.SelectedIndex = -1;
                        CurrentlyUsedDatabaseDelete.Invoke(sender, e);
                        DB_Connection.DBConnectionManager.DatabaseName = "";
                        DB_Connection.DBConnectionManager.Connect();
                    }
                }
                else if (MessageBox.Show("Are you sure you want to delete " + databasesList.SelectedItem.ToString() + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DatabaseDelete.Invoke(sender, e);                   
                }
                
                DisplayDatabasesList();
                databasesList.SelectedIndex = -1;
            }
        }
    }
}
