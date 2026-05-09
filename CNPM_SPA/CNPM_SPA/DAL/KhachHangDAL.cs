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
    public class KhachHangDAL
    {

        // LOAD ALL (dùng VIEW VIP luôn)
        public DataTable Load()
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_KhachHang_VIP", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable LoadVIP()
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_DanhSachVIP", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable LoadThuong()
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_DanhSachThuong", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        // THÊM
        public void Them(KhachHangDTO kh)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // SỬA
        public void Sua(KhachHangDTO kh)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_SuaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhachHang", kh.MaKhachHang);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // XOÁ
        public void Xoa(int ma)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaKhachHang", ma);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // TÌM KIẾM
        public DataTable TimKiem(string tuKhoa)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
