using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QUANLIKARAOKE.VIEW
{
    public partial class FormMENU : Form
    {
        public FormMENU()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDVT d = new FormDVT();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMatHang m = new FormMatHang();
            m.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormNhapHang nh = new FormNhapHang();
            nh.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBanHang ban = new FormBanHang();
            ban.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPhong p = new FormPhong();
            p.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            nv.ShowDialog();
        }

        private void FormMENU_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
