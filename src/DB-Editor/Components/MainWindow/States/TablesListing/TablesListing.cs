using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.Definitions;

namespace DB_Editor.Components.MainWindow.States.TablesListing
{
    public class TablesListing : State
    {
        public TablesListing() : base("TablesListing", new TablesListingControl())
        {
            NextState = "TableEditor";
            ButtonText = "Add new table";
        }
        public override void DatabaseChanged(object sender, EventArgs e)
        {
            try
            {
                DB_Connection.DBConnectionManager.Connect();
                List<string> tablesNamesList = DB_Handlers.Database.GetTablesFromDatabase(DB_Connection.DBConnectionManager.DatabaseName);
                TablesListingControl tablesListObject = (TablesListingControl)this.Control;
                tablesListObject.AddTables(tablesNamesList);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                DB_Connection.DBConnectionManager.Connection.Close();
            }
        }
    }
}
