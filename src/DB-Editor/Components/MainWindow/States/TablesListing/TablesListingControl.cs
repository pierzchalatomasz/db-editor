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
using DB_Editor.Components.MainWindow.States.TablesListing.Partials;

namespace DB_Editor.Components.MainWindow.States.TablesListing
{
    public partial class TablesListingControl : StateControl
    {
        public TablesListingControl()
        {
            InitializeComponent();
            SetTableItemsWidth();
            DisplayData();
        }

        public void AddTables(List<string> tablesNamesList)
        {
            TableItemsContainer.Controls.Clear();
            foreach (var tableName in tablesNamesList)
            {
                TableItem tableItem = new TableItem(tableName);
                tableItem.Show();
                TableItemsContainer.Controls.Add(tableItem);
            }
        }

        public override void OnResize(int width, int height)
        {
            base.OnResize(width, height);
            TableItemsContainer.Width = Width;
            SetTableItemsWidth();
        }

        private void SetTableItemsWidth()
        {
            foreach (Control tableItem in TableItemsContainer.Controls)
            {
                tableItem.Width = Width - 25;
            }
        }

        private void DisplayData()
        {
            try
            {
                List<string> tablesNamesList = DB_Handlers.Database.GetTablesFromDatabase(DB_Connection.DBConnectionManager.DatabaseName);
                AddTables(tablesNamesList);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                DB_Connection.DBConnectionManager.Connection.Close();
            }
        }
    }
}
