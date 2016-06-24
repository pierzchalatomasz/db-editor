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
            this.components = new System.ComponentModel.Container();
            this.wrapper = new System.Windows.Forms.Panel();
            this.tblNameTextBox = new System.Windows.Forms.TextBox();
            this.tblNameLabel = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddNewField = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // wrapper
            // 
            this.wrapper.Controls.Add(this.tblNameTextBox);
            this.wrapper.Controls.Add(this.tblNameLabel);
            this.wrapper.Controls.Add(this.container);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(476, 268);
            this.wrapper.TabIndex = 2;
            // 
            // tblNameTextBox
            // 
            this.tblNameTextBox.Location = new System.Drawing.Point(80, 0);
            this.tblNameTextBox.Name = "tblNameTextBox";
            this.tblNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.tblNameTextBox.TabIndex = 2;
            this.tblNameTextBox.TextChanged += new System.EventHandler(this.tblNameTextBox_TextChanged);
            // 
            // tblNameLabel
            // 
            this.tblNameLabel.AutoSize = true;
            this.tblNameLabel.Location = new System.Drawing.Point(3, 3);
            this.tblNameLabel.Name = "tblNameLabel";
            this.tblNameLabel.Size = new System.Drawing.Size(71, 13);
            this.tblNameLabel.TabIndex = 1;
            this.tblNameLabel.Text = "Table Name: ";
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(0, 26);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(476, 242);
            this.container.TabIndex = 0;
            // 
            // buttonAddNewField
            // 
            this.buttonAddNewField.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAddNewField.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TableEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wrapper);
            this.Controls.Add(this.buttonAddNewField);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TableEditorControl";
            this.Size = new System.Drawing.Size(476, 308);
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel container;
        private System.Windows.Forms.Button buttonAddNewField;
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.TextBox tblNameTextBox;
        private System.Windows.Forms.Label tblNameLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
