using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class clsHangSanXuat_BUS
    {
        clsHangSanXuat_DAO dao = new clsHangSanXuat_DAO();
        public DataTable LayBangHangSanXuat()
        {
            return dao.LayBangHangSanXuat();
        }
    }
}
