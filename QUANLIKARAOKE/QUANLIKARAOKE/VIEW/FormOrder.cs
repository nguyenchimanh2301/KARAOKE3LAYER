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
    public partial class FormOrder : Form
    {
        public long idhd;
        private string tenphong;
        private DataGridViewRow r;
        private karaokeDataContext db;
        private string idphong;
        private int idmh;

        public FormOrder(long idhd,string tenphong, int idmh, DataGridViewRow r)
        {
            this.idmh = idmh;
            this.idhd= idhd;
            this.r = r;
            this.tenphong = tenphong;
            InitializeComponent();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            
            this.lbname.Text ="MẶT HÀNG YÊU CẦU:" + r.Cells["tenhang"].Value.ToString().ToUpper();
            this.phongtxt.Text = String.Format("Phòng phục vụ {0}", tenphong);
            
        }

        private void butxn_Click(object sender, EventArgs e)
        {
            int sl = 0;
            int tonkho = 0;
            try
            {
                sl = int.Parse(textsl.Text);
                var kho = db.ChiTietHoaDonNhaps.Where(x => x.IDMatHang == idmh && x.SoLuong >= 0);
                foreach (var item in kho)
                {
                    tonkho = int.Parse(item.SoLuong.ToString());
                }
                if (sl == 0 || sl > tonkho)
                {
                    MessageBox.Show("Số Lượng không hợp lệ", "Ràng buộc dữ liệu");
                    textsl.Select();
                    return;
                }
                else
                {
                    var ct = new ChiTietHoaDonBan();
                    var item = db.ChiTietHoaDonBans.SingleOrDefault(x => x.IDHoaDon == idhd && x.IDMatHang == int.Parse(r.Cells["mahang"].Value.ToString()));
                    if (item != null)
                    {
                        item.SL += sl;
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mặt hàng vào phòng " + tenphong + " thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                                

                        ct.IDHoaDon = idhd;
                        ct.IDMatHang = int.Parse(r.Cells["mahang"].Value.ToString());
                        ct.SL = sl;
                        var mh = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["mahang"].Value.ToString()));
                        ct.DonGiaBan = mh.DonGiaBan;
                        db.ChiTietHoaDonBans.InsertOnSubmit(ct);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mặt hàng vào phòng " + tenphong + " thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Số Lượng không hợp lệ", "Ràng buộc dữ liệu");
                textsl.Select();
                return;
            }
           
            
        }
    }
}
