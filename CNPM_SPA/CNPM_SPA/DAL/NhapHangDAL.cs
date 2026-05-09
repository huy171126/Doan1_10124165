using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public class NhapHangDAL
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Phan_Mem_Spa;Integrated Security=True";

        // THÊM PHIẾU NHẬP
        public int InsertNhapHang(int maNCC, DateTime ngay)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"INSERT INTO NhapHang(MaNCC, NgayNhap)
                               VALUES (@ncc, @ngay);
                               SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ncc", maNCC);
                cmd.Parameters.AddWithValue("@ngay", ngay);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // THÊM CHI TIẾT NHẬP
        public void InsertChiTietNhap(int maNhap, int maSP, int soLuong, decimal giaNhap)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"INSERT INTO ChiTietNhap(MaNhap, MaSanPham, SoLuong, GiaNhap)
                               VALUES (@mn, @sp, @sl, @gia)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@mn", maNhap);
                cmd.Parameters.AddWithValue("@sp", maSP);
                cmd.Parameters.AddWithValue("@sl", soLuong);
                cmd.Parameters.AddWithValue("@gia", giaNhap);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
