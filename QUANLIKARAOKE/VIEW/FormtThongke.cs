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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

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
            panel2.Controls.Clear();
            CartesianChart chart = new CartesianChart();
            CartesianChart chart1 = new CartesianChart();
            CartesianChart chart3 = new CartesianChart();


            r = null;
          
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
                            chart.Series.Clear();
                            Axis axisX = new Axis
                            {
                                Title = "Tên dữ liệu",
                                Labels = new List<string>()  // Khởi tạo axisX.Labels là một List<string>
                            };

                            ColumnSeries series = new ColumnSeries
                            {
                                Title = "Doanhthu",
                                Values = new ChartValues<int>()
                            };
                            for (int i = 0; i < r.Count; i++)
                            {
                                axisX.Labels.Add(r[i].MatHang);
                                series.Values.Add(i);
                            }
                            // Thêm Series vào Chart
                            chart.Series.Add(series);
                            for (int i = 0; i < r.Count; i++)
                            {
                                series.Values[i] = r[i].ThanhTien;  // Giá trị cột đầu tiên

                            }
                            chart.AxisX.Add(axisX);
                            chart.Width = panel2.Width;
                            chart.Height = panel2.Height;
                            chart.Parent = panel2;
                        }
                        else
                        {
                            r = thongkehang(tungay, toingay, null);
                            Axis axisX = new Axis
                            {
                                Title = "Tên dữ liệu",
                                Labels = new List<string>()  // Khởi tạo axisX.Labels là một List<string>
                            };
                          
                            ColumnSeries series = new ColumnSeries
                            {
                                Title = "Doanhthu",
                                Values = new ChartValues<int> ()
                            };
                            for (int i = 0; i < r.Count; i++)
                            {
                                axisX.Labels.Add(r[i].MatHang);
                                series.Values.Add(i);
                            }
                            // Thêm Series vào Chart
                            chart.Series.Add(series);
                            for (int i = 0; i < r.Count; i++)
                            {
                                series.Values[i] = r[i].ThanhTien;  // Giá trị cột đầu tiên

                            }
                            chart.AxisX.Add(axisX);
                            chart.Width = panel2.Width;
                            chart.Height = panel2.Height;
                            chart.Parent = panel2;
                        }
                    }
                    else if (rp.Checked)
                    {
                        if (comboBox1.SelectedIndex >= 0)
                        {
                            key = comboBox1.SelectedValue.ToString();
                            /*dgvtk.DataSource = null;*/
                            r = thongkephong(tungay, toingay, key);
                            chart.Series.Clear();
                            Axis axisX = new Axis
                            {
                                Title = "Tên dữ liệu",
                                Labels = new List<string>()  // Khởi tạo axisX.Labels là một List<string>
                            };

                            ColumnSeries series = new ColumnSeries
                            {
                                Title = "Doanhthu",
                                Values = new ChartValues<int>()
                            };
                            for (int i = 0; i < r.Count; i++)
                            {
                                axisX.Labels.Add(r[i].MatHang);
                                series.Values.Add(i);
                            }
                            // Thêm Series vào Chart
                            chart.Series.Add(series);
                            for (int i = 0; i < r.Count; i++)
                            {
                                series.Values[i] = r[i].ThanhTien;  // Giá trị cột đầu tiên

                            }
                            chart.AxisX.Add(axisX);
                            chart.Width = panel2.Width;
                            chart.Height = panel2.Height;
                            chart.Parent = panel2;
                        }
                        else
                        {
                            r = thongkephong(tungay, toingay, null);
                            chart.Series.Clear();
                            Axis axisX = new Axis
                            {
                                Title = "Tên dữ liệu",
                                Labels = new List<string>()  // Khởi tạo axisX.Labels là một List<string>
                            };

                            ColumnSeries series = new ColumnSeries
                            {
                                Title = "Doanh thu",
                                Values = new ChartValues<int>()
                            };
                            for (int i = 0; i < r.Count; i++)
                            {
                                axisX.Labels.Add(r[i].MatHang);
                                series.Values.Add(i);
                            }
                            // Thêm Series vào Chart
                            chart1.Series.Add(series);
                            for (int i = 0; i < r.Count; i++)
                            {
                                series.Values[i] = r[i].ThanhTien;  // Giá trị cột đầu tiên

                            }
                            chart1.AxisX.Add(axisX);
                            chart1.Width = panel2.Width;
                            chart1.Height = panel2.Height;
                            chart1.Parent = panel2;

                        }
                    }
                    else
                    {
                        r = thongkephong(tungay, toingay,null);
                        r.AddRange(thongkehang(tungay, toingay,null));
                        chart.Series.Clear();
                        Axis axisX = new Axis
                        {
                            Title = "Tên dữ liệu",
                            Labels = new List<string> {"Phòng","Mặt hàng" } // Khởi tạo axisX.Labels là một List<string>
                        };

                        ColumnSeries series = new ColumnSeries
                        {
                            Title = "Doanh thu",
                            Values = new ChartValues<int>()
                        };
                        for (int i = 0; i < r.Count; i++)
                        {
                            series.Values.Add(i);
                        }
                        // Thêm Series vào Chart
                        chart1.Series.Add(series);
                        for (int i = 0; i < r.Count; i++)
                        {
                            series.Values[i] = r[i].ThanhTien;  // Giá trị cột đầu tiên

                        }
                        chart1.AxisX.Add(axisX);
                        chart1.Width = panel2.Width;
                        chart1.Height = panel2.Height;
                        chart1.Parent = panel2;


                    }
                }
                var sum = r.Sum(x => x.ThanhTien);
                txtsum.Text = string.Format("Tổng tiền : {0:N0} VNĐ", sum);
                /* dgvtk.DataSource = r;*/

            }
            catch (Exception)
            {

                MessageBox.Show("Thời gian không hợp lệ", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
      /*      this.Controls.Add(chart);*/


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
