using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Events
{
    public class StateChangeRequestEventArgs : EventArgs
    {
        public StateChangeRequestEventArgs(string state, StateOrder stateOrder = StateOrder.Next)
        {
            State = state;
            StateOrder = stateOrder;
            Data = new Dictionary<string, string>();
            Mode = Mode.Creator;
        }

        public string State { get; private set; }

        public Dictionary<string, string> Data { get; set; }

        public StateOrder StateOrder { get; private set; }

        public Mode Mode { get; set; }
    }

    public enum StateOrder
    {
        Next,
        Prev
    }

    public enum Mode
    {
        Editor,
        Creator
    }
}
