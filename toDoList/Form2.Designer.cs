namespace toDoList
{
    partial class Form2
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
            this.lblDueDate = new System.Windows.Forms.Label();
            this.cmbDueDates = new System.Windows.Forms.ComboBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(12, 42);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(278, 13);
            this.lblDueDate.TabIndex = 11;
            this.lblDueDate.Text = "On a scale of 1 to 5 how high is the urgency for this task?";
            // 
            // cmbDueDates
            // 
            this.cmbDueDates.FormattingEnabled = true;
            this.cmbDueDates.Location = new System.Drawing.Point(72, 58);
            this.cmbDueDates.Name = "cmbDueDates";
            this.cmbDueDates.Size = new System.Drawing.Size(121, 21);
            this.cmbDueDates.TabIndex = 12;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(89, 82);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.Text = "E&nter";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 121);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.cmbDueDates);
            this.Controls.Add(this.lblDueDate);
            this.Name = "Form2";
            this.Text = "Due Date?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.ComboBox cmbDueDates;
        private System.Windows.Forms.Button btnInfo;
    }
}