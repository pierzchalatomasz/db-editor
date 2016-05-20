using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.States.TablesListing.Partials;

namespace DB_Editor.Components.MainWindow.States.TablesListing
{
    public partial class TablesListing : UserControl
    {
        public TablesListing()
        {
            InitializeComponent();
            TableItem tableItem = new TableItem("country");
            tableItem.Show();
            TableItemsContainer.Controls.Add(tableItem);

            TableItem tableItem2 = new TableItem("city");
            tableItem2.Show();
            TableItemsContainer.Controls.Add(tableItem2);
        }
    }
}
