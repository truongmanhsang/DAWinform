using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class clsNhaCungCap_DAO
    {
        public DataTable LayBangNhaCungCap()
        {
            string query = "select * from NhaCungCap where TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public string ThemNCC(clsNhaCungCap_DTO NCC)
        {
            string strMaNCC = "NCC" + (ThaoTacDuLieu.DemSoDongCuaBang("NhaCungCap") + 1);
            string query = string.Format("insert into NhaCungCap values('{0}','{1}','{2}','{3}','{4}',1)", strMaNCC, NCC.TenNhaCungCap, NCC.DiaChi, NCC.SoDT, NCC.GhiChu);
            ThaoTacDuLieu.ThucThi(query);
            return strMaNCC;
        }
    }
}
