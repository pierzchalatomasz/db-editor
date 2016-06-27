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
    public partial class OneColumnTextEditor : UserControl, IControlInterface
    {
        public OneColumnTextEditor()
        {
            InitializeComponent();

        }

        #region Properties
        public string FieldName
        {
            get
            {
                return FieldNameTextBox.Lines[0].TrimEnd('*');
            }
            set
            {
                FieldNameTextBox.Text = value;
            }
        }

        public string ValueName
        {
            get
            {
                return ValueTextBox.Text;
            }
            set
            {
                ValueTextBox.Text = value;
            }
        }

        public bool NullValue { get; set; }

        public string Type 
        { 
            get
            {
                return FieldNameTextBox.Lines[1];
            }
            set
            {
                FieldNameTextBox.Text += System.Environment.NewLine + value;
            }
        }

        public int Length
        {
            get
            {
                return ValueTextBox.MaxLength;
            }
            set
            {
                ValueTextBox.MaxLength = value;
            }
        }
        #endregion

        public bool IfNecesseryFullfiled()
        {
            errorProvider1.Clear();
            if (!NullValue)
                if (ValueTextBox.Text != "")
                {
                    errorProvider1.SetError(this, "This column has to have value");
                    return false;
                }
            return true;
        }
    }
}
