using CNPM_SPA.BLL;
using System;
using System.Windows.Forms;

namespace CNPM_SPA.GUI
{
    public partial class frHoaDon : Form
    {
        HoaDonBLL bll = new HoaDonBLL();

        public frHoaDon()
        {
            InitializeComponent();

            txttongtien.ReadOnly = true;
            txtngaynhap.ReadOnly = true;
            txtgia.ReadOnly = true;
        }

        private void btnxong_Click(object sender, EventArgs e)
        {
            try
            {
                int maKH = Convert.ToInt32(txtmakhachhang.Text);
                int maNV = Convert.ToInt32(txtmanhanvien.Text);
                int maSP = Convert.ToInt32(txtmasanpham.Text);
                int soLuong = Convert.ToInt32(txtsoluong.Text);

                DateTime ngay = DateTime.Now;

                // Tạo hóa đơn
                int maHD = bll.ThemHoaDon(maKH, maNV, ngay);

                // Thêm chi tiết
                bll.ThemChiTiet(maHD, maSP, soLuong);

                // Tổng tiền gốc
                decimal tongTienGoc = bll.LayTongTien(maHD);

                // % giảm
                decimal phanTramGiam = bll.LayPhanTramGiam(maKH, maSP);

                // Tiền giảm
                decimal tienGiam = tongTienGoc * phanTramGiam / 100;

                // Tổng sau giảm
                decimal tongSauGiam = tongTienGoc - tienGiam;

                // Update tổng tiền
                bll.CapNhatTongTien(maHD, tongSauGiam);

                txttongtien.Text = tongSauGiam.ToString("N0");

                decimal giaHienThi = Convert.ToDecimal(txtgia.Text);

                string thongBao =
                    "THÊM HÓA ĐƠN THÀNH CÔNG\n\n" +
                    "Mã hóa đơn: " + maHD + "\n" +
                    "Mã khách hàng: " + maKH + "\n" +
                    "Mã nhân viên: " + maNV + "\n" +
                    "Mã sản phẩm: " + maSP + "\n" +
                    "Số lượng: " + soLuong + "\n" +
                    "Giá sản phẩm: " + giaHienThi.ToString("N0") + " VNĐ\n" +
                    "Tổng gốc: " + tongTienGoc.ToString("N0") + " VNĐ\n" +
                    "Giảm giá: " + phanTramGiam + "%\n" +
                    "Tiền giảm: " + tienGiam.ToString("N0") + " VNĐ\n" +
                    "Tổng thanh toán: " + tongSauGiam.ToString("N0") + " VNĐ\n" +
                    "Ngày lập: " + ngay.ToString("dd/MM/yyyy HH:mm");

                MessageBox.Show(thongBao,
                    "Thông tin hóa đơn",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtmasanpham.Text, out int maSP))
            {
                decimal gia = bll.LayGiaSanPham(maSP);

                txtgia.Text = gia.ToString("N0");
            }
        }

        private void txtgia_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtmasanpham.Text.Trim() != "")
                {
                    int maSP = Convert.ToInt32(txtmasanpham.Text);

                    decimal gia = bll.LayGiaSanPham(maSP);

                    txtgia.Text = gia.ToString();
                }
            }
            catch
            {
                txtgia.Text = "";
            }
        }

        private void txtmasanpham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtmasanpham.Text.Trim() != "")
                {
                    int maSP = Convert.ToInt32(txtmasanpham.Text);

                    decimal gia = bll.LayGiaSanPham(maSP);

                    txtgia.Text = gia.ToString("N0");

                    // Tính lại tổng
                    txtsoluong_TextChanged(null, null);
                }
                else
                {
                    txtgia.Text = "";
                }
            }
            catch
            {
                txtgia.Text = "";
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtgia.Text.Trim() != "" &&
                    txtsoluong.Text.Trim() != "" &&
                    txtmakhachhang.Text.Trim() != "" &&
                    txtmasanpham.Text.Trim() != "")
                {
                    decimal gia = Convert.ToDecimal(txtgia.Text.Replace(",", ""));

                    int soLuong = Convert.ToInt32(txtsoluong.Text);
                    int maKH = Convert.ToInt32(txtmakhachhang.Text);
                    int maSP = Convert.ToInt32(txtmasanpham.Text);

                    // Tổng gốc
                    decimal tongGoc = gia * soLuong;

                    // % giảm
                    decimal phanTramGiam = bll.LayPhanTramGiam(maKH, maSP);

                    // Tiền giảm
                    decimal tienGiam = tongGoc * phanTramGiam / 100;

                    // Tổng sau giảm
                    decimal tongSauGiam = tongGoc - tienGiam;

                    txttongtien.Text = tongSauGiam.ToString("N0");
                }
                else
                {
                    txttongtien.Text = "";
                }
            }
            catch
            {
                txttongtien.Text = "";
            }
        }
    }
}