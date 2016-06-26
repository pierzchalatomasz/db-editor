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
using DB_Editor.Components.MainWindow.States.Welcome;

namespace DB_Editor.Components.MainWindow
{
    using StatesDict = Dictionary<string, State>;

    class Model
    {
        private Dictionary<string, Type> stateTypes_;

        public event Action<string> StateBuilt;

        public Model()
        {
            States = new StatesDict();
            stateTypes_ = new Dictionary<string, Type>();
            //CreateStates();
        }

        public StatesDict States { get; private set; }

        public State ActiveState { get; set; }

        public void RebuildState(string name)
        {
            States.Remove(name);
            State state = Activator.CreateInstance(stateTypes_[name]) as State;
            States.Add(state.Name, state);
            EmitStateBuiltEvent(state.Name);
        }

        public void CreateStates()
        {
            CreateSingleState(typeof(Welcome));
            CreateSingleState(typeof(TablesListing));
            CreateSingleState(typeof(TableEditor));
            CreateSingleState(typeof(RowEditor));
            CreateSingleState(typeof(RecordsListing));
        }

        private void CreateSingleState(Type type)
        {
            State state = Activator.CreateInstance(type) as State;
            States.Add(state.Name, state);
            stateTypes_.Add(state.Name, type);
            EmitStateBuiltEvent(state.Name);
        }

        private void EmitStateBuiltEvent(string name)
        {
            if (StateBuilt != null)
            {
                StateBuilt(name);
            }
        }
    }
}
