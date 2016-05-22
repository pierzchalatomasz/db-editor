namespace DB_Editor.Components.MainWindow.States.TablesListing
{
    partial class TablesListingControl
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
            this.TableItemsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // TableItemsContainer
            // 
            this.TableItemsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableItemsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TableItemsContainer.Location = new System.Drawing.Point(0, 0);
            this.TableItemsContainer.Name = "TableItemsContainer";
            this.TableItemsContainer.Size = new System.Drawing.Size(476, 308);
            this.TableItemsContainer.TabIndex = 0;
            // 
            // TablesListingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.TableItemsContainer);
            this.Name = "TablesListingControl";
            this.Size = new System.Drawing.Size(476, 308);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TableItemsContainer;

    }
}
