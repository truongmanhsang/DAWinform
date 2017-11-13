using DAO;
using DTO;
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
        public DataTable KiemTraTen(string strTen)
        {
            return dao.KiemTraTen(strTen);
        }
        public bool ThemHSX(clsHangSanXuat_DTO HSX)
        {
            return dao.ThemHSX(HSX);
        }
        public DataTable LayBangHangSanXuat(string strMaHSX)
        {
            return dao.LayBangHangSanXuat(strMaHSX);
        }
        public bool SuaHSX(clsHangSanXuat_DTO HSX)
        {
            return dao.SuaHSX(HSX);
        }
        public bool XoaHSX(string strMaHSX)
        {
            return dao.XoaHSX(strMaHSX);
        }
    }
}
