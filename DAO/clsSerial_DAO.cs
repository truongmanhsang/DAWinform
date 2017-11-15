using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary;
using System.Data;

namespace DAO
{
    public class clsSerial_DAO
    {
        clsSanPham_DAO _SanPhamDAO = new clsSanPham_DAO();
        public DataTable LayBangSerial()
        {
            string query = @"select * 
                                from Serial as sr
                                    left join PhieuXuat as px on px.MaPhieuXuat = sr.MaPhieuXuat
                                    left join PhieuNhap as pn on pn.MaPhieuNhap = sr.MaPhieuNhap
                                    left join SanPham as sp on sp.MaSanPham = sr.MaSanPham
                                and sr.TrangThai=1";
            return ThaoTacDuLieu.LayBang(query);
        }
        public string LayMaSerial(string strMaSP, int iSoThangBH) // Lấy mã serial cùng với update số tháng bảo hành
        {
            string strSerial = string.Empty;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();

            string sqlSelect = string.Format("select top 1 MaSerial from Serial where ThoiHanBaoHanh IS NULL and MaSanPham = '{0}'", strMaSP); // select mã serial còn trống
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            strSerial = cmd.ExecuteScalar().ToString();


            DateTime dtHanBaoHanh = DateTime.Now.AddMonths(iSoThangBH);
            string sqlUpdate = string.Format("update Serial set ThoiHanBaoHanh='{0}' where MaSerial='{1}'", dtHanBaoHanh.ToString("MM/dd/yyyy"), strSerial);// update số serial đó với thời hạn bảo hành
            cmd = new SqlCommand(sqlUpdate, conn);
            cmd.ExecuteNonQuery();

            ThaoTacDuLieu.DongKetNoi(conn);

            return strSerial;
        }

        public void ThemSoSerial(string strMaSP, int iSL, string strMaPhieu)
        {
            for (int i = 0; i < iSL; i++)
            {
                string strMaSR = "SER" + (ThaoTacDuLieu.DemSoDongCuaBang("Serial") + 1);
                string strSoSerial = PhatSinhSerial();
                string query = string.Format("insert into Serial values('{0}','{1}',NULL,'{2}',NULL,NULL,'{3}',1)", strMaSR, strSoSerial, strMaSP ,strMaPhieu);
                ThaoTacDuLieu.ThucThi(query);
            }
        }

        private string PhatSinhSerial()
        {
            string strSoSerial = string.Empty;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlDataReader dr = null;
            do
            {
                if (dr != null)
                    dr.Close();
                strSoSerial = TienIch.GenerateSerial(12);
                string query = string.Format("select * from Serial where SoSerial='{0}'", strSoSerial);
                SqlCommand cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
            } while (dr.HasRows);
            ThaoTacDuLieu.DongKetNoi(conn);
            return strSoSerial;
        }

        public void BatDauBaoHanh(string strMaSP, int iSL, string strMaPhieu)
        {
            int iThangBaoHanh = _SanPhamDAO.LaySoThangBaoHanh(strMaSP);
            string strThoiHanHetBH = DateTime.Now.AddMonths(iThangBaoHanh).ToString("MM/dd/yyyy");
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            for (int i = 0; i < iSL; i++)
            {
                string strMaSerial = LayMaSerialTrong(strMaSP);
                string query = string.Format("update Serial set ThoiHanBaoHanh='{0}', MaPhieuXuat='{1}' where MaSerial='{2}'", strThoiHanHetBH, strMaPhieu, strMaSerial);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            ThaoTacDuLieu.DongKetNoi(conn);
        }
        private string LayMaSerialTrong(string strMaSP) // lấy mã serial còn trống của mã sp
        {
            string strMaSerial = "";
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string query = string.Format("select top 1 MaSerial from Serial where MaSanPham='{0}' and ThoiHanBaoHanh is NULL", strMaSP);
            SqlCommand cmd = new SqlCommand(query, conn);
            strMaSerial = Convert.ToString(cmd.ExecuteScalar());
            ThaoTacDuLieu.DongKetNoi(conn);
            return strMaSerial;
        }
        public string LayTenSanPhamConBH(string strSoSerial)
        {
            string strTen = string.Empty;
            string query = string.Format("select sp.TenSanPham from Serial sr, SanPham sp where sr.MaSanPham = sp.MaSanPham and sr.ThoiHanBaoHanh is not null and GETDATE() <= sr.ThoiHanBaoHanh and SoSerial='{0}'", strSoSerial);
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);
            strTen = Convert.ToString(cmd.ExecuteScalar());
            ThaoTacDuLieu.DongKetNoi(conn);
            return strTen;
        }
        public string LayMaSerial(string strSoSerial)
        {
            string strMa = string.Empty;
            string query = string.Format("select MaSerial from Serial where SoSerial='{0}'", strSoSerial);
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(query, conn);
            strMa = Convert.ToString(cmd.ExecuteScalar());
            ThaoTacDuLieu.DongKetNoi(conn);
            return strMa;
        }
    }
}
