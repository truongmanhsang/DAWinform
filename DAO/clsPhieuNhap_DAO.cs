using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class clsPhieuNhap_DAO
    {
        public string TaoPhieuNhap(clsPhieuNhap_DTO phieuNhap)
        {
            string strMaPhieu = "PN" + (ThaoTacDuLieu.DemSoDongCuaBang("PhieuNhap") + 1);
            string query = string.Format("insert into PhieuNhap values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',1,1)", strMaPhieu, phieuNhap.MaNhaCungCap, phieuNhap.TongTien, phieuNhap.TienNo, phieuNhap.ChietKhau, phieuNhap.Thue, phieuNhap.NgayLap, phieuNhap.MaNVLap, phieuNhap.GhiChu);
            ThaoTacDuLieu.ThucThi(query);
            return strMaPhieu;
        }
    }
}
