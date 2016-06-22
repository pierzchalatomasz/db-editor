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
            Resize += OnResize;
            Paint += OnResize;
        }

        public void RefreshComponent()
        {
            this.welcomeInfo.AutoSize = true;
            this.welcomeInfo.BackColor = System.Drawing.Color.Transparent;
            this.welcomeInfo.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeInfo.Location = new System.Drawing.Point(0, 0);
            this.welcomeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeInfo.Name = "welcomeInfo";
            this.welcomeInfo.Size = new System.Drawing.Size(351, 15);
            this.welcomeInfo.TabIndex = 0;
            this.welcomeInfo.Text = "Choose the database to connect from the left panel (double click)";
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

        public void OnResize(object sender, EventArgs e)
        {
            foreach (Control tableItem in TableItemsContainer.Controls)
            {
                tableItem.Width = Width - 25;
            }
        }
    }
}
