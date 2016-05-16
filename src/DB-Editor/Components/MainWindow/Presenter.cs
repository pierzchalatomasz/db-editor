using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Editor.Components.MainWindow
{
    class Presenter
    {
        private View view_;
        private Model model_;

        public Presenter(View view)
        {
            view_ = view;
            model_ = new Model();
        }
    }
}
