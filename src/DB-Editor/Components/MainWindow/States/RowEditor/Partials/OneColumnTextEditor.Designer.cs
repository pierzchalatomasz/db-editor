namespace DB_Editor.Components.MainWindow.States.RowEditor.Partials
{
    partial class OneColumnTextEditor
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
            this.components = new System.ComponentModel.Container();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.FieldNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(0, 44);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(121, 20);
            this.ValueTextBox.TabIndex = 0;
            // 
            // FieldNameTextBox
            // 
            this.FieldNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.FieldNameTextBox.Multiline = true;
            this.FieldNameTextBox.Name = "FieldNameTextBox";
            this.FieldNameTextBox.ReadOnly = true;
            this.FieldNameTextBox.Size = new System.Drawing.Size(121, 38);
            this.FieldNameTextBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OneColumnTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FieldNameTextBox);
            this.Controls.Add(this.ValueTextBox);
            this.Name = "OneColumnTextEditor";
            this.Size = new System.Drawing.Size(124, 67);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.TextBox FieldNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
