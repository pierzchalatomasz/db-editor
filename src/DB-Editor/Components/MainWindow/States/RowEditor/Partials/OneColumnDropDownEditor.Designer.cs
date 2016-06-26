namespace DB_Editor.Components.MainWindow.States.RowEditor.Partials
{
    partial class OneColumnDropDownEditor
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
            this.ColumnNameTextBox = new System.Windows.Forms.TextBox();
            this.ValueDropDownList = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnNameTextBox
            // 
            this.ColumnNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.ColumnNameTextBox.Multiline = true;
            this.ColumnNameTextBox.Name = "ColumnNameTextBox";
            this.ColumnNameTextBox.ReadOnly = true;
            this.ColumnNameTextBox.Size = new System.Drawing.Size(121, 38);
            this.ColumnNameTextBox.TabIndex = 2;
            // 
            // ValueDropDownList
            // 
            this.ValueDropDownList.FormattingEnabled = true;
            this.ValueDropDownList.Location = new System.Drawing.Point(0, 44);
            this.ValueDropDownList.Name = "ValueDropDownList";
            this.ValueDropDownList.Size = new System.Drawing.Size(121, 21);
            this.ValueDropDownList.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OneColumnDropDownEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueDropDownList);
            this.Controls.Add(this.ColumnNameTextBox);
            this.Name = "OneColumnDropDownEditor";
            this.Size = new System.Drawing.Size(121, 64);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColumnNameTextBox;
        private System.Windows.Forms.ComboBox ValueDropDownList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
