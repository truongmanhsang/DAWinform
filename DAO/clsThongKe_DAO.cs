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
            DataTable dtThongKeXuat = ThaoTacDuLieu.LayBang(@"select NgayLap, sum(TongTien) as 'BanHang'
            from PhieuXuat
            where Loai = 1
            group by NgayLap");

            DataTable dtThongKeNhap = ThaoTacDuLieu.LayBang(@"select NgayLap, sum(TongTien) as 'NhapHang'
            from PhieuNhap
            group by NgayLap");

            DataTable dtDoanhThu = new DataTable();
            dtDoanhThu.Columns.Add("NgayLap", typeof(DateTime));
            dtDoanhThu.Columns.Add("BanHang", typeof(decimal));
            dtDoanhThu.Columns.Add("NhapHang", typeof(decimal));

            foreach (DataRow drXuat in dtThongKeXuat.Rows)
            {
                DateTime tNgayLap = Convert.ToDateTime(drXuat["NgayLap"]);
                decimal dBanHang = Convert.ToDecimal(drXuat["BanHang"]);

                dtDoanhThu.Rows.Add(tNgayLap, dBanHang, 0);
            }

            foreach (DataRow drNhap in dtThongKeNhap.Rows)
            {
                bool bThem = true;
                DateTime tNgayLap = Convert.ToDateTime(drNhap["NgayLap"]);
                decimal dNhapHang = Convert.ToDecimal(drNhap["NhapHang"]);
                foreach (DataRow drDoanhThu in dtDoanhThu.Rows)
                {
                    if (tNgayLap == Convert.ToDateTime(drDoanhThu["NgayLap"]))
                    {
                        drDoanhThu["NhapHang"] = dNhapHang;
                        bThem = false;
                        break;
                    }
                }
                if (bThem)
                {
                    dtDoanhThu.Rows.Add(tNgayLap, 0, dNhapHang);
                }
            }

            return dtDoanhThu;
        }
        public DataTable TinhLoiNhuan()
        {
            return ThaoTacDuLieu.LayBang(string.Format(@"select px.NgayLap, sum(px.TongTien) as 'DoanhThu', sum(sp.GiaMua * ctpx.SoLuong) as 'TriGia'
                from PhieuXuat px, ChiTietPhieuXuat ctpx, SanPham sp
                where px.MaPhieuXuat = ctpx.MaPhieuXuat
                and ctpx.MaSanPham = sp.MaSanPham
                group by px.NgayLap
                "));
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
