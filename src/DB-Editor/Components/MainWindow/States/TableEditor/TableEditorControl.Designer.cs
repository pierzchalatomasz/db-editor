namespace DB_Editor.Components.MainWindow.States.TableEditor
{
    partial class TableEditorControl
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
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddNewField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(476, 265);
            this.container.TabIndex = 0;
            // 
            // buttonAddNewField
            // 
            this.buttonAddNewField.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAddNewField.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewField.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewField.Location = new System.Drawing.Point(0, 268);
            this.buttonAddNewField.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddNewField.Name = "buttonAddNewField";
            this.buttonAddNewField.Size = new System.Drawing.Size(476, 40);
            this.buttonAddNewField.TabIndex = 1;
            this.buttonAddNewField.Text = "Add new field";
            this.buttonAddNewField.UseVisualStyleBackColor = false;
            this.buttonAddNewField.Click += new System.EventHandler(this.buttonAddNewField_Click);
            // 
            // TableEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddNewField);
            this.Controls.Add(this.container);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TableEditorControl";
            this.Size = new System.Drawing.Size(476, 308);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel container;
        private System.Windows.Forms.Button buttonAddNewField;
    }
}
