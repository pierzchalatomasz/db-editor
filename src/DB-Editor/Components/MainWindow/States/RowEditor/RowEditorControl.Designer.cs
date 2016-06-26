namespace DB_Editor.Components.MainWindow.States.RowEditor
{
    partial class RowEditorControl
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
            this.RowEditorContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // RowEditorContainer
            // 
            this.RowEditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowEditorContainer.Location = new System.Drawing.Point(0, 0);
            this.RowEditorContainer.Name = "RowEditorContainer";
            this.RowEditorContainer.Size = new System.Drawing.Size(476, 308);
            this.RowEditorContainer.TabIndex = 0;
            // 
            // RowEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RowEditorContainer);
            this.Name = "RowEditorControl";
            this.Size = new System.Drawing.Size(476, 308);
            this.RowEditorContainer.ResumeLayout(false);
            this.ResumeLayout(false);


            /*this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(476, 308);
            this.container.TabIndex = 0;
            // 
            // RowEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.container);
            this.Name = "RowEditorControl";
            this.Size = new System.Drawing.Size(476, 308);
            this.ResumeLayout(false);*/

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RowEditorContainer;
    }
}
