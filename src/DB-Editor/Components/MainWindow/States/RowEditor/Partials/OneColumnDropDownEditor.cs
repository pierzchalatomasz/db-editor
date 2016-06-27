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
    public partial class OneColumnDropDownEditor : UserControl, IControlInterface
    {
        public OneColumnDropDownEditor()
        {
            InitializeComponent();
        }

        public void SelectItem()
        {
            ValueDropDownList.SelectedIndex = 0;
        }
              
        public void SelectItem(string name)
        {
            ValueDropDownList.SelectedItem = name;
        }
        
        #region Properties
        public string ValueName
        {
            get
            {
                return ValueDropDownList.SelectedItem.ToString();
            }
            set
            {
                 ValueDropDownList.SelectedItem = value;
            }
        }


        public string FieldName
        {
            get
            {
                return ColumnNameTextBox.Text.TrimEnd('*');
            }
            set
            {
                ColumnNameTextBox.Text = value;
            }
        }

        public bool NullValue { get; set; }

        public string Type { get; set; }

        public string[] Values
        {
            get
            {
                string[] tmpArray = new string[ValueDropDownList.Items.Count];
                for(int i = 0;i<ValueDropDownList.Items.Count;i++)
                    tmpArray[i] = ValueDropDownList.Items[i].ToString();
                return tmpArray;
            }
            set
            {
                if (NullValue)
                    ValueDropDownList.Items.Add("NULL");
                foreach (string item in value)
                    ValueDropDownList.Items.Add(item);
            }
        }
        #endregion

        public bool IfNecesseryFullfiled()
        {
            errorProvider1.Clear();
            if (!NullValue)
                if (ValueDropDownList.SelectedItem.ToString() != "")
                {
                    errorProvider1.SetError(this, "This column has to have value");
                    return false;
                }
            return true;
        }
    }
}
