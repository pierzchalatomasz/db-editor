using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.States.TablesListing;

namespace DB_Editor.Components.MainWindow
{
    using StatesDict = Dictionary<string, List<Control>>;

    class Model
    {
        private StatesDict states_;

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

        private void CreateStates()
        {
            CreateSingleState("TablesListing", new UserControl(), new TablesListing());
            CreateSingleState("Test", new TablesListing(), new TextBox());
        }

        private void CreateSingleState(string stateName, Control leftControl, Control rightControl)
        {
            List<Control> controls = new List<Control>();
            controls.Add(leftControl);
            controls.Add(rightControl);
            states_.Add(stateName, controls);
        }
    }
}
