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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }
        public NhanVien nv;
        private karaokeDataContext db;
        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            db= new karaokeDataContext();
            
        }

        private void btnxn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassnow.Text) || string.IsNullOrEmpty(txtpassnew.Text) || string.IsNullOrEmpty(txtpassagain.Text))
            {
                MessageBox.Show("Vui lòng không để trống thông tin", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ac = db.NhanViens.SingleOrDefault(x => x.Username == nv.Username && x.Password == txtpassnow.Text);
                if (ac == null)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpassnow.Select();
                }
                else
                {
                    ac.Password = txtpassnew.Text;
                    ac.DiaChi = nv.DiaChi;
                    ac.HoVaTen = nv.HoVaTen;
                    ac.DienThoai = nv.DienThoai;
                    db.SubmitChanges();
                    MessageBox.Show("Đổi Mật khẩu thành công ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }

            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã hủy đổi mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Dispose();
        }
    }
}
