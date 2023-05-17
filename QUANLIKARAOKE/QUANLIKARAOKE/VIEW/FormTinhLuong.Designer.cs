namespace QUANLIKARAOKE.VIEW
{
    partial class FormTinhLuong
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
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.Label();
            this.dgvtl = new System.Windows.Forms.DataGridView();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.txtsnn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtl)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(120, 53);
            this.date.Mask = "00/00/0000 90:00";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(108, 20);
            this.date.TabIndex = 100;
            this.date.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Lương cơ bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "số ngày nghỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "QUẢN LÍ LƯƠNG NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 96;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(650, 137);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 95;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 93;
            this.button1.Text = "Trả Lương";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtuser
            // 
            this.txtuser.AutoSize = true;
            this.txtuser.Location = new System.Drawing.Point(22, 56);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(72, 13);
            this.txtuser.TabIndex = 92;
            this.txtuser.Text = "Ngày bắt đầu";
            // 
            // dgvtl
            // 
            this.dgvtl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtl.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvtl.Location = new System.Drawing.Point(1, 166);
            this.dgvtl.Name = "dgvtl";
            this.dgvtl.Size = new System.Drawing.Size(814, 378);
            this.dgvtl.TabIndex = 91;
            // 
            // txtlcb
            // 
            this.txtlcb.Location = new System.Drawing.Point(609, 53);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(144, 20);
            this.txtlcb.TabIndex = 102;
            // 
            // txtsnn
            // 
            this.txtsnn.Location = new System.Drawing.Point(339, 53);
            this.txtsnn.Name = "txtsnn";
            this.txtsnn.Size = new System.Drawing.Size(100, 20);
            this.txtsnn.TabIndex = 103;
            // 
            // FormTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 545);
            this.Controls.Add(this.txtsnn);
            this.Controls.Add(this.txtlcb);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.dgvtl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTinhLuong";
            this.Text = "FormTinhLuong";
            this.Load += new System.EventHandler(this.FormTinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtuser;
        private System.Windows.Forms.DataGridView dgvtl;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.TextBox txtsnn;
    }
}