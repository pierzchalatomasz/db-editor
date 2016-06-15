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
        public event EventHandler SelectedRecordChange;

        public string ID { get; set; }

        public Record(List<string> recordData)
        {
            InitializeComponent();
            DoubleBuffered = true;

            foreach (string fieldValue in recordData)
            {
                RecordField rf = new RecordField();
                rf.FieldValue = fieldValue;
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
            if (SelectedRecordChange != null)
            {
                SelectedRecordChange(this, e);
            }
        }
    }
}
