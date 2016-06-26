using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow.States.RecordsListing.Partials
{
    public partial class TableHeaderItem : UserControl
    {
        public TableHeaderItem(string name = "")
        {
            InitializeComponent();
            DoubleBuffered = true;
            FieldName = name;
        }

        public string FieldName
        {
            set
            {
                fieldName.Text = value;
            }
        }
    }
}
