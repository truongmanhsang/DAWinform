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
    public class clsNhanVien_BUS
    {
        clsNhanVien_DAO dao = new clsNhanVien_DAO();
        public DataTable LayThongTinNV(string strTenDN)
        {
            return dao.LayThongTinNV(strTenDN);
        }
        public DataTable LayThongTinNV(string strTenDN, string strMatKhau)
        {
            return dao.LayThongTinNV(strTenDN, strMatKhau);
        }
        public DataTable LayBangNhanVien()
        {
            return dao.LayBangNhanVien();
        }
        public DataTable LayBangChucVu()
        {
            return dao.LayBangChucVu();
        }
        public bool ThemNhanVien(clsNhanVien_DTO nhanvien)
        { 
            return dao.ThemNhanVien(nhanvien);
        }
        public bool SuaNhanVien(clsNhanVien_DTO nhanvien)
        {
            return dao.SuaNhanVien(nhanvien);
        }
        public bool XoaNhanVien(string MaNV)
        {
            return dao.XoaNhanVien(MaNV);
        }
        public DataTable LayNVTheoMaNV(string MaNV)
        {
            return dao.LayNVTheoMaNV(MaNV);
        }
    }
}
