namespace Library
{
    partial class ViewBooksForm
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
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 16;
            this.listBoxBooks.Location = new System.Drawing.Point(12, 12);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(776, 424);
            this.listBoxBooks.TabIndex = 0;
            // 
            // ViewBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxBooks);
            this.Name = "ViewBooksForm";
            this.Text = "View Books";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxBooks;
    }
}
