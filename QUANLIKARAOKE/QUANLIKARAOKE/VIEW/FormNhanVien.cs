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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private string nhanvien = "admin";
        private karaokeDataContext db;
        private DataGridViewRow r;
         string [] chucvu = { "admin", "nhanvien" };
        string selectedValue = "";
        public void loaddata()
        {
            var lp = (from t in db.NhanViens
                      select new
                      {
                          t.Username,
                          t.Password,
                          t.DiaChi,
                          t.DienThoai,
                          t.HoVaTen,
                          t.ChucVu
                      });
            dgvlp.DataSource = lp;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            dgvlp.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dgvlp.MultiSelect = false;
            loaddata();
            foreach (var item in chucvu)
            {
                cbcv.Items.Add(item);
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên Nhà cung cấp", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusname.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                MessageBox.Show("Vui lòng nhập tên user", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Vui lòng nhập password", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusname.Select();
                return;
            }
            var c  = db.NhanViens.Where(x=>x.Username.Trim().ToLower()==txtuser.Text.Trim().ToLower()).Count();
            if (c > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Select();
                return;
            }
            var tl = new TinhLuong();
            var lp = new NhanVien();
            lp.HoVaTen = textname.Text;
            lp.DiaChi = txtdiachi.Text;
            lp.Password = txtpass.Text;
            lp.DienThoai = txtsdt.Text;
            lp.Username = txtusname.Text;
            
            string selectedValue = cbcv.SelectedItem.ToString();
            lp.ChucVu = selectedValue;
            //them vao bang tinh luong
            tl.IDusername = lp.Username;
            tl.Dathanhtoan = 0;
            tl.songaynghi = 0;
            tl.Ngaybatdau = DateTime.Now;
            tl.LuongCB = 150000;
            db.NhanViens.InsertOnSubmit(lp);
            db.TinhLuongs.InsertOnSubmit(tl);
            db.SubmitChanges();
            loaddata();
            MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtdiachi.Text = null;
            txtusname.Text = null;
            txtuser.Text = null;
            txtsdt.Text = null;
            txtpass.Text = null;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn sửa", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusname.Select();
                return;
            }

            var dvt = db.NhanViens.SingleOrDefault(x => x.Username == r.Cells["username"].Value.ToString());
            dvt.Password = txtpass.Text;
            dvt.HoVaTen = textname.Text;
            dvt.DienThoai = txtsdt.Text;
            dvt.DiaChi = txtdiachi.Text;
            string selectedValue = cbcv.SelectedItem.ToString();
            dvt.ChucVu = selectedValue;
            db.SubmitChanges();
            MessageBox.Show("Cập nhật thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaddata();
            r = null;
            textname.Text = txtusname.Text = txtpass.Text = txtdiachi.Text = txtsdt.Text = null;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (MessageBox.Show("Bạn thật sự muốn xóa Nhân viên " + r.Cells["hovaten"].Value.ToString() + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    var dvt = db.NhanViens.SingleOrDefault(x => x.Username == r.Cells["username"].Value.ToString());
                    var us = db.TinhLuongs.SingleOrDefault(x => x.IDusername == r.Cells["username"].Value.ToString());
                    db.TinhLuongs.DeleteOnSubmit(us);
                    db.NhanViens.DeleteOnSubmit(dvt);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    r = null;
                    textname.Text = txtusname.Text = txtpass.Text =txtdiachi.Text= txtsdt.Text=null;

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
                textname.Text = r.Cells["hovaten"].Value.ToString();
                txtdiachi.Text = r.Cells["diachi"].Value.ToString();
                txtusname.Text = r.Cells["username"].Value.ToString();
                txtsdt.Text = r.Cells["dienthoai"].Value.ToString();
                txtpass.Text = r.Cells["password"].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textname.Text == null)
            {
                var lp = (from t in db.NhanViens
                          select new
                          {
                              t.Username,
                              t.Password,
                              t.DiaChi,
                              t.DienThoai,
                              t.HoVaTen
                          });
                dgvlp.DataSource = lp;
            }
            else
            {
                var lp = (from t in db.NhanViens.Where(x=>x.HoVaTen.Contains(textname.Text))
                          select new
                          {
                              t.Username,
                              t.Password,
                              t.DiaChi,
                              t.DienThoai,
                              t.HoVaTen
                          });
                dgvlp.DataSource = null;
                dgvlp.DataSource = lp;
            }
        }
    }
}
