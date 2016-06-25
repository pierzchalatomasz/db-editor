using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.Definitions;
using DB_Editor.Components.MainWindow.States.TableEditor.Partials;

namespace DB_Editor.Components.MainWindow.States.TableEditor
{
    public class TableEditor : State
    {
        private TableEditorControl control_;
        public TableEditor() : base("TableEditor", new TableEditorControl())
        {
            PrevState = "TablesListing";
            NextState = "TablesListing";
            ButtonText = "Save";
            control_ = Control as TableEditorControl;
            this.AllowChangeState = false;
            control_.SetTitle = SetTitle;
        }

        public void SetTitle(string tableName)
        {
            Title = string.Format("Editing \"{0}\" table", tableName);
        }

        public override void OnNextState()
        {           
            Console.WriteLine("Saved successfully");
        }

        public override void OnPrevState()
        {
            Console.WriteLine("Are you sure?");
        }

        //do dokumentacji
        public override void ModifyAllowChangeState()
        {
            if (DoAllTheTests())
            {
                DB_Handlers.Database.CreateTable(control_.NewTableName, control_.GetAllColumns(), DB_Connection.DBConnectionManager.DatabaseName);
                this.AllowChangeState = true;
            }
            else
            {
                this.AllowChangeState = false;
            }
        }

        private bool DoAllTheTests()
        {
            if (control_.CheckTableName())
            {
                if (control_.CheckAmountOfColumns())
                {
                    if (control_.CheckNamesOfColumns())
                    {
                        if (control_.CheckTypesOfColumns())
                        {
                            if (control_.CheckAmountOfPrimaryKeys())
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

    }
}
