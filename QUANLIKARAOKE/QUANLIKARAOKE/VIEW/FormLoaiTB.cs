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
    public partial class FormLoaiTB : Form
    {
        public FormLoaiTB()
        {
            InitializeComponent();
        }
        private karaokeDataContext db;
        private LoaiTBBLL bll = new LoaiTBBLL();

        private void FormLoaiTB_Load(object sender, EventArgs e)
        {
            db = new karaokeDataContext();
            loaddata();
            dgvthietbi.Columns["id"].Width = 100;
            dgvthietbi.Columns["id"].HeaderText = "Mã Loại";
            dgvthietbi.Columns["TenLoaiTB"].HeaderText = "Tên Loại Thiết Bị";
            dgvthietbi.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvthietbi.Columns["TenLoaiTB"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvthietbi.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dgvthietbi.MultiSelect = false;
        }
        public void loaddata()
        {
            var ltb = (from t in db.LoaiThietBis
                      select new
                      {
                          t.ID,
                          t.TenLoaiTB,
                      }).OrderBy(x => x.TenLoaiTB);
            dgvthietbi.DataSource = ltb;
        }
        private DataGridViewRow r;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại thiết bị", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Select();
                return;
            }
            var lp = new LoaiThietBi();
            lp.TenLoaiTB = txtname.Text;
            bll.themLoaiThietBi(lp);
         /*   db.LoaiThietBis.InsertOnSubmit(lp);
            db.SubmitChanges();*/
            loaddata();
            MessageBox.Show("Thêm mới thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtname.Text = null;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn loại thiết bịcần sửa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                var dvt = db.LoaiThietBis.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                dvt.TenLoaiTB = txtname.Text;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                r = null;
                txtname.Text = null;

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị cần xóa", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (MessageBox.Show("Bạn thật sự muốn xóa loại thiết bị" + r.Cells["TenLoaiTB"].Value.ToString() + "?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var dvt = db.LoaiThietBis.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    bll.xoa(int.Parse(r.Cells["id"].Value.ToString()));
                    /*db.SubmitChanges();*/
                    MessageBox.Show("Xóa thành công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                    r = null;
                    txtname.Text = null;

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw;
                }
            }
        }

        private void dgvthietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvthietbi.Rows[e.RowIndex];
                txtname.Text = r.Cells["TenLoaiTB"].Value.ToString();
            }
        }
    }
}
