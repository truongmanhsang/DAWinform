using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsChiTietPhieuNhap_DAO
    {
        clsSanPham_DAO _SanPhamDAO = new clsSanPham_DAO();
        public void TaoChiTieuPhieuNhap(List<clsChiTietPhieuNhap_DTO> dsChiTiet, string strMaPhieuNhap)
        {
            foreach (clsChiTietPhieuNhap_DTO chiTiet in dsChiTiet)
            {
                string sqlInsertChitiet = string.Format("insert into ChiTietPhieuNhap values ('{0}','{1}','{2}','{3}')", strMaPhieuNhap, chiTiet.MaSanPham, chiTiet.SoLuong, chiTiet.Gia);

                ThaoTacDuLieu.ThucThi(sqlInsertChitiet);

                // Đặt lại số lượng mới cho SP
                int iSLMoi = _SanPhamDAO.LaySoLuongSP(chiTiet.MaSanPham) + chiTiet.SoLuong;
                _SanPhamDAO.DatLaiSoLuongSP(chiTiet.MaSanPham, iSLMoi);
            }
        }
    }
}
