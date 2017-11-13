using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class clsKhachHang_BUS
    {
        clsKhachHang_DAO dao = new clsKhachHang_DAO();
        public DataTable LayBangKhachHang()
        {
            return dao.LayBangKhachHang();
        }
        public DataTable LayBangKhachHang(string strMaKH)
        {
            return dao.LayBangKhachHang(strMaKH);
        }
        public string ThemKhachHang(clsKhachHang_DTO khachHang)
        {
            return dao.ThemKhachHang(khachHang);
        }
        public DataTable TimKiemKhachHang(string query)
        {
           
            return dao.TimKiemKhachHang(query);
        }
        public bool SuaKhachHang(clsKhachHang_DTO khdto)
        {
          
            return dao.SuaKhachHang(khdto);
        }
        public bool XoaKhachHang(string MaKH)
        {
            return dao.XoaKhachHang(MaKH);
        }
    }
}
