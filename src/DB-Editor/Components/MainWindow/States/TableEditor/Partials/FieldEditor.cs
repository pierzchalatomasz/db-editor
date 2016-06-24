using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.DB_Handlers;

namespace DB_Editor.Components.MainWindow.States.TableEditor.Partials
{
    public partial class FieldEditor : UserControl
    {
        private FieldEditorPresenter presenter_;
        private static bool auto_increment_clicked;
        private static bool primary_key_clicked;
        private static bool foreign_key_clicked;

        public FieldEditor()
        {
            InitializeComponent();
            BasicValues();
            presenter_ = new FieldEditorPresenter(this);
            auto_increment_clicked = false;
            primary_key_clicked = false;
            foreign_key_clicked = false;
        }

        #region Properties
        public ColumnStructureCreator ColumnStructureObject
        {
            get
            {
                return new ColumnStructureCreator(FieldName, FieldType, NullValue, Primary_Key, TypeLength, Default, Extra);
            }
        }
        public string FieldName
        {
            get
            {
                return fieldNameTxtBox.Text;
            }
            set
            {
                fieldNameTxtBox.Text = value;
            }
        }
        public string FieldType
        {
            get
            {
                if (fieldTypeDrpDwnLst.SelectedIndex > -1)
                    return fieldTypeDrpDwnLst.SelectedItem.ToString();
                else
                    return "";
            }
       
            //set
            //{
            //    fieldTypeDrpDwnLst.SelectedItem = value;
            //}
        }
        public string TypeLength
        {
            get
            {
                return LengthTxtBox.Text;
            }
            //set
            //{
            //    LengthTxtBox.Text = value;
            //}
        }       
        public bool NullValue
        {
            get
            {
                if(NullDrpDwnLst.SelectedItem.ToString() == "YES")
                    return true;
                else
                    return false;
            }
            //set
            //{
            //    if(value)
            //       NullDrpDwnLst.SelectedItem = "YES";
            //    else
            //        NullDrpDwnLst.SelectedItem = "NO";
            //}
        }       
        public bool Primary_Key
        {
            get
            {
                return PrimaryKeyChckBox.Checked;
            }
            //set
            //{
            //    PrimaryKeyChckBox.Checked = value;
            //}
        }       
        public string Default
        {
            get
            {
                return defaultTextBox.Text;
            }
            //set
            //{
            //    defaultTextBox.Text = value;
            //}
        }      
        public bool Extra
        {
            get
            {
                return AutoIncrementChckBox.Checked;
            }
            //set
            //{
            //    AutoIncrementChckBox.Checked = value;
            //}
        }
        #endregion
        public void Clear()
        {
            fieldNameTxtBox.Text = "";
            fieldTypeDrpDwnLst.SelectedItem = "YES";
        }

        #region BasicSettings
        private void BasicValues()
        {
            AddBasicItemsToNullDrpDwnLst();
            AddBasicTypesToFieldTypeDrpDwnlst();
        }
        private void AddBasicItemsToNullDrpDwnLst()
        {
            NullDrpDwnLst.Items.Add("YES");
            NullDrpDwnLst.Items.Add("NO");
            NullDrpDwnLst.SelectedIndex = 0;
        }
        private void AddBasicTypesToFieldTypeDrpDwnlst()
        {
            fieldTypeDrpDwnLst.Items.Add("int");
            fieldTypeDrpDwnLst.Items.Add("tinyint");
            fieldTypeDrpDwnLst.Items.Add("smallint");
            fieldTypeDrpDwnLst.Items.Add("mediumint");
            fieldTypeDrpDwnLst.Items.Add("bigint");
            fieldTypeDrpDwnLst.Items.Add("float");//tutaj moze byc troche 'inaczej' z implementacja
            fieldTypeDrpDwnLst.Items.Add("double");//tutaj moze byc troche 'inaczej' z implementacja
            fieldTypeDrpDwnLst.Items.Add("decimal");//tutaj moze byc troche 'inaczej' z implementacja
            fieldTypeDrpDwnLst.Items.Add("char");
            fieldTypeDrpDwnLst.Items.Add("varchar");
            fieldTypeDrpDwnLst.Items.Add("text");
            fieldTypeDrpDwnLst.Items.Add("tinytext");
            fieldTypeDrpDwnLst.Items.Add("mediumtext");
            fieldTypeDrpDwnLst.Items.Add("longtext");
            fieldTypeDrpDwnLst.Items.Add("enum");//tutaj moze byc troche 'inaczej' z implementacja
            fieldTypeDrpDwnLst.Items.Add("date");
            fieldTypeDrpDwnLst.Items.Add("datetime");
            fieldTypeDrpDwnLst.Items.Add("timestamp");
            fieldTypeDrpDwnLst.Items.Add("time");
            fieldTypeDrpDwnLst.Items.Add("year");
            fieldTypeDrpDwnLst.Items.Add("bool");
        }
        #endregion

        #region Events
        public void Auto_Increment_CheckChanged(object sender, EventArgs e)
        {
            ForeignKeyChckBox.Checked = false;
            PrimaryKeyChckBox.Checked = !auto_increment_clicked;
            defaultTextBox.Text = "";
            defaultTextBox.Enabled = auto_increment_clicked;
            NullDrpDwnLst.Enabled = auto_increment_clicked;
            if(auto_increment_clicked)
                NullDrpDwnLst.SelectedItem = "YES";
            else
                NullDrpDwnLst.SelectedItem = "NO";
            ForeignKeyChckBox.Enabled = auto_increment_clicked;
            PrimaryKeyChckBox.Enabled = auto_increment_clicked;           
            auto_increment_clicked = !auto_increment_clicked;
        }
        public void Primary_Key_CheckChanged(object sender, EventArgs e)
        {
            PrimaryKeyChckBox.Checked = !primary_key_clicked;
            ForeignKeyChckBox.Checked = false;
            defaultTextBox.Text = "";
            defaultTextBox.Enabled = primary_key_clicked;
            NullDrpDwnLst.Enabled = primary_key_clicked;
            if (primary_key_clicked)
                NullDrpDwnLst.SelectedItem = "YES";
            else
                NullDrpDwnLst.SelectedItem = "NO";
            ForeignKeyChckBox.Enabled = primary_key_clicked;

            
            primary_key_clicked = !primary_key_clicked;
        }
        public void Foreign_Key_CheckChanged(object sender, EventArgs e)
        {
            PrimaryKeyChckBox.Checked = false;
            AutoIncrementChckBox.Checked = false;
            defaultTextBox.Text = "";
            defaultTextBox.Enabled = foreign_key_clicked;
            NullDrpDwnLst.Enabled = foreign_key_clicked;
            if (foreign_key_clicked)
                NullDrpDwnLst.SelectedItem = "YES";
            else
                NullDrpDwnLst.SelectedItem = "NO";
            PrimaryKeyChckBox.Enabled = foreign_key_clicked;
            AutoIncrementChckBox.Enabled = foreign_key_clicked;  
      
            foreign_key_clicked = !foreign_key_clicked;
        }
        public void Field_Type_Changed(object sender, EventArgs e)
        {
            string[] settingableTypes = new string[] { "float", "double", "decimal", "char", "varchar", "text", "enum" };
            if (settingableTypes.Contains(fieldTypeDrpDwnLst.SelectedItem))
                LengthTxtBox.ReadOnly = false;
            else
                LengthTxtBox.ReadOnly = true;
        }
        #endregion

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
