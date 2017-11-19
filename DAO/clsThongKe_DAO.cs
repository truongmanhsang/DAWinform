using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsThongKe_DAO
    {
        public DataTable TinhThongKe()
        {
            return ThaoTacDuLieu.LayBang(string.Format(@"select  px.NgayLap, sum(px.TongTien) as 'BanHang', sum(pn.TongTien) as 'NhapHang'
            from PhieuXuat px
            left
            join PhieuNhap pn
            on px.NgayLap = pn.NgayLap
            group by (px.NgayLap)"));
        }
        public DataTable TinhLoiNhuan()
        {
            return ThaoTacDuLieu.LayBang(string.Format(@"select  px.NgayLap,sum(GiaBan -(GiaBan/100*KhuyenMai)) as 'DoanhThu', sum(GiaMua) as 'TriGia'
                from PhieuXuat px, ChiTietPhieuXuat ctpx, SanPham sp
                where ctpx.MaSanPham = sp.MaSanPham
                and px.MaPhieuXuat = ctpx.MaPhieuXuat
                group by px.NgayLap"));
        }
        public int LaySLBan(string strNgay)
        {
            string query = string.Format(@"select sum(ct.SoLuong)
            from ChiTietPhieuXuat ct, PhieuXuat px
            where ct.MaPhieuXuat = px.MaPhieuXuat
            and px.NgayLap = '{0}'", strNgay);
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);

            int iSL = 0;
            try
            {
                iSL = Convert.ToInt16(cmd.ExecuteScalar());
            }
            catch
            {
                ThaoTacDuLieu.DongKetNoi(conn);
                return 0;
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return iSL;
        }
        public int LaySLNhap(string strNgay)
        {
            string query = string.Format(@"select sum(ct.SoLuong)
            from ChiTietPhieuNhap ct, PhieuNhap pn
            where ct.MaPhieuNhap = pn.MaPhieuNhap
            and pn.NgayLap = '{0}'", strNgay);
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);

            int iSL = 0;
            try
            {
                iSL = Convert.ToInt16(cmd.ExecuteScalar());
            }
            catch
            {
                ThaoTacDuLieu.DongKetNoi(conn);
                return 0;
            }
            ThaoTacDuLieu.DongKetNoi(conn);
            return iSL;
        }
    }
}
