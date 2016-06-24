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
        }

        public override StateChangeRequestEventArgs EventData
        {
            set
            {
                container.Controls.Clear();

                // Get mode (creator / editor)
                if (value.Mode == Mode.Editor)
                {
                    List<string> fieldNames = DB_Handlers.Database.GetFieldNamesFromTable(value.Data["id"]);
                    foreach (var fieldName in fieldNames)
                    {
                        Partials.FieldEditor field = new Partials.FieldEditor();
                        field.FieldName = fieldName;
                        field.Show();
                        container.Controls.Add(field);
                    }
                }
                else
                {
                    Clear();
                }
            }
        }

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
        public bool CheckTableName()
        {
            if (NewTableName != String.Empty)
                return true;
            else
            {
                errorProvider1.SetError(tblNameTextBox, "You have to put a table name");
                return false;
            }
        }
        
        public List<ColumnStructureCreator> GetAllColumns()
        {
            List<ColumnStructureCreator> listOfObjects = new List<ColumnStructureCreator>();//, string dbName = "", List<Tuple<string, string, string>> foreignKeys = null)
            foreach (FieldEditor item in container.Controls)
            {
                listOfObjects.Add(item.ColumnStructureObject);
            }
            
            return listOfObjects;
        }

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
            tblNameTextBox.Text = String.Empty;
            field.Show();
            container.Controls.Add(field);
            ScrollToNewField();
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
