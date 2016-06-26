namespace DB_Editor.Components.MainWindow.States.RowEditor.Partials
{
    partial class HorizontalLineControl
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
            this.HorLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HorLine
            // 
            this.HorLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorLine.Location = new System.Drawing.Point(0, 0);
            this.HorLine.Name = "HorLine";
            this.HorLine.Size = new System.Drawing.Size(2, 64);
            this.HorLine.TabIndex = 0;
            // 
            // HorizontalLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HorLine);
            this.Name = "HorizontalLineControl";
            this.Size = new System.Drawing.Size(2, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HorLine;
    }
}
