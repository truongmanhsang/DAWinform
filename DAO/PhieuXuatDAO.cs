using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class PhieuXuatDAO
    {
        public int TaoPhieuXuat(PhieuXuatDTO phieuXuat, List<ChiTietPhieuXuatDTO> dsChiTiet)
        {
            int iResult = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string strMaPhieu = "PX" + (DemSoPhieuXuat() + 1); // Tạo mã mới
            string sqlInsertPhieu = string.Format("insert into PhieuXuat values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',1,1)", strMaPhieu, phieuXuat.MaKhachHang, phieuXuat.TongTien, phieuXuat.TienNo, phieuXuat.ChietKhau, phieuXuat.Thue, phieuXuat.NgayLap, phieuXuat.MaNVLap, phieuXuat.GhiChu);
            SqlCommand cmd = new SqlCommand(sqlInsertPhieu, conn);
            iResult = cmd.ExecuteNonQuery();

            // insert chi tiết hoá đơn
            foreach (ChiTietPhieuXuatDTO chiTiet in dsChiTiet)
            {
                string sqlInsertChitiet = string.Format("insert into ChiTietPhieuXuat values ('{0}','{1}','{2}','{3}','{4}')",strMaPhieu,chiTiet.MaSanPham,chiTiet.SoLuong,chiTiet.Gia,chiTiet.MaSerial);

                cmd = new SqlCommand(sqlInsertChitiet, conn);
                cmd.ExecuteNonQuery();

                // Đặt lại số lượng mới cho SP
                int iSLMoi = LaySoLuongSP(chiTiet.MaSanPham) - chiTiet.SoLuong;
                DatLaiSoLuongSP(chiTiet.MaSanPham, iSLMoi);
            }

            ThaoTacDuLieu.DongKetNoi(conn);
            return iResult;
        }

        int LaySoLuongSP(string strMaSP)
        {
            int iSL = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("select SoLuong from SanPham where MaSanPham='{0}'",strMaSP);
            SqlCommand cmd = new SqlCommand(sql, conn);
            iSL = Convert.ToInt16(cmd.ExecuteScalar());
            ThaoTacDuLieu.DongKetNoi(conn);
            return iSL;
        }
        void DatLaiSoLuongSP(string strMaSP, int iSL)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("update SanPham set SoLuong={0} where MaSanPham='{1}'",iSL,strMaSP);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
        }

        int DemSoPhieuXuat()
        {
            int iSoPhieu = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = "select count(*) from PhieuXuat where TrangThai = 1";
            SqlCommand cmd = new SqlCommand(sql, conn);
            iSoPhieu = Convert.ToInt16(cmd.ExecuteScalar());
            ThaoTacDuLieu.DongKetNoi(conn);
            return iSoPhieu;
        }
    }
}
