using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Events
{
    public static class DisplayError
    {
        public static event Action<string, string> DisplayErrorEvent;

        public static void FireDisplayErrorEvent(string message, string title = "Error")
        {
            if (DisplayErrorEvent != null)
            {
                DisplayErrorEvent(message, title);
            }
        }
    }
}
