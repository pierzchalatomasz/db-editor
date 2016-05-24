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
