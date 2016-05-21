namespace DB_Editor.Components.MainWindow
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LeftPanelTitle = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.RightPanelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
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
            this.splitContainer.Panel1.Controls.Add(this.listBox1);
            this.splitContainer.Panel1.Controls.Add(this.LeftPanelTitle);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(15);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.splitContainer.Panel2.Controls.Add(this.buttonBack);
            this.splitContainer.Panel2.Controls.Add(this.rightPanel);
            this.splitContainer.Panel2.Controls.Add(this.buttonNext);
            this.splitContainer.Panel2.Controls.Add(this.RightPanelTitle);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.splitContainer.Size = new System.Drawing.Size(808, 483);
            this.splitContainer.SplitterDistance = 269;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(32, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 380);
            this.listBox1.TabIndex = 1;
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
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Gray;
            this.buttonBack.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(32, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonBack.Size = new System.Drawing.Size(137, 41);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(32, 76);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(476, 308);
            this.rightPanel.TabIndex = 4;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNext.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(371, 415);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.buttonNext.Size = new System.Drawing.Size(137, 41);
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
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 483);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "View";
            this.Text = "DB Editor";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label LeftPanelTitle;
        private System.Windows.Forms.Label RightPanelTitle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.FlowLayoutPanel rightPanel;
        private System.Windows.Forms.Button buttonBack;
    }
}