using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DTO
{
    public class GiaoDichDTO
    {
        public int MaGiaoDich { get; set; }
        public DateTime Ngay { get; set; }
        public string LoaiGiaoDich { get; set; }
        public string DoiTuong { get; set; }
        public decimal TongTien { get; set; }
    }
}
