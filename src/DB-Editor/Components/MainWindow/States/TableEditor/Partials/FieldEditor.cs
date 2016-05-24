using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow.States.TableEditor.Partials
{
    public partial class FieldEditor : UserControl
    {
        public FieldEditor()
        {
            InitializeComponent();
        }

        public string FieldName
        {
            set
            {
                fieldName.Text = value;
            }
        }

        public void Clear()
        {
            fieldName.Text = "";
            fieldType.SelectedText = "";
        }
    }
}
