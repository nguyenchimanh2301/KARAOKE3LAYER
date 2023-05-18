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
    public partial class FormThietBi : Form
    {
        public FormThietBi()
        {
            InitializeComponent();
        }
        private karaokeDataContext db;
        private DataGridViewRow r;
        private ThietBiBLL bll = new ThietBiBLL();
        private void FormThietBi_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            showdata();
            cbltb.DataSource = db.LoaiThietBis;
            cbltb.DisplayMember = "TenLoaiTB";
            cbltb.ValueMember = "ID";
            cbltb.SelectedIndex = -1;
            dgvmt.Columns["id"].Visible= false;
            dgvmt.Columns["Mausac"].HeaderText = "Màu sắc";
            dgvmt.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvmt.Columns["Kichthuoc"].HeaderText = "Kích thước";

            dgvmt.Columns["TenThietBi"].HeaderText = "Tên thiết bị";
            dgvmt.Columns["TenThietBi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvmt.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dgvmt.MultiSelect = false;
        }
        public void showdata()
        {
            var mt = from tb in db.ThietBis
                     join h in db.LoaiThietBis on tb.IDLoaiTB  equals h.ID
                     select new
                     {
                         tb.ID,
                         h.TenLoaiTB,
                         tb.TenThietBi,
                         tb.Mausac,
                         tb.Kichthuoc,
                         tb.DonGia

                     };
            dgvmt.DataSource = mt;
            //load dữ liệu ra data gridview

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (MessageBox.Show("Bạn thật sự muốn xóa thiết bị " + r.Cells["TenThietBi"].Value.ToString() + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var dvt = db.ThietBis.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    bll.xoa(int.Parse(r.Cells["id"].Value.ToString()));
                    /*  db.ThietBis.DeleteOnSubmit(dvt);
                    db.SubmitChanges();*/
                    MessageBox.Show("Xóa thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    r = null;
                    cbltb.SelectedIndex = -1;
                    txtdongia.Text = "0";
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtkichco.Text = "nosize";
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Select();
                return;
            }
            if (cbltb.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtdongia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá bán", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mh = new ThietBi();
            mh.TenThietBi = txtname.Text;
            mh.IDLoaiTB = int.Parse(cbltb.SelectedValue.ToString());
            mh.Mausac = txtmausac.Text;
            mh.Kichthuoc = txtkichco.Text;
            mh.DonGia = int.Parse(txtdongia.Text);
            bll.themThietBi(mh);
           /* db.ThietBis.InsertOnSubmit(mh);
            db.SubmitChanges();*/
            showdata();
            MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtdongia.Text = "0";
            txtname.Text = null;
            txtmausac.Text = mh.Kichthuoc = null;
            cbltb.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dgvmt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvmt.Rows[e.RowIndex];
                txtdongia.Text = r.Cells["DonGia"].Value.ToString();
                cbltb.Text = r.Cells["TenLoaiTB"].Value.ToString();
                txtname.Text = r.Cells["TenThietBi"].Value.ToString();
                txtmausac.Text = r.Cells["Mausac"].Value.ToString();
                if (r.Cells["Kichthuoc"].Value.ToString() == null)
                {
                    txtkichco.Text = "n";
                }
                else
                {
                    txtkichco.Text = r.Cells["Kichthuoc"].Value.ToString();
                }
            }
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần sửa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                var mh = db.ThietBis.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                mh.TenThietBi = txtname.Text;
                mh.IDLoaiTB = int.Parse(cbltb.SelectedValue.ToString());
                mh.Mausac = txtmausac.Text;
                mh.Kichthuoc = txtkichco.Text;
                mh.DonGia = int.Parse(txtdongia.Text);
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata();
                r = null;
                cbltb.SelectedIndex = -1;
                txtdongia.Text = "0";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
