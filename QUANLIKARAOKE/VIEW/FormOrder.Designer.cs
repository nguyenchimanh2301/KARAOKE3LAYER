namespace QUANLIKARAOKE.VIEW
{
    partial class FormOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butdele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textsl = new System.Windows.Forms.TextBox();
            this.butxn = new System.Windows.Forms.Button();
            this.phongtxt = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(773, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 149);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butdele);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // butdele
            // 
            this.butdele.Location = new System.Drawing.Point(749, 9);
            this.butdele.Name = "butdele";
            this.butdele.Size = new System.Drawing.Size(48, 31);
            this.butdele.TabIndex = 2;
            this.butdele.Text = "X";
            this.butdele.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yêu cầu phục vụ";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 44);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 149);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(740, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 149);
            this.panel5.TabIndex = 4;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(106, 88);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(49, 13);
            this.lbname.TabIndex = 5;
            this.lbname.Text = "tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng yêu cầu";
            // 
            // textsl
            // 
            this.textsl.Location = new System.Drawing.Point(195, 150);
            this.textsl.Name = "textsl";
            this.textsl.Size = new System.Drawing.Size(131, 20);
            this.textsl.TabIndex = 7;
            // 
            // butxn
            // 
            this.butxn.Location = new System.Drawing.Point(611, 150);
            this.butxn.Name = "butxn";
            this.butxn.Size = new System.Drawing.Size(75, 23);
            this.butxn.TabIndex = 8;
            this.butxn.Text = "Xác nhận";
            this.butxn.UseVisualStyleBackColor = true;
            this.butxn.Click += new System.EventHandler(this.butxn_Click);
            // 
            // phongtxt
            // 
            this.phongtxt.AutoSize = true;
            this.phongtxt.Location = new System.Drawing.Point(411, 79);
            this.phongtxt.Name = "phongtxt";
            this.phongtxt.Size = new System.Drawing.Size(46, 13);
            this.phongtxt.TabIndex = 9;
            this.phongtxt.Text = "PHONG";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 239);
            this.Controls.Add(this.phongtxt);
            this.Controls.Add(this.butxn);
            this.Controls.Add(this.textsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button butdele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textsl;
        private System.Windows.Forms.Button butxn;
        private System.Windows.Forms.Label phongtxt;
    }
}