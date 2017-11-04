using OTHER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        public DataTable LayBangSanPham()
        {
            string query = "select * from SanPham where TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public bool ThemSoLuongSP(string strMaSP,int SL)
        {
            
            string queryUpdateSP = string.Format("update SanPham set SoLuong={1} where MaSanPham='{0}'", strMaSP,SL);
            if (ThaoTacDuLieu.ThucThi(queryUpdateSP))
            {
                int SoDong = 0;
                for(int i = 0; i < SL; i++)
                {
                    string SoSR = Utilities.GenerateSerial(12);
                    SoDong = ThaoTacDuLieu.DemSoDongCuaBang("Serial");
                    string MaSR = "SER" + (SoDong+1);
                    ThaoTacDuLieu.ThucThi(string.Format("insert into Serial values('{0}','{1}',NULL,'{2}',NULL,{3})", MaSR,SoSR,strMaSP,1));
                     
                }

                return true;
            }
            else
            {
                return false;
            }
            
        }
        public int LaySoThangBaoHanh(string strMaSP)
        {
            int iSoThangBH = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string query = string.Format("select BaoHanh from SanPham where MaSanPham='{0}'",strMaSP);
            SqlCommand cmd = new SqlCommand(query, conn);
            iSoThangBH = Convert.ToInt16(cmd.ExecuteScalar());
            ThaoTacDuLieu.DongKetNoi(conn);
            return iSoThangBH;
        }
        public void DatLaiSoLuongSP(string strMaSP, int iSL)
        {
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("update SanPham set SoLuong={0} where MaSanPham='{1}'", iSL, strMaSP);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
        }
        public int LaySoLuongSP(string strMaSP)
        {
            int iSL = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string sql = string.Format("select SoLuong from SanPham where MaSanPham='{0}'", strMaSP);
            SqlCommand cmd = new SqlCommand(sql, conn);
            iSL = Convert.ToInt16(cmd.ExecuteScalar());
            ThaoTacDuLieu.DongKetNoi(conn);
            return iSL;
        }
    }
}
