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
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }
        private karaokeDataContext db;
        private ListView l;
        string tenphong;
        private long idhd = 0;
        private int idp = 0;
        private int idlp = 0;
        string nhanvien = "admin";
        private int tabindex = 0;
        private int idmathang = 0;



        public void FormBanHang_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();

            var dslp = db.LoaiPhongs;

            foreach (var p in dslp)
            {
                TabPage tp = new TabPage(p.TenLoaiPhong);
                tp.Name = p.ID.ToString();
                tabct1.Controls.Add(tp);
            }
            idlp = db.LoaiPhongs.Min(x => x.ID);

            dgvdadung.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dgvdadung.MultiSelect = false;
            dgvmathang.SelectionMode =
             DataGridViewSelectionMode.FullRowSelect;
            dgvmathang.MultiSelect = false;
            dvgls.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dvgls.MultiSelect = false;
            loaddata(idlp,tabindex);
            showdata();
            showls();
        }
        public void loaddata(int lp, int tab)
        {
            tabct1.TabPages[tabindex].Controls.Clear();
            l = new ListView();
            l.Dock = DockStyle.Fill;

            ImageList img = new ImageList();
            img.ImageSize = new Size(126, 126);
            img.Images.Add(Properties.Resources.karaoke);
            img.Images.Add(Properties.Resources.singing);

            l.LargeImageList = img;
            l.SelectedIndexChanged += lv_SelectedIndexChanged;
            var dsp = db.Phongs.Where(X => X.IDLoaiPhong == lp);
            foreach (var ph in dsp)
            {
                if (ph.TrangThai == 1)
                {
                    l.Items.Add(new ListViewItem { ImageIndex = 1, Text = ph.TenPhong, Name = ph.ID.ToString(), Tag = true });
                }
                else
                {
                    l.Items.Add(new ListViewItem { ImageIndex = 0, Text = ph.TenPhong, Name = ph.ID.ToString(), Tag = false }); ;

                }
            }
            tabct1.TabPages[tab].Controls.Add(l);

        }


        public void showdata()
        {
            var nhap = from p in db.ChiTietHoaDonNhaps.GroupBy(x => x.IDMatHang)
                       select new
                       {
                           mahang = p.First().IDMatHang,
                           tongnhap = p.Sum(x => x.SoLuong)

                       };
            var xuat = from p in db.ChiTietHoaDonBans.GroupBy(x => x.IDMatHang)
                       select new
                       {
                           mahang = p.First().IDMatHang,
                           tongxuat = p.Sum(x => x.SL)
                       };
            var khadung = from p in nhap
                          join q in xuat on p.mahang equals q.mahang
                          into t
                          join h in db.MatHangs on p.mahang equals h.ID
                          join d in db.DonViTinhs on h.DVT equals d.ID
                          from s in t.DefaultIfEmpty()
                          select new
                          {
                              mahang = p.mahang,
                              tenhang = h.TenMatHang,
                              dvt = d.TenDVT,
                              dongia = h.DonGiaBan,
                              tonkho = s.mahang == null ? p.tongnhap:p.tongnhap - s.tongxuat

                          };
              
            dgvmathang.DataSource = khadung.OrderBy(x => x.tenhang);
            dgvmathang.Columns["mahang"].Visible = false;
            dgvmathang.Columns["tonkho"].HeaderText = "Tồn";
            dgvmathang.Columns["dongia"].HeaderText = "Đơn Giá";
            dgvmathang.Columns["tenhang"].HeaderText = "Mặt Hàng";
            dgvmathang.Columns["dvt"].HeaderText = "ĐVT";



        }


            private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indx = l.SelectedIndices;
            if (indx.Count > 0)
            {
                idp = int.Parse(l.SelectedItems[0].Name);
                tenphong = l.SelectedItems[0].Text.ToUpper();
                txtphong.Text = tenphong;
                var tt = db.Phongs.FirstOrDefault(x => x.ID == idp);
                label1.Text = tt.TrangThai == 0 ? "CÒN TRỐNG" : "ĐANG SỬ DỤNG";
                if ((bool)l.SelectedItems[0].Tag)
                {
                    /*         var hd = db.HoaDonBanHangs.FirstOrDefault(x => x.IDHoaDon == db.HoaDonBanHangs.Where(y => y.IDPhong == idp).Max(z => z.IDPhong));*/
                    var id = db.HoaDonBanHangs.FirstOrDefault(y => y.IDPhong == idp);
                    var hd = db.HoaDonBanHangs.FirstOrDefault(x => x.IDHoaDon == id.IDHoaDon);
                    idhd = hd.IDHoaDon;
                    timer1.Enabled = false;
                    maskbd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    maskkt.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    showmathang();
                }
                else
                {
                    dgvdadung.DataSource = null;
                    maskbd.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    maskkt.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                }
            }
            else
            {
                dgvdadung.DataSource = null;
            }
        }
        public void showmathang()
        {
            db = new karaokeDataContext();
            
            var rs = from ct in db.ChiTietHoaDonBans.Where(x => x.IDHoaDon == idhd)
                     join h in db.MatHangs on ct.IDMatHang equals h.ID
                     join d in db.DonViTinhs on h.DVT equals d.ID
                     select new
                     {
                         mahang = h.ID,
                         tenhang = h.TenMatHang,
                         dvt = d.TenDVT,
                         sl = ct.SL,
                         dg = ct.DonGiaBan,
                         thanhtien = ct.SL * ct.DonGiaBan
                     };
            dgvdadung.DataSource = rs;
            dgvdadung.Columns["dg"].HeaderText = "Đơn Giá";
            dgvdadung.Columns["tenhang"].HeaderText = "Mặt Hàng";
            dgvdadung.Columns["dvt"].HeaderText = "ĐVT";
            dgvdadung.Columns["sl"].HeaderText = "số lượng";
            dgvdadung.Columns["thanhtien"].HeaderText = "Thành tiền";
        }

        private void dgvmathang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (idp == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng tiếp tục", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (e.RowIndex >=0)
            {
                
                var r = dgvmathang.Rows[e.RowIndex];
                idmathang = int.Parse(r.Cells["mahang"].Value.ToString());
                new FormOrder(idhd,tenphong,idmathang,r).ShowDialog();
                showdata();
                showmathang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng tiếp tục", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void tabct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idlp = int.Parse(tabct1.SelectedTab.Name);
            tabindex = tabct1.SelectedIndex;
            loaddata(idlp, tabindex);
            showdata();
        }
        private void txtready_Click(object sender, EventArgs e)
        {
            try
            {
                var lp = db.LoaiPhongs.SingleOrDefault(x => x.ID == idlp);
                var o = new HoaDonBanHang();
                o.IDPhong = idp;
                o.NguoiBan = nhanvien;
                o.ThoiGianBDau = DateTime.ParseExact(maskbd.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                o.ThoiGianKThuc = DateTime.ParseExact(maskbd.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                o.DonGiaPhong = lp.DonGia;
                o.Nguoitao = nhanvien;
                db.HoaDonBanHangs.InsertOnSubmit(o);
                db.SubmitChanges();
                var p = db.Phongs.SingleOrDefault(x => x.ID == idp);
                p.TrangThai = 1;
                db.SubmitChanges();
                loaddata(idlp, tabindex);
                MessageBox.Show("ĐẶT PHÒNG THÀNH CÔNG", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception)
            {
                MessageBox.Show("ĐẶT PHÒNG THẤT BẠI", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var o = db.HoaDonBanHangs.SingleOrDefault(x=>x.IDHoaDon==idhd);
               
                o.ThoiGianKThuc = DateTime.ParseExact(maskkt.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                db.SubmitChanges();
                var p = db.Phongs.SingleOrDefault(x => x.ID == idp);
                p.TrangThai = 0;
                db.SubmitChanges();
                MessageBox.Show("THANH TOÁN PHÒNG THÀNH CÔNG", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata(idlp, tabindex);
                idhd = o.IDHoaDon;
                Inhoadon();
            }
            catch (Exception)
            {
                MessageBox.Show("THANH TOÁN PHÒNG THẤT BẠI", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void showls()
        {

            var ls2 = from hd in db.HoaDonBanHangs.Where(x => x.ThoiGianKThuc != null)
                       join ct in db.ChiTietHoaDonBans
                       on hd.IDHoaDon equals ct.IDHoaDon
                       join mh in db.MatHangs on ct.IDMatHang equals mh.ID
                                  select new
                                  {
                                      tenmathang = mh.TenMatHang,
                                      sl = ct.SL,

                                  };
            string a = "";
            foreach (var item in ls2)
            {
              a += item.tenmathang +"-"+item.sl+"/";
            }
            var ls = from hd in db.HoaDonBanHangs.Where(x => x.ThoiGianKThuc != null)
                     join p in db.Phongs on hd.IDPhong equals p.ID
                     join ct in db.ChiTietHoaDonBans.GroupBy(x => x.IDHoaDon)
                     on hd.IDHoaDon equals ct.First().IDHoaDon
                     join mh in db.MatHangs on ct.First().IDMatHang equals mh.ID
                     select new
                     {
                         idhoadon = hd.IDHoaDon,
                         phong = p.TenPhong,
                         tenmathang = a,
                         Tgbd = hd.ThoiGianBDau,
                         tgkt = hd.ThoiGianKThuc,
                         sogio = (int)((TimeSpan)((DateTime)hd.ThoiGianKThuc - (DateTime)hd.ThoiGianBDau)).TotalHours,
                         sotien = (int)((TimeSpan)((DateTime)hd.ThoiGianKThuc - (DateTime)hd.ThoiGianBDau)).TotalHours * hd.DonGiaPhong+ct.Sum(x=>x.SL*x.DonGiaBan)

                     };
            
            dvgls.DataSource = ls;
            dvgls.Columns["idhoadon"].Visible = false;
            dvgls.Columns["phong"].HeaderText = "Phòng";
            dvgls.Columns["phong"].Width = 50;
            dvgls.Columns["sogio"].Width = 50;

            dvgls.Columns["Tgbd"].HeaderText = "TG bắt đầu";
            dvgls.Columns["tgkt"].HeaderText = "TG kết thúc";
            dvgls.Columns["sotien"].HeaderText = "Tổng thanh toán";
            dvgls.Columns["sotien"].DefaultCellStyle.Format = "N0";
            dvgls.Columns["tenmathang"].HeaderText = "tên mặt hàng- số lượng";
            dvgls.Columns["Tgbd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dvgls.Columns["tgkt"].AutoSizeMode =DataGridViewAutoSizeColumnMode.Fill;
            dvgls.Columns["tenmathang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        public void Inhoadon()
        {
            pdd1.Document = pd1;
            pdd1.ShowDialog();
        }

        private void pd1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string tencuahang = "DANG HOANG";
            string diachi = "105-NHÂN HÒA-MỸ HÀO-HƯNG YÊN";
            string sdt = "0123456789";

            var hd = db.HoaDonBanHangs.SingleOrDefault(x => x.IDHoaDon == idhd);
            var w = pd1.DefaultPageSettings.PaperSize.Width;
            e.Graphics.DrawString(tencuahang.ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, 20));


            e.Graphics.DrawString(String.Format("HD{0}",hd.IDHoaDon), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2+200, 20));
           
            e.Graphics.DrawString(String.Format("HD{0} - {1}",diachi,sdt), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, 45));
            e.Graphics.DrawString(String.Format("HD{0}",DateTime.Now.ToString()), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 170, 45));
            Pen pen = new Pen(Color.Black, 1);
            var y = 70;
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(pen, p1, p2);
            y += 10;
            e.Graphics.DrawString(String.Format("Giờ bắt đầu :{0}",((DateTime)hd.ThoiGianBDau).ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10,y));
            e.Graphics.DrawString(String.Format("Giờ kết thúc :{0}", ((DateTime)hd.ThoiGianKThuc).ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2, y));
            y += 20;
            int sum = 0;
            var tgsd = ((DateTime)hd.ThoiGianKThuc - (DateTime)hd.ThoiGianBDau).TotalMinutes;
            var gio = (int)(tgsd / 60);
            var phut = tgsd % 60;
            var tienphong = (int)Math.Round((double)(tgsd / 60 * hd.DonGiaPhong) / 1000, 3) * 1000;
            sum += tienphong;
            e.Graphics.DrawString(String.Format("Thời gian sử dụng: {0}:{1}",gio,phut), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString(String.Format("Thành tiền: {0:N0} VNĐ",tienphong), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2, y));
            y += 20;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(pen, p1, p2);
            y += 10;
            e.Graphics.DrawString("STT", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString("Mặt hàng/dịch vụ", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
            e.Graphics.DrawString("SL", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w/2+100, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));
            var rs = from ct in db.ChiTietHoaDonBans.Where(x => x.IDHoaDon == idhd)
                     join h in db.MatHangs on ct.IDMatHang equals h.ID
                     join d in db.DonViTinhs on h.DVT equals d.ID
                     select new
                     {
                         mahang = h.ID,
                         tenhang = h.TenMatHang,
                         dvt = d.TenDVT,
                         sl = ct.SL,
                         dg = ct.DonGiaBan,
                         thanhtien = ct.SL * ct.DonGiaBan
                     };
            int i = 1;
            y += 20;
            foreach (var item in rs)
            {
                e.Graphics.DrawString(String.Format("{0}",i++), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));
                e.Graphics.DrawString(item.tenhang, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
                e.Graphics.DrawString(String.Format("{0}",item.sl), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
                e.Graphics.DrawString(String.Format("{0:N0}", item.dg), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
                e.Graphics.DrawString(String.Format("{0:N0}", item.thanhtien), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));
                y += 20;
            }
            y += 40;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(pen, p1, p2);
            y += 20;
            e.Graphics.DrawString(String.Format("Tổng tiền: {0:N0} VNĐ",sum), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w - 280, y));
            y += 20;
            y += 40;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawString(String.Format("Thành chữ: {0}", NumberToText(sum)), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, y));

        }

        private void dvgls_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idhd = int.Parse(dvgls.Rows[e.RowIndex].Cells["idhoadon"].Value.ToString());
                Inhoadon();
            }
        }
        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");
        }

        private void txtphong_Click(object sender, EventArgs e)
        {

        }
    }
         
}
