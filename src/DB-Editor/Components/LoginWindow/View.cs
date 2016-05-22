using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Editor.Components.LoginWindow
{
    public partial class View : Form
    {
        private Presenter presenter_;

        public View()
        {
            InitializeComponent();
            presenter_ = new Presenter(this);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            new MainWindow.View().Show();
        }
    }
}
