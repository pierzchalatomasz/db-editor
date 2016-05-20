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
            listBox1.Items.Add("swiat");
            listBox1.Items.Add("znajomi");
        }

        public void ShowInLeftPanel(Control control)
        {

        }

        public void ShowInRightPanel(Control control, string stateName)
        {
            rightPanel.Controls.Clear();
            control.Show();
            rightPanel.Controls.Add(control);
            RightPanelTitle.Text = stateName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter_.ChangeState("Test");
        }
    }
}
