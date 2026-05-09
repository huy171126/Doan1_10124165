using System;
using System.Data;
using System.Data.SqlClient;

namespace CNPM_SPA.DAL
{
    public class SoQuyDAL
    {
        // ===== LẤY TẤT CẢ =====
        public DataTable LayTatCa()
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_LaySoQuy", conn);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ===== THÊM =====
        public void Them(string loai, double sotien, string mota, DateTime ngay)
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_ThemSoQuy", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Loai", loai);
                cmd.Parameters.AddWithValue("@SoTien", sotien);
                cmd.Parameters.AddWithValue("@MoTa", mota);
                cmd.Parameters.AddWithValue("@Ngay", ngay);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ===== LỌC THEO LOẠI =====
        public DataTable LocLoai(string loai)
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_LocTheoLoai", conn);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@Loai", loai);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ===== TÌM KIẾM =====
        public DataTable TimKiem(string mota)
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_TimKiemSoQuy", conn);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@MoTa", mota);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ===== TỔNG THU =====
        public double TongThu()
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_TongThu", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                conn.Open();

                return Convert.ToDouble(cmd.ExecuteScalar());
            }
        }

        // ===== TỔNG CHI =====
        public double TongChi()
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_TongChi", conn);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                conn.Open();

                return Convert.ToDouble(cmd.ExecuteScalar());
            }
        }

        // ===== 7 NGÀY =====
        public DataTable Lay7Ngay()
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_Lay7Ngay", conn);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ===== LỌC 7 NGÀY THEO LOẠI =====
        public DataTable Loc7NgayTheoLoai(string loai)
        {
            using (SqlConnection conn =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_LocLoaiVa7Ngay", conn);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@Loai", loai);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}