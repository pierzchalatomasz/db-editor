using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow.States.RecordsListing.Partials
{
    public partial class Record : UserControl
    {
        public Record()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                RecordField rf = new RecordField();
                rf.FieldValue = "Field value " + (i + 1);
                rf.Show();
                container.Controls.Add(rf);
            }

            ListenToClick(container.Controls);
        }

        private void ListenToClick(ControlCollection controls)
        {            
            foreach (Control control in controls)
            {
                control.Click += container_Click;

                if (controls.Count > 0)
                {
                    ListenToClick(control.Controls);
                }
            }
        }

        private void container_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }
    }
}
