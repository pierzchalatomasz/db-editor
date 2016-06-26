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
        private Dictionary<string, string> oldValues_ = new Dictionary<string,string>();

        private Dictionary<string, FieldEditor> fieldEditors_ = new Dictionary<string, FieldEditor>();

        public RowEditorControl()
        {
            InitializeComponent();
        }

        public string TableName { get; set; }

        public Action<string> SetTitle;

        public override StateChangeRequestEventArgs EventData
        {
            set
            {
                TableName = value.Data["tableName"];
                SetTitle(TableName);
                ReadRecordDataOnStateChange(value.Data);
                BuildFields();
            }
        }

        public void Save()
        {
            try
            {
                DB_Handlers.Record.ChangeRowValue(TableName, oldValues_, GetChangedFields());
            }
            catch(Exception e)
            {
                DisplayError.FireDisplayErrorEvent(e.Message);
            }
        }

        private void BuildFields()
        {
            foreach (var fieldData in oldValues_)
            {
                if (fieldData.Key != "tableName")
                {
                    try
                    {
                        FieldEditor fieldEditor = new FieldEditor();
                        fieldEditor.FieldName = fieldData.Key;
                        fieldEditor.Value = fieldData.Value;
                        fieldEditor.FieldType = DB_Handlers.Table.GetFieldDataType(fieldData.Key, TableName);
                        fieldEditor.Show();
                        container.Controls.Add(fieldEditor);
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
                if (item.Key != "tableName")
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
                if (oldValue.Value != fieldEditors_[oldValue.Key].Value)
                {
                    FieldEditor fieldEditor = fieldEditors_[oldValue.Key];
                    changedFields.Add(fieldEditor.FieldName, fieldEditor.Value);
                }
            }

            return changedFields;
        }
    }
}
