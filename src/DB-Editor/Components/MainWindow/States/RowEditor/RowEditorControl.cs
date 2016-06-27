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
using DB_Editor.DB_Handlers;

namespace DB_Editor.Components.MainWindow.States.RowEditor
{
    public partial class RowEditorControl : StateControl
    {
        #region PrivateFields
        private Dictionary<string, string> oldValues_ = new Dictionary<string, string>();
        private Dictionary<string, FieldEditor> fieldEditors_ = new Dictionary<string, FieldEditor>();
        private HorizontalLineControl tmpCtrl_ = new HorizontalLineControl();
        private bool changeRowControl_ = true;
        #endregion

        public RowEditorControl()
        {
            InitializeComponent();
            RowEditorContainer.Controls.Clear();
        }

        private void AddControl(Control ctrl)
        {
            RowEditorContainer.Controls.Add(ctrl);
        }

        public bool ReturnChangeRowControl
        {
            get
            {
                return changeRowControl_;
            }
        }

        public string TableName { get; set; }

        public Action<string, bool> SetTitle;

        public override StateChangeRequestEventArgs EventData
        {
            set
            {
                TableName = value.Data["tableName"];
                
                if (value.Data["changeRow"] == "changeRow")
                {
                    ReadRecordDataOnStateChange(value.Data);
                    BuildFields();
                    changeRowControl_ = true;
                    SetTitle(TableName, changeRowControl_);
                }
                else
                {
                    MakeAllTheComponents();
                    changeRowControl_ = false;
                    SetTitle(TableName, changeRowControl_);
                }

            }
        }

        #region MakingNewRecord
        private void MakeAllTheComponents()
        {
            changeRowControl_ = false;
            List<ColumnStructureCreator> tmpList = new List<ColumnStructureCreator>();
            tmpList = Database.GetColumnStructureCreatorsFromTable(TableName);
            foreach (ColumnStructureCreator item in tmpList)
            {
                OneColumnDropDownEditor example1 = new OneColumnDropDownEditor();
                OneColumnTextEditor example2 = new OneColumnTextEditor();
                if (item.Type == "enum")
                {
                    example1.FieldName = item.Field;
                    string[] tmpList2 = DB_Handlers.Table.GetEnumValues(TableName, item.Field);

                    example1.Values = tmpList2;
                    example1.NullValue = item.NullValue;
                    if (!item.NullValue)
                    {

                        example1.FieldName = example1.FieldName + "*";
                        example1.SelectItem();
                    }
                    example1.Type = "enum";
                    if (item.Default != "")
                        example1.SelectItem(item.Default);
                    example1.Show();
                    this.RowEditorContainer.Controls.Add(example1);
                }
                else
                {
                    example2.FieldName = item.Field;
                    //example2.NullValue = item.NullValue;
                    if (!item.NullValue)
                    {
                        example2.FieldName = example2.FieldName + "*";
                    }

                    example2.Type = item.Type;
                    example2.ValueName = item.Default;
                    example2.Show();
                    this.RowEditorContainer.Controls.Add(example2);
                }
                this.RowEditorContainer.Controls.Add(new HorizontalLineControl());
            }
        }

        private bool IsItAllowed()
        {
            bool result = false;
            foreach (IControlInterface item in RowEditorContainer.Controls)
            {
                if (item.GetType() != tmpCtrl_.GetType())
                {
                    if (item.IfNecesseryFullfiled())
                        result = true;
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }
        #endregion

        public void Save()
        {
            if (changeRowControl_)
            {
                try
                {                 
                    OperationResult result = DB_Handlers.Record.ChangeRowValue(TableName, oldValues_, GetChangedFields());
                    if(!result.IsSucceded)
                    {
                        changeRowControl_ = false;
                        MessageBox.Show(result.Exception.ToString(), "Warning");
                    }
                }
                catch (Exception e)
                {
                    DisplayError.FireDisplayErrorEvent(e.Message);
                }
            }
            else
            {
                try
                {
                    List<string> columnNames = new List<string>();
                    List<string> values = new List<string>();
                    foreach (IControlInterface item in RowEditorContainer.Controls)
                    {
                        if (item.GetType() != tmpCtrl_.GetType())
                        {
                            if (item.FieldName != "")
                                columnNames.Add(item.FieldName);
                            else
                                columnNames.Add("NULL");
                            if (item.ValueName != "")
                                values.Add(item.ValueName);
                            else
                                values.Add("NULL");
                        }
                    }
                    DB_Handlers.Record.InsertRowValue(TableName, columnNames, values);
                }
                catch (Exception e)
                {
                    DisplayError.FireDisplayErrorEvent(e.Message);
                }
            }
        }

        #region EditingRecord
        private void BuildFields()
        {
            foreach (var fieldData in oldValues_)
            {
                if (fieldData.Key != "tableName" && fieldData.Key != "changeRow")
                {
                    try
                    {
                        FieldEditor fieldEditor = new FieldEditor();
                        fieldEditor.FieldName = fieldData.Key;
                        fieldEditor.Value = fieldData.Value;
                        fieldEditor.FieldType = DB_Handlers.Table.GetFieldDataType(fieldData.Key, TableName);
                        fieldEditor.Show();
                        RowEditorContainer.Controls.Add(fieldEditor);
                        fieldEditors_.Add(fieldData.Key, fieldEditor);
                    }
                    catch (Exception e)
                    {
                        DisplayError.FireDisplayErrorEvent(e.Message);
                    }
                }
            }
        }

        private void ReadRecordDataOnStateChange(Dictionary<string, string> data)
        {
            foreach (var item in data)
            {
                if (item.Key != "tableName" && item.Key != "changeRow")
                {
                    oldValues_.Add(item.Key, item.Value);
                }
            }
        }

        private Dictionary<string, string> GetChangedFields()
        {
            Dictionary<string, string> changedFields = new Dictionary<string, string>();

            foreach (var oldValue in oldValues_)
            {
                //linijka nizej, najprawdopodobniej szukasz po "zlym" kluczu, przez to nie chce sie zapisywac zmiana
                if (oldValue.Value != fieldEditors_[oldValue.Key].Value)
                {
                    FieldEditor fieldEditor = fieldEditors_[oldValue.Key];
                    changedFields.Add(fieldEditor.FieldName, fieldEditor.Value);
                }
            }

            return changedFields;
        }
        #endregion
    }
}
