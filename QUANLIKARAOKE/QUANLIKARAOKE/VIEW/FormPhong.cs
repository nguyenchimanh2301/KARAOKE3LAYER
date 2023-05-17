using ENTITY;
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
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
        }
        private karaokeDataContext db;
        private string nhanvien = "admin";
        private DataGridViewRow r;
        private void FormPhong_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            loaddata();
            cblp.DataSource = db.LoaiPhongs;
            cblp.DisplayMember = "tenloaiphong";
            cblp.ValueMember = "id";
            cblp.SelectedIndex = -1;
            dgvlp.Columns["id"].Width = 100;
            dgvlp.Columns["dongia"].Width = 150;
            dgvlp.Columns["id"].HeaderText = "Mã Phòng";
            dgvlp.Columns["tenloaiphong"].HeaderText = "Loại Phòng";
            dgvlp.Columns["tenphong"].HeaderText = "Tên Phòng";
            dgvlp.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvlp.Columns["succhua"].HeaderText = "sức chứa";
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
            var lp = (from t in db.Phongs
                      join l in db.LoaiPhongs
                      on t.IDLoaiPhong equals l.ID
                      select new
                      {
                          t.ID,
                          t.TenPhong,
                          l.TenLoaiPhong,
                          l.DonGia,
                          t.SucChua
                      }).OrderBy(x => x.ID);
            dgvlp.DataSource = lp;
        }
        private void dgvlp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvlp.Rows[e.RowIndex];
                txtname.Text = r.Cells["tenphong"].Value.ToString();
                txtsucchua.Text = r.Cells["succhua"].Value.ToString();
                cblp.Text = r.Cells["tenloaiphong"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Select();
                return;
            }
            if (cblp.SelectedIndex <0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtsucchua.Text) || int.Parse(txtsucchua.Text) <= 0)
            {
                MessageBox.Show("Sức chứa phải lớn hơn 0", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsucchua.Select();
                return;
            }
            var lp = new Phong();
            lp.TenPhong = txtname.Text;
            lp.NguoiTao = nhanvien;
            lp.NgayTao = DateTime.Now;
            lp.SucChua = int.Parse(txtsucchua.Text);
            lp.IDLoaiPhong = int.Parse(cblp.SelectedValue.ToString());
            db.Phongs.InsertOnSubmit(lp);
            db.SubmitChanges();
            loaddata();
            MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtsucchua.Text = "0";
            txtname.Text = null;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Select();
                return;
            }
            if (cblp.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Loại phòng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtsucchua.Text) || int.Parse(txtsucchua.Text) <= 0)
            {
                MessageBox.Show("Sức chứa phải lớn hơn 0", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dvt = db.Phongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
            dvt.TenPhong = txtname.Text;
            dvt.NguoiCapNhat = nhanvien;
            dvt.IDLoaiPhong = int.Parse(cblp.SelectedValue.ToString());
            dvt.SucChua = int.Parse(txtsucchua.Text);

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
                MessageBox.Show("Vui lòng chọn phòng cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (MessageBox.Show("Bạn thật sự muốn xóa phòng " + r.Cells["tenphong"].Value.ToString() + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var dvt = db.Phongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    db.Phongs.DeleteOnSubmit(dvt);
                    db.SubmitChanges();
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

        private void txtsucchua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

    

   

