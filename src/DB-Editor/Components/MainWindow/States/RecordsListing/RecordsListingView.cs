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

        private RecordsContainer recordsContainerOld_ = new RecordsContainer();

        private RecordsContainer recordsContainerNew_ = new RecordsContainer();

        public Action<string> SetTitle;

        public RecordsListingView()
        {
            InitializeComponent();
            presenter_ = new RecordsListingPresenter(this);
            DoubleBuffered = true;
        }

        public override StateChangeRequestEventArgs EventData
        {
            set 
            {
                if (value.Data.ContainsKey("id"))
                {
                    presenter_.TableName = value.Data["id"];
                    ClearControls();
                    presenter_.Init();

                    SetTitle(presenter_.TableName);
                }
            }
        }

        public void UpdateView()
        {
            labelPage.Text = string.Format("Page {0} of {1}", presenter_.CurrentPage + 1, presenter_.AmountOfPages);

            BuildRecordsContainer();
            recordsContainerOld_.Hide();

            ClearControls();
            recordsContainerOld_ = recordsContainerNew_;

            ScrollTop();
            ToggleNextPageButtonVisibility();
            TogglePrevPageButtonVisibility();
            ToggleEditButtonVisibility();
        }

        #region View Builders

        private void BuildRecordsContainer()
        {
            RecordsContainer recordsContainer = new RecordsContainer();
            recordsContainer.Scroll += container_Scroll;
            recordsContainer.Show();

            ShowTableHeader(recordsContainer);
            ShowRecords(recordsContainer);

            recordsContainerNew_ = recordsContainer;
            container.Controls.Add(recordsContainerNew_);
        }

        private void ShowTableHeader(RecordsContainer recordsContainer)
        {
            TableHeader tableHeader = new TableHeader(presenter_.TableFieldNames);
            tableHeader.Show();
            recordsContainer.Controls.Add(tableHeader);
        }

        private void ShowRecords(RecordsContainer recordsContainer)
        {
            int iterator = 0;

            records_.Clear();

            foreach (var recordData in presenter_.RecordsData)
            {
                Record record = BuildRecord(recordData, iterator);
                recordsContainer.Controls.Add(record);
                records_.Add(record);
                iterator++;
            }
        }

        private Record BuildRecord(List<string> recordData, long id)
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
            StateChangeRequestEventArgs args = new StateChangeRequestEventArgs("RowEditor");
            args.Data = presenter_.GetSelectedRecordData();
            args.Data["tableName"] = presenter_.TableName;

            StateChangeRequestEvents.FireStateChangeRequest(sender, args);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Internal Methods

        private void ToggleNextPageButtonVisibility()
        {
            if (presenter_.CurrentPage == presenter_.AmountOfPages - 1 || presenter_.AmountOfPages == 0)
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
            if (presenter_.CurrentPage == 0 || presenter_.AmountOfPages == 0)
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
            
            if (presenter_.SelectedRecordID != record.ID)
            {
                presenter_.SelectedRecordID = record.ID;
            }
            else
            {
                presenter_.SelectedRecordID = -1;
            }
        }

        private void HighlightSelectedRecord(long oldId, long newId)
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
            for(int i = recordsContainerOld_.Controls.Count - 1; i >= 0; i--)
            {
                recordsContainerOld_.Controls[i].Dispose();
            }
            
            container.Controls.Remove(recordsContainerOld_);
            recordsContainerOld_.Dispose();
        }

        private void ScrollTop()
        {
            container.AutoScroll = false;
            container.VerticalScroll.Value = 0;
            container.AutoScroll = true;
        }

        #endregion

        // Blinking on scrolling fix
        private void container_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
            Application.DoEvents();
        }

        public void ToggleEditButtonVisibility()
        {
            if (presenter_.SelectedRecordID == -1)
            {
                buttonEdit.Hide();
            }
            else
            {
                buttonEdit.Show();
            }
        }
    }
}
