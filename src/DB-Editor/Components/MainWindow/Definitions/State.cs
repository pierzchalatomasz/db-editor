using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Events;

namespace DB_Editor.Components.MainWindow.Definitions
{
    abstract public class State
    {
        public virtual void DatabaseAdd(object sender, EventArgs e)
        {
            DB_Connection.DBConnectionManager.Connection.Open();
            DB_Handlers.OperationResult tmp = DB_Handlers.Database.CreateDatabase(View.DatabaseNameToAction);
            if (tmp.Exception.Message != "QUERY Ok")
                MessageBox.Show("Error! " + tmp.Exception.Message + " Try again.", "Database Add Error");
            DB_Connection.DBConnectionManager.Connection.Close(); 
        }
        public virtual void DatabaseChanged(object sender, EventArgs e) { }
        public virtual void DatabaseDelete(object sender, EventArgs e)
        {
            DB_Connection.DBConnectionManager.Connection.Open();
            DB_Handlers.OperationResult tmp = DB_Handlers.Database.DropDatabase(View.DatabaseNameToAction);
            if (tmp.Exception.Message != "QUERY Ok")
                MessageBox.Show("Error! " + tmp.Exception.Message + " Try again.", "Database Delete Error");
            DB_Connection.DBConnectionManager.Connection.Close();
        }
        public virtual void CurrentlyUsedDatabaseDelete(object sender, EventArgs e)
        {
            StateChangeRequestEventArgs eventArgs = new StateChangeRequestEventArgs("TablesListing");
            StateChangeRequestEvents.FireStateChangeRequest(this, eventArgs);
            DB_Connection.DBConnectionManager.Connection.Open();
            DB_Handlers.OperationResult tmp = DB_Handlers.Database.DropDatabase(View.DatabaseNameToAction);
            if (tmp.Exception.Message != "QUERY Ok")
                MessageBox.Show("Error! " + tmp.Exception.Message + " Try again.", "Database Delete Error");
            DB_Connection.DBConnectionManager.Connection.Close();
        }

        public State(string stateName, StateControl Control)
        {
            Name = stateName;
            this.Control = Control;
        }

        public StateControl Control { get; private set; }

        public string Name { get; private set; }

        public string ButtonText { get; set; }

        public string NextState { get; set; }

        public string PrevState { get; set; }

        public StateChangeRequestEventArgs EventData
        {
            set
            {
                Control.EventData = value;
            }
        }

        public virtual void OnPrevState() { }

        public virtual void OnNextState() { }
    }
}
