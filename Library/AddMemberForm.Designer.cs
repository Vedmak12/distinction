namespace Library
{
    partial class AddMemberForm
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
            this.labelMemberId = new System.Windows.Forms.Label();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMemberId
            // 
            this.labelMemberId.AutoSize = true;
            this.labelMemberId.Location = new System.Drawing.Point(12, 15);
            this.labelMemberId.Name = "labelMemberId";
            this.labelMemberId.Size = new System.Drawing.Size(72, 16);
            this.labelMemberId.TabIndex = 0;
            this.labelMemberId.Text = "Member ID:";
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Location = new System.Drawing.Point(12, 44);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(96, 16);
            this.labelMemberName.TabIndex = 1;
            this.labelMemberName.Text = "Member Name:";
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(114, 12);
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(100, 22);
            this.textBoxMemberId.TabIndex = 2;
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(114, 41);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(100, 22);
            this.textBoxMemberName.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(114, 70);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Member";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.labelMemberName);
            this.Controls.Add(this.labelMemberId);
            this.Name = "AddMemberForm";
            this.Text = "Add Member";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.TextBox textBoxMemberId;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Button buttonAdd;
    }
}
