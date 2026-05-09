using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public class BaoCaoDAL
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Phan_Mem_Spa;Integrated Security=True";

        // ================= TỒN KHO =================
        public DataTable GetTonKho()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_BaoCao_TonKho", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= DOANH THU (CHI TIẾT + TỔNG) =================
        public DataTable GetDoanhThu(int soNgay)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_BaoCao_DoanhThu_ChiTiet", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@SoNgay", soNgay);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

