using System;
using System.Data;
using System.Data.SqlClient;

namespace CNPM_SPA.DAL
{
    public class HoaDonDAL
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Phan_Mem_Spa;Integrated Security=True";

        // Thêm hóa đơn
        public int InsertHoaDon(int maKH, int maNV, DateTime ngay)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                    INSERT INTO HoaDon(MaKhachHang, MaNhanVien, NgayLap, TongTien)
                    VALUES (@kh, @nv, @ngay, 0);

                    SELECT SCOPE_IDENTITY();
                ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@kh", maKH);
                cmd.Parameters.AddWithValue("@nv", maNV);
                cmd.Parameters.AddWithValue("@ngay", ngay);

                conn.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Thêm chi tiết hóa đơn
        public void InsertChiTiet(int maHD, int maSP, int soLuong)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemChiTietHoaDon", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHoaDon", maHD);
                cmd.Parameters.AddWithValue("@MaSanPham", maSP);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        // Tính tổng tiền
        public decimal GetTongTien(int maHD)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                    SELECT ISNULL(SUM(SoLuong * Gia),0)
                    FROM ChiTietHoaDon
                    WHERE MaHoaDon = @hd
                ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@hd", maHD);

                conn.Open();

                object result = cmd.ExecuteScalar();

                return Convert.ToDecimal(result);
            }
        }

        // Update tổng tiền
        public void UpdateTongTien(int maHD, decimal tongTien)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                    UPDATE HoaDon
                    SET TongTien = @tong
                    WHERE MaHoaDon = @hd
                ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tong", tongTien);
                cmd.Parameters.AddWithValue("@hd", maHD);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        // Lấy % giảm giá
        public decimal LayPhanTramGiam(int maKH, int maSP)
        {
            decimal giam = 0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_LayPhanTramGiam", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    giam = Convert.ToDecimal(result);
                }
            }

            return giam;
        }
        public decimal LayGiaSanPham(int maSP)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT GiaBan FROM SanPham WHERE MaSanPham = @sp";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sp", maSP);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                    return Convert.ToDecimal(result);

                return 0;
            }
        }
    }
}