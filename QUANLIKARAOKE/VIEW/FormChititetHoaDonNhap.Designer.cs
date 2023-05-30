namespace QUANLIKARAOKE.VIEW
{
    partial class FormChititetHoaDonNhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.dgchititet = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.cbmh = new System.Windows.Forms.ComboBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.ryeucau = new System.Windows.Forms.RadioButton();
            this.rnhapkho = new System.Windows.Forms.RadioButton();
            this.txttt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tongtien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgchititet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "QUẢN LÍ CHI TIẾT NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Đơn giá";
            // 
            // txtdg
            // 
            this.txtdg.Location = new System.Drawing.Point(358, 52);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(175, 20);
            this.txtdg.TabIndex = 60;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(713, 133);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 58;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(12, 55);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(52, 13);
            this.l.TabIndex = 55;
            this.l.Text = "Mặt hàng";
            // 
            // dgchititet
            // 
            this.dgchititet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgchititet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgchititet.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgchititet.Location = new System.Drawing.Point(1, 162);
            this.dgchititet.Name = "dgchititet";
            this.dgchititet.Size = new System.Drawing.Size(798, 272);
            this.dgchititet.TabIndex = 54;
            this.dgchititet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgchititet_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Số lượng";
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(97, 106);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(105, 20);
            this.txtsl.TabIndex = 65;
            // 
            // cbmh
            // 
            this.cbmh.FormattingEnabled = true;
            this.cbmh.Location = new System.Drawing.Point(97, 55);
            this.cbmh.Name = "cbmh";
            this.cbmh.Size = new System.Drawing.Size(147, 21);
            this.cbmh.TabIndex = 67;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(699, 478);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(75, 23);
            this.btnxacnhan.TabIndex = 59;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // ryeucau
            // 
            this.ryeucau.AutoSize = true;
            this.ryeucau.Location = new System.Drawing.Point(214, 481);
            this.ryeucau.Name = "ryeucau";
            this.ryeucau.Size = new System.Drawing.Size(65, 17);
            this.ryeucau.TabIndex = 68;
            this.ryeucau.TabStop = true;
            this.ryeucau.Text = "Yêu cầu";
            this.ryeucau.UseVisualStyleBackColor = true;
            this.ryeucau.CheckedChanged += new System.EventHandler(this.ryeucau_CheckedChanged);
            // 
            // rnhapkho
            // 
            this.rnhapkho.AutoSize = true;
            this.rnhapkho.Location = new System.Drawing.Point(321, 481);
            this.rnhapkho.Name = "rnhapkho";
            this.rnhapkho.Size = new System.Drawing.Size(72, 17);
            this.rnhapkho.TabIndex = 69;
            this.rnhapkho.TabStop = true;
            this.rnhapkho.Text = "Nhập kho";
            this.rnhapkho.UseVisualStyleBackColor = true;
            this.rnhapkho.CheckedChanged += new System.EventHandler(this.rnhapkho_CheckedChanged);
            this.rnhapkho.Click += new System.EventHandler(this.rnhapkho_Click);
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(539, 478);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(129, 20);
            this.txttt.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "thanh toán";
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Location = new System.Drawing.Point(29, 449);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(35, 13);
            this.tongtien.TabIndex = 72;
            this.tongtien.Text = "label5";
            // 
            // FormChititetHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.rnhapkho);
            this.Controls.Add(this.ryeucau);
            this.Controls.Add(this.cbmh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdg);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.dgchititet);
            this.Name = "FormChititetHoaDonNhap";
            this.Text = "FormChititetHoaDonNhap";
            this.Load += new System.EventHandler(this.FormChititetHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgchititet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dgchititet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.ComboBox cbmh;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.RadioButton ryeucau;
        private System.Windows.Forms.RadioButton rnhapkho;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tongtien;
    }
}