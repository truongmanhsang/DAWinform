using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class clsPhieuNhap_DAO
    {
        public DataTable LayBangInPhieuNhap(string strMaPhieu)
        {
            return ThaoTacDuLieu.LayBang(string.Format(@"select sp.TenSanPham, sp.BaoHanh, sp.DonViTinh, ct.SoLuong, ct.Gia, (ct.SoLuong * ct.Gia) as ThanhTien
                from SanPham sp, ChiTietPhieuNhap ct
                where sp.MaSanPham = ct.MaSanPham and ct.MaPhieuNhap = '{0}'", strMaPhieu));
        }
        public DataTable LayBangNCCPhieuNhap(string strMaPhieu)
        {
            return ThaoTacDuLieu.LayBang(string.Format(@"select *
            from ChiTietPhieuNhap ct, PhieuNhap pn, NhaCungCap ncc
            where ct.MaPhieuNhap = pn.MaPhieuNhap and pn.MaNhaCungCap = ncc.MaNhaCungCap
            and pn.MaPhieuNhap = '{0}'", strMaPhieu));
        }
        public string TaoPhieuNhap(clsPhieuNhap_DTO phieuNhap)
        {
            string strMaPhieu = "PN" + (ThaoTacDuLieu.DemSoDongCuaBang("PhieuNhap") + 1);
            string query = string.Format("insert into PhieuNhap values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',1,1)", strMaPhieu, phieuNhap.MaNhaCungCap, phieuNhap.TongTien, phieuNhap.TienNo, phieuNhap.ChietKhau, phieuNhap.Thue, phieuNhap.NgayLap, phieuNhap.MaNVLap, phieuNhap.GhiChu);
            ThaoTacDuLieu.ThucThi(query);
            return strMaPhieu;
        }
        public DataTable LayBangPhieuNhap()
        {
            string query = "select * from PhieuNhap pn, NhanVien nv, NhaCungCap ncc where pn.NhanVienLap = nv.MaNhanVien and pn.MaNhaCungCap = ncc.MaNhaCungCap and pn.TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public bool TraTienNo(string strMaPhieu)
        {
            string query = string.Format("update PhieuNhap set TienNo=0 where MaPhieuNhap='{0}'", strMaPhieu);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool XoaPhieuNhap(string strMaPhieu)
        {
            string query = string.Format("update PhieuNhap set TrangThai=0 where MaPhieuNhap='{0}'", strMaPhieu);
            return ThaoTacDuLieu.ThucThi(query);
        }
    }
}
