using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.Definitions;
using DB_Editor.Components.MainWindow.States.TableEditor.Partials;
using DB_Editor.Events;
using DB_Editor.DB_Handlers;

namespace DB_Editor.Components.MainWindow.States.TableEditor
{
    public class TableEditor : State
    {
        private TableEditorControl control_;
        public TableEditor()
            : base("TableEditor", new TableEditorControl())
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

        public override void ModifyAllowChangeState()
        {
            if (DoAllTheTests())
            {
                if (control_.ActualMode == Mode.Creator)
                {
                    Database.CreateTable(control_.NewTableName, control_.GetAllColumns());
                    this.AllowChangeState = true;
                }
                else
                {
                     if (control_.OldTableName != control_.NewTableName)
                         Database.RenameTable(control_.OldTableName, control_.NewTableName);
                     
                    List<ColumnStructureCreator> oldColumnListWithProperties = new List<ColumnStructureCreator>();
                    oldColumnListWithProperties = Database.GetColumnStructureCreatorsFromTable(control_.NewTableName);

                    List<ColumnStructureCreator> actualColumnListWithProperties = control_.GetColumnsWithProperties();
                    
                    for (int i = 0; i < oldColumnListWithProperties.Count; i++)
                    {
                        if (oldColumnListWithProperties[i] != actualColumnListWithProperties[i])
                        {
                            DB_Handlers.Table.ChangeColumn(control_.NewTableName, oldColumnListWithProperties[i].Field, actualColumnListWithProperties[i], DB_Connection.DBConnectionManager.DatabaseName);
                        }
                    }


                    if (oldColumnListWithProperties.Count != actualColumnListWithProperties.Count)
                    {
                        for (int i = 0; i < actualColumnListWithProperties.Count - oldColumnListWithProperties.Count; i++)
                        {
                            DB_Handlers.Table.AddColumn(control_.NewTableName, actualColumnListWithProperties[oldColumnListWithProperties.Count+i]);
                        }
                    }
                    this.AllowChangeState = true;
                }
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
