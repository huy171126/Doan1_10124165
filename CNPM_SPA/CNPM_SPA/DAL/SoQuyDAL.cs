using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public class SoQuyDAL
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Phan_Mem_Spa;Integrated Security=True";

        // ===== LẤY TẤT CẢ =====
        public DataTable LayTatCa()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_LaySoQuy", connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // ===== THÊM =====
        public void Them(string loai, double sotien, string mota, DateTime ngay)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemSoQuy", conn);
                cmd.CommandType = CommandType.StoredProcedure;

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
            SqlDataAdapter da = new SqlDataAdapter("sp_LocTheoLoai", connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@Loai", loai);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // ===== TÌM KIẾM =====
        public DataTable TimKiem(string mota)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_TimKiemSoQuy", connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@MoTa", mota);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // ===== TỔNG THU =====
        public double TongThu()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_TongThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
        }

        // ===== TỔNG CHI =====
        public double TongChi()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_TongChi", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
        }
        public DataTable Lay7Ngay()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Lay7Ngay", connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Loc7NgayTheoLoai(string loai)
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_LocLoaiVa7Ngay", connStr);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("@Loai", loai);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}