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
using DB_Editor.Components.MainWindow.Definitions;
using DB_Editor.Components.MainWindow.States.RowEditor.Partials;

namespace DB_Editor.Components.MainWindow.States.RowEditor
{
    public partial class RowEditorControl : StateControl
    {
        public RowEditorControl()
        {
            InitializeComponent();
        }

        public override StateChangeRequestEventArgs EventData
        {
            set
            {
                // Get mode (creator / editor)
                //if (value.Mode == Mode.Editor)
                //{
                    BuildFields(value.Data);
                //}
                //else
                {
                  //  Clear();
                }
            }
        }

        private void BuildFields(Dictionary<string, string> data)
        {
            foreach (var fieldData in data)
            {
                Console.WriteLine(fieldData.Key);

                FieldEditor field = new FieldEditor();
                field.FieldName = fieldData.Key;
                field.Value = fieldData.Value;
                field.Show();
                container.Controls.Add(field);
            }
        }
    }
}
