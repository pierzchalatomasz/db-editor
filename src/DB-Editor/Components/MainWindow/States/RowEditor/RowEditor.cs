﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Components.MainWindow.Definitions;
using DB_Editor.Components.MainWindow.States.RecordsListing.Partials;
using DB_Editor.Components.MainWindow.States.RowEditor.Partials;
using DB_Editor.Events;

namespace DB_Editor.Components.MainWindow.States.RowEditor
{
    public class RowEditor : State
    {
        RowEditorControl control_;

        public RowEditor() : base("RowEditor", new RowEditorControl())
        {
            ButtonText = "Save";
            NextState = "RecordsListing";
            PrevState = "RecordsListing";

            control_ = Control as RowEditorControl;
            control_.SetTitle = SetTitle;
            AllowChangeState = true;
        }

        public void SetTitle(string tableName)
        {
            Title = string.Format("Adding record to \"{0}\" table", tableName);
        }


        public override void OnNextState()
        {
            control_.Save();
        }
    }
}
