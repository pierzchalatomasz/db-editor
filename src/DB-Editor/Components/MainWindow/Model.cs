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
        private Dictionary<string, State> states_;

        private State activeState_;

        public Model()
        {
            states_ = new StatesDict();
            CreateStates();
        }

        public StatesDict States
        {
            get
            {
                return states_;
            }
        }

        public State ActiveState
        {
            get
            {
                return activeState_;
            }
            set
            {
                activeState_ = value;
            }
        }

        private void CreateStates()
        {
            CreateSingleState(new TablesListing());
            CreateSingleState(new TableEditor());
            CreateSingleState(new RowEditor());
            CreateSingleState(new RecordsListing());
        }

        private void CreateSingleState(State state)
        {
            states_.Add(state.Name, state);
        }
    }
}
