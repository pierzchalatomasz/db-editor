using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.DB_Handlers;
using DB_Editor.DB_Connection;

namespace DB_Editor.Components.LoginWindow
{
    class Presenter
    {
        private View view_;

        private Model model_;

        public Presenter(View view)
        {
            view_ = view;
            model_ = new Model();
            //DB_Connection.DBConnectionManager.Connect();
            //List<string> ofo = Database.GetTablesFromDatabase("fuu");
            //foreach (var i in ofo)
               // Console.WriteLine(i);
        }

        public void Connect()
        {
            
        }
    }
}
