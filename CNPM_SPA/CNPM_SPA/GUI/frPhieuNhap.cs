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
    public partial class frPhieuNhap : Form
    {
        NhapHangBLL bll = new NhapHangBLL();

        public frPhieuNhap()
        {
            InitializeComponent();
            txtngaynhap.ReadOnly = true;
        }

        private void btnxong_Click(object sender, EventArgs e)
        {
            try
            {
                int maNCC = Convert.ToInt32(txtncc.Text);
                int maSP = Convert.ToInt32(txtmasanpham.Text);
                int soLuong = Convert.ToInt32(txtsoluong.Text);
                decimal giaNhap = Convert.ToDecimal(txtgianhap.Text);

                DateTime ngay = DateTime.Now;

                // 1. tạo phiếu nhập
                int maNhap = bll.ThemPhieuNhap(maNCC, ngay);

                // 2. thêm chi tiết
                bll.ThemChiTiet(maNhap, maSP, soLuong, giaNhap);

                MessageBox.Show("Thêm phiếu nhập thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
