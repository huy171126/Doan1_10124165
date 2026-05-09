using CNPM_SPA.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class BaoCaoBLL
    {
        BaoCaoDAL dal = new BaoCaoDAL();

        // ================= TỒN KHO =================
        public DataTable TonKho()
        {
            return dal.GetTonKho();
        }

        // ================= DOANH THU =================
        public DataTable DoanhThuNgay()
        {
            return dal.GetDoanhThu(0);
        }

        public DataTable DoanhThu7Ngay()
        {
            return dal.GetDoanhThu(7);
        }

        public DataTable DoanhThu30Ngay()
        {
            return dal.GetDoanhThu(30);
        }
    }
}
