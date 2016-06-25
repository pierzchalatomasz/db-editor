﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.Definitions;

namespace DB_Editor.Components.MainWindow.States.RowEditor
{
    public class RowEditor : State
    {
        public RowEditor() : base("RowEditor", new RowEditorControl())
        {
            ButtonText = "Save";
            NextState = "TablesListing";
            PrevState = "RecordsListing";

            var control = Control as RowEditorControl;
            control.SetTitle = SetTitle;
        }

        public void SetTitle(string tableName)
        {
            Title = string.Format("Editing record of \"{0}\" table", tableName);
        }
    }
}
