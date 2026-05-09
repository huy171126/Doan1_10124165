using CNPM_SPA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public class PhongDAL
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Phan_Mem_Spa;Integrated Security=True";

        // Lấy tất cả phòng
        public DataTable LayTatCaPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_TatCaPhong", connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Phòng đang hoạt động
        public DataTable LayPhongDangHoatDong()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_PhongDangHoatDong", connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Phòng trống
        public DataTable LayPhongTrong()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_PhongTrong", connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thêm phòng
        public void ThemPhong(string ten, string trangthai)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_ThemPhong", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TenPhong", ten);
            cmd.Parameters.AddWithValue("@TrangThai", trangthai);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // Xóa phòng
        public void XoaPhong(int ma)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_XoaPhong", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhong", ma);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // Sửa phòng
        public void SuaPhong(int ma, string ten, string trangthai)
        {
            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("sp_SuaPhong", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaPhong", ma);
            cmd.Parameters.AddWithValue("@TenPhong", ten);
            cmd.Parameters.AddWithValue("@TrangThai", trangthai);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
