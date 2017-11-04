using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class ChiTietPhieuXuatDAO
    {
        SanPhamDAO _SanPhamDAO = new SanPhamDAO();
        public void TaoChiTieuPhieuXuat(List<ChiTietPhieuXuatDTO> dsChiTiet, string strMaPhieuXuat)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            foreach (ChiTietPhieuXuatDTO chiTiet in dsChiTiet)
            {
                string sqlInsertChitiet = string.Format("insert into ChiTietPhieuXuat values ('{0}','{1}','{2}','{3}')", strMaPhieuXuat, chiTiet.MaSanPham, chiTiet.SoLuong, chiTiet.Gia);

                SqlCommand cmd = new SqlCommand(sqlInsertChitiet, conn);
                cmd.ExecuteNonQuery();

                // Đặt lại số lượng mới cho SP
                int iSLMoi = _SanPhamDAO.LaySoLuongSP(chiTiet.MaSanPham) - chiTiet.SoLuong;
                _SanPhamDAO.DatLaiSoLuongSP(chiTiet.MaSanPham, iSLMoi);
            }
        }
    }
}
