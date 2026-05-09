using CNPM_SPA.BLL;
using CNPM_SPA.DTO;
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
    public partial class TongQuan : UserControl
    {
        public TongQuan()
        {
            this.Load += TongQuan_Load;
            InitializeComponent();
            txtdoanhthu.ReadOnly = true;
            txtkhachhang.ReadOnly = true;
            txtkhachdangpv.ReadOnly = true;
            txtkhachsapden.ReadOnly = true;
            txtdoanhthu7ngay.ReadOnly = true;
            txtdoanhthu30ngay.ReadOnly = true;
            txtkhach7ngay.ReadOnly = true;
            txtkhach30ngay.ReadOnly = true;
        }
        private void LoadThongKe()
        {
            try
            {
                ThongKeBLL bll = new ThongKeBLL();
                ThongKeDTO tk = bll.LayThongKe();

                txtdoanhthu.Text = tk.DoanhThuHomNay.ToString("N0");
                txtkhachhang.Text = tk.SoKhachTrongNgay.ToString();
                txtkhachdangpv.Text = tk.KhachDangPhucVu.ToString();
                txtkhachsapden.Text = tk.KhachSapDen.ToString();

                txtdoanhthu7ngay.Text = tk.DoanhThu7Ngay.ToString("N0");
                txtdoanhthu30ngay.Text = tk.DoanhThu30Ngay.ToString("N0");

                txtkhach7ngay.Text = tk.SoKhach7Ngay.ToString();
                txtkhach30ngay.Text = tk.SoKhach30Ngay.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thống kê: " + ex.Message);
            }
        }
        Timer timer = new Timer();

        private void TongQuan_Load(object sender, EventArgs e)
        {
            LoadThongKe();

            timer.Interval = 5000; // 5 giây
            timer.Tick += (s, ev) => LoadThongKe();
            timer.Start();
        }

        private void TongQuan_Load_1(object sender, EventArgs e)
        {

        }
    }
}
