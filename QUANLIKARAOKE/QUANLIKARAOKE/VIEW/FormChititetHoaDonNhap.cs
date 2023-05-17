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
    public partial class FormChititetHoaDonNhap : Form
    {
        public FormChititetHoaDonNhap(long idhdn,byte danhapkho)
        {
            this.idhdn = idhdn;
            this.danhapkho = danhapkho;
            InitializeComponent();
        }
        private byte danhapkho;
        private long idhdn;
        private string nhanvien = "admin";
        private karaokeDataContext db;
        private DataGridViewRow r;
        public void loaddata()
        {
            
            var lp = (from
                     cn in db.ChiTietHoaDonNhaps.Where(x=>x.IDHoaDon==idhdn)
                      join m in db.MatHangs
                      on cn.IDMatHang equals m.ID
                      join d in db.DonViTinhs on m.DVT equals d.ID
                      select new
                      {
                          idmh = m.ID,
                          mathang = m.TenMatHang,
                          dvt = d.TenDVT,
                          sl = cn.SoLuong,
                          dg = cn.DonGiaNhap,
                          thanhtien = cn.SoLuong * cn.DonGiaNhap
                      });
            dgchititet.DataSource = lp;
            tongtien.Text = String.Format("{0:N0}", lp.Sum(x => x.thanhtien));
        }
        private void FormChititetHoaDonNhap_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            var hdn = db.HoaDonNhaps.SingleOrDefault(x => x.ID == idhdn);
            if (hdn.DaNhap == 1)
            {
                btnxoa.Enabled = false;
            }
            loaddata();
            var lp = (from
                     m in db.MatHangs
                      join d in db.DonViTinhs on m.DVT equals d.ID
                      select new
                      {
                          TenMatHang = m.TenMatHang + " - " + d.TenDVT,
                          ID = m.ID
                      });
            cbmh.DataSource = lp;
            cbmh.DisplayMember = "TenMatHang";
            cbmh.ValueMember = "ID";
            cbmh.SelectedIndex = -1;
            dgchititet.Columns["dvt"].HeaderText = "Đơn vị";
            dgchititet.Columns["sl"].HeaderText = "Số Lượng";
            dgchititet.Columns["dg"].HeaderText = "Đơn Giá";
            dgchititet.Columns["thanhtien"].HeaderText = "Thành tiền";
            dgchititet.Columns["mathang"].HeaderText = "Tên Mặt Hàng";
            dgchititet.Columns["mathang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgchititet.Columns["thanhtien"].DefaultCellStyle.Format = "N0";
            dgchititet.Columns["dg"].DefaultCellStyle.Format = "N0";
            dgchititet.SelectionMode =
         DataGridViewSelectionMode.FullRowSelect;
            dgchititet.MultiSelect = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbmh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần nhập", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ct = new ChiTietHoaDonNhap();
            var item = db.ChiTietHoaDonNhaps.FirstOrDefault(x => x.IDHoaDon == idhdn && x.IDMatHang == int.Parse(cbmh.SelectedValue.ToString()));
            if (item == null)
            {
                ct.IDHoaDon = idhdn;
                ct.IDMatHang = int.Parse(cbmh.SelectedValue.ToString());
                ct.DonGiaNhap = int.Parse(txtdg.Text);
                ct.SoLuong = int.Parse(txtsl.Text);
                db.ChiTietHoaDonNhaps.InsertOnSubmit(ct);
                db.SubmitChanges();
            }
            else
            {
                item.SoLuong+= int.Parse(txtsl.Text);
                db.SubmitChanges();

            }


            loaddata();

        }
        private void dgchititet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgchititet.Rows[e.RowIndex];
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgchititet.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm mặt hàng vào hóa đơn", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            var hd = db.HoaDonNhaps.SingleOrDefault(x => x.ID == idhdn);
            hd.TienThanhToan = int.Parse(txttt.Text);
            hd.DaNhap = ryeucau.Checked ? (byte)0 : (byte)1;
            db.SubmitChanges();
            this.Dispose();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (MessageBox.Show("Bạn thật sự muốn xóa mặt hàng " + r.Cells["mathang"].Value.ToString() + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var dvt = db.ChiTietHoaDonNhaps.FirstOrDefault(x => x.IDHoaDon == idhdn && x.IDMatHang == int.Parse(r.Cells["idmh"].Value.ToString()));
                    db.ChiTietHoaDonNhaps.DeleteOnSubmit(dvt);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    r = null;

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
        }

        private void rnhapkho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ryeucau_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rnhapkho_Click(object sender, EventArgs e)
        {
            if (ryeucau.Checked)
            {
                txttt.Enabled = false;
                txttt.Text = "0";
            }
            else
            {
                txttt.Enabled = true;
            }
        }
    }
    
}
