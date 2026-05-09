using CNPM_SPA.DTO;
using System.Data;
using System.Data.SqlClient;

namespace CNPM_SPA.DAL
{
    public class SanPhamDAL
    {

        // ================= LOAD ALL =================
        public DataTable LoadAll()
        {
            return Exec("sp_TatCaSanPham");
        }

        // ================= CÒN TỒN =================
        public DataTable ConTon()
        {
            return Exec("sp_ConTonHang");
        }

        // ================= HẾT HÀNG =================
        public DataTable HetHang()
        {
            return Exec("sp_DaHetHang");
        }

        // ================= TÌM KIẾM =================
        public DataTable TimKiem(string ten)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_TimKiemSanPham", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ten", ten);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
        }

        // ================= THÊM =================
        public void Them(SanPhamDTO sp)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_ThemSanPham", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
                cmd.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                cmd.Parameters.AddWithValue("@GiaNhap", sp.GiaNhap);
                cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ================= XOÁ =================
        public void Xoa(int maSanPham)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_XoaSanPham", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ================= HÀM CHUNG =================
        private DataTable Exec(string sp)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(sp, conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}