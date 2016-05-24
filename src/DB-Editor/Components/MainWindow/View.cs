using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Editor.Events;

namespace DB_Editor.Components.MainWindow
{
    public partial class View : Form
    {
        private Presenter presenter_;

        public View()
        {
            InitializeComponent();
            presenter_ = new Presenter(this);
            presenter_.Init();

            // TODO
            databasesList.Items.Add("swiat");
            databasesList.Items.Add("znajomi");
        }

        public void DisplayStateChange()
        {
            rightPanel.Controls.Clear();
            presenter_.ActiveState.Control.Show();
            rightPanel.Controls.Add(presenter_.ActiveState.Control);
            RightPanelTitle.Text = presenter_.ActiveState.Name;

            UpdateButtons();
        }

        private void ToggleButtonVisibility(Button button, string anotherState)
        {
            if (anotherState != null)
            {
                button.Show();
            }
            else
            {
                button.Hide();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            StateChangeRequestEventArgs args = new StateChangeRequestEventArgs(presenter_.ActiveState.NextState);
            StateChangeRequestEvents.FireStateChangeRequest(sender, args);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StateChangeRequestEventArgs args = new StateChangeRequestEventArgs(presenter_.ActiveState.PrevState, StateOrder.Prev);
            StateChangeRequestEvents.FireStateChangeRequest(sender, args);
        }

        private void UpdateButtons()
        {
            SetButtonText();
            ToggleButtonVisibility(buttonNext, presenter_.ActiveState.NextState);
            ToggleButtonVisibility(buttonBack, presenter_.ActiveState.PrevState);
        }

        private void SetButtonText()
        {
            if (presenter_.ActiveState.ButtonText != null)
            {
                buttonNext.Text = presenter_.ActiveState.ButtonText;
            }
        }
    }
}
