using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow.States.RecordsListing.Partials
{
    class RecordsContainer : FlowLayoutPanel
    {
        public RecordsContainer() : base()
        {
            AutoScroll = true;
            AutoSize = true;
            BackColor = System.Drawing.Color.Transparent;
            Dock = System.Windows.Forms.DockStyle.Fill;
            FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            Location = new System.Drawing.Point(0, 0);
            Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            Name = "recordsContainer";
            Size = new System.Drawing.Size(479, 253);
            TabIndex = 0;
            WrapContents = false;
        }
    }
}
