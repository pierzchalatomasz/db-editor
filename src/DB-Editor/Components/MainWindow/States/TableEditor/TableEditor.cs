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
        }   

        public override void OnNextState()
        {

            if(control_.CheckTableName())
            {
                DB_Handlers.Database.CreateTable(control_.NewTableName, control_.GetAllColumns(), DB_Connection.DBConnectionManager.DatabaseName);
            }          
        }


        public override void OnPrevState()
        {
            Console.WriteLine("Are you sure?");
        }
    }
}
