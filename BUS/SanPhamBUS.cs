using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO dao = new SanPhamDAO();
        public DataTable LayBangSanPham()
        {
            return dao.LayBangSanPham();
        }
        public bool ThemSoLuongSP(string strMaSP, int SL)
        {
            return dao.ThemSoLuongSP(strMaSP,SL);
        }
    }
}
