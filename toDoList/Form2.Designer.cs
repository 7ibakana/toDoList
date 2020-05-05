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
            this.lblUrgencyLevel = new System.Windows.Forms.Label();
            this.cmbUrgencyLevel = new System.Windows.Forms.ComboBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrgencyLevel
            // 
            this.lblUrgencyLevel.AutoSize = true;
            this.lblUrgencyLevel.Location = new System.Drawing.Point(12, 42);
            this.lblUrgencyLevel.Name = "lblUrgencyLevel";
            this.lblUrgencyLevel.Size = new System.Drawing.Size(480, 13);
            this.lblUrgencyLevel.TabIndex = 11;
            this.lblUrgencyLevel.Text = "On a scale of 1 to 5, with 1 being the highest and 5 the lowest, how high is the " +
    "urgency for this task?";
            // 
            // cmbUrgencyLevel
            // 
            this.cmbUrgencyLevel.FormattingEnabled = true;
            this.cmbUrgencyLevel.Location = new System.Drawing.Point(200, 67);
            this.cmbUrgencyLevel.Name = "cmbUrgencyLevel";
            this.cmbUrgencyLevel.Size = new System.Drawing.Size(121, 21);
            this.cmbUrgencyLevel.TabIndex = 12;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(225, 94);
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
            this.ClientSize = new System.Drawing.Size(489, 134);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.cmbUrgencyLevel);
            this.Controls.Add(this.lblUrgencyLevel);
            this.Name = "Form2";
            this.Text = "Due Date?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrgencyLevel;
        private System.Windows.Forms.ComboBox cmbUrgencyLevel;
        private System.Windows.Forms.Button btnInfo;
    }
}