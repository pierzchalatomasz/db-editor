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
using DB_Editor.Components.MainWindow.States.TablesListing;

namespace DB_Editor.Components.MainWindow
{
    public partial class View : Form
    {
        private Presenter presenter_;

        public View()
        {
            InitializeComponent();
            databasesList.Init();
            presenter_ = new Presenter(this);
            presenter_.Init();
            this.buttonNext.Visible = false;
        }

        public void DisplayStateChange()
        {
            rightPanel.Controls.Clear();
            presenter_.ActiveState.Control.Height = rightPanel.Height;
            presenter_.ActiveState.Control.Width = rightPanel.Width;
            presenter_.ActiveState.Control.AutoScroll = true;
            presenter_.ActiveState.Control.Show();
            rightPanel.Controls.Add(presenter_.ActiveState.Control);
            RightPanelTitle.Text = presenter_.ActiveState.Title;

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
            presenter_.ActiveState.ModifyAllowChangeState();
            if(presenter_.ActiveState.AllowChangeState)
            {
                StateChangeRequestEventArgs args = new StateChangeRequestEventArgs(presenter_.ActiveState.NextState);

                if (presenter_.ActiveState.DefaultNextStateData != null)
                {
                    args.Data = presenter_.ActiveState.DefaultNextStateData;
                }

                StateChangeRequestEvents.FireStateChangeRequest(sender, args);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StateChangeRequestEventArgs args = new StateChangeRequestEventArgs(presenter_.ActiveState.PrevState, StateOrder.Prev);

            if (presenter_.ActiveState.DefaultPrevStateData != null)
            {
                args.Data = presenter_.ActiveState.DefaultPrevStateData;
            }

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

        public void DisplayError(string message, string title)
        {
            MessageBox.Show(message, title);
        }
    }
}
