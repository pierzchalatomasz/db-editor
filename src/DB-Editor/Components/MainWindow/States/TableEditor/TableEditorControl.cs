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

namespace DB_Editor.Components.MainWindow.States.TableEditor
{
    public partial class TableEditorControl : StateControl
    {
        public TableEditorControl()
        {
            InitializeComponent();
            SetScrollBar();            

            for (int i = 0; i < 7; i++)
            {
                Partials.FieldEditor field = new Partials.FieldEditor();
                field.Show();
                container.Controls.Add(field);
            }
        }

        private void SetScrollBar()
        {
            container.HorizontalScroll.Maximum = 0;
            container.AutoScroll = false;
            container.VerticalScroll.Visible = false;
            container.AutoScroll = true;
        }
    }
}
