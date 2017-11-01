using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        public DataTable LayBangKhachHang()
        {
            string query = "select * from KhachHang where TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public string ThemKhachHang(KhachHangDTO khachHang) // thêm và lấy id kh về để thêm vào hoá đơn
        {
            string strMaKH = "KH" + (DemSoLuongKH() + 1);
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string query = string.Format("insert into KhachHang values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}')", strMaKH, khachHang.TenKhachHang, khachHang.CMND, khachHang.SoDT, khachHang.DiaChi, khachHang.GhiChu, 1);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return strMaKH;
        }
        public int DemSoLuongKH()
        {
            int iSL = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string query = "select count(*) from KhachHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            iSL = Convert.ToInt16(cmd.ExecuteScalar());
            ThaoTacDuLieu.DongKetNoi(conn);
            return iSL;
        }
    }
}
