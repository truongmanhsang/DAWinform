using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsNhanVien_DAO
    {
        public DataTable LayThongTinNV(string strTenDN)
        {
            string query = string.Format("select * from NhanVien where TenDangNhap='{0}' and TrangThai=1", strTenDN);
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public DataTable LayThongTinNV(string strTenDN, string strMatKhau)
        {
            string query = string.Format("select * from NhanVien where TenDangNhap='{0}' and MatKhau='{1}' and TrangThai=1", strTenDN, strMatKhau);
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public DataTable LayBangNhanVien()
        {
            string query = "select * from NhanVien where TrangThai = 1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
    }
}
