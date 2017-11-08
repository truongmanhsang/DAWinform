using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class clsPhieuXuat_DAO
    {
        public string TaoPhieuXuat(clsPhieuXuat_DTO phieuXuat)
        {
            int iResult = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string strMaPhieu = "PX" + (ThaoTacDuLieu.DemSoDongCuaBang("PhieuXuat") + 1); // Tạo mã mới
            string sqlInsertPhieu = string.Format("insert into PhieuXuat values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',1,1)", strMaPhieu, phieuXuat.MaKhachHang, phieuXuat.TongTien, phieuXuat.TienNo, phieuXuat.ChietKhau, phieuXuat.Thue, phieuXuat.NgayLap, phieuXuat.MaNVLap, phieuXuat.GhiChu);
            SqlCommand cmd = new SqlCommand(sqlInsertPhieu, conn);
            iResult = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return strMaPhieu;
        }
    }
}
