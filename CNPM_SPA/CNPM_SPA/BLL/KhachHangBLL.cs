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
    public class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();

        public DataTable Load()
        {
            return dal.Load();
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return dal.TimKiem(tuKhoa);
        }

        public void Them(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKhachHang))
                throw new System.Exception("Tên khách hàng không được rỗng");

            dal.Them(kh);
        }

        public void Sua(KhachHangDTO kh)
        {
            dal.Sua(kh);
        }

        public void Xoa(int ma)
        {
            dal.Xoa(ma);
        }
        public DataTable VIP()
        {
            return dal.LoadVIP();
        }
        public DataTable Thuong()
        {
            return dal.LoadThuong();
        }
    }
}
