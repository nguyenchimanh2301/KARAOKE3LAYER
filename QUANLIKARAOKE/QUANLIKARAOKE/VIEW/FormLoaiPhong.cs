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
    public partial class FormLoaiPhong : Form
    {
        public FormLoaiPhong()
        {
            InitializeComponent();
        }
        private karaokeDataContext db;
        private string nhanvien = "admin";
        private LoaiPhongBLLcs bll = new LoaiPhongBLLcs();
        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            loaddata();
            dgvlp.Columns["id"].Width = 100;
            dgvlp.Columns["dongia"].Width = 150;
            dgvlp.Columns["id"].HeaderText = "Mã Loại";
            dgvlp.Columns["tenloaiphong"].HeaderText = "Tên Loại Phòng";
            dgvlp.Columns["dongia"].HeaderText = "Đơn giá";
            dgvlp.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvlp.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvlp.Columns["dongia"].DefaultCellStyle.Format = "N0";
            dgvlp.Columns["tenloaiphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvlp.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dgvlp.MultiSelect = false;
        }
        public void loaddata()
        {
            var lp = (from t in db.LoaiPhongs
                      select new
                      {
                          t.ID,
                          t.TenLoaiPhong,
                          t.DonGia
                      }).OrderBy(x=>x.ID);
            dgvlp.DataSource = lp;
        }
        private DataGridViewRow r;
        private void dgvlp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvlp.Rows[e.RowIndex];
                txtdongia.Text = r.Cells["dongia"].Value.ToString();
                txtname.Text = r.Cells["tenloaiphong"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtdongia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá bán", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongia.Select();
                return;
            }
            var lp = new LoaiPhong();
            lp.TenLoaiPhong = txtname.Text;
            lp.NguoiTao = nhanvien;
            lp.NgayTao = DateTime.Now;
            lp.DonGia = int.Parse(txtdongia.Text);
            bll.themLoaiPhong(lp);
            loaddata();
            MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtdongia.Text = "0";
            txtname.Text = null;
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void l_Click(object sender, EventArgs e)
        {

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                var dvt = db.LoaiPhongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                dvt.TenLoaiPhong = txtname.Text;
                dvt.DonGia = int.Parse(txtdongia.Text);
                dvt.NguoiCapNhat = nhanvien;
                dvt.NgayCapNhat = DateTime.Now;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                r = null;
                txtdongia.Text = "0";
                txtname.Text = null;

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (MessageBox.Show("Bạn thật sự muốn xóa loại phòng " + r.Cells["tenloaiphong"].Value.ToString() + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var dvt = db.LoaiPhongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    bll.xoa(int.Parse(r.Cells["id"].Value.ToString()));

                    /*     db.LoaiPhongs.DeleteOnSubmit(dvt);
                    db.SubmitChanges();*/
                    MessageBox.Show("Xóa thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    r = null;
                    txtdongia.Text = "0";
                    txtname.Text = null;

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
        }

        private void dgvlp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
