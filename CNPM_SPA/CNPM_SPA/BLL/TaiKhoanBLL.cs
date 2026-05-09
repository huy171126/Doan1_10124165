using CNPM_SPA.DAL;
using CNPM_SPA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();

        public string DangNhap(TaiKhoanDTO tk)
        {
            if (string.IsNullOrWhiteSpace(tk.TenDangNhap) ||
                string.IsNullOrWhiteSpace(tk.MatKhau))
                return null;

            return dal.DangNhap(tk);
        }
    }
}
