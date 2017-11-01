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
        public static string strConnection = "Data Source=.;Initial Catalog=QLBH;Integrated Security=True";
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
            SqlConnection conn = TaoVaMoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            DongKetNoi(conn);
            return dt;
        }
    }
}
