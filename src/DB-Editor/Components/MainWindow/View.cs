using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.MainWindow
{
    public partial class View : Form
    {
        private Presenter presenter_;

        public View()
        {
            InitializeComponent();
            presenter_ = new Presenter(this);
        }
    }
}
