using CNPM_SPA.DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public class NhanVienDAL
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Phan_Mem_Spa;Integrated Security=True";

        // LOAD ALL
        public DataTable Load()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // THÊM
        public void Them(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO NhanVien VALUES (@Ten,@SDT,@CV,@Luong)", conn);

                cmd.Parameters.AddWithValue("@Ten", nv.TenNhanVien);
                cmd.Parameters.AddWithValue("@SDT", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@CV", nv.ChucVu);
                cmd.Parameters.AddWithValue("@Luong", nv.LuongCoBan);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // XOÁ
        public void Xoa(int ma)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM NhanVien WHERE MaNhanVien=@ma", conn);

                cmd.Parameters.AddWithValue("@ma", ma);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // SỬA
        public void Sua(NhanVienDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE NhanVien
                    SET TenNhanVien=@Ten,
                        SoDienThoai=@SDT,
                        ChucVu=@CV,
                        LuongCoBan=@Luong
                    WHERE MaNhanVien=@Ma", conn);

                cmd.Parameters.AddWithValue("@Ma", nv.MaNhanVien);
                cmd.Parameters.AddWithValue("@Ten", nv.TenNhanVien);
                cmd.Parameters.AddWithValue("@SDT", nv.SoDienThoai);
                cmd.Parameters.AddWithValue("@CV", nv.ChucVu);
                cmd.Parameters.AddWithValue("@Luong", nv.LuongCoBan);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // TÌM KIẾM
        public DataTable TimKiem(string key)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT * FROM NhanVien
                    WHERE TenNhanVien LIKE '%' + @key + '%'
                    OR SoDienThoai LIKE '%' + @key + '%'", conn);

                da.SelectCommand.Parameters.AddWithValue("@key", key);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
