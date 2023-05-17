namespace QUANLIKARAOKE.VIEW
{
    partial class FormNhapHang
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.Label();
            this.dgvnhap = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.MaskedTextBox();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.cbncc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Nhân viên nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "QUẢN LÍ NHẬP HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 79;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(628, 137);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 77;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(713, 137);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 76;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtuser
            // 
            this.txtuser.AutoSize = true;
            this.txtuser.Location = new System.Drawing.Point(13, 59);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(61, 13);
            this.txtuser.TabIndex = 73;
            this.txtuser.Text = "Ngày Nhập";
            // 
            // dgvnhap
            // 
            this.dgvnhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhap.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvnhap.Location = new System.Drawing.Point(1, 166);
            this.dgvnhap.Name = "dgvnhap";
            this.dgvnhap.Size = new System.Drawing.Size(798, 272);
            this.dgvnhap.TabIndex = 72;
            this.dgvnhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhap_CellDoubleClick);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(120, 53);
            this.date.Mask = "00/00/0000";
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(108, 20);
            this.date.TabIndex = 88;
            this.date.ValidatingType = typeof(System.DateTime);
            // 
            // cbnv
            // 
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(351, 56);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(137, 21);
            this.cbnv.TabIndex = 89;
            // 
            // cbncc
            // 
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(599, 53);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(189, 21);
            this.cbncc.TabIndex = 90;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbncc);
            this.Controls.Add(this.cbnv);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.dgvnhap);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtuser;
        private System.Windows.Forms.DataGridView dgvnhap;
        private System.Windows.Forms.MaskedTextBox date;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.ComboBox cbncc;
    }
}