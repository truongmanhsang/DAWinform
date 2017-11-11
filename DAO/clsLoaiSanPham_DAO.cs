using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsLoaiSanPham_DAO
    {
        public DataTable LayBangLoaiSanPham()
        {
            string query = "select * from LoaiSanPham where TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
    }
}
