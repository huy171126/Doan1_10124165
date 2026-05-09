using CNPM_SPA.DAL;
using CNPM_SPA.DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL dal = new NhanVienDAL();

        public DataTable Load()
        {
            return dal.Load();
        }

        public DataTable TimKiem(string key)
        {
            return dal.TimKiem(key);
        }

        public void Them(NhanVienDTO nv)
        {
            dal.Them(nv);
        }

        public void Sua(NhanVienDTO nv)
        {
            dal.Sua(nv);
        }

        public void Xoa(int ma)
        {
            dal.Xoa(ma);
        }
    }
}
