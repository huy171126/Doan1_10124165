using CNPM_SPA.DAL;
using System;

namespace CNPM_SPA.BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL dal = new HoaDonDAL();

        public int ThemHoaDon(int maKH, int maNV, DateTime ngay)
        {
            if (maKH <= 0 || maNV <= 0)
                throw new Exception("Mã khách hoặc nhân viên không hợp lệ");

            return dal.InsertHoaDon(maKH, maNV, ngay);
        }

        public void ThemChiTiet(int maHD, int maSP, int soLuong)
        {
            if (maHD <= 0 || maSP <= 0 || soLuong <= 0)
                throw new Exception("Chi tiết hóa đơn không hợp lệ");

            dal.InsertChiTiet(maHD, maSP, soLuong);
        }

        public decimal LayTongTien(int maHD)
        {
            return dal.GetTongTien(maHD);
        }

        public void CapNhatTongTien(int maHD, decimal tongTien)
        {
            dal.UpdateTongTien(maHD, tongTien);
        }

        public decimal LayPhanTramGiam(int maKH, int maSP)
        {
            return dal.LayPhanTramGiam(maKH, maSP);
        }
        public decimal LayGiaSanPham(int maSP)
        {
            return dal.LayGiaSanPham(maSP);
        }
    }
}