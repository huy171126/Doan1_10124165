using CNPM_SPA.BLL;
using CNPM_SPA.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CNPM_SPA
{
    public partial class frDangNhap : Form
    {
        public frDangNhap()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!");
                txtTenDangNhap.Focus();
                return;
            }

            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }

            try
            {
                TaiKhoanDTO tk = new TaiKhoanDTO()
                {
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim()
                };

                TaiKhoanBLL bll = new TaiKhoanBLL();
                string vaiTro = bll.DangNhap(tk);

                if (vaiTro == "Admin")
                {
                    new ManagerQuanLy().Show();
                    this.Hide();
                }
                else if (vaiTro == "NhanVien")
                {
                    new frManagerNhanVien().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:\n" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false; 
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true; 
            }
        }

        private void frDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}