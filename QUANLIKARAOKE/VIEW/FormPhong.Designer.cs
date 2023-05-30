namespace QUANLIKARAOKE.VIEW
{
    partial class FormPhong
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
            this.txtsucchua = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.dgvlp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cblp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlp)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "QUẢN LÍ PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Sức chứa";
            // 
            // txtsucchua
            // 
            this.txtsucchua.Location = new System.Drawing.Point(667, 66);
            this.txtsucchua.Name = "txtsucchua";
            this.txtsucchua.Size = new System.Drawing.Size(75, 20);
            this.txtsucchua.TabIndex = 36;
            this.txtsucchua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsucchua_KeyPress);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(628, 126);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 35;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(713, 126);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(116, 76);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(108, 20);
            this.txtname.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(23, 76);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(59, 13);
            this.l.TabIndex = 31;
            this.l.Text = "Tên phòng";
            // 
            // dgvlp
            // 
            this.dgvlp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvlp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlp.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvlp.Location = new System.Drawing.Point(1, 155);
            this.dgvlp.Name = "dgvlp";
            this.dgvlp.Size = new System.Drawing.Size(798, 272);
            this.dgvlp.TabIndex = 30;
            this.dgvlp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlp_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Loại phòng";
            // 
            // cblp
            // 
            this.cblp.FormattingEnabled = true;
            this.cblp.Location = new System.Drawing.Point(365, 73);
            this.cblp.Name = "cblp";
            this.cblp.Size = new System.Drawing.Size(114, 21);
            this.cblp.TabIndex = 40;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cblp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsucchua);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.dgvlp);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsucchua;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dgvlp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cblp;
    }
}