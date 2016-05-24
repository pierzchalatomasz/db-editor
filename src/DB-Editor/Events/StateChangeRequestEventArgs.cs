using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Events
{
    public class StateChangeRequestEventArgs : EventArgs
    {
        private string state_;

        private Dictionary<string, string> data_;

        private StateOrder stateOrder_;

        private Mode mode_;

        public StateChangeRequestEventArgs(string state, StateOrder stateOrder = StateOrder.Next)
        {
            state_ = state;
            stateOrder_ = stateOrder;
            data_ = new Dictionary<string, string>();
            mode_ = Mode.Creator;
        }

        public string State
        {
            get
            {
                return state_;
            }
        }

        public Dictionary<string, string> Data
        {
            get
            {
                return data_;
            }
            set
            {
                data_ = value;
            }
        }

        public StateOrder StateOrder
        {
            get
            {
                return stateOrder_;
            }
        }

        public Mode Mode
        {
            get
            {
                return mode_;
            }
            set
            {
                mode_ = value;
            }
        }
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
