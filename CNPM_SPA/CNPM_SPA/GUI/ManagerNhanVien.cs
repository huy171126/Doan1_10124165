using CNPM_SPA.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SPA
{
    public partial class frManagerNhanVien : Form
    {
        public frManagerNhanVien()
        {
            InitializeComponent();
        }

        private void frManagerNhanVien_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            LichLamViec lich = new LichLamViec();
            lich.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(lich);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
            "Bạn có chắc muốn đăng xuất?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                frDangNhap f = new frDangNhap();
                f.Show();
                this.Close(); // đóng form hiện tại
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtThoiGian.ReadOnly = true;
        }
        private void btnthemkhachhangvalichdat_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            ThemKhachVaLich frm = new ThemKhachVaLich();

            frm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(frm);
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            LichLamViec frm = new LichLamViec();

            frm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(frm);

        }
    }
    
}
