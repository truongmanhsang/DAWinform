using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsHangSanXuat_DAO
    {
        public DataTable LayBangHangSanXuat()
        {
            string query = "select * from HangSanXuat where TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
    }
}
