namespace QUANLIKARAOKE.VIEW
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtphong = new System.Windows.Forms.Label();
            this.dgvmathang = new System.Windows.Forms.DataGridView();
            this.panelorder = new System.Windows.Forms.Panel();
            this.txtready = new System.Windows.Forms.Button();
            this.dgvdadung = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.maskkt = new System.Windows.Forms.MaskedTextBox();
            this.maskbd = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabbh = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabct1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvgls = new System.Windows.Forms.DataGridView();
            this.pd1 = new System.Drawing.Printing.PrintDocument();
            this.pdd1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmathang)).BeginInit();
            this.panelorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdadung)).BeginInit();
            this.tabbh.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgls)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtphong);
            this.panel1.Controls.Add(this.dgvmathang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(755, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 745);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "-TRẠNG THÁI";
            // 
            // txtphong
            // 
            this.txtphong.AutoSize = true;
            this.txtphong.Location = new System.Drawing.Point(162, 22);
            this.txtphong.Name = "txtphong";
            this.txtphong.Size = new System.Drawing.Size(46, 13);
            this.txtphong.TabIndex = 2;
            this.txtphong.Text = "PHÒNG";
            this.txtphong.Click += new System.EventHandler(this.txtphong_Click);
            // 
            // dgvmathang
            // 
            this.dgvmathang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmathang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvmathang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvmathang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmathang.Location = new System.Drawing.Point(0, 63);
            this.dgvmathang.Name = "dgvmathang";
            this.dgvmathang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmathang.Size = new System.Drawing.Size(448, 568);
            this.dgvmathang.TabIndex = 1;
            this.dgvmathang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmathang_CellDoubleClick);
            // 
            // panelorder
            // 
            this.panelorder.AutoSize = true;
            this.panelorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelorder.Controls.Add(this.txtready);
            this.panelorder.Controls.Add(this.dgvdadung);
            this.panelorder.Controls.Add(this.button1);
            this.panelorder.Controls.Add(this.maskkt);
            this.panelorder.Controls.Add(this.maskbd);
            this.panelorder.Controls.Add(this.label4);
            this.panelorder.Controls.Add(this.label3);
            this.panelorder.Controls.Add(this.label2);
            this.panelorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelorder.Location = new System.Drawing.Point(0, 571);
            this.panelorder.Name = "panelorder";
            this.panelorder.Size = new System.Drawing.Size(755, 174);
            this.panelorder.TabIndex = 2;
            // 
            // txtready
            // 
            this.txtready.Location = new System.Drawing.Point(37, 133);
            this.txtready.Name = "txtready";
            this.txtready.Size = new System.Drawing.Size(75, 23);
            this.txtready.TabIndex = 10;
            this.txtready.Text = "Bắt đầu";
            this.txtready.UseVisualStyleBackColor = true;
            this.txtready.Click += new System.EventHandler(this.txtready_Click);
            // 
            // dgvdadung
            // 
            this.dgvdadung.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvdadung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdadung.Location = new System.Drawing.Point(252, 26);
            this.dgvdadung.Name = "dgvdadung";
            this.dgvdadung.Size = new System.Drawing.Size(485, 145);
            this.dgvdadung.TabIndex = 9;
            this.dgvdadung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdadung_CellContentClick);
            this.dgvdadung.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdadung_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kết thúc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskkt
            // 
            this.maskkt.Location = new System.Drawing.Point(77, 80);
            this.maskkt.Mask = "00/00/0000 90:00";
            this.maskkt.Name = "maskkt";
            this.maskkt.Size = new System.Drawing.Size(149, 20);
            this.maskkt.TabIndex = 6;
            this.maskkt.ValidatingType = typeof(System.DateTime);
            // 
            // maskbd
            // 
            this.maskbd.Location = new System.Drawing.Point(77, 23);
            this.maskbd.Mask = "00/00/0000 90:00";
            this.maskbd.Name = "maskbd";
            this.maskbd.Size = new System.Drawing.Size(149, 20);
            this.maskbd.TabIndex = 5;
            this.maskbd.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DANH SÁCH MẶT HÀNG PHÒNG ĐÃ DÙNG";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // tabbh
            // 
            this.tabbh.Controls.Add(this.tabPage1);
            this.tabbh.Controls.Add(this.tabPage2);
            this.tabbh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabbh.Location = new System.Drawing.Point(0, 0);
            this.tabbh.Name = "tabbh";
            this.tabbh.SelectedIndex = 0;
            this.tabbh.Size = new System.Drawing.Size(755, 571);
            this.tabbh.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabct1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bán hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabct1
            // 
            this.tabct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabct1.Location = new System.Drawing.Point(3, 3);
            this.tabct1.Name = "tabct1";
            this.tabct1.SelectedIndex = 0;
            this.tabct1.Size = new System.Drawing.Size(741, 539);
            this.tabct1.TabIndex = 4;
            this.tabct1.SelectedIndexChanged += new System.EventHandler(this.tabct1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvgls);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lịch sử";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvgls
            // 
            this.dvgls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgls.Location = new System.Drawing.Point(3, 3);
            this.dvgls.Name = "dvgls";
            this.dvgls.Size = new System.Drawing.Size(741, 539);
            this.dvgls.TabIndex = 0;
            this.dvgls.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgls_CellDoubleClick);
            // 
            // pd1
            // 
            this.pd1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd1_PrintPage);
            // 
            // pdd1
            // 
            this.pdd1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pdd1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pdd1.ClientSize = new System.Drawing.Size(400, 300);
            this.pdd1.Enabled = true;
            this.pdd1.Icon = ((System.Drawing.Icon)(resources.GetObject("pdd1.Icon")));
            this.pdd1.Name = "pdd1";
            this.pdd1.Visible = false;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 745);
            this.Controls.Add(this.tabbh);
            this.Controls.Add(this.panelorder);
            this.Controls.Add(this.panel1);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmathang)).EndInit();
            this.panelorder.ResumeLayout(false);
            this.panelorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdadung)).EndInit();
            this.tabbh.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskkt;
        private System.Windows.Forms.MaskedTextBox maskbd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtphong;
        private System.Windows.Forms.DataGridView dgvmathang;
        private System.Windows.Forms.DataGridView dgvdadung;
        private System.Windows.Forms.Button txtready;
        private System.Windows.Forms.TabControl tabbh;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabct1;
        private System.Windows.Forms.DataGridView dvgls;
        private System.Drawing.Printing.PrintDocument pd1;
        private System.Windows.Forms.PrintPreviewDialog pdd1;
        private System.Windows.Forms.Label label1;
    }
}