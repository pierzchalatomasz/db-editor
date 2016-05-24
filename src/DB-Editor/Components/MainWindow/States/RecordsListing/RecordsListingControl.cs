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
using DB_Editor.Components.MainWindow.States.RecordsListing.Partials;

namespace DB_Editor.Components.MainWindow.States.RecordsListing
{
    public partial class RecordsListingControl : StateControl
    {
        public RecordsListingControl()
        {
            InitializeComponent();

            TableHeader th1 = new TableHeader();
            th1.Show();
            container.Controls.Add(th1);

            for (int i = 0; i < 15; i++)
            {
                Record record = new Record();
                record.Show();
                container.Controls.Add(record);
            }
        }
    }
}
