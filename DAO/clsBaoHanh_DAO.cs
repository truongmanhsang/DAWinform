using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsBaoHanh_DAO
    {
        public string ThemBaoHanh(clsBaoHanh_DTO baoHanh)
        {
            string strMaBH = "BH" + (ThaoTacDuLieu.DemSoDongCuaBang("BaoHanh") + 1);
            string query = string.Format("insert into BaoHanh values('{0}','{1}','{2}','{3}',1)", strMaBH, baoHanh.MaKhachHang, baoHanh.MaNhanVien, baoHanh.NgayBaoHanh);
            ThaoTacDuLieu.ThucThi(query);
            return strMaBH;
        }
        public DataTable LayBangBaoHanh()
        {
            return ThaoTacDuLieu.LayBang("select * from BaoHanh bh, KhachHang kh, NhanVien nv where bh.MaKhachHang = kh.MaKhachHang  and bh.MaNhanVien = nv.MaNhanVien and bh.TrangThai = 1");
        }
        public bool XoaPhieuBaoHanh(string strMaBH)
        {
            string query = string.Format("update BaoHanh set TrangThai=0 where MaBaoHanh='{0}'", strMaBH);
            return ThaoTacDuLieu.ThucThi(query);
        }
    }
}
