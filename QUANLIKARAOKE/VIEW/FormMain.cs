using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
namespace QUANLIKARAOKE.VIEW
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public Boolean isMaximize = false;
        public NhanVien nvien;
        private void FormMain_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            var nv = f.nv;
            nvien= f.nv;
            if (nv.ChucVu == "admin")
            {
                bcToolStripMenuItem.Visible = true;
            }
            else
            {
                bcToolStripMenuItem.Visible = false;
            }
            label1.Text = String.Format("Nhân viên : {0}", nv.HoVaTen) + "--KARAOKE HƯNG YÊN - 105-NHÂN HÒA-MỸ HÀO-0123456789";
        }

        private void lpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormLoaiPhong();
            addform(f);
        }
        public void addform(Form f)
        {
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.TopMost = true;
            grbcnt.Controls.Clear();
            grbcnt.Controls.Add(f);
            f.Show();
        }
        private void lpgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiPhong f = new FormLoaiPhong();
            addform(f);
        }

        private void pgToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPhong d = new FormPhong();
            addform(d);
        }

        private void dvhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDVT d = new FormDVT();
            addform(d);
        }

        private void nhccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNCC f = new FormNCC();
            addform(f);
        }

        private void nhvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien f = new FormNhanVien();
            addform(f);
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhapHang f = new FormNhapHang();
            addform(f);

        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMatHang d = new FormMatHang();
            addform(d);
        }

        private void bhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBanHang d = new FormBanHang();
            addform(d);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDoiMatKhau(nvien).ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tkDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormtThongke tk = new FormtThongke();
            addform(tk);
        }

        private void tklnvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTinhLuong tl = new FormTinhLuong();
            addform(tl);
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLTHIETBI qltb = new FormQLTHIETBI();
            addform(qltb);
        }
    }
}
