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

namespace DB_Editor.Components.MainWindow.States.TablesListing.Partials
{
    public partial class TableItem : UserControl
    {
        public TableItem(string name)
        {
            InitializeComponent();
            this.name.Text = name;
        }

        #region ControlEvents
        private void buttonRecords_Click(object sender, EventArgs args)
        {
            StateChangeRequestEventArgs eventArgs = new StateChangeRequestEventArgs("RecordsListing");
            eventArgs.Data.Add("id", name.Text);
            eventArgs.Mode = Mode.Editor;
            StateChangeRequestEvents.FireStateChangeRequest(sender, eventArgs);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            StateChangeRequestEventArgs eventArgs = new StateChangeRequestEventArgs("TableEditor");
            eventArgs.Data.Add("id", name.Text);
            eventArgs.Mode = Mode.Editor;
            StateChangeRequestEvents.FireStateChangeRequest(sender, eventArgs);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("This will delete whole table from database. Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DB_Handlers.Database.DropTable(this.name.Text);
                this.Dispose();
            }
        }
        #endregion
    }
}
