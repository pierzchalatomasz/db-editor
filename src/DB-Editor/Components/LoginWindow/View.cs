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

        private MainWindow.View mainWindow;

        public View()
        {
            InitializeComponent();
            presenter_ = new Presenter(this);
        }

        private void CloseLoginWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            mainWindow = new MainWindow.View(server.Text, username.Text, password.Text);
            mainWindow.Show();
            mainWindow.FormClosed += CloseLoginWindow;
            Hide();
        }
    }
}
