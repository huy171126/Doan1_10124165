using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public class DatLichDAL
    {
        // ================= THÊM KHÁCH =================
        public void ThemKhach(string ten, string sdt, int diem)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TenKhachHang", ten);
                cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                cmd.Parameters.AddWithValue("@DiemTichLuy", diem);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ================= THÊM LỊCH =================
        public void ThemLich(int makh, int manv, int maphong, int madv, DateTime tg)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemLichDat_nv", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhachHang", makh);
                cmd.Parameters.AddWithValue("@MaNhanVien", manv);
                cmd.Parameters.AddWithValue("@MaPhong", maphong);
                cmd.Parameters.AddWithValue("@MaDichVu", madv);
                cmd.Parameters.AddWithValue("@ThoiGian", tg);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
