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
    public class TaiKhoanDAL
    {

        public string DangNhap(TaiKhoanDTO tk)
        {
            using (SqlConnection conn = new SqlConnection(DBConnect.connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_DangNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau);

                conn.Open();

                object result = cmd.ExecuteScalar();

                return result?.ToString();
            }
        }
    }
}
