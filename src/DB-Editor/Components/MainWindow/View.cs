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

        public event EventHandler DatabaseChanged;

        public View(string serverUrl, string username, string password)
        {
            InitializeComponent();
            presenter_ = new Presenter(this);
            presenter_.Init();
            presenter_.EstablishConnection(serverUrl, username, password);

            DisplayDatabasesList();
        }

        public void DisplayStateChange()
        {
            rightPanel.Controls.Clear();
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
    }
}
