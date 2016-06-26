using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.Events;
using DB_Editor.DB_Connection;
using DB_Editor.Components.MainWindow.Definitions;
using DB_Editor.Components.MainWindow.States.TablesListing;

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
            model_.StateBuilt += SetOnResizeEventHandler;
            model_.CreateStates();
            ListenToEvents();
            SetDefaultState("Welcome");
        }

        public State ActiveState
        {
            get
            {
                return model_.ActiveState;
            }
        }

        public Action<string> StateBuilt
        {
            set
            {
                model_.StateBuilt += value;
            }
        }

        public void ChangeState(object sender, StateChangeRequestEventArgs args)
        {
            if (model_.ActiveState != null)
            {
                PerformActionOnStateChange(args.StateOrder);
            }

            if (model_.States[args.State].Rebuildable)
            {
                model_.RebuildState(args.State);
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
            DisplayError.DisplayErrorEvent += view_.DisplayError;
        }

        public State GetStateByName(string name)
        {
            return model_.States[name];
        }

        private void SetOnResizeEventHandler(string name)
        {
            view_.ContainerResize += model_.States[name].Control.OnResize;
            Console.WriteLine(name);
        }
    }
}
