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
        public TableEditor() : base("TableEditor", new TableEditorControl())
        {
            PrevState = "TablesListing";
            NextState = "TablesListing";
            ButtonText = "Save";
        }   

        public override void OnNextState()
        {

            //this.Control.Container
            Console.WriteLine("Saved sucessfully!");
        }

        public override void OnPrevState()
        {
            Console.WriteLine("Are you sure?");
        }
    }
}
