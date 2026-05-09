using CNPM_SPA.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CNPM_SPA.DAL
{
    public class PhongDAL
    {
        // Lấy tất cả phòng
        public DataTable LayTatCaPhong()
        {
            using (SqlConnection con =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_TatCaPhong", con);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Phòng đang hoạt động
        public DataTable LayPhongDangHoatDong()
        {
            using (SqlConnection con =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_PhongDangHoatDong", con);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Phòng trống
        public DataTable LayPhongTrong()
        {
            using (SqlConnection con =
                new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter("sp_PhongTrong", con);

                da.SelectCommand.CommandType =
                    CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Thêm phòng
        public void ThemPhong(string ten, string trangthai)
        {
            using (SqlConnection con =
                new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_ThemPhong", con);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TenPhong", ten);
                cmd.Parameters.AddWithValue("@TrangThai", trangthai);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Xóa phòng
        public void XoaPhong(int ma)
        {
            using (SqlConnection con =
                new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_XoaPhong", con);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhong", ma);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Sửa phòng
        public void SuaPhong(int ma, string ten, string trangthai)
        {
            using (SqlConnection con =
                new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd =
                    new SqlCommand("sp_SuaPhong", con);

                cmd.CommandType =
                    CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhong", ma);
                cmd.Parameters.AddWithValue("@TenPhong", ten);
                cmd.Parameters.AddWithValue("@TrangThai", trangthai);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}