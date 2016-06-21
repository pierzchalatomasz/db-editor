using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Components.MainWindow.States.TableEditor.Partials
{
    class FieldEditorPresenter
    {
        #region EventHandlers
        public event EventHandler PrimaryKeyCheckChanged;
        public event EventHandler ForeignKeyCheckChanged;
        public event EventHandler AutoIncrementCheckChanged;
        public event EventHandler FieldTypeChanged;
        #endregion

        public FieldEditorPresenter(FieldEditor fld)
        {
            AutoIncrementCheckChanged += fld.Auto_Increment_CheckChanged;
            PrimaryKeyCheckChanged += fld.Primary_Key_CheckChanged;
            ForeignKeyCheckChanged += fld.Foreign_Key_CheckChanged;
            FieldTypeChanged += fld.Field_Type_Changed;
        
        }

    }
}
