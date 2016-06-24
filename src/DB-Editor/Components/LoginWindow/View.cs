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
            bool connected = false;

            try
            {
                LogIn();
                connected = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Login Error");
            }
            finally
            {
                if (connected)
                {
                    ShowMainWindow();
                }
            }
        }

        private void LogIn()
        {
            DB_Connection.DBConnectionManager.ServerUrl = server.Text;
            DB_Connection.DBConnectionManager.Username = username.Text;
            DB_Connection.DBConnectionManager.Password = password.Text;
            DB_Connection.DBConnectionManager.Connect();
            DB_Connection.DBConnectionManager.TryLogIn();
        }

        private void ShowMainWindow()
        {
            mainWindow = new MainWindow.View();
            mainWindow.Show();
            mainWindow.FormClosed += CloseLoginWindow;
            Hide();
        }
    }
}
