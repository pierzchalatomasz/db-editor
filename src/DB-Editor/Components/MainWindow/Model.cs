using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.Definitions;
using DB_Editor.Components.MainWindow.States.TablesListing;
using DB_Editor.Components.MainWindow.States.TableEditor;
using DB_Editor.Components.MainWindow.States.RowEditor;
using DB_Editor.Components.MainWindow.States.RecordsListing;

namespace DB_Editor.Components.MainWindow
{
    using StatesDict = Dictionary<string, State>;

    class Model
    {
        public event EventHandler DatabaseChanged;

        protected virtual void OnDatabaseChanged(EventArgs e)
        {
            if (DatabaseChanged != null)
                DatabaseChanged(this, e);
        }

        public Model()
        {
            States = new StatesDict();
            CreateStates();
        }

        public StatesDict States { get; private set; }

        public State ActiveState { get; set; }

        private void CreateStates()
        {
            CreateSingleState(new TablesListing());
            CreateSingleState(new TableEditor());
            CreateSingleState(new RowEditor());
            CreateSingleState(new RecordsListing());
        }

        private void CreateSingleState(State state)
        {
            States.Add(state.Name, state);
        }
    }
}
