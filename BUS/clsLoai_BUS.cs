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
    public class clsLoai_BUS
    {
        clsLoai_DAO dao = new clsLoai_DAO();
        public DataTable LayBangLoai()
        {
            return dao.LayBangLoai();
        }
        public DataTable KiemTraTen(string strTen)
        {
            return dao.KiemTraTen(strTen);
        }
        public bool ThemLoai(clsLoai_DTO loai)
        {
            return dao.ThemLoai(loai);
        }
        public DataTable LayBangLoai(string strMaLoai)
        {
            return dao.LayBangLoai(strMaLoai);
        }
        public bool SuaLoai(clsLoai_DTO loai)
        {
            return dao.SuaLoai(loai);
        }
        public bool XoaLoai(string strMaLoai)
        {
            return dao.XoaLoai(strMaLoai);
        }
    }
}
