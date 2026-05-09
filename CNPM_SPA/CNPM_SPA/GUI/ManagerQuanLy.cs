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
    public partial class ManagerQuanLy : Form
    {
        public ManagerQuanLy()
        {
            InitializeComponent();
        }

        private void ManagerQuanLy_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TongQuan TongQuan = new TongQuan();
            TongQuan.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(TongQuan);
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
        void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();      
            uc.Dock = DockStyle.Fill;         
            pnlContent.Controls.Add(uc);      
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TongQuan tongquan = new TongQuan();
            LoadUserControl(tongquan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyHangHoa qlhh = new QuanLyHangHoa();
            LoadUserControl(qlhh);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyPhong qlp = new QuanLyPhong();
            LoadUserControl(qlp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyGiaoDich qlgd = new QuanLyGiaoDich();
            LoadUserControl(qlgd);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang qlkh = new QuanLyKhachHang();
            LoadUserControl(qlkh);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            LoadUserControl (qlnv);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SoQuy soquy = new SoQuy();
            LoadUserControl(soquy);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BaoCao baocao = new BaoCao();   
            LoadUserControl(baocao);
        }
    }
}
