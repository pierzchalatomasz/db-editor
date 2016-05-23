namespace DB_Editor.Components.MainWindow.States.RecordsListing.Partials
{
    partial class RecordField
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
            this.fieldValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fieldValue
            // 
            this.fieldValue.AutoEllipsis = true;
            this.fieldValue.AutoSize = true;
            this.fieldValue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fieldValue.Location = new System.Drawing.Point(-3, 0);
            this.fieldValue.Name = "fieldValue";
            this.fieldValue.Size = new System.Drawing.Size(68, 14);
            this.fieldValue.TabIndex = 0;
            this.fieldValue.Text = "Field value";
            // 
            // RecordField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldValue);
            this.Name = "RecordField";
            this.Size = new System.Drawing.Size(150, 14);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fieldValue;
    }
}
