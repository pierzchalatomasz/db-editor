using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Events;

namespace DB_Editor.Components.MainWindow.Definitions
{
    public class StateControl : UserControl
    {
        virtual public StateChangeRequestEventArgs EventData { get; set; }

        virtual protected void Clear() { }
    }
}
