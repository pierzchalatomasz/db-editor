namespace DB_Editor.Components.LoginWindow
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HorizontalLineLabel = new System.Windows.Forms.Label();
            this.PleaseLogInLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswdLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswdTextBox = new System.Windows.Forms.TextBox();
            this.AdvancedButton = new System.Windows.Forms.Label();
            this.SignInButt = new System.Windows.Forms.Button();
            this.CancelButt = new System.Windows.Forms.Button();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HorizontalLineLabel
            // 
            this.HorizontalLineLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLineLabel.Location = new System.Drawing.Point(-5, 49);
            this.HorizontalLineLabel.Name = "HorizontalLineLabel";
            this.HorizontalLineLabel.Size = new System.Drawing.Size(300, 2);
            this.HorizontalLineLabel.TabIndex = 0;
            // 
            // PleaseLogInLabel
            // 
            this.PleaseLogInLabel.AutoSize = true;
            this.PleaseLogInLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PleaseLogInLabel.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PleaseLogInLabel.Location = new System.Drawing.Point(72, 9);
            this.PleaseLogInLabel.Name = "PleaseLogInLabel";
            this.PleaseLogInLabel.Size = new System.Drawing.Size(151, 26);
            this.PleaseLogInLabel.TabIndex = 1;
            this.PleaseLogInLabel.Text = "PLEASE LOG IN";
            this.PleaseLogInLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDown);
            this.PleaseLogInLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Component_MouseMove);
            this.PleaseLogInLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component_MouseUp);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UsernameLabel.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 80);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(64, 15);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDown);
            this.UsernameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Component_MouseMove);
            this.UsernameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component_MouseUp);
            // 
            // PasswdLabel
            // 
            this.PasswdLabel.AutoSize = true;
            this.PasswdLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasswdLabel.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswdLabel.Location = new System.Drawing.Point(12, 104);
            this.PasswdLabel.Name = "PasswdLabel";
            this.PasswdLabel.Size = new System.Drawing.Size(60, 15);
            this.PasswdLabel.TabIndex = 3;
            this.PasswdLabel.Text = "Password:";
            this.PasswdLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDown);
            this.PasswdLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Component_MouseMove);
            this.PasswdLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component_MouseUp);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameTextBox.Location = new System.Drawing.Point(77, 80);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(163, 23);
            this.UsernameTextBox.TabIndex = 4;
            this.UsernameTextBox.Text = "root";
            // 
            // PasswdTextBox
            // 
            this.PasswdTextBox.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswdTextBox.Location = new System.Drawing.Point(77, 104);
            this.PasswdTextBox.Name = "PasswdTextBox";
            this.PasswdTextBox.PasswordChar = '*';
            this.PasswdTextBox.Size = new System.Drawing.Size(163, 23);
            this.PasswdTextBox.TabIndex = 5;
            // 
            // AdvancedButton
            // 
            this.AdvancedButton.AutoSize = true;
            this.AdvancedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdvancedButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdvancedButton.ForeColor = System.Drawing.Color.Blue;
            this.AdvancedButton.Location = new System.Drawing.Point(74, 127);
            this.AdvancedButton.Name = "AdvancedButton";
            this.AdvancedButton.Size = new System.Drawing.Size(60, 15);
            this.AdvancedButton.TabIndex = 6;
            this.AdvancedButton.Text = "Advanced";
            this.AdvancedButton.Click += new System.EventHandler(this.AdvancedButton_Click);
            // 
            // SignInButt
            // 
            this.SignInButt.BackColor = System.Drawing.Color.Gainsboro;
            this.SignInButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInButt.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignInButt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignInButt.Location = new System.Drawing.Point(77, 173);
            this.SignInButt.Name = "SignInButt";
            this.SignInButt.Size = new System.Drawing.Size(75, 23);
            this.SignInButt.TabIndex = 7;
            this.SignInButt.Text = "Sign In";
            this.SignInButt.UseVisualStyleBackColor = false;
            this.SignInButt.Click += new System.EventHandler(this.SignInButt_Click);
            this.SignInButt.MouseEnter += new System.EventHandler(this.Butt_MouseEnter);
            this.SignInButt.MouseLeave += new System.EventHandler(this.Butt_MouseLeave);
            // 
            // CancelButt
            // 
            this.CancelButt.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButt.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButt.Location = new System.Drawing.Point(165, 173);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(75, 23);
            this.CancelButt.TabIndex = 8;
            this.CancelButt.Text = "Cancel";
            this.CancelButt.UseVisualStyleBackColor = false;
            this.CancelButt.Click += new System.EventHandler(this.CancelButt_Click);
            this.CancelButt.MouseEnter += new System.EventHandler(this.Butt_MouseEnter);
            this.CancelButt.MouseLeave += new System.EventHandler(this.Butt_MouseLeave);
            // 
            // IPTextBox
            // 
            this.IPTextBox.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPTextBox.Location = new System.Drawing.Point(77, 146);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(163, 23);
            this.IPTextBox.TabIndex = 9;
            this.IPTextBox.Text = "localhost";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IPLabel.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPLabel.Location = new System.Drawing.Point(12, 149);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(20, 15);
            this.IPLabel.TabIndex = 10;
            this.IPLabel.Text = "IP:";
            this.IPLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDown);
            this.IPLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Component_MouseMove);
            this.IPLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component_MouseUp);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(292, 206);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.CancelButt);
            this.Controls.Add(this.SignInButt);
            this.Controls.Add(this.AdvancedButton);
            this.Controls.Add(this.PasswdTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswdLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PleaseLogInLabel);
            this.Controls.Add(this.HorizontalLineLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View";
            this.ShowIcon = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Component_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Component_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HorizontalLineLabel;
        private System.Windows.Forms.Label PleaseLogInLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswdLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswdTextBox;
        private System.Windows.Forms.Label AdvancedButton;
        private System.Windows.Forms.Button SignInButt;
        private System.Windows.Forms.Button CancelButt;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label IPLabel;
    }
}