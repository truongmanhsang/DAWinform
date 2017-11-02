using System;
using System.Collections.Generic;
using System.Data;
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
                    string SoSR = GenerateSerial(12);
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
        public string GenerateSerial(int iLength)
        {
            StringBuilder strSerial = new StringBuilder();
            string strTemp = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            for (int i = 0; i < iLength; i++)
            {
                char c = strTemp[rand.Next(0, strTemp.Length)];
                strSerial.Append(c);
            }
            return strSerial.ToString();
        }
    }
}
