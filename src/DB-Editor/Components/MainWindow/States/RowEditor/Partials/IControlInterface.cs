using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Components.MainWindow.States.RowEditor.Partials
{
    interface IControlInterface
    {
        string FieldName
        {
            get;
            set;
        }
        string ValueName { get; set; }
        bool NullValue
        {
            get;
            set;
        }
        bool IfNecesseryFullfiled();
    }
}
