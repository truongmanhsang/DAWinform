using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class clsChiTietPhieuXuat_DAO
    {
        clsSanPham_DAO _SanPhamDAO = new clsSanPham_DAO();
        public void TaoChiTieuPhieuXuat(List<clsChiTietPhieuXuat_DTO> dsChiTiet, string strMaPhieuXuat)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            foreach (clsChiTietPhieuXuat_DTO chiTiet in dsChiTiet)
            {
                string sqlInsertChitiet = string.Format("insert into ChiTietPhieuXuat values ('{0}','{1}','{2}','{3}')", strMaPhieuXuat, chiTiet.MaSanPham, chiTiet.SoLuong, chiTiet.Gia);

                SqlCommand cmd = new SqlCommand(sqlInsertChitiet, conn);
                cmd.ExecuteNonQuery();

                // Đặt lại số lượng mới cho SP
                int iSLMoi = _SanPhamDAO.LaySoLuongSP(chiTiet.MaSanPham) - chiTiet.SoLuong;
                _SanPhamDAO.DatLaiSoLuongSP(chiTiet.MaSanPham, iSLMoi);
            }
        }

        public DataTable LayChiTietPhieu(string strMaPhieu)
        {
            string query = string.Format("select * from ChiTietPhieuXuat ct,SanPham sp where ct.MaSanPham = sp.MaSanPham and ct.MaPhieuXuat = '{0}'", strMaPhieu);
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
    }
}
