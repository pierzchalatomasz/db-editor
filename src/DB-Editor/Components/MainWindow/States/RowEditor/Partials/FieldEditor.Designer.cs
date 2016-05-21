namespace DB_Editor.Components.MainWindow.States.RowEditor.Partials
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
            this.label1 = new System.Windows.Forms.Label();
            this.fieldName = new System.Windows.Forms.TextBox();
            this.fieldType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Field name";
            // 
            // fieldName
            // 
            this.fieldName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fieldName.Location = new System.Drawing.Point(0, 18);
            this.fieldName.Name = "fieldName";
            this.fieldName.ReadOnly = true;
            this.fieldName.Size = new System.Drawing.Size(100, 22);
            this.fieldName.TabIndex = 1;
            // 
            // fieldType
            // 
            this.fieldType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fieldType.Location = new System.Drawing.Point(109, 18);
            this.fieldType.Name = "fieldType";
            this.fieldType.ReadOnly = true;
            this.fieldType.Size = new System.Drawing.Size(100, 22);
            this.fieldType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field type";
            // 
            // fieldValue
            // 
            this.fieldValue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fieldValue.Location = new System.Drawing.Point(218, 18);
            this.fieldValue.Name = "fieldValue";
            this.fieldValue.Size = new System.Drawing.Size(243, 22);
            this.fieldValue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Field value";
            // 
            // FieldEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.Name = "FieldEditor";
            this.Size = new System.Drawing.Size(476, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fieldName;
        private System.Windows.Forms.TextBox fieldType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldValue;
        private System.Windows.Forms.Label label3;
    }
}
