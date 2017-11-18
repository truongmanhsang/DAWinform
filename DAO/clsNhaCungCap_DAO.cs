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
            string query = string.Format("insert into NhaCungCap values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',1)", strMaNCC, NCC.TenNhaCungCap, NCC.DiaChi, NCC.SoDT, NCC.GhiChu);
            ThaoTacDuLieu.ThucThi(query);
            return strMaNCC;
        }
        public DataTable LayBangNhaCungCapTheoMa(string MaNCC)
        {
            string query = string.Format("select * from NhaCungCap where TrangThai=1 and MaNhaCungCap='{0}'", MaNCC);
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public bool SuaNCC(clsNhaCungCap_DTO NCC)
        {
            string query = string.Format("update NhaCungCap set TenNhaCungCap=N'{0}',DiaChi=N'{1}',SoDT='{2}',GhiChu=N'{3}' where MaNhaCungCap='{4}'", NCC.TenNhaCungCap, NCC.DiaChi, NCC.SoDT, NCC.GhiChu, NCC.MaNhaCungCap);
            return ThaoTacDuLieu.ThucThi(query);
        }

    }
}
