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
        public TableHeader()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                TableHeaderItem thi1 = new TableHeaderItem();
                thi1.FieldName = "Field" + (i + 1);
                thi1.Show();
                container.Controls.Add(thi1);
            }
        }
    }
}
