using CNPM_SPA.DAL;
using System;
using System.Data;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class SoQuyBLL
    {
        SoQuyDAL dal = new SoQuyDAL();

        public DataTable Lay()
        {
            return dal.LayTatCa();
        }

        public void Them(string loai, double sotien, string mota)
        {
            dal.Them(loai, sotien, mota, DateTime.Now);
        }

        public DataTable LocThu()
        {
            return dal.LocLoai("Thu");
        }

        public DataTable LocChi()
        {
            return dal.LocLoai("Chi");
        }

        public DataTable Tim(string mota)
        {
            return dal.TimKiem(mota);
        }

        public double GetThu()
        {
            return dal.TongThu();
        }

        public double GetChi()
        {
            return dal.TongChi();
        }
        public DataTable Lay7Ngay()
        {
            return dal.Lay7Ngay();
        }

        public DataTable Loc7NgayTheoLoai(string loai)
        {
            return dal.Loc7NgayTheoLoai(loai);
        }
    }
}
