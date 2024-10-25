namespace Library
{
    partial class Form1
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
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonViewBooks = new System.Windows.Forms.Button();
            this.buttonLoanBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(12, 12);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(100, 23);
            this.buttonAddBook.TabIndex = 0;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(12, 41);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(100, 23);
            this.buttonAddMember.TabIndex = 1;
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // buttonViewBooks
            // 
            this.buttonViewBooks.Location = new System.Drawing.Point(12, 70);
            this.buttonViewBooks.Name = "buttonViewBooks";
            this.buttonViewBooks.Size = new System.Drawing.Size(100, 23);
            this.buttonViewBooks.TabIndex = 2;
            this.buttonViewBooks.Text = "View Books";
            this.buttonViewBooks.UseVisualStyleBackColor = true;
            this.buttonViewBooks.Click += new System.EventHandler(this.buttonViewBooks_Click);
            // 
            // buttonLoanBook
            // 
            this.buttonLoanBook.Location = new System.Drawing.Point(12, 99);
            this.buttonLoanBook.Name = "buttonLoanBook";
            this.buttonLoanBook.Size = new System.Drawing.Size(100, 23);
            this.buttonLoanBook.TabIndex = 3;
            this.buttonLoanBook.Text = "Loan Book";
            this.buttonLoanBook.UseVisualStyleBackColor = true;
            this.buttonLoanBook.Click += new System.EventHandler(this.buttonLoanBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoanBook);
            this.Controls.Add(this.buttonViewBooks);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.buttonAddBook);
            this.Name = "Form1";
            this.Text = "Library Management System";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Button buttonViewBooks;
        private System.Windows.Forms.Button buttonLoanBook;
    }
}
