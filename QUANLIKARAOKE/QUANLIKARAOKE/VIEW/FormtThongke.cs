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
    public partial class FormtThongke : Form
    {
        public karaokeDataContext db;
        public FormtThongke()
        {
            InitializeComponent();
        }



        private void rall_CheckedChanged_1(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            if (rall.Checked)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                if (rmh.Checked)
                {
                    comboBox1.DataSource = db.MatHangs.ToList();
                    comboBox1.DisplayMember = "TenMatHang";
                    comboBox1.ValueMember = "ID";
                }
                else
                {
                   
                    comboBox1.DataSource = db.Phongs;
                    comboBox1.DisplayMember = "TenPhong";
                    comboBox1.ValueMember = "ID";
                }
            }
        }

        private void FormtThongke_Load_1(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            maskbd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            maskkt.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            comboBox1.SelectedIndex = -1;
           
        }

        public List<ListTK> r;
        public int total;
        private void txtready_Click(object sender, EventArgs e)
        {
            DateTime tungay, toingay;
            string key = null;
            try
            {
                tungay = DateTime.ParseExact(maskbd.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                toingay = DateTime.ParseExact(maskkt.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                if (toingay <= tungay)
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (rmh.Checked)
                    {
                        if (comboBox1.SelectedIndex >= 0)
                        {
                            key = comboBox1.SelectedValue.ToString();
                            r = thongkehang(tungay, toingay, key);
                        }
                        else
                        {
                            r = thongkehang(tungay, toingay, null);
                        }
                    }
                    else if (rp.Checked)
                    {
                        if (comboBox1.SelectedIndex >= 0)
                        {
                            key = comboBox1.SelectedValue.ToString();
                            dgvtk.DataSource = null;
                            r = thongkephong(tungay, toingay, key);
                        }
                        else
                        {
                            r = thongkephong(tungay, toingay, null);
                        }
                    }
                    else
                    {
                        r = thongkephong(tungay, toingay,null);
                        r.AddRange(thongkehang(tungay, toingay,null));
                    }
                }
                var sum = r.Sum(x => x.ThanhTien);
                txtsum.Text = string.Format("Tổng tiền : {0:N0} VNĐ", sum);
                dgvtk.DataSource = r;

            }
            catch (Exception)
            {

                MessageBox.Show("Thời gian không hợp lệ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvtk.Columns["MatHang"].HeaderText = "Mặt Hàng";
            dgvtk.Columns["DVT"].HeaderText = "Tên ĐVT";
            dgvtk.Columns["DG"].HeaderText = "Đơn Gía";
            dgvtk.Columns["SL"].HeaderText = "Số Lượng";
            dgvtk.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvtk.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            dgvtk.Columns["ID"].Visible = false;

            dgvtk.Columns["MatHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        public List<ListTK> thongkephong(DateTime tungay,DateTime toingay,string key)
        {
            var rs = from h in db.HoaDonBanHangs.Where(x => x.ThoiGianKThuc != null && x.ThoiGianBDau>=tungay && x.ThoiGianBDau<=toingay)
                     join p in db.Phongs on h.IDPhong equals p.ID
                     select new ListTK
                     {
                         NgayGD = DateTime.Parse(h.ThoiGianBDau.ToString()).ToString("dd/MM/yyyy HH:mm"),
                         MatHang = p.TenPhong,
                         ID = p.ID.ToString(),
                         DVT = "Giờ",
                         DG = (int)h.DonGiaPhong,
                         SL = new Phongtk(((DateTime)h.ThoiGianKThuc - (DateTime)h.ThoiGianBDau).TotalHours).ToString(),
                         ThanhTien =  new Phongtk().thanhtien(((DateTime)h.ThoiGianKThuc - (DateTime)h.ThoiGianBDau).TotalHours, (int)h.DonGiaPhong)
                     };
           
            if (!string.IsNullOrEmpty(key))
            {
                return rs.ToList().Where(x => x.ID == key).ToList();

            }
            return rs.ToList();
           
        }
        public List<ListTK> thongkehang(DateTime tungay, DateTime toingay,string key)
        {
            var rs = from h in db.HoaDonBanHangs.Where(x => x.ThoiGianKThuc != null && x.ThoiGianBDau >= tungay && x.ThoiGianBDau <= toingay)
                     join ct in db.ChiTietHoaDonBans on h.IDHoaDon equals ct.IDHoaDon
                     join p in db.MatHangs on ct.IDMatHang equals p.ID
                     join dv in db.DonViTinhs on p.DVT equals dv.ID
                     select new ListTK
                     {
                         NgayGD = DateTime.Parse(h.ThoiGianBDau.ToString()).ToString("dd/MM/yyyy HH:mm"),
                         MatHang = p.TenMatHang,
                         ID = Convert.ToString(p.ID),
                         DVT = dv.TenDVT,
                         SL = ct.SL.ToString(),
                         DG = (int)ct.DonGiaBan,
                         ThanhTien = (int)ct.SL* (int)ct.DonGiaBan
                     };
            
            if (!string.IsNullOrEmpty(key))
            {
                return rs.ToList().Where(x => x.ID == key).ToList(); 
            }
            return rs.ToList();
        }

        private void rmh_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void rp_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }
    }
}
