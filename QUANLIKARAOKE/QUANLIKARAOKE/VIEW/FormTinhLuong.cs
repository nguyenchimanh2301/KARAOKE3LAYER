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
using ENTITY;

namespace QUANLIKARAOKE.VIEW
{
    public partial class FormTinhLuong : Form
    {
        public FormTinhLuong()
        {
            InitializeComponent();
        }
        private karaokeDataContext db;
        private DataGridViewRow r;
        private void FormTinhLuong_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            showdata();
            dgvtl.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

            dgvtl.MultiSelect = false;
            dgvtl.Columns["ID"].Visible = false;
            dgvtl.Columns["username"].HeaderText = "Tên tài khoản";
            dgvtl.Columns["hoten"].HeaderText = "Họ tên";
            dgvtl.Columns["luongcb"].HeaderText = "Lương CB";
            dgvtl.Columns["songaynghi"].HeaderText = "Số ngày nghỉ";
            dgvtl.Columns["tongluong"].HeaderText = "Tổng lương";
            dgvtl.Columns["tl"].HeaderText = "Thanh toán"; 
            dgvtl.Columns["ngaybd"].HeaderText = "Ngày bắt đầu"; 
            dgvtl.Columns["luongcb"].DefaultCellStyle.Format = "N0";
            dgvtl.Columns["tongluong"].DefaultCellStyle.Format = "N0";


        }
        public void showdata()
        {
            var rs = from nv in db.NhanViens
                     join
                     tl in db.TinhLuongs on nv.Username equals tl.IDusername
                     select new
                     {
                         ID = tl.ID,
                         username = nv.Username,
                         hoten = nv.HoVaTen,
                         luongcb = tl.LuongCB,
                         ngaybd = DateTime.Parse(tl.Ngaybatdau.ToString()).ToString("dd/MM/yyyy HH:mm"),
                         songaynghi = tl.songaynghi,
                         tongluong = new Phongtk().thanhtien2(Convert.ToDouble(tl.LuongCB * (DateTime.Now - (DateTime)tl.Ngaybatdau).TotalDays),Convert.ToInt32(tl.LuongCB * tl.songaynghi)),
                         tl = tl.Dathanhtoan == 0 ? "Chưa trả lương" : "Đã trả lương"

                     };


            dgvtl.DataSource = rs;

        }
        
        private void dgvtl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvtl.Rows[e.RowIndex];
                txtsnn.Text = r.Cells["songaynghi"].Value.ToString();
                txtlcb.Text = r.Cells["luongcb"].Value.ToString();
                date.Text = r.Cells["ngaybd"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new karaokeDataContext();

            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn trả lương", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var dvt = db.TinhLuongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["ID"].Value.ToString()));
            dvt.Dathanhtoan = 1;
            dvt.Ngaybatdau = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            db.SubmitChanges();
            MessageBox.Show("Thanh toán thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showdata();
            r = null;
            txtsnn.Text = txtlcb.Text  = null;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cập nhật", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                 
            var dvt = db.TinhLuongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["ID"].Value.ToString()));
            dvt.songaynghi = int.Parse(txtsnn.Text);
            dvt.LuongCB = int.Parse(txtlcb.Text);
            dvt.Ngaybatdau = DateTime.ParseExact(date.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            db.SubmitChanges();
            MessageBox.Show("Cập nhật thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showdata();
            r = null;
            txtsnn.Text = txtlcb.Text = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtlcb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
