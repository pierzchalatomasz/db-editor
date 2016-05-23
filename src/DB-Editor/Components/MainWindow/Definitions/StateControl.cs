using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow.Definitions
{
    public class StateControl : UserControl
    {
        virtual public Dictionary<string, string> EventData { get; set; }
    }
}
