﻿namespace DB_Editor.Components.MainWindow.States.TableEditor.Partials
{
    partial class FieldEditor
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
            this.fieldNameTxtBox = new System.Windows.Forms.TextBox();
            this.fieldNameLabel = new System.Windows.Forms.Label();
            this.fieldTypeLabel = new System.Windows.Forms.Label();
            this.fieldTypeDrpDwnLst = new System.Windows.Forms.ComboBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthTxtBox = new System.Windows.Forms.TextBox();
            this.NullDrpDwnLst = new System.Windows.Forms.ComboBox();
            this.NullLabel = new System.Windows.Forms.Label();
            this.PrimaryKeyChckBox = new System.Windows.Forms.CheckBox();
            this.ForeignKeyChckBox = new System.Windows.Forms.CheckBox();
            this.AutoIncrementChckBox = new System.Windows.Forms.CheckBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.defaultTextBox = new System.Windows.Forms.TextBox();
            this.defaultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fieldNameTxtBox
            // 
            this.fieldNameTxtBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fieldNameTxtBox.Location = new System.Drawing.Point(13, 28);
            this.fieldNameTxtBox.Name = "fieldNameTxtBox";
            this.fieldNameTxtBox.Size = new System.Drawing.Size(108, 22);
            this.fieldNameTxtBox.TabIndex = 0;
            // 
            // fieldNameLabel
            // 
            this.fieldNameLabel.AutoSize = true;
            this.fieldNameLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fieldNameLabel.Location = new System.Drawing.Point(36, 9);
            this.fieldNameLabel.Name = "fieldNameLabel";
            this.fieldNameLabel.Size = new System.Drawing.Size(64, 15);
            this.fieldNameLabel.TabIndex = 1;
            this.fieldNameLabel.Text = "Field name";
            // 
            // fieldTypeLabel
            // 
            this.fieldTypeLabel.AutoSize = true;
            this.fieldTypeLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fieldTypeLabel.Location = new System.Drawing.Point(134, 10);
            this.fieldTypeLabel.Name = "fieldTypeLabel";
            this.fieldTypeLabel.Size = new System.Drawing.Size(58, 15);
            this.fieldTypeLabel.TabIndex = 3;
            this.fieldTypeLabel.Text = "Field type";
            // 
            // fieldTypeDrpDwnLst
            // 
            this.fieldTypeDrpDwnLst.FormattingEnabled = true;
            this.fieldTypeDrpDwnLst.Location = new System.Drawing.Point(127, 29);
            this.fieldTypeDrpDwnLst.Name = "fieldTypeDrpDwnLst";
            this.fieldTypeDrpDwnLst.Size = new System.Drawing.Size(78, 21);
            this.fieldTypeDrpDwnLst.TabIndex = 4;
            this.fieldTypeDrpDwnLst.SelectedIndexChanged += new System.EventHandler(this.Field_Type_Changed);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LengthLabel.Location = new System.Drawing.Point(222, 9);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(42, 15);
            this.LengthLabel.TabIndex = 6;
            this.LengthLabel.Text = "Length";
            // 
            // LengthTxtBox
            // 
            this.LengthTxtBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LengthTxtBox.Location = new System.Drawing.Point(211, 27);
            this.LengthTxtBox.Name = "LengthTxtBox";
            this.LengthTxtBox.ReadOnly = true;
            this.LengthTxtBox.Size = new System.Drawing.Size(71, 22);
            this.LengthTxtBox.TabIndex = 5;
            this.LengthTxtBox.Click += new System.EventHandler(this.LengthTxtBox_Click);
            this.LengthTxtBox.Leave += new System.EventHandler(this.LengthTxtBox_Leave);
            this.LengthTxtBox.MouseHover += new System.EventHandler(this.LengthTxtBox_MouseHover);
            // 
            // NullDrpDwnLst
            // 
            this.NullDrpDwnLst.FormattingEnabled = true;
            this.NullDrpDwnLst.Location = new System.Drawing.Point(288, 27);
            this.NullDrpDwnLst.Name = "NullDrpDwnLst";
            this.NullDrpDwnLst.Size = new System.Drawing.Size(55, 21);
            this.NullDrpDwnLst.TabIndex = 8;
            // 
            // NullLabel
            // 
            this.NullLabel.AutoSize = true;
            this.NullLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NullLabel.Location = new System.Drawing.Point(298, 8);
            this.NullLabel.Name = "NullLabel";
            this.NullLabel.Size = new System.Drawing.Size(28, 15);
            this.NullLabel.TabIndex = 7;
            this.NullLabel.Text = "Null";
            // 
            // PrimaryKeyChckBox
            // 
            this.PrimaryKeyChckBox.AutoSize = true;
            this.PrimaryKeyChckBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrimaryKeyChckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PrimaryKeyChckBox.Location = new System.Drawing.Point(13, 56);
            this.PrimaryKeyChckBox.Name = "PrimaryKeyChckBox";
            this.PrimaryKeyChckBox.Size = new System.Drawing.Size(87, 19);
            this.PrimaryKeyChckBox.TabIndex = 9;
            this.PrimaryKeyChckBox.Text = "Primary key";
            this.PrimaryKeyChckBox.UseVisualStyleBackColor = true;
            this.PrimaryKeyChckBox.CheckedChanged += new System.EventHandler(this.Primary_Key_CheckChanged);
            // 
            // ForeignKeyChckBox
            // 
            this.ForeignKeyChckBox.AutoSize = true;
            this.ForeignKeyChckBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeignKeyChckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ForeignKeyChckBox.Location = new System.Drawing.Point(106, 56);
            this.ForeignKeyChckBox.Name = "ForeignKeyChckBox";
            this.ForeignKeyChckBox.Size = new System.Drawing.Size(86, 19);
            this.ForeignKeyChckBox.TabIndex = 10;
            this.ForeignKeyChckBox.Text = "Foreign key";
            this.ForeignKeyChckBox.UseVisualStyleBackColor = true;
            this.ForeignKeyChckBox.CheckedChanged += new System.EventHandler(this.Foreign_Key_CheckChanged);
            // 
            // AutoIncrementChckBox
            // 
            this.AutoIncrementChckBox.AutoSize = true;
            this.AutoIncrementChckBox.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AutoIncrementChckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AutoIncrementChckBox.Location = new System.Drawing.Point(198, 56);
            this.AutoIncrementChckBox.Name = "AutoIncrementChckBox";
            this.AutoIncrementChckBox.Size = new System.Drawing.Size(107, 19);
            this.AutoIncrementChckBox.TabIndex = 11;
            this.AutoIncrementChckBox.Text = "Auto increment";
            this.AutoIncrementChckBox.UseVisualStyleBackColor = true;
            this.AutoIncrementChckBox.CheckedChanged += new System.EventHandler(this.Auto_Increment_CheckChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteButton.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(434, 18);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(62, 40);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // defaultTextBox
            // 
            this.defaultTextBox.Location = new System.Drawing.Point(349, 27);
            this.defaultTextBox.Name = "defaultTextBox";
            this.defaultTextBox.Size = new System.Drawing.Size(79, 20);
            this.defaultTextBox.TabIndex = 13;
            // 
            // defaultLabel
            // 
            this.defaultLabel.AutoSize = true;
            this.defaultLabel.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defaultLabel.Location = new System.Drawing.Point(362, 8);
            this.defaultLabel.Name = "defaultLabel";
            this.defaultLabel.Size = new System.Drawing.Size(45, 15);
            this.defaultLabel.TabIndex = 14;
            this.defaultLabel.Text = "Default";
            // 
            // FieldEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.defaultLabel);
            this.Controls.Add(this.defaultTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AutoIncrementChckBox);
            this.Controls.Add(this.ForeignKeyChckBox);
            this.Controls.Add(this.PrimaryKeyChckBox);
            this.Controls.Add(this.NullDrpDwnLst);
            this.Controls.Add(this.NullLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.LengthTxtBox);
            this.Controls.Add(this.fieldTypeDrpDwnLst);
            this.Controls.Add(this.fieldTypeLabel);
            this.Controls.Add(this.fieldNameLabel);
            this.Controls.Add(this.fieldNameTxtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.Name = "FieldEditor";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(512, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fieldNameTxtBox;
        private System.Windows.Forms.Label fieldNameLabel;
        private System.Windows.Forms.Label fieldTypeLabel;
        private System.Windows.Forms.ComboBox fieldTypeDrpDwnLst;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox LengthTxtBox;
        private System.Windows.Forms.ComboBox NullDrpDwnLst;
        private System.Windows.Forms.Label NullLabel;
        private System.Windows.Forms.CheckBox PrimaryKeyChckBox;
        private System.Windows.Forms.CheckBox ForeignKeyChckBox;
        private System.Windows.Forms.CheckBox AutoIncrementChckBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox defaultTextBox;
        private System.Windows.Forms.Label defaultLabel;
    }
}
