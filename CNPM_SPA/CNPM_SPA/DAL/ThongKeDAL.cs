using CNPM_SPA.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public class ThongKeDAL
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Phan_Mem_Spa;Integrated Security=True";

        public ThongKeDTO LayThongKe()
        {
            ThongKeDTO tk = new ThongKeDTO();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                tk.DoanhThuHomNay = ConvertToDecimal(ExecScalar(conn, "sp_DoanhThuHomNay"));
                tk.SoKhachTrongNgay = ConvertToInt(ExecScalar(conn, "sp_SoKhachTrongNgay"));
                tk.KhachDangPhucVu = ConvertToInt(ExecScalar(conn, "sp_KhachDangPhucVu"));
                tk.KhachSapDen = ConvertToInt(ExecScalar(conn, "sp_KhachSapDen"));

                tk.DoanhThu7Ngay = ConvertToDecimal(ExecScalar(conn, "sp_DoanhThu7Ngay"));
                tk.DoanhThu30Ngay = ConvertToDecimal(ExecScalar(conn, "sp_DoanhThu30Ngay"));

                tk.SoKhach7Ngay = ConvertToInt(ExecScalar(conn, "sp_SoKhach7Ngay"));
                tk.SoKhach30Ngay = ConvertToInt(ExecScalar(conn, "sp_SoKhach30Ngay"));
            }

            return tk;
        }

        // 🔹 Hàm chạy SP chung
        private object ExecScalar(SqlConnection conn, string spName)
        {
            SqlCommand cmd = new SqlCommand(spName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd.ExecuteScalar();
        }

        private int ConvertToInt(object obj)
        {
            return obj == null ? 0 : int.Parse(obj.ToString());
        }

        private decimal ConvertToDecimal(object obj)
        {
            return obj == null ? 0 : decimal.Parse(obj.ToString());
        }
    }
}
