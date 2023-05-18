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
    public partial class FormMatHang : Form
    {
        public FormMatHang()
        {
            InitializeComponent();
        }
        private karaokeDataContext db;
        MatHangBLL bll = new MatHangBLL();
        private string nhanvien = "admin";
        private void FormMatHang_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            showdata();
            cbdvt.DataSource = db.DonViTinhs;
            cbdvt.DisplayMember = "TenDVT";
            cbdvt.ValueMember = "ID";
            cbdvt.SelectedIndex = -1;
            dgvmt.Columns["id"].Width = 100;
            dgvmt.Columns["tendvt"].Width = 100;
            dgvmt.Columns["dongiaban"].Width = 100;
            dgvmt.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvmt.Columns["tendvt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvmt.Columns["dongiaban"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvmt.Columns["id"].HeaderText = "Mã hàng";
            dgvmt.Columns["tendvt"].HeaderText = "ĐVT";
            dgvmt.Columns["dongiaban"].HeaderText = "Đơn giá";
            dgvmt.Columns["tenmathang"].HeaderText = "Tên Mặt Hàng";
            dgvmt.Columns["tenmathang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvmt.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dgvmt.MultiSelect = false;
        }

        public void showdata()
        {
            var mt = from h in db.MatHangs
                     join d in db.DonViTinhs
                     on h.DVT equals d.ID
                     select new { 
                     h.ID,
                     h.TenMatHang,
                     d.TenDVT,
                     h.DonGiaBan
                     };
            dgvmt.DataSource = mt;
            //load dữ liệu ra data gridview

        }

        private void dgvmt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên mặt hàng", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Select();
                return;
            }
            if (cbdvt.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtdongia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá bán", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mh = new MatHang();
            mh.TenMatHang = txtname.Text;
            mh.DVT = int.Parse(cbdvt.SelectedValue.ToString());
            mh.Nguoitao = nhanvien;
            mh.Ngaytao = DateTime.Now;
            mh.DonGiaBan = int.Parse(txtdongia.Text);
            bll.themMathang(mh);
            showdata();
            MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtdongia.Text = "0";
            txtname.Text = null;
            cbdvt.SelectedIndex = -1;
            //thêm mặt hàng
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { 
            
            e.Handled = true;
            }
        }
        private DataGridViewRow r;
        private void dgvmt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvmt.Rows[e.RowIndex];
                txtdongia.Text = r.Cells["dongiaban"].Value.ToString();
                cbdvt.Text = r.Cells["tendvt"].Value.ToString();
                txtname.Text = r.Cells["tenmathang"].Value.ToString();
            }
            //chọn dữ liệu theo dòng
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần sửa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                var dvt = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                dvt.TenMatHang = txtname.Text;
                dvt.DonGiaBan = int.Parse(txtdongia.Text);
                dvt.DVT = int.Parse(cbdvt.SelectedValue.ToString());
                dvt.NguoiCapNhat = nhanvien;
                dvt.NgayCapNhat = DateTime.Now;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata();
                r = null;
                cbdvt.SelectedIndex = -1;
                txtdongia.Text = "0";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (MessageBox.Show("Bạn thật sự muốn xóa mặt hàng " + r.Cells["tenmathang"].Value.ToString() + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var dvt = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    bll.xoa(int.Parse(r.Cells["id"].Value.ToString()));
                    /*db.MatHangs.DeleteOnSubmit(dvt);*/
                    MessageBox.Show("Xóa thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    r = null;
                    cbdvt.SelectedIndex = -1;
                    txtdongia.Text = "0";
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //tìm kiếm gần đúng theo tên
        {
            if (txtname.Text == null)
            {
                showdata();
            }
            else
            {
                var mt = bll.Timkiem(txtname.Text);
                dgvmt.DataSource = null;
                dgvmt.DataSource = mt;
            }
        }
    }
}
