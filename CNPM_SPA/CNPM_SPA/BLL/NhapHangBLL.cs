using CNPM_SPA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class NhapHangBLL
    {
        NhapHangDAL dal = new NhapHangDAL();

        public int ThemPhieuNhap(int maNCC, DateTime ngay)
        {
            if (maNCC <= 0)
                throw new Exception("Mã nhà cung cấp không hợp lệ");

            return dal.InsertNhapHang(maNCC, ngay);
        }

        public void ThemChiTiet(int maNhap, int maSP, int soLuong, decimal giaNhap)
        {
            if (maNhap <= 0 || maSP <= 0)
                throw new Exception("Dữ liệu không hợp lệ");

            if (soLuong <= 0 || giaNhap <= 0)
                throw new Exception("Số lượng và giá phải > 0");

            dal.InsertChiTietNhap(maNhap, maSP, soLuong, giaNhap);
        }
    }
}
