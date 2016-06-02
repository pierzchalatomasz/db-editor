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
        private List<Record> records_ = new List<Record>();

        private string SelectedRecordID = "";

        public RecordsListingControl()
        {
            InitializeComponent();

            TableHeader th1 = new TableHeader();
            th1.Show();
            container.Controls.Add(th1);

            for (int i = 0; i < 15; i++)
            {
                Record record = new Record();
                record.ID = i.ToString();
                record.Show();
                container.Controls.Add(record);
                records_.Add(record);
            }

            ListenToSelectedRecordChange();
        }

        private void ListenToSelectedRecordChange()
        {
            foreach (Record record in records_)
            {
                record.SelectedRecordChange += SelectedRecordChanged;
            }
        }

        private void SelectedRecordChanged(object sender, EventArgs e)
        {
            Record record = sender as Record;
            SelectedRecordID = record.ID;
            HighlightSelectedRecord(record.ID);
            // test
            Console.WriteLine("Selected record changed to: " + record.ID);
        }

        private void HighlightSelectedRecord(string id)
        {
            foreach (Record record in records_)
            {
                if (id == record.ID)
                {
                    record.BackColor = Color.LightBlue;
                }
                else
                {
                    record.BackColor = Color.White;
                }
            }
        }
    }
}
