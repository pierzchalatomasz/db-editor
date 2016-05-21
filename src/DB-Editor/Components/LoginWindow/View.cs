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
        private bool advancedClicked_;
        private bool allowDrag_;
        private Point beforeDragLocation_;
        private const int advancedComponentSize_ = 30;
        private const bool clicked_ = true;
        
        public View()
        {
            InitializeComponent();
            ChangeComponentsLocation(-advancedComponentSize_, !clicked_);
        }
        
        private void AdvancedButton_Click(object sender, EventArgs e)
        {
            if(advancedClicked_)
            {
                ChangeComponentsLocation(-advancedComponentSize_, !clicked_);                
            }
            else
            {
                ChangeComponentsLocation(advancedComponentSize_, clicked_);
            }
        }
        private void ChangeComponentsLocation(int size, bool clicked)
        {
            SignInButt.Location = new Point(SignInButt.Location.X, SignInButt.Location.Y + size);
            CancelButt.Location = new Point(CancelButt.Location.X, CancelButt.Location.Y + size);
            advancedClicked_ = clicked;
            IPLabel.Visible = clicked;
            IPTextBox.Visible = clicked;
            this.Height += size;
        }

        private void SignInButt_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != String.Empty && PasswdTextBox.Text != String.Empty)
                ;
            //wyslac dalej do prezentera
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Umozliwienie przeciagania tej formy przy braku obramowania

        #region DragSettings
        private void Component_MouseDown(object sender, MouseEventArgs e)
        {
            allowDrag_ = true;
            beforeDragLocation_ = e.Location;
        }
        private void Component_MouseUp(object sender, MouseEventArgs e)
        {
            allowDrag_ = false;
        }
        private void Component_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }
        #endregion
        private void MoveForm(MouseEventArgs e)
        {
            if (allowDrag_)
            {
                this.Location = new Point((this.Location.X - beforeDragLocation_.X) + e.Location.X, (this.Location.Y - beforeDragLocation_.Y) + e.Location.Y);
                this.Update();
            }
        }
        #endregion

        #region ButtonOnHoverSettings
        private void Butt_MouseEnter(object sender, EventArgs e)
        {
            SignInButt.BackColor = Color.LightGray;
        }

        private void Butt_MouseLeave(object sender, EventArgs e)
        {
            SignInButt.BackColor = Color.Gainsboro;
        }
        #endregion
    }
}
