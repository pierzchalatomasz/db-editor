using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Components.MainWindow
{
    class Presenter
    {
        View view_;
        Model model_;

        public Presenter(View view)
        {
            view_ = view;
            model_ = new Model();
        }
    }
}
