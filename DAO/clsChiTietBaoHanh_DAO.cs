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
        public void ThemChiTietBaoHanh(List<clsChiTietBaoHanh_DTO> dsChiTiet, string strMaBH)
        {
            foreach (clsChiTietBaoHanh_DTO chiTiet in dsChiTiet)
            {
                string query = string.Format("insert into ChiTietBaoHanh values('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}')",strMaBH,chiTiet.MaSerial,chiTiet.NgayHenTra,chiTiet.GiaSuaChua,chiTiet.TraHang,chiTiet.MotaLoi,chiTiet.GhiChu);
                ThaoTacDuLieu.ThucThi(query);
            }
        }
        public DataTable LayBangChiTietBH(string strMaBH)
        {
            return ThaoTacDuLieu.LayBang(string.Format("select * from ChiTietBaoHanh ct,Serial sr, SanPham sp where ct.MaSerial = sr.MaSerial and sr.MaSanPham = sp.MaSanPham and ct.MaBaoHanh = '{0}'", strMaBH));
        }
    }
}
