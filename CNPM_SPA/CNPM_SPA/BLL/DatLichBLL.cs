using CNPM_SPA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class DatLichBLL
    {
        DatLichDAL dal = new DatLichDAL();

        // ================= KHÁCH =================
        public void ThemKhach(string ten, string sdt, int diem)
        {
            dal.ThemKhach(ten, sdt, diem);
        }

        // ================= LỊCH =================
        public void ThemLich(int makh, int manv, int maphong, int madv, DateTime tg)
        {
            dal.ThemLich(makh, manv, maphong, madv, tg);
        }
    }
}
