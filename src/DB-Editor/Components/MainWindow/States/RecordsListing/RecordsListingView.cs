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
    public partial class RecordsListingView : StateControl
    {
        private RecordsListingPresenter presenter_;

        private List<Record> records_ = new List<Record>();

        public RecordsListingView()
        {
            InitializeComponent();
            presenter_ = new RecordsListingPresenter(this);
        }

        public override StateChangeRequestEventArgs EventData
        {
            set 
            {
                presenter_.TableName = value.Data["id"];
                ClearControls();
                presenter_.Init();
            }
        }

        public void UpdateView()
        {
            labelPage.Text = string.Format("Page {0} of {1}", presenter_.CurrentPage, presenter_.AmountOfPages);

            ClearControls();
            ShowTableHeader();
            ShowRecords();

            ToggleNextPageButtonVisibility();
            TogglePrevPageButtonVisibility();
        }

        #region View Builders

        private void ShowTableHeader()
        {
            TableHeader tableHeader = new TableHeader(presenter_.TableFieldNames);
            tableHeader.Show();
            container.Controls.Add(tableHeader);
        }

        private void ShowRecords()
        {
            int iterator = 50 * (presenter_.CurrentPage - 1);

            foreach (var recordData in presenter_.RecordsData)
            {
                Record record = BuildRecord(recordData, iterator.ToString());
                container.Controls.Add(record);
                records_.Add(record);
                iterator++;
            }
        }

        private Record BuildRecord(List<string> recordData, string id)
        {
            Record record = new Record(recordData);
            record.ID = id;
            record.SelectedRecordChange += SelectedRecordChanged;
            record.Show();

            return record;
        }

        #endregion

        #region Button Methods

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            presenter_.CurrentPage++;
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            presenter_.CurrentPage--;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Internal Methods

        private void ToggleNextPageButtonVisibility()
        {
            if (presenter_.CurrentPage == presenter_.AmountOfPages || presenter_.AmountOfPages == 0)
            {
                buttonNextPage.Hide();
            }
            else
            {
                buttonNextPage.Show();
            }
        }

        private void TogglePrevPageButtonVisibility()
        {
            if (presenter_.CurrentPage == 1 || presenter_.AmountOfPages == 0)
            {
                buttonPrevPage.Hide();
            }
            else
            {
                buttonPrevPage.Show();
            }
        }

        private void SelectedRecordChanged(object sender, EventArgs e)
        {
            Record record = sender as Record;
            HighlightSelectedRecord(presenter_.SelectedRecordID, record.ID);
            presenter_.SelectedRecordID = record.ID;
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

        private void ClearControls()
        {
            for(int i = container.Controls.Count - 1; i >= 0; i--)
            {
                container.Controls[i].Dispose();
            }
            records_.Clear();
            container.Controls.Clear();
        }

        #endregion
    }
}
