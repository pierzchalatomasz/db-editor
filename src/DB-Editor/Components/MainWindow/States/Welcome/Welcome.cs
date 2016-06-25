using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.Components.MainWindow.Definitions;

namespace DB_Editor.Components.MainWindow.States.Welcome
{
    public class Welcome : State
    {
        public Welcome() : base("Welcome", new WelcomeControl())
        {
            NextState = "TablesListing";
            ButtonText = "Add new table";
        }
    }
}
