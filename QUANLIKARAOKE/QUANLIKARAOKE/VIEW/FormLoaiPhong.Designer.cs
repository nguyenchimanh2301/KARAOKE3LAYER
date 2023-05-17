namespace QUANLIKARAOKE.VIEW
{
    partial class FormLoaiPhong
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
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.dgvlp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlp)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "QUẢN LÍ DANH SÁCH LOẠI PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Đơn giá";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(435, 73);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(167, 20);
            this.txtdongia.TabIndex = 25;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(628, 126);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 24;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(713, 126);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 23;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(126, 73);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 20);
            this.txtname.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(23, 76);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(78, 13);
            this.l.TabIndex = 20;
            this.l.Text = "Tên loại phòng";
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // dgvlp
            // 
            this.dgvlp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvlp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlp.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvlp.Location = new System.Drawing.Point(1, 155);
            this.dgvlp.Name = "dgvlp";
            this.dgvlp.Size = new System.Drawing.Size(798, 272);
            this.dgvlp.TabIndex = 19;
            this.dgvlp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlp_CellClick);
            this.dgvlp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlp_CellContentClick);
            // 
            // FormLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.dgvlp);
            this.Name = "FormLoaiPhong";
            this.Text = "FormLoaiPhong";
            this.Load += new System.EventHandler(this.FormLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dgvlp;
    }
}