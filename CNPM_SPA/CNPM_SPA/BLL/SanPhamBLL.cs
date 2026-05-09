using CNPM_SPA.DAL;
using CNPM_SPA.DTO;
using System.Data;

namespace CNPM_SPA.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public DataTable Load()
        {
            return dal.LoadAll();
        }

        public DataTable ConTon()
        {
            return dal.ConTon();
        }

        public DataTable HetHang()
        {
            return dal.HetHang();
        }

        public DataTable TimKiem(string ten)
        {
            return dal.TimKiem(ten);
        }

        public void Them(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.TenSanPham))
                throw new System.Exception("Tên sản phẩm không được rỗng");

            dal.Them(sp);
        }

        public void Xoa(int ma)
        {
            dal.Xoa(ma);
        }
    }
}