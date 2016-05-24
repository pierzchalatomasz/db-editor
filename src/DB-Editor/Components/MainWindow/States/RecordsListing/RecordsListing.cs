using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.Components.MainWindow.Definitions;

namespace DB_Editor.Components.MainWindow.States.RecordsListing
{
    public class RecordsListing : State
    {
        public RecordsListing() : base("RecordsListing", new RecordsListingControl())
        {
            NextState = Name;
            PrevState = "TablesListing";
        }
    }
}
