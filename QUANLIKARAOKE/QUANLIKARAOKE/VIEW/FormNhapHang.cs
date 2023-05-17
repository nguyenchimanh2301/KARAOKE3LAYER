using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLIKARAOKE.VIEW
{
    public partial class FormNhapHang : Form
    {
        public FormNhapHang()
        {
            InitializeComponent();
        }
        private string nhanvien = "admin";
        private karaokeDataContext db;
        private DataGridViewRow r;
        public void loaddata()
        {
            var lp = from o in db.HoaDonNhaps
                      join n in db.NhaCungCaps on o.IDNhaCC equals n.ID
                      join c in db.NhanViens on o.NhanVienNhap equals c.Username
                     
                      select new
                      {
                          id = o.ID,
                          NgayNhap = o.NgayNhap,
                          TenNCC = n.TenNCC,
                          danhap = o.DaNhap,
                          trangthai = o.DaNhap == 1 ? "Đã Nhập":"Yêu cầu",
                          tongtien = db.ChiTietHoaDonNhaps.Where(x => x.IDHoaDon == o.ID).Sum(y => y.SoLuong * y.DonGiaNhap),
                          dathanhtoan = o.TienThanhToan
                      };
            dgvnhap.DataSource = lp;

        }
        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            db= new karaokeDataContext();
            date.Text = DateTime.Now.ToString("dd//mm//yyyy");


            dgvnhap.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dgvnhap .MultiSelect = false;


            cbnv.DataSource = db.NhanViens;
            cbnv.DisplayMember = "hovaten";
            cbnv.ValueMember = "username";
            cbnv.SelectedIndex = -1;
            cbncc.DataSource = db.NhaCungCaps;
            cbncc.DisplayMember = "TenNCC";
            cbncc.ValueMember = "ID";
            cbncc.SelectedIndex = -1;
            loaddata();
            dgvnhap.Columns["id"].HeaderText = "Mã Đơn Nhập";
            dgvnhap.Columns["id"].Width = 100;
            dgvnhap.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dgvnhap.Columns["NgayNhap"].Width = 100;
            dgvnhap.Columns["dathanhtoan"].HeaderText = "Đã thanh toán";
            dgvnhap.Columns["dathanhtoan"].Width = 100;
           
            dgvnhap.Columns["trangthai"].HeaderText = "Trạng Thái";
            dgvnhap.Columns["trangthai"].Width = 100;
            dgvnhap.Columns["tongtien"].HeaderText = "Tổng tiền";
            dgvnhap.Columns["tongtien"].Width = 100;
        
            dgvnhap.Columns["TenNCC"].HeaderText = "Nhà cung cấp";
            dgvnhap.Columns["TenNCC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateT;
            try
            {
                 dateT = DateTime.ParseExact(date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {

                MessageBox.Show("Ngày nhập không hợp lệ", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbncc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbnv.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân viên nhập", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var order = new HoaDonNhap();
                order.NhanVienNhap = cbnv.SelectedValue.ToString();
                order.IDNhaCC = int.Parse(cbncc.SelectedValue.ToString());
                order.NgayNhap = dateT;

                order.NguoiTao = nhanvien;
                order.NgayTao = DateTime.Now;
                db.HoaDonNhaps.InsertOnSubmit(order);
                db.SubmitChanges();
                var idhdnhap = db.HoaDonNhaps.Max(x => x.ID);
                /*  MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                new FormChititetHoaDonNhap(idhdnhap,0).ShowDialog();
                loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" +ex.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void dgvnhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvnhap.Rows[e.RowIndex];
                byte danhapkho = r.Cells["danhap"].Value==null ? (byte)0 : byte.Parse(r.Cells["danhap"].Value.ToString());
                new FormChititetHoaDonNhap(long.Parse(r.Cells["id"].Value.ToString()), danhapkho).ShowDialog();

            }
        }
    }
    
}
