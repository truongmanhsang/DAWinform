using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsLoai_DAO
    {
        public DataTable LayBangLoai()
        {
            string query = "select * from LoaiSanPham where TrangThai=1";
            return ThaoTacDuLieu.LayBang(query);
        }
        public DataTable LayBangLoai(string strMaLoai)
        {
            string query = string.Format("select * from LoaiSanPham where TrangThai=1 and MaLoaiSanPham='{0}'", strMaLoai);
            return ThaoTacDuLieu.LayBang(query);
        }
        public DataTable KiemTraTen(string strTen)
        {
            return ThaoTacDuLieu.LayBang(string.Format("select * from LoaiSanPham where TenLoaiSanPham='{0}'", strTen));
        }
        public bool ThemLoai(clsLoai_DTO loai)
        {
            string strMaLoai = "LSP" + (ThaoTacDuLieu.DemSoDongCuaBang("LoaiSanPham") + 1);
            string query = string.Format("insert into LoaiSanPham values('{0}',N'{1}',N'{2}','{3}')", strMaLoai, loai.TenLoaiSanPham, loai.GhiChu, 1);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool SuaLoai(clsLoai_DTO loai)
        {
            string query = string.Format("update LoaiSanPham set TenLoaiSanPham=N'{0}',GhiChu=N'{1}',TrangThai=1 where MaLoaiSanPham='{2}'", loai.TenLoaiSanPham, loai.GhiChu, loai.MaLoaiSanPham);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool XoaLoai(string strMaLoai)
        {
            return ThaoTacDuLieu.ThucThi(string.Format("update LoaiSanPham set TrangThai=0 where MaLoaiSanPham='{0}'",strMaLoai));
        }

    }
}
