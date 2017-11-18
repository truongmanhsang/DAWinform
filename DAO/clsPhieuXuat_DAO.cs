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
    public class clsPhieuXuat_DAO
    {
        public DataTable LayBangKhachHangPX(string strMaPhieu)
        {
            return ThaoTacDuLieu.LayBang(string.Format(@"select *
            from ChiTietPhieuXuat ct, PhieuXuat px, KhachHang kh
            where ct.MaPhieuXuat = px.MaPhieuXuat and px.MaKhachHang = kh.MaKhachHang
            and px.MaPhieuXuat = '{0}'", strMaPhieu));
        }
        public DataTable LayBanInPhieuXuat(string strMaPhieu)
        {
            return ThaoTacDuLieu.LayBang(string.Format(@"select sp.TenSanPham, sp.BaoHanh, sp.DonViTinh, ct.SoLuong, ct.Gia, (ct.SoLuong * ct.Gia) as ThanhTien
                from SanPham sp, ChiTietPhieuXuat ct
                where sp.MaSanPham = ct.MaSanPham and ct.MaPhieuXuat = '{0}'",strMaPhieu));
        }
        public DataTable LayBangPhieuXuat()
        {
            string query = "select * from PhieuXuat px, NhanVien nv, KhachHang kh where px.NhanVienLap = nv.MaNhanVien and px.MaKhachHang = kh.MaKhachHang and px.TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public string TaoPhieuXuat(clsPhieuXuat_DTO phieuXuat)
        {
            int iResult = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string strMaPhieu = "PX" + (ThaoTacDuLieu.DemSoDongCuaBang("PhieuXuat") + 1); // Tạo mã mới
            string sqlInsertPhieu = string.Format("insert into PhieuXuat values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',1)", strMaPhieu, phieuXuat.MaKhachHang, phieuXuat.TongTien, phieuXuat.ChietKhau, phieuXuat.Thue, phieuXuat.NgayLap, phieuXuat.MaNVLap, phieuXuat.GhiChu, phieuXuat.Loai);
            SqlCommand cmd = new SqlCommand(sqlInsertPhieu, conn);
            iResult = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return strMaPhieu;
        }
        public bool HoanTatChuyenHang(string strMaPhieu)
        {
            string query = string.Format("update PhieuXuat set Loai=1 where MaPhieuXuat='{0}'",strMaPhieu);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool XoaPhieuXuat(string strMaPhieu)
        {
            string query = string.Format("update PhieuXuat set TrangThai=0 where MaPhieuXuat='{0}'", strMaPhieu);
            return ThaoTacDuLieu.ThucThi(query);
        }
    }
}
