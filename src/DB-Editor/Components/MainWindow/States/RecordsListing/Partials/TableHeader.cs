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
    public partial class TableHeader : UserControl
    {
        public TableHeader(List<string> tableFieldNames)
        {
            InitializeComponent();

            foreach (string tableFieldName in tableFieldNames)
            {
                TableHeaderItem thi = new TableHeaderItem();
                thi.FieldName = tableFieldName;
                thi.Show();
                container.Controls.Add(thi);
            }
        }
    }
}
