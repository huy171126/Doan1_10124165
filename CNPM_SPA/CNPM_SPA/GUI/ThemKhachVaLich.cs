using CNPM_SPA.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SPA.GUI
{
    public partial class ThemKhachVaLich : UserControl
    {
        DatLichBLL bll = new DatLichBLL();

        public ThemKhachVaLich()
        {
            InitializeComponent();
        }

        // ================= LOAD FORM =================
        private void ThemKhachVaLich_Load(object sender, EventArgs e)
        {
            dtpthoigian.Format = DateTimePickerFormat.Custom;
            dtpthoigian.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpthoigian.ShowUpDown = true;

            dtpthoigian.Value = DateTime.Now;

        }

        // ================= THÊM KHÁCH =================
        private void btnthemkhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenkhachhang.Text.Trim() == "" ||
                    txtsodienthoai.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin khách hàng!");
                    return;
                }

                int diem = 0;

                if (txtdiemtichluy.Text.Trim() != "")
                    diem = int.Parse(txtdiemtichluy.Text);

                bll.ThemKhach(
                    txttenkhachhang.Text,
                    txtsodienthoai.Text,
                    diem
                );

                MessageBox.Show("Thêm khách hàng thành công!");

                ClearKhach();
            }
            catch
            {
                MessageBox.Show("Dữ liệu khách hàng không hợp lệ!");
            }
        }

        // ================= THÊM LỊCH ĐẶT =================
        private void btnthemlichdat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmakhachhang.Text.Trim() == "" ||
                    txtmanhanvien.Text.Trim() == "" ||
                    txtmaphong.Text.Trim() == "" ||
                    txtmadichvu.Text.Trim() == "")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin lịch đặt!");
                    return;
                }

                int makh = int.Parse(txtmakhachhang.Text);
                int manv = int.Parse(txtmanhanvien.Text);
                int maphong = int.Parse(txtmaphong.Text);
                int madv = int.Parse(txtmadichvu.Text);

                DateTime tg = dtpthoigian.Value;

                bll.ThemLich(makh, manv, maphong, madv, tg);

                MessageBox.Show("Đặt lịch thành công!");

                ClearLich();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================= CLEAR KHÁCH =================
        void ClearKhach()
        {
            txttenkhachhang.Clear();
            txtsodienthoai.Clear();
            txtdiemtichluy.Clear();
        }

        // ================= CLEAR LỊCH =================
        void ClearLich()
        {
            txtmakhachhang.Clear();
            txtmanhanvien.Clear();
            txtmaphong.Clear();
            txtmadichvu.Clear();
        }

        // ================= DATETIME =================
        private void dtpthoigian_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
