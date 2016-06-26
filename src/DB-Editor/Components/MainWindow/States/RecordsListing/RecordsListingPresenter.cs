using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.Events;

namespace DB_Editor.Components.MainWindow.States.RecordsListing
{
    class RecordsListingPresenter
    {
        private RecordsListingModel model_;

        private RecordsListingView view_;

        public RecordsListingPresenter(RecordsListingView view)
        {
            view_ = view;
            model_ = new RecordsListingModel();
        }

        public void Init()
        {
            SetAmountOfPages();
            CurrentPage = 0;
        }

        public void UpdateData()
        {
            FetchRecords();
            FetchTableFieldNames();
            SelectedRecordID = -1;
            view_.UpdateView();
        }

        public void DeleteRecord()
        {
            DB_Handlers.Record.DeleteRow(TableName, GetSelectedRecordData());
            FetchRecords();
            view_.UpdateView();
        }

        public StateChangeRequestEventArgs GetSelectedRecordArgs()
        {
            StateChangeRequestEventArgs args = new StateChangeRequestEventArgs("RowEditor");
            args.Data = GetSelectedRecordData();
            args.Data["tableName"] = TableName;

            return args;
        }

        #region Private Methods

        private void FetchRecords()
        {
            try
            {
                model_.RecordsData = DB_Handlers.Table.GetPageOfRecordsByIndex(CurrentPage, TableName);
            }
            catch (Exception e)
            {
                DisplayError.FireDisplayErrorEvent(e.Message);
            }
        }

        private void FetchTableFieldNames()
        {
            try
            {
                TableFieldNames = DB_Handlers.Database.GetFieldNamesFromTable(TableName);
            }
            catch (Exception e)
            {
                DisplayError.FireDisplayErrorEvent(e.Message);
            }
        }

        private void SetAmountOfPages()
        {
            try
            {
                AmountOfPages = DB_Handlers.Table.GetAmountOfPages(TableName);
            }
            catch (Exception e)
            {
                DisplayError.FireDisplayErrorEvent(e.Message);
            }
        }

        public Dictionary<string, string> GetSelectedRecordData()
        {
            var output = new Dictionary<string, string>();

            for (int i = 0; i < TableFieldNames.Count; i++)
            {
                string fieldName = TableFieldNames.ElementAt(i);
                string value = RecordsData.ElementAt((int)SelectedRecordID).ElementAt(i);
                output.Add(fieldName, value);
            }

            return output;
        }

        #endregion

        #region Getters / Setters

        public long SelectedRecordID
        {
            get
            {
                return model_.SelectedRecordID;
            }
            set
            {
                model_.SelectedRecordID = value;
                view_.ToggleEditButtonVisibility();
            }
        }

        public int CurrentPage
        {
            get
            {
                return model_.CurrentPage;
            }
            set
            {
                model_.CurrentPage = value;
                FetchRecords();
                FetchTableFieldNames();
                view_.UpdateView();
            }
        }

        public int AmountOfPages
        {
            get
            {
                return model_.AmountOfPages;
            }
            set
            {
                model_.AmountOfPages = value;
            }
        }

        public string TableName
        {
            get
            {
                return model_.TableName;
            }
            set
            {
                model_.TableName = value;
            }
        }

        public List<List<string>> RecordsData
        {
            get
            {
                return model_.RecordsData;
            }
            set
            {
                model_.RecordsData = value;
            }
        }

        public List<string> TableFieldNames
        {
            get
            {
                return model_.TableFieldNames;
            }
            set
            {
                model_.TableFieldNames = value;
            }
        }

        #endregion
    }
}
