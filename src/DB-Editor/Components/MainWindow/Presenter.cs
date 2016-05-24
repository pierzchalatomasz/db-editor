using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.Events;
using DB_Editor.DB_Connection;
using DB_Editor.Components.MainWindow.Definitions;

namespace DB_Editor.Components.MainWindow
{
    using QueryResult = List<Dictionary<string, string>>;

    class Presenter
    {
        private View view_;

        private Model model_;

        public Presenter(View view)
        {
            view_ = view;
            model_ = new Model();
        }

        public void Init()
        {
            ListenToEvents();
            SetDefaultState("TablesListing");
        }

        public State ActiveState
        {
            get
            {
                return model_.ActiveState;
            }
        }

        public void ChangeState(object sender, StateChangeRequestEventArgs args)
        {
            if (model_.ActiveState != null)
            {
                PerformActionOnStateChange(args.StateOrder);
            }

            model_.ActiveState = model_.States[args.State];
            model_.ActiveState.EventData = args;
            view_.DisplayStateChange();
        }

        private void PerformActionOnStateChange(StateOrder stateOrder)
        {
            if (stateOrder == StateOrder.Next)
            {
                model_.ActiveState.OnNextState();
            }
            else
            {
                model_.ActiveState.OnPrevState();
            }
        }

        private void SetDefaultState(string stateName)
        {
            model_.ActiveState = model_.States[stateName];
            view_.DisplayStateChange();
        }

        private void ListenToEvents()
        {
            StateChangeRequestEvents.StateChangeRequest += ChangeState;
        }
    }
}
