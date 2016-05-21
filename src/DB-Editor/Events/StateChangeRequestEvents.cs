using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Events
{
    public static class StateChangeRequestEvents
    {
        public static event EventHandler<StateChangeRequestEventArgs> StateChangeRequest;

        public static void FireStateChangeRequest(object sender, StateChangeRequestEventArgs args)
        {
            var evt = StateChangeRequest;

            if (evt != null)
            {
                evt(sender, args);
            }
        }
    }
}
