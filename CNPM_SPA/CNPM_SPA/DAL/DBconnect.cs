using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SPA.DAL
{
    public static class DBConnect
    {
        public static string connStr =
            @"Data Source=.\SQLEXPRESS;
          Initial Catalog=Phan_Mem_Spa;
          Integrated Security=True";
    }
}
