namespace DB_Editor.Components.MainWindow.Partials
{
    partial class DatabasesListView
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.addNewDatabaseContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newDatabaseLabel = new System.Windows.Forms.Label();
            this.addNewDatabase = new System.Windows.Forms.Button();
            this.newDatabaseName = new System.Windows.Forms.TextBox();
            this.databasesList = new System.Windows.Forms.ListBox();
            this.LeftPanelTitle = new System.Windows.Forms.Label();
            this.addNewDatabaseContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(147, 13);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 40);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // addNewDatabaseContainer
            // 
            this.addNewDatabaseContainer.Controls.Add(this.label1);
            this.addNewDatabaseContainer.Controls.Add(this.newDatabaseLabel);
            this.addNewDatabaseContainer.Controls.Add(this.addNewDatabase);
            this.addNewDatabaseContainer.Controls.Add(this.newDatabaseName);
            this.addNewDatabaseContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addNewDatabaseContainer.Location = new System.Drawing.Point(0, 335);
            this.addNewDatabaseContainer.Name = "addNewDatabaseContainer";
            this.addNewDatabaseContainer.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.addNewDatabaseContainer.Size = new System.Drawing.Size(245, 107);
            this.addNewDatabaseContainer.TabIndex = 6;
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
            this.addNewDatabase.Click += new System.EventHandler(this.addNewDatabase_Click);
            // 
            // newDatabaseName
            // 
            this.newDatabaseName.Location = new System.Drawing.Point(17, 48);
            this.newDatabaseName.Name = "newDatabaseName";
            this.newDatabaseName.Size = new System.Drawing.Size(117, 20);
            this.newDatabaseName.TabIndex = 0;
            // 
            // databasesList
            // 
            this.databasesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.databasesList.BackColor = System.Drawing.Color.White;
            this.databasesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.databasesList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.databasesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.databasesList.FormattingEnabled = true;
            this.databasesList.ItemHeight = 19;
            this.databasesList.Location = new System.Drawing.Point(17, 71);
            this.databasesList.Name = "databasesList";
            this.databasesList.Size = new System.Drawing.Size(205, 247);
            this.databasesList.TabIndex = 5;
            this.databasesList.DoubleClick += new System.EventHandler(this.databasesList_DoubleClick);
            // 
            // LeftPanelTitle
            // 
            this.LeftPanelTitle.AutoSize = true;
            this.LeftPanelTitle.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LeftPanelTitle.Location = new System.Drawing.Point(12, 19);
            this.LeftPanelTitle.Name = "LeftPanelTitle";
            this.LeftPanelTitle.Size = new System.Drawing.Size(111, 29);
            this.LeftPanelTitle.TabIndex = 4;
            this.LeftPanelTitle.Text = "Databases";
            // 
            // DatabasesListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.addNewDatabaseContainer);
            this.Controls.Add(this.databasesList);
            this.Controls.Add(this.LeftPanelTitle);
            this.Name = "DatabasesListView";
            this.Size = new System.Drawing.Size(245, 442);
            this.addNewDatabaseContainer.ResumeLayout(false);
            this.addNewDatabaseContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel addNewDatabaseContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newDatabaseLabel;
        private System.Windows.Forms.Button addNewDatabase;
        private System.Windows.Forms.TextBox newDatabaseName;
        private System.Windows.Forms.ListBox databasesList;
        private System.Windows.Forms.Label LeftPanelTitle;
    }
}
