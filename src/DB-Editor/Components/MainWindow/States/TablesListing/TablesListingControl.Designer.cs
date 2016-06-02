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
            this.welcomeInfo = new System.Windows.Forms.Label();
            this.TableItemsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableItemsContainer
            // 
            this.TableItemsContainer.Controls.Add(this.welcomeInfo);
            this.TableItemsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableItemsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TableItemsContainer.Location = new System.Drawing.Point(0, 0);
            this.TableItemsContainer.Name = "TableItemsContainer";
            this.TableItemsContainer.Size = new System.Drawing.Size(476, 308);
            this.TableItemsContainer.TabIndex = 0;
            // 
            // welcomeInfo
            // 
            this.welcomeInfo.AutoSize = true;
            this.welcomeInfo.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeInfo.Location = new System.Drawing.Point(0, 0);
            this.welcomeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeInfo.Name = "welcomeInfo";
            this.welcomeInfo.Size = new System.Drawing.Size(351, 15);
            this.welcomeInfo.TabIndex = 0;
            this.welcomeInfo.Text = "Choose the database to connect from the left panel (double click)";
            // 
            // TablesListingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.TableItemsContainer);
            this.Name = "TablesListingControl";
            this.Size = new System.Drawing.Size(476, 308);
            this.TableItemsContainer.ResumeLayout(false);
            this.TableItemsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel TableItemsContainer;
        private System.Windows.Forms.Label welcomeInfo;

    }
}
