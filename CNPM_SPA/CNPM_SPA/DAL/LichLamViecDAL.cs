using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public class LichLamViecDAL
    {


        // ===== LẤY LỊCH TUẦN =====
        public DataTable GetLichTuan(DateTime startDate)
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_LichLamViec_Tuan", conn);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        // ===== THÊM LỊCH =====
        public void ThemLich(int maKH, int maNV, int maPhong, int maDV, DateTime tg, string trangThai)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemLichDat", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhachHang", maKH);
                cmd.Parameters.AddWithValue("@MaNhanVien", maNV);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                cmd.Parameters.AddWithValue("@MaDichVu", maDV);
                cmd.Parameters.AddWithValue("@ThoiGian", tg);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ===== CHECK TRÙNG =====
        public int KiemTraTrung(DateTime tg)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_KiemTraTrungLich", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ThoiGian", tg);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
