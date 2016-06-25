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
using DB_Editor.Components.MainWindow.States.TableEditor.Partials;
using DB_Editor.DB_Handlers;

namespace DB_Editor.Components.MainWindow.States.TableEditor
{
    public partial class TableEditorControl : StateControl
    {
        public TableEditorControl()
        {
            InitializeComponent();
            SetScrollBar();
            tblNameTextBox.Text = String.Empty;
        }

        public Action<string> SetTitle;

        public override StateChangeRequestEventArgs EventData
        {
            set
            {
                // Get mode (creator / editor)
                if (value.Mode == Mode.Editor)
                {
                    SetTitle(value.Data["id"]);

                    tblNameTextBox.Text = value.Data["id"];
                    string[] settingableTypes = new string[] { "float", "double", "decimal", "char", "varchar", "text", "enum" };
                        
                    List<ColumnStructureCreator> columnList = DB_Handlers.Database.GetColumnStructureCreatorsFromTable(value.Data["id"], DB_Connection.DBConnectionManager.DatabaseName);
                    foreach (var property in columnList)
                    {
                        Partials.FieldEditor field = new Partials.FieldEditor();
                        field.FieldName = property.Field;
                        field.FieldType = property.Type;
                        if (settingableTypes.Contains(field.FieldType))
                        {                        
                            field.TypeLength = property.TypeLength;
                            field.LengthReadOnly = true;
                        }
                        field.NullValue = property.NullValue;
                        field.Primary_Key = property.Primary_Key;
                        field.Default = property.Default;
                        field.Extra = property.Extra;
                        field.Show();
                        container.Controls.Add(field);
                    }
                }
                else
                {
                    Clear();
                    buttonAddNewField_Click(new object(), new EventArgs());
                }
            }
        }


        #region StuffForNewTable
        //do dokumentacji
        public string NewTableName
        {
            get
            {
                return tblNameTextBox.Text;
            }
            set
            {
                tblNameTextBox.Text = value;
            }
        }
        //do dokumentacji
        public bool CheckTableName()
        {
            if (NewTableName != String.Empty)
                return true;
            else
            {
                SetErrorProvider(tblNameTextBox, "You have to put a table name");
                return false;
            }
        }
        //do dokumentacji
        public bool CheckAmountOfColumns()
        {
            if (container.Controls.Count > 0)
                return true;
            SetErrorProvider(tblNameTextBox, "Table has to have at least one column");
            return false;

        }
        //do dokumentacji
        public bool CheckNamesOfColumns()
        {
            bool result = true;
            foreach (FieldEditor item in container.Controls)
            {
                if (item.FieldName == String.Empty)
                {
                    result = false;
                    SetErrorProvider(item, "You have to put a name for a column");
                    break;
                }
            }
            return result;
        }
        //do dokumentacji
        public bool CheckTypesOfColumns()
        {
            bool result = true;
            foreach (FieldEditor item in container.Controls)
            {
                if (item.FieldType == String.Empty)
                {
                    result = false;
                    SetErrorProvider(item, "You have to put a type field for a column");
                    break;
                }
            }
            return result;
        }
        //do dokumentacji
        public bool CheckAmountOfPrimaryKeys()
        {
            int result = 0;
            foreach (FieldEditor item in container.Controls)
            {
                if (item.Primary_Key)
                    result++;
                if(result>1)
                {
                    SetErrorProvider(item, "There can be only one primary key in table.");
                    return false;
                }
            }
            return true;          
        }

        private void SetErrorProvider(Control ctrl, string message)
        {
            errorProvider1.Clear();
            errorProvider1.SetError(ctrl, message);
        }
        //do dokumentacji
        public List<ColumnStructureCreator> GetAllColumns()
        {
            List<ColumnStructureCreator> listOfObjects = new List<ColumnStructureCreator>();//, string dbName = "", List<Tuple<string, string, string>> foreignKeys = null)
            foreach (FieldEditor item in container.Controls)
            {
                listOfObjects.Add(item.ColumnStructureObject);
            }
            return listOfObjects;
        }
        #endregion
        protected override void Clear()
        {
            // TEST of accessing event data
            foreach (Partials.FieldEditor control in container.Controls)
            {
                control.Clear();
            }
        }

        private void SetScrollBar()
        {
            container.HorizontalScroll.Maximum = 0;
            container.AutoScroll = false;
            container.VerticalScroll.Visible = false;
            container.AutoScroll = true;
        }

        private void buttonAddNewField_Click(object sender, EventArgs e)
        {
            Partials.FieldEditor field = new Partials.FieldEditor();
            field.Show();
            container.Controls.Add(field);
            ScrollToNewField();
            errorProvider1.Clear();
        }

        private void ScrollToNewField()
        {
            container.AutoScroll = false;
            container.VerticalScroll.Value = container.VerticalScroll.Maximum;
            container.AutoScroll = true;
        }

        private void tblNameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
