using CNPM_SPA.DAL;
using CNPM_SPA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.BLL
{
    public class ThongKeBLL
    {
        ThongKeDAL dal = new ThongKeDAL();

        public ThongKeDTO LayThongKe()
        {
            return dal.LayThongKe();
        }
    }
}
