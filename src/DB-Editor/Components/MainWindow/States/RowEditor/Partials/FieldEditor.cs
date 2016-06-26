using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow.States.RowEditor.Partials
{
    public partial class FieldEditor : UserControl
    {
        public FieldEditor()
        {
            InitializeComponent();
        }

        public string FieldName
        {
            get
            {
                return fieldName.Text;
            }
            set
            {
                fieldName.Text = value;
            }
        }

        public string Value
        {
            get
            {
                return fieldValue.Text;
            }
            set
            {
                fieldValue.Text = value;
            }
        }

        public string FieldType
        {
            get
            {
                return fieldType.Text;
            }
            set
            {
                fieldType.Text = value;
            }
        }
    }
}
