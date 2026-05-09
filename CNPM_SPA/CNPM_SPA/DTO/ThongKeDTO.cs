using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DTO
{
    public class ThongKeDTO
    {
        public decimal DoanhThuHomNay { get; set; }
        public int SoKhachTrongNgay { get; set; }
        public int KhachDangPhucVu { get; set; }
        public int KhachSapDen { get; set; }

        public decimal DoanhThu7Ngay { get; set; }
        public decimal DoanhThu30Ngay { get; set; }

        public int SoKhach7Ngay { get; set; }
        public int SoKhach30Ngay { get; set; }
    }
}
