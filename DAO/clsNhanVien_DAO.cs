using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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
        public DataTable LayBangChucVu()
        {
            string query = "select Quyen from NhanVien where TrangThai = 1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public bool ThemNhanVien(clsNhanVien_DTO nhanvien)
        {
            string MaNV = "NV" + (ThaoTacDuLieu.DemSoDongCuaBang("NhanVien") + 1);
            string query = string.Format("insert into NhanVien values('{0}',N'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",MaNV, nhanvien.TenNV, nhanvien.TenDangNhap, nhanvien.MatKhau,nhanvien.Hinh, nhanvien.DiaChi, nhanvien.CMND, nhanvien.SDT, nhanvien.Email, nhanvien.Quyen, "", 1);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool XoaNhanVien(string MaNV)
        { 
            string query = string.Format("update NhanVien set TrangThai=0 where MaNhanVien='{0}'",MaNV);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool SuaNhanVien(clsNhanVien_DTO nhanvien)
        {
            string query = string.Format("update NhanVien set TenNhanVien='{0}',TenDangNhap='{1}',MatKhau='{2}',HinhDaiDien='{3}',DiaChi='{4}',CMND='{5}',SoDT='{6}',Email='{7}',Quyen={8},GhiChu='{9}',TrangThai={10} where MaNhanVien='{11}'",nhanvien.TenNV, nhanvien.TenDangNhap, nhanvien.MatKhau, nhanvien.Hinh, nhanvien.DiaChi, nhanvien.CMND, nhanvien.SDT, nhanvien.Email, nhanvien.Quyen, "", nhanvien.TrangThai,nhanvien.MaNV);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public DataTable LayNVTheoMaNV(string MaNV)
        {
            string query = "select * from NhanVien where TrangThai = 1 and MaNhanVien='"+ MaNV + "'";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
    }
}
