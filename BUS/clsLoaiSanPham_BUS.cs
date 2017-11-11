using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class clsLoaiSanPham_BUS
    {
        clsLoaiSanPham_DAO dao = new clsLoaiSanPham_DAO();
        public DataTable LayBangLoaiSanPham()
        {
            return dao.LayBangLoaiSanPham();
        }
    }
}
