﻿namespace DB_Editor.Components.MainWindow.States.TableEditor
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
            this.buttonAddNewField = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.wrapper = new System.Windows.Forms.Panel();
            this.wrapper.SuspendLayout();
            this.SuspendLayout();
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
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(476, 268);
            this.container.TabIndex = 0;
            // 
            // wrapper
            // 
            this.wrapper.Controls.Add(this.container);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(476, 268);
            this.wrapper.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel container;
        private System.Windows.Forms.Button buttonAddNewField;
        private System.Windows.Forms.Panel wrapper;
    }
}
