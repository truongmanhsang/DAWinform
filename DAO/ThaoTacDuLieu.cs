using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class ThaoTacDuLieu
    {
        public static string strConnection = @"Data Source=DESKTOP-0T6UI6A;Initial Catalog=QLBH;Integrated Security=True";
        public static SqlConnection TaoVaMoKetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConnection);
                conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }
        }
        public static void DongKetNoi(SqlConnection conn)
        {
            conn.Close();
        }

        public static DataTable LayBang(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = TaoVaMoKetNoi();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
                DongKetNoi(conn);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public static bool ThucThi(string query)
        {
            SqlConnection conn = TaoVaMoKetNoi();
            SqlCommand cmd = new SqlCommand(query,conn);
            int thucthi = cmd.ExecuteNonQuery();
            DongKetNoi(conn);
            return thucthi == 1;
        }
        public static int DemSoDongCuaBang(string strTenBang)
        {
            int iSoDong = 0;
            SqlConnection conn = TaoVaMoKetNoi();
            string sql =string.Format("select count(*) from {0} ", strTenBang);
            SqlCommand cmd = new SqlCommand(sql, conn);
            iSoDong = Convert.ToInt16(cmd.ExecuteScalar());
            DongKetNoi(conn);
            return iSoDong;
        }
    }
}
