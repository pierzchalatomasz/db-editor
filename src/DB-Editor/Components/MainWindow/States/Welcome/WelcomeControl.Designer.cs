namespace DB_Editor.Components.MainWindow.States.Welcome
{
    partial class WelcomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeInfo
            // 
            this.welcomeInfo.AutoSize = true;
            this.welcomeInfo.BackColor = System.Drawing.Color.Transparent;
            this.welcomeInfo.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeInfo.Location = new System.Drawing.Point(0, 0);
            this.welcomeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeInfo.Name = "welcomeInfo";
            this.welcomeInfo.Size = new System.Drawing.Size(351, 15);
            this.welcomeInfo.TabIndex = 1;
            this.welcomeInfo.Text = "Choose the database to connect from the left panel (double click)";
            // 
            // WelcomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.welcomeInfo);
            this.Name = "WelcomeControl";
            this.Size = new System.Drawing.Size(351, 15);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeInfo;
    }
}
