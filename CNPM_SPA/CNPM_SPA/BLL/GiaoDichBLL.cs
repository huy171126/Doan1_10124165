using CNPM_SPA.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class GiaoDichBLL
    {
        GiaoDichDAL dal = new GiaoDichDAL();

        public DataTable LoadAll()
        {
            return dal.GetAll();
        }

        public DataTable LoadByType(string loai)
        {
            return dal.GetByType(loai);
        }

        public DataTable LoadByDate(DateTime from, DateTime to)
        {
            return dal.GetByDate(from, to);
        }
        public decimal TinhTongTien(int maHD, int soLuong, decimal gia)
        {
            return soLuong * gia;
        }
    }
}
