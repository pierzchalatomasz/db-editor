﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.Definitions;

namespace DB_Editor.Components.MainWindow.States.TablesListing
{
    public class TablesListing : State
    {
        public TablesListing() : base("TablesListing", new TablesListingControl())
        {
            NextState = "TableEditor";
            ButtonText = "Add new table";
            Title = string.Format("Tables of \"{0}\" database", DB_Connection.DBConnectionManager.DatabaseName);
        }
    }
}
