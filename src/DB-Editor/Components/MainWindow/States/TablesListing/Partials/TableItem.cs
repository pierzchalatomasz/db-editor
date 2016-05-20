using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow.States.TablesListing.Partials
{
    public partial class TableItem : UserControl
    {
        public TableItem(string name)
        {
            InitializeComponent();
            this.name.Text = name;
        }
    }
}
