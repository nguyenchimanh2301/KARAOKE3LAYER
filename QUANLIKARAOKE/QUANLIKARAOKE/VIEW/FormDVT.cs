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
    public partial class FormDVT : Form
    {
        public FormDVT()
        {
            InitializeComponent();
        }
        private karaokeDataContext db;
        private DVTBLL bll = new DVTBLL();
        private string nhanvien = "admin";
        private void FormDVT_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext(); // Khởi tạo đối tượng dbcontext
            showdata();
            dgvdvt.Columns["id"].HeaderText = "Mã ĐVT";
            dgvdvt.Columns["id"].Width = 100;
            dgvdvt.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvdvt.Columns["TenDVT"].HeaderText = "Tên ĐVT";
            dgvdvt.Columns["TenDVT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvdvt.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dgvdvt.MultiSelect = false;
        }
        public void showdata()
        {
            dgvdvt.DataSource = db.DonViTinhs.Select(x => new { 
            id = x.ID,
            TenDVT = x.TenDVT
            }).ToList(); //đổ dữ liệu ra datagridview

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtdvt.Text))
            {
                DonViTinh dvt = new DonViTinh();
                dvt.TenDVT = txtdvt.Text;
                dvt.NguoiTao = nhanvien;
                dvt.NgayTao = DateTime.Now;
                bll.themDonViTinh(dvt);
               /* db.DonViTinhs.InsertOnSubmit(dvt);
                db.SubmitChanges();*/
                MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đơn vị tính","Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private DataGridViewRow r;
        private void dgvdvt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             r = dgvdvt.Rows[e.RowIndex];
            txtdvt.Text = r.Cells["TenDVT"].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (r == null)
                {
                    MessageBox.Show("Vui lòng chọn đơn vị tính cần sửa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (!string.IsNullOrEmpty(txtdvt.Text))
                {
                    var dvt = db.DonViTinhs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    dvt.TenDVT = txtdvt.Text;
                    dvt.NguoiCapNhat = nhanvien;
                    dvt.NgayCapNhat = DateTime.Now;
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    r = null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (MessageBox.Show("Bạn thật sự muốn xóa Đơn vị tính " + r.Cells["TenDVT"].Value.ToString()+"?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var dvt = db.DonViTinhs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                bll.xoa(int.Parse(r.Cells["id"].Value.ToString()));
                /*  db.DonViTinhs.DeleteOnSubmit(dvt);
                db.SubmitChanges();*/
                MessageBox.Show("Xóa thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata();
                r = null;
            }
        }
    }
}
