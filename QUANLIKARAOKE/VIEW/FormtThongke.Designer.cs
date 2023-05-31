namespace QUANLIKARAOKE.VIEW
{
    partial class FormtThongke
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskbd = new System.Windows.Forms.MaskedTextBox();
            this.maskkt = new System.Windows.Forms.MaskedTextBox();
            this.txtready = new System.Windows.Forms.Button();
            this.panelorder = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rmh = new System.Windows.Forms.RadioButton();
            this.rp = new System.Windows.Forms.RadioButton();
            this.rall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelorder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến ngày";
            // 
            // maskbd
            // 
            this.maskbd.Location = new System.Drawing.Point(432, 48);
            this.maskbd.Mask = "00/00/0000 90:00";
            this.maskbd.Name = "maskbd";
            this.maskbd.Size = new System.Drawing.Size(149, 20);
            this.maskbd.TabIndex = 5;
            this.maskbd.ValidatingType = typeof(System.DateTime);
            // 
            // maskkt
            // 
            this.maskkt.Location = new System.Drawing.Point(700, 48);
            this.maskkt.Mask = "00/00/0000 90:00";
            this.maskkt.Name = "maskkt";
            this.maskkt.Size = new System.Drawing.Size(149, 20);
            this.maskkt.TabIndex = 6;
            this.maskkt.ValidatingType = typeof(System.DateTime);
            // 
            // txtready
            // 
            this.txtready.Location = new System.Drawing.Point(774, 94);
            this.txtready.Name = "txtready";
            this.txtready.Size = new System.Drawing.Size(75, 23);
            this.txtready.TabIndex = 10;
            this.txtready.Text = "Thống kê";
            this.txtready.UseVisualStyleBackColor = true;
            this.txtready.Click += new System.EventHandler(this.txtready_Click);
            // 
            // panelorder
            // 
            this.panelorder.AutoSize = true;
            this.panelorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelorder.Controls.Add(this.comboBox1);
            this.panelorder.Controls.Add(this.rmh);
            this.panelorder.Controls.Add(this.rp);
            this.panelorder.Controls.Add(this.rall);
            this.panelorder.Controls.Add(this.label1);
            this.panelorder.Controls.Add(this.txtready);
            this.panelorder.Controls.Add(this.maskkt);
            this.panelorder.Controls.Add(this.maskbd);
            this.panelorder.Controls.Add(this.label4);
            this.panelorder.Controls.Add(this.label3);
            this.panelorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelorder.Location = new System.Drawing.Point(0, 0);
            this.panelorder.Name = "panelorder";
            this.panelorder.Size = new System.Drawing.Size(1087, 120);
            this.panelorder.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(630, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // rmh
            // 
            this.rmh.AutoSize = true;
            this.rmh.Location = new System.Drawing.Point(520, 97);
            this.rmh.Name = "rmh";
            this.rmh.Size = new System.Drawing.Size(72, 17);
            this.rmh.TabIndex = 14;
            this.rmh.TabStop = true;
            this.rmh.Text = "Mặt Hàng";
            this.rmh.UseVisualStyleBackColor = true;
            this.rmh.CheckedChanged += new System.EventHandler(this.rall_CheckedChanged_1);
            this.rmh.Click += new System.EventHandler(this.rmh_Click);
            // 
            // rp
            // 
            this.rp.AutoSize = true;
            this.rp.Location = new System.Drawing.Point(432, 97);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(56, 17);
            this.rp.TabIndex = 13;
            this.rp.TabStop = true;
            this.rp.Text = "Phòng";
            this.rp.UseVisualStyleBackColor = true;
            this.rp.CheckedChanged += new System.EventHandler(this.rall_CheckedChanged_1);
            this.rp.Click += new System.EventHandler(this.rp_Click);
            // 
            // rall
            // 
            this.rall.AutoSize = true;
            this.rall.Location = new System.Drawing.Point(340, 97);
            this.rall.Name = "rall";
            this.rall.Size = new System.Drawing.Size(56, 17);
            this.rall.TabIndex = 12;
            this.rall.TabStop = true;
            this.rall.Text = "Tất cả";
            this.rall.UseVisualStyleBackColor = true;
            this.rall.CheckedChanged += new System.EventHandler(this.rall_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtsum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 47);
            this.panel1.TabIndex = 7;
            // 
            // txtsum
            // 
            this.txtsum.AutoSize = true;
            this.txtsum.Location = new System.Drawing.Point(12, 14);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(28, 13);
            this.txtsum.TabIndex = 0;
            this.txtsum.Text = "tong";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1087, 464);
            this.dataGridView1.TabIndex = 8;
            // 
            // FormtThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 631);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelorder);
            this.Name = "FormtThongke";
            this.Text = "FormtThongke";
            this.Load += new System.EventHandler(this.FormtThongke_Load_1);
            this.panelorder.ResumeLayout(false);
            this.panelorder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskbd;
        private System.Windows.Forms.MaskedTextBox maskkt;
        private System.Windows.Forms.Button txtready;
        private System.Windows.Forms.Panel panelorder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rmh;
        private System.Windows.Forms.RadioButton rp;
        private System.Windows.Forms.RadioButton rall;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtsum;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}