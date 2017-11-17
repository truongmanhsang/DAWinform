using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsChiTietBaoHanh_DAO
    {
        clsSerial_DAO _SerialDAO = new clsSerial_DAO();
        public void ThemChiTietBaoHanh(List<clsChiTietBaoHanh_DTO> dsChiTiet, string strMaBH)
        {
            foreach (clsChiTietBaoHanh_DTO chiTiet in dsChiTiet)
            {
                string query = string.Format("insert into ChiTietBaoHanh values('{0}','{1}','{2}','{3}',N'{4}',N'{5}')", strMaBH, chiTiet.MaSerial, chiTiet.NgayHenTra, chiTiet.TinhTrang, chiTiet.MotaLoi, chiTiet.GhiChu);
                ThaoTacDuLieu.ThucThi(query);
            }
        }
        public DataTable LayBangChiTietBH(string strMaBH)
        {
            return ThaoTacDuLieu.LayBang(string.Format("select * from ChiTietBaoHanh ct,Serial sr, SanPham sp where ct.MaSerial = sr.MaSerial and sr.MaSanPham = sp.MaSanPham and ct.MaBaoHanh = '{0}'", strMaBH));
        }
        public DataTable LayBangChiTietKhoBH()
        {
            return ThaoTacDuLieu.LayBang(@"select *
            from ChiTietBaoHanh ct, BaoHanh bh, Serial sr, PhieuNhap pn,SanPham sp, NhaCungCap ncc
            where ct.MaBaoHanh = bh.MaBaoHanh
            and ct.MaSerial = sr.MaSerial
            and sr.MaPhieuNhap = pn.MaPhieuNhap
            and sr.MaSanPham = sp.MaSanPham
            and (ct.TinhTrang = 0 or ct.TinhTrang = 2 or ct.TinhTrang = 3)");
        }
        public void CapNhapBaoHanh(string strSoSerial)
        {
            string strMaSerial = _SerialDAO.LayMaSerial(strSoSerial);
            string query = string.Format("update ChiTietBaoHanh set TinhTrang=1 where MaSerial='{0}'", strMaSerial);
            ThaoTacDuLieu.ThucThi(query);
        }
    }
}
