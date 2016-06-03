using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Events;
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
        }

        public override StateChangeRequestEventArgs EventData
        {
            set
            {
                container.Controls.Clear();

                string id = value.Data["id"];
                AddTableHeader(id);
                AddRecords(id);

                ListenToSelectedRecordChange();
            }
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
            HighlightSelectedRecord(SelectedRecordID, record.ID);
            SelectedRecordID = record.ID;
        }

        private void HighlightSelectedRecord(string oldId, string newId)
        {
            Record selectedRecord = records_.Find(rec => rec.ID == newId);
            Record prevSelectedRecord = records_.Find(rec => rec.ID == oldId);

            selectedRecord.BackColor = Color.LightBlue;
            
            if (prevSelectedRecord != null)
            {
                prevSelectedRecord.BackColor = Color.White;
            }
        }

        private void AddTableHeader(string id)
        {
            try
            {
                List<string> tableFieldNames = DB_Handlers.Database.GetFieldNamesFromTable(id);
                TableHeader th1 = new TableHeader(tableFieldNames);
                th1.Show();
                container.Controls.Add(th1);
            }
            catch (SystemException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private void AddRecords(string id)
        {
            try
            {
                int iterator = 0;

                List<List<string>> recordsData = DB_Handlers.Table.GetFirstPageOfRecords(id);
                foreach (var recordData in recordsData)
                {
                    Record record = new Record(recordData);
                    record.ID = iterator.ToString();
                    record.Show();
                    container.Controls.Add(record);
                    records_.Add(record);
                    iterator++;
                }
            }
            catch (SystemException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
