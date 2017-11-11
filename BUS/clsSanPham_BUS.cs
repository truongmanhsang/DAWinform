using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class clsSanPham_BUS
    {
        clsSanPham_DAO dao = new clsSanPham_DAO();
        public bool SuaSanPham(clsSanPham_DTO sanPham)
        {
            return dao.SuaSanPham(sanPham);
        }
        public bool ThemSanPham(clsSanPham_DTO sanPham)
        {
            return dao.ThemSanPham(sanPham);
        }
        public DataTable LayBangSanPham()
        {
            return dao.LayBangSanPham();
        }
        public DataTable LayBangSanPham(string strMaSP)
        {
            return dao.LayBangSanPham(strMaSP);
        }
        public bool ThemSoLuongSP(string strMaSP, int SL)
        {
            return dao.ThemSoLuongSP(strMaSP,SL);
        }
    }
}
