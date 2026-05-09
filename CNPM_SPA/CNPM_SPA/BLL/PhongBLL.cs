using CNPM_SPA.DAL;
using CNPM_SPA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CNPM_SPA.BLL
{
    public class PhongBLL
    {
        PhongDAL dal = new PhongDAL();

        public DataTable LoadTatCa()
        {
            return dal.LayTatCaPhong();
        }

        public DataTable LoadDangHoatDong()
        {
            return dal.LayPhongDangHoatDong();
        }

        public DataTable LoadPhongTrong()
        {
            return dal.LayPhongTrong();
        }

        public void Them(string ten, string trangthai)
        {
            dal.ThemPhong(ten, trangthai);
        }

        public void Xoa(int ma)
        {
            dal.XoaPhong(ma);
        }

        public void Sua(int ma, string ten, string trangthai)
        {
            dal.SuaPhong(ma, ten, trangthai);
        }
    }
}