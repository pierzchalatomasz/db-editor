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
using DB_Editor.Components.MainWindow.States.RowEditor.Partials;

namespace DB_Editor.Components.MainWindow.States.RowEditor
{
    public partial class RowEditorControl : StateControl
    {
        public RowEditorControl()
        {
            InitializeComponent();

            FieldEditor field = new FieldEditor();
            field.Show();
            container.Controls.Add(field);
        }

        public override Dictionary<string, string> EventData
        {
            set
            {
                // TEST of accessing event data
                foreach (FieldEditor control in container.Controls)
                {
                    control.FieldName = value["id"];
                }
            }
        }
    }
}
