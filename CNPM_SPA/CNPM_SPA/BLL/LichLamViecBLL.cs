using CNPM_SPA.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class LichLamViecBLL
    {
        LichLamViecDAL dal = new LichLamViecDAL();

        public DataTable GetLichTuan(DateTime start)
        {
            return dal.GetLichTuan(start);
        }

        public bool ThemLich(int maKH, int maNV, int maPhong, int maDV, DateTime tg)
        {
            if (dal.KiemTraTrung(tg) > 0)
                return false;

            dal.ThemLich(maKH, maNV, maPhong, maDV, tg, "DangSuDung");
            return true;
        }
    }
}
