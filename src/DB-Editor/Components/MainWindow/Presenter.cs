using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Editor.DB_Connection;

namespace DB_Editor.Components.MainWindow
{
    using QueryResult = List<Dictionary<string, string>>;

    class Presenter
    {
        private View view_;
        private Model model_;

        public Presenter(View view)
        {
            view_ = view;
            model_ = new Model();

            // Test połączenia
            /*DBConnectionManager.Connect("localhost", "root", "", "swiat");
            QueryResult result = DBConnectionManager.Query("SELECT * from country where name like 'p%'");

            foreach (var row in result)
            {
                foreach (var column in row)
                {
                    Console.WriteLine(column.Key + " : " + column.Value);
                }
            }*/
        }
    }
}
