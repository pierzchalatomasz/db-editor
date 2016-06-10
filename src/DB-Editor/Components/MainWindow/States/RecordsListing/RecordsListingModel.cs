using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.Components.MainWindow.States.RecordsListing.Partials;

namespace DB_Editor.Components.MainWindow.States.RecordsListing
{
    class RecordsListingModel
    {
        public RecordsListingModel()
        {
            SelectedRecordID = "";
            TableFieldNames = new List<string>();
            RecordsData = new List<List<string>>();
            CurrentPage = 0;
            AmountOfPages = 0;
        }

        public List<string> TableFieldNames { get; set; }

        public List<List<string>> RecordsData { get; set; }

        public int CurrentPage { get; set; }

        public string SelectedRecordID { get; set; }

        public int AmountOfPages { get; set; }

        public string TableName { get; set; }
    }
}
