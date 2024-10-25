namespace Library
{
    partial class AddBookForm
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 15);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 16);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(36, 16);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 73);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(48, 16);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(70, 12);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(70, 41);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(70, 70);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 22);
            this.textBoxAuthor.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(70, 98);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add Book";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelId);
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Button buttonAdd;
    }
}
