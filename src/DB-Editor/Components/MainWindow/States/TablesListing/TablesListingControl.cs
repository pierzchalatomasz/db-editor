using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.Definitions;
using DB_Editor.Components.MainWindow.States.TablesListing.Partials;

namespace DB_Editor.Components.MainWindow.States.TablesListing
{
    public partial class TablesListingControl : StateControl
    {
        public TablesListingControl()
        {
            InitializeComponent();

            TableItem tableItem = new TableItem("country");
            tableItem.Show();
            TableItemsContainer.Controls.Add(tableItem);

        }
        public void AddTables(List<string> tablesNamesList)
        {
            TableItemsContainer.Controls.Clear();
            foreach (var tableName in tablesNamesList)
            {
                TableItem tableItem = new TableItem(tableName);
                tableItem.Show();
                TableItemsContainer.Controls.Add(tableItem);
            }
        }

    }
}
