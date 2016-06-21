﻿namespace DB_Editor.Components.MainWindow
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.databasesList = new System.Windows.Forms.ListBox();
            this.LeftPanelTitle = new System.Windows.Forms.Label();
            this.buttonsContainer = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.RightPanelTitle = new System.Windows.Forms.Label();
            this.rightPanelWrapper = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addNewDatabaseContainer = new System.Windows.Forms.Panel();
            this.newDatabaseName = new System.Windows.Forms.TextBox();
            this.addNewDatabase = new System.Windows.Forms.Button();
            this.newDatabaseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.buttonsContainer.SuspendLayout();
            this.rightPanelWrapper.SuspendLayout();
            this.addNewDatabaseContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.addNewDatabaseContainer);
            this.splitContainer.Panel1.Controls.Add(this.databasesList);
            this.splitContainer.Panel1.Controls.Add(this.LeftPanelTitle);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(15);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.splitContainer.Panel2.Controls.Add(this.buttonsContainer);
            this.splitContainer.Panel2.Controls.Add(this.RightPanelTitle);
            this.splitContainer.Panel2.Controls.Add(this.rightPanelWrapper);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.splitContainer.Size = new System.Drawing.Size(808, 483);
            this.splitContainer.SplitterDistance = 269;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // databasesList
            // 
            this.databasesList.BackColor = System.Drawing.Color.White;
            this.databasesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.databasesList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.databasesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.databasesList.FormattingEnabled = true;
            this.databasesList.ItemHeight = 19;
            this.databasesList.Location = new System.Drawing.Point(32, 76);
            this.databasesList.Name = "databasesList";
            this.databasesList.Size = new System.Drawing.Size(205, 380);
            this.databasesList.TabIndex = 1;
            this.databasesList.DoubleClick += new System.EventHandler(this.databasesList_DoubleClick);
            // 
            // LeftPanelTitle
            // 
            this.LeftPanelTitle.AutoSize = true;
            this.LeftPanelTitle.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftPanelTitle.Location = new System.Drawing.Point(27, 24);
            this.LeftPanelTitle.Name = "LeftPanelTitle";
            this.LeftPanelTitle.Size = new System.Drawing.Size(111, 29);
            this.LeftPanelTitle.TabIndex = 0;
            this.LeftPanelTitle.Text = "Databases";
            // 
            // buttonsContainer
            // 
            this.buttonsContainer.Controls.Add(this.buttonBack);
            this.buttonsContainer.Controls.Add(this.buttonNext);
            this.buttonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsContainer.Location = new System.Drawing.Point(15, 394);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Padding = new System.Windows.Forms.Padding(15);
            this.buttonsContainer.Size = new System.Drawing.Size(508, 74);
            this.buttonsContainer.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gray;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(15, 15);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonBack.Size = new System.Drawing.Size(137, 44);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNext.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(353, 15);
            this.buttonNext.MaximumSize = new System.Drawing.Size(140, 41);
            this.buttonNext.MinimumSize = new System.Drawing.Size(140, 41);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonNext.Size = new System.Drawing.Size(140, 41);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Add new table";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // RightPanelTitle
            // 
            this.RightPanelTitle.AutoSize = true;
            this.RightPanelTitle.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RightPanelTitle.Location = new System.Drawing.Point(27, 24);
            this.RightPanelTitle.Name = "RightPanelTitle";
            this.RightPanelTitle.Size = new System.Drawing.Size(72, 29);
            this.RightPanelTitle.TabIndex = 1;
            this.RightPanelTitle.Text = "Tables";
            // 
            // rightPanelWrapper
            // 
            this.rightPanelWrapper.Controls.Add(this.rightPanel);
            this.rightPanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelWrapper.Location = new System.Drawing.Point(15, 15);
            this.rightPanelWrapper.Name = "rightPanelWrapper";
            this.rightPanelWrapper.Padding = new System.Windows.Forms.Padding(15, 60, 15, 75);
            this.rightPanelWrapper.Size = new System.Drawing.Size(508, 453);
            this.rightPanelWrapper.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.AutoSize = true;
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(15, 60);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(478, 318);
            this.rightPanel.TabIndex = 4;
            // 
            // addNewDatabaseContainer
            // 
            this.addNewDatabaseContainer.Controls.Add(this.label1);
            this.addNewDatabaseContainer.Controls.Add(this.newDatabaseLabel);
            this.addNewDatabaseContainer.Controls.Add(this.addNewDatabase);
            this.addNewDatabaseContainer.Controls.Add(this.newDatabaseName);
            this.addNewDatabaseContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addNewDatabaseContainer.Location = new System.Drawing.Point(15, 361);
            this.addNewDatabaseContainer.Name = "addNewDatabaseContainer";
            this.addNewDatabaseContainer.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.addNewDatabaseContainer.Size = new System.Drawing.Size(239, 107);
            this.addNewDatabaseContainer.TabIndex = 2;
            // 
            // newDatabaseName
            // 
            this.newDatabaseName.Location = new System.Drawing.Point(17, 48);
            this.newDatabaseName.Name = "newDatabaseName";
            this.newDatabaseName.Size = new System.Drawing.Size(117, 20);
            this.newDatabaseName.TabIndex = 0;
            // 
            // addNewDatabase
            // 
            this.addNewDatabase.BackColor = System.Drawing.Color.RoyalBlue;
            this.addNewDatabase.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewDatabase.ForeColor = System.Drawing.Color.White;
            this.addNewDatabase.Location = new System.Drawing.Point(154, 32);
            this.addNewDatabase.MaximumSize = new System.Drawing.Size(140, 41);
            this.addNewDatabase.MinimumSize = new System.Drawing.Size(10, 41);
            this.addNewDatabase.Name = "addNewDatabase";
            this.addNewDatabase.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.addNewDatabase.Size = new System.Drawing.Size(69, 41);
            this.addNewDatabase.TabIndex = 4;
            this.addNewDatabase.Text = "Add";
            this.addNewDatabase.UseVisualStyleBackColor = false;
            // 
            // newDatabaseLabel
            // 
            this.newDatabaseLabel.AutoSize = true;
            this.newDatabaseLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newDatabaseLabel.Location = new System.Drawing.Point(14, 32);
            this.newDatabaseLabel.Name = "newDatabaseLabel";
            this.newDatabaseLabel.Size = new System.Drawing.Size(120, 14);
            this.newDatabaseLabel.TabIndex = 5;
            this.newDatabaseLabel.Text = "New database name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add new database";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 483);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "View";
            this.Text = "DB Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.buttonsContainer.ResumeLayout(false);
            this.rightPanelWrapper.ResumeLayout(false);
            this.rightPanelWrapper.PerformLayout();
            this.addNewDatabaseContainer.ResumeLayout(false);
            this.addNewDatabaseContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label LeftPanelTitle;
        private System.Windows.Forms.Label RightPanelTitle;
        private System.Windows.Forms.ListBox databasesList;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.FlowLayoutPanel rightPanel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel buttonsContainer;
        private System.Windows.Forms.Panel rightPanelWrapper;
        private System.Windows.Forms.Panel addNewDatabaseContainer;
        private System.Windows.Forms.Label newDatabaseLabel;
        private System.Windows.Forms.Button addNewDatabase;
        private System.Windows.Forms.TextBox newDatabaseName;
        private System.Windows.Forms.Label label1;
    }
}