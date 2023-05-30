namespace QUANLIKARAOKE.VIEW
{
    partial class FormDoiMatKhau
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
            this.txtpassnow = new System.Windows.Forms.TextBox();
            this.txtpassnew = new System.Windows.Forms.TextBox();
            this.txtpassagain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnxn = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpassnow
            // 
            this.txtpassnow.Location = new System.Drawing.Point(169, 43);
            this.txtpassnow.Name = "txtpassnow";
            this.txtpassnow.Size = new System.Drawing.Size(143, 20);
            this.txtpassnow.TabIndex = 0;
            // 
            // txtpassnew
            // 
            this.txtpassnew.Location = new System.Drawing.Point(169, 98);
            this.txtpassnew.Name = "txtpassnew";
            this.txtpassnew.Size = new System.Drawing.Size(143, 20);
            this.txtpassnew.TabIndex = 1;
            // 
            // txtpassagain
            // 
            this.txtpassagain.Location = new System.Drawing.Point(169, 154);
            this.txtpassagain.Name = "txtpassagain";
            this.txtpassagain.Size = new System.Drawing.Size(143, 20);
            this.txtpassagain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // btnxn
            // 
            this.btnxn.Location = new System.Drawing.Point(84, 203);
            this.btnxn.Name = "btnxn";
            this.btnxn.Size = new System.Drawing.Size(75, 23);
            this.btnxn.TabIndex = 6;
            this.btnxn.Text = "Xác nhận";
            this.btnxn.UseVisualStyleBackColor = true;
            this.btnxn.Click += new System.EventHandler(this.btnxn_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(223, 203);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 7;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 259);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassagain);
            this.Controls.Add(this.txtpassnew);
            this.Controls.Add(this.txtpassnow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoiMatKhau";
            this.Text = "FormDoiMatKhau";
            this.Load += new System.EventHandler(this.FormDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassnow;
        private System.Windows.Forms.TextBox txtpassnew;
        private System.Windows.Forms.TextBox txtpassagain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnxn;
        private System.Windows.Forms.Button btnhuy;
    }
}