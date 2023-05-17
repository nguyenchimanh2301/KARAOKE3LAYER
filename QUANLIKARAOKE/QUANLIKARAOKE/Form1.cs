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
using QUANLIKARAOKE.VIEW;
namespace QUANLIKARAOKE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public NhanVien nv;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtiuser.Text == null || txtpass.Text == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtiuser.Select();
                return;
            }
            karaokeDataContext data = new karaokeDataContext();
            var ac = data.NhanViens.SingleOrDefault(x => x.Username == txtiuser.Text && x.Password == txtpass.Text);
            if (ac != null)
            {
                nv = ac;
                MessageBox.Show("Đăng Nhập Thành Công nhân viên :"+ac.HoVaTen, "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác,vui lòng kiểm tra lại", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtiuser.Select();
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
