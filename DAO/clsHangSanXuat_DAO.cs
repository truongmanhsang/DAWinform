using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsHangSanXuat_DAO
    {
        public DataTable LayBangHangSanXuat()
        {
            string query = "select * from HangSanXuat where TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public DataTable LayBangHangSanXuat(string strMaHSX)
        {
            string query = string.Format("select * from HangSanXuat where TrangThai=1 and MaHangSanXuat='{0}'", strMaHSX);
            return ThaoTacDuLieu.LayBang(query);
        }
        public DataTable KiemTraTen(string strTen)
        {
            return ThaoTacDuLieu.LayBang(string.Format("select * from HangSanXuat where TenHangSanXuat='{0}'", strTen));
        }
        public bool ThemHSX(clsHangSanXuat_DTO HSX)
        {
            string strMaHSX = "HSX" + (ThaoTacDuLieu.DemSoDongCuaBang("HangSanXuat") + 1);
            string query = string.Format("insert into HangSanXuat values('{0}',N'{1}',N'{2}','{3}')", strMaHSX, HSX.TenHangSanXuat, HSX.GhiChu, 1);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool SuaHSX(clsHangSanXuat_DTO HSX)
        {
            string query = string.Format("update HangSanXuat set TenHangSanXuat=N'{0}',GhiChu=N'{1}',TrangThai=1 where MaHangSanXuat='{2}'", HSX.TenHangSanXuat, HSX.GhiChu, HSX.MaHangSanXuat);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool XoaHSX(string strMaHSX)
        {
            return ThaoTacDuLieu.ThucThi(string.Format("update HangSanXuat set TrangThai=0 where MaHangSanXuat='{0}'", strMaHSX));
        }
    }
}
