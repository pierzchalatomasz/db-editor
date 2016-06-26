using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.Components.MainWindow.Definitions;
using DB_Editor.Events;

namespace DB_Editor.Components.MainWindow.States.RecordsListing
{
    public class RecordsListing : State
    {
        public RecordsListing() : base("RecordsListing", new RecordsListingView())
        {
            NextState = "RowEditor";
            PrevState = "TablesListing";
            ButtonText = "Add new record";
            Rebuildable = false;

            var control = Control as RecordsListingView;
            control.SetTitle += SetTitle;
            control.SetTitle += SetDefaultNextStateData;
        }

        public override void OnNextState()
        {
           
        }

        private void SetTitle(string tableName)
        {
            Title = string.Format("Records of \"{0}\" table", tableName);
            
        }

        private void SetDefaultNextStateData(string tableName)
        {
            DefaultNextStateData = new Dictionary<string, string>();
            DefaultNextStateData.Add("tableName", tableName);
        }
    }
}
