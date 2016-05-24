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
        private string name_;

        private string buttonNextText_;

        private string nextState_;

        private string prevState_;

        private StateControl leftPanelControl_;

        private StateControl rightPanelControl_;

        public State(string stateName, StateControl leftPanelControl, StateControl rightPanelControl)
        {
            name_ = stateName;
            leftPanelControl_ = leftPanelControl;
            rightPanelControl_ = rightPanelControl;
        }

        public StateControl Left
        {
            get
            {
                return leftPanelControl_;
            }
        }

        public StateControl Right
        {
            get
            {
                return rightPanelControl_;
            }
        }

        public string Name
        {
            get
            {
                return name_;
            }
        }

        public string ButtonText
        {
            get
            {
                return buttonNextText_;
            }
            set
            {
                buttonNextText_ = value;
            }
        }

        public string NextState
        {
            get
            {
                return nextState_;
            }
            set
            {
                nextState_ = value;
            }
        }

        public string PrevState
        {
            get
            {
                return prevState_;
            }
            set
            {
                prevState_ = value;
            }
        }

        public StateChangeRequestEventArgs EventData 
        {
            set 
            {
                Right.EventData = value;
            }
        }

        public virtual void OnPrevState() { }

        public virtual void OnNextState() { }
    }
}
