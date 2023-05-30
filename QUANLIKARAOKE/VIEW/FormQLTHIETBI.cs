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
    public partial class FormQLTHIETBI : Form
    {
        public FormQLTHIETBI()
        {
            InitializeComponent();
        }
        public void addform(Form f,GroupBox gr)
        {
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.TopMost = true;
            gr.Controls.Clear();
            gr.Controls.Add(f);
            f.Show();
        }
        private void FormQLTHIETBI_Load(object sender, EventArgs e)
        {
            FormThietBi f = new FormThietBi();
            FormLoaiTB l = new FormLoaiTB();
            addform(l, groupBox1);
            addform(f, groupBox2);
        }
    }
}
