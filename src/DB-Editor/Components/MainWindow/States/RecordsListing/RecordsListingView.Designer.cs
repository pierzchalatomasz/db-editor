namespace DB_Editor.Components.MainWindow.States.RecordsListing
{
    partial class RecordsListingView
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
            this.wrapper = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonsWrapper = new System.Windows.Forms.Panel();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.wrapper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.buttonsWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapper
            // 
            this.wrapper.AutoSize = true;
            this.wrapper.Controls.Add(this.container);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.wrapper.Size = new System.Drawing.Size(479, 268);
            this.wrapper.TabIndex = 6;
            // 
            // container
            // 
            this.container.AutoScroll = true;
            this.container.AutoSize = true;
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(479, 253);
            this.container.TabIndex = 0;
            this.container.WrapContents = false;
            this.container.Scroll += new System.Windows.Forms.ScrollEventHandler(this.container_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonsWrapper);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 40);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 40);
            this.panel2.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(123, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 40);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(42, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 40);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonsWrapper
            // 
            this.buttonsWrapper.Controls.Add(this.labelPage);
            this.buttonsWrapper.Controls.Add(this.buttonNextPage);
            this.buttonsWrapper.Controls.Add(this.buttonPrevPage);
            this.buttonsWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsWrapper.Location = new System.Drawing.Point(0, 0);
            this.buttonsWrapper.Name = "buttonsWrapper";
            this.buttonsWrapper.Size = new System.Drawing.Size(275, 40);
            this.buttonsWrapper.TabIndex = 6;
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPage.Location = new System.Drawing.Point(3, 13);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(31, 14);
            this.labelPage.TabIndex = 1;
            this.labelPage.Text = "Page";
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonNextPage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNextPage.ForeColor = System.Drawing.Color.White;
            this.buttonNextPage.Location = new System.Drawing.Point(200, 0);
            this.buttonNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(75, 40);
            this.buttonNextPage.TabIndex = 2;
            this.buttonNextPage.Text = "Next Page";
            this.buttonNextPage.UseVisualStyleBackColor = false;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrevPage.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrevPage.ForeColor = System.Drawing.Color.White;
            this.buttonPrevPage.Location = new System.Drawing.Point(112, 0);
            this.buttonPrevPage.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(75, 40);
            this.buttonPrevPage.TabIndex = 3;
            this.buttonPrevPage.Text = "Prev Page";
            this.buttonPrevPage.UseVisualStyleBackColor = false;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // RecordsListingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.wrapper);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RecordsListingView";
            this.Size = new System.Drawing.Size(479, 308);
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.buttonsWrapper.ResumeLayout(false);
            this.buttonsWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel container;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPrevPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel buttonsWrapper;
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}
