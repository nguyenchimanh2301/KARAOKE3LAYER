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
using KARAOKEBUS;
namespace QUANLIKARAOKE.VIEW
{
    public partial class FormNCC : Form
    {
        public FormNCC()
        {
            InitializeComponent();
        }
        private string nhanvien = "admin";
        private karaokeDataContext db;
        private DataGridViewRow r;
        private NhaCungCapBLL bll = new NhaCungCapBLL();
        public void loaddata()
        {
            var lp = (from t in db.NhaCungCaps
                      select new
                      {
                          t.ID,
                          t.TenNCC,
                          t.DiaChi,
                          t.DienThoai,
                          t.Email
                      }).OrderBy(x => x.ID);
            dgvlp.DataSource = lp;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên Nhà cung cấp", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Select();
                return;
            }
           
            var lp = new NhaCungCap();
            lp.TenNCC = txtname.Text;
            lp.NgayTao = DateTime.Now;
            lp.DiaChi = txtdiachi.Text;
            lp.Email =  txtemail.Text;
            lp.DienThoai = txtsdt.Text;
            lp.NguoiTao = nhanvien;
            bll.themNhaCungCap(lp);
          /*  db.NhaCungCaps.InsertOnSubmit(lp);
            db.SubmitChanges();*/
            loaddata();
            MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtdiachi.Text = null;
            txtname.Text = null;
            txtemail.Text = null;
            txtsdt.Text = null;
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            dgvlp.SelectionMode =
             DataGridViewSelectionMode.FullRowSelect;
            dgvlp.MultiSelect = false;
            loaddata();        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (r==null)
            {
                MessageBox.Show("Vui lòng chọn tên Nhà cung cấp", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Select();
                return;
            }
            
            var dvt = db.NhaCungCaps.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
            dvt.TenNCC = txtname.Text;
            dvt.NguoiCapNhat = nhanvien;
            dvt.Email = txtemail.Text;
            dvt.DienThoai = txtsdt.Text;
            dvt.NguoiCapNhat = nhanvien;
            dvt.NgayCapNhat = DateTime.Now;
            db.SubmitChanges();
            MessageBox.Show("Cập nhật thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaddata();
            r = null;
            txtname.Text = null;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (MessageBox.Show("Bạn thật sự muốn xóa Nhà cung cấp " + r.Cells["tenncc"].Value.ToString() + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var dvt = db.NhaCungCaps.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    bll.xoa(int.Parse(r.Cells["id"].Value.ToString()));
                    /*  db.NhaCungCaps.DeleteOnSubmit(dvt);
                    db.SubmitChanges();*/
                    MessageBox.Show("Xóa thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    r = null;
                    txtname.Text = null;

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
        }

        private void dgvlp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvlp.Rows[e.RowIndex];
                txtname.Text = r.Cells["tenncc"].Value.ToString();
                txtdiachi.Text =  r.Cells["diachi"].Value.ToString();
                txtemail.Text =   r.Cells["email"].Value.ToString();
                txtsdt.Text = r.Cells["dienthoai"].Value.ToString();
                

            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
