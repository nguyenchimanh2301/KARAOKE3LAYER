namespace QUANLIKARAOKE.VIEW
{
    partial class FormThietBi
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbltb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.dgvmt = new System.Windows.Forms.DataGridView();
            this.txtmausac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkichco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmt)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 32);
            this.button2.TabIndex = 31;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "QUẢN LÍ DANH SÁCH THIẾT BỊ";
            // 
            // cbltb
            // 
            this.cbltb.FormattingEnabled = true;
            this.cbltb.Location = new System.Drawing.Point(93, 105);
            this.cbltb.Name = "cbltb";
            this.cbltb.Size = new System.Drawing.Size(121, 21);
            this.cbltb.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Loại Thiết Bị";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(333, 53);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(146, 20);
            this.txtdongia.TabIndex = 26;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(424, 138);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(84, 32);
            this.btnsua.TabIndex = 25;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(514, 138);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(79, 32);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(93, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 20);
            this.txtname.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(12, 56);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(65, 13);
            this.l.TabIndex = 21;
            this.l.Text = "Tên Thiết Bị";
            // 
            // dgvmt
            // 
            this.dgvmt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvmt.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvmt.Location = new System.Drawing.Point(0, 187);
            this.dgvmt.Name = "dgvmt";
            this.dgvmt.Size = new System.Drawing.Size(638, 331);
            this.dgvmt.TabIndex = 20;
            this.dgvmt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmt_CellClick);
            // 
            // txtmausac
            // 
            this.txtmausac.Location = new System.Drawing.Point(500, 101);
            this.txtmausac.Name = "txtmausac";
            this.txtmausac.Size = new System.Drawing.Size(124, 20);
            this.txtmausac.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "màu sắc";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtkichco
            // 
            this.txtkichco.Location = new System.Drawing.Point(290, 101);
            this.txtkichco.Name = "txtkichco";
            this.txtkichco.Size = new System.Drawing.Size(124, 20);
            this.txtkichco.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "kích cỡ";
            // 
            // FormThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbltb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkichco);
            this.Controls.Add(this.txtmausac);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.dgvmt);
            this.Name = "FormThietBi";
            this.Text = "FormThietBi";
            this.Load += new System.EventHandler(this.FormThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbltb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dgvmt;
        private System.Windows.Forms.TextBox txtmausac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkichco;
        private System.Windows.Forms.Label label5;
    }
}