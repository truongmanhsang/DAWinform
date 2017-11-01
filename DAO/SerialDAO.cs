using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class SerialDAO
    {
        public string LayMaSerial(string strMaSP, int iSoThangBH)
        {
            string strSerial = string.Empty;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();

            string sqlSelect = string.Format("select top 1 MaSerial from Serial where ThoiHanBaoHanh IS NULL and MaSanPham = '{0}'", strMaSP); // select mã serial còn trống
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            strSerial = cmd.ExecuteScalar().ToString();


            DateTime dtHanBaoHanh = DateTime.Now.AddMonths(iSoThangBH);
            string sqlUpdate = string.Format("update Serial set ThoiHanBaoHanh='{0}' where MaSerial='{1}'",dtHanBaoHanh.ToString("dd/MM/yyyy"),strSerial);// update số serial đó với thời hạn bảo hành
            cmd = new SqlCommand(sqlUpdate, conn);
            cmd.ExecuteNonQuery();

            ThaoTacDuLieu.DongKetNoi(conn);

            return strSerial;
        }
    }
}
