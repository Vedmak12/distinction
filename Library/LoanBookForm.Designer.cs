namespace Library
{
    partial class LoanBookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelBookId = new System.Windows.Forms.Label();
            this.labelMemberId = new System.Windows.Forms.Label();
            this.textBoxBookId = new System.Windows.Forms.TextBox();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.buttonLoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.Location = new System.Drawing.Point(12, 15);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(56, 16);
            this.labelBookId.TabIndex = 0;
            this.labelBookId.Text = "Book ID:";
            // 
            // labelMemberId
            // 
            this.labelMemberId.AutoSize = true;
            this.labelMemberId.Location = new System.Drawing.Point(12, 44);
            this.labelMemberId.Name = "labelMemberId";
            this.labelMemberId.Size = new System.Drawing.Size(72, 16);
            this.labelMemberId.TabIndex = 1;
            this.labelMemberId.Text = "Member ID:";
            // 
            // textBoxBookId
            // 
            this.textBoxBookId.Location = new System.Drawing.Point(84, 12);
            this.textBoxBookId.Name = "textBoxBookId";
            this.textBoxBookId.Size = new System.Drawing.Size(100, 22);
            this.textBoxBookId.TabIndex = 2;
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(84, 41);
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(100, 22);
            this.textBoxMemberId.TabIndex = 3;
            // 
            // buttonLoan
            // 
            this.buttonLoan.Location = new System.Drawing.Point(84, 70);
            this.buttonLoan.Name = "buttonLoan";
            this.buttonLoan.Size = new System.Drawing.Size(100, 23);
            this.buttonLoan.TabIndex = 4;
            this.buttonLoan.Text = "Loan Book";
            this.buttonLoan.UseVisualStyleBackColor = true;
            this.buttonLoan.Click += new System.EventHandler(this.buttonLoan_Click);
            // 
            // LoanBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.buttonLoan);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.textBoxBookId);
            this.Controls.Add(this.labelMemberId);
            this.Controls.Add(this.labelBookId);
            this.Name = "LoanBookForm";
            this.Text = "Loan Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.TextBox textBoxBookId;
        private System.Windows.Forms.TextBox textBoxMemberId;
        private System.Windows.Forms.Button buttonLoan;
    }
}
