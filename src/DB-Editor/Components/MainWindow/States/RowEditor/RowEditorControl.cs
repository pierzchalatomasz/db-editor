using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.States.RowEditor.Partials;

namespace DB_Editor.Components.MainWindow.States.RowEditor
{
    public partial class RowEditorControl : UserControl
    {
        public RowEditorControl()
        {
            InitializeComponent();

            FieldEditor field = new FieldEditor();
            field.Show();
            container.Controls.Add(field);
        }
    }
}
