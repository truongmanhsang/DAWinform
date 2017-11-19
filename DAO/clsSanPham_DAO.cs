using ClassLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class clsSanPham_DAO
    {
        public bool XoaSanPham(string strMaSP)
        {
            string query = string.Format("update SanPham set TrangThai=0 where MaSanPham='{0}'",strMaSP);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool SuaSanPham(clsSanPham_DTO sanPham)
        {
            string query = string.Format("update SanPham set TenSanPham=N'{0}',Hinh='{1}',GiaMua='{2}',GiaBan='{3}',KhuyenMai='{4}',MoTa=N'{5}',BaoHanh='{6}',SoLuong='{7}',DonViTinh='{8}',MaLoaiSanPham='{9}',MaHangSanXuat='{10}',GhiChu=N'{11}',TrangThai='{12}' where MaSanPham='{13}'", sanPham.TenSanPham, sanPham.Hinh, sanPham.GiaMua, sanPham.GiaBan, sanPham.KhuyenMai, sanPham.MoTa, sanPham.BaoHanh, sanPham.SoLuong, sanPham.DonViTinh, sanPham.MaLoaiSanPham, sanPham.MaHangSanXuat, sanPham.GhiChu, 1, sanPham.MaSanPham);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool ThemSanPham(clsSanPham_DTO sanPham)
        {
            string strMaSP = "SP" + (ThaoTacDuLieu.DemSoDongCuaBang("SanPham") + 1);
            string query = string.Format("insert into SanPham values('{0}',N'{1}','{2}','{3}','{4}','{5}',N'{6}','{7}','{8}','{9}','{10}','{11}',N'{12}','{13}')", strMaSP, sanPham.TenSanPham, sanPham.Hinh, sanPham.GiaMua, sanPham.GiaBan, sanPham.KhuyenMai, sanPham.MoTa, sanPham.BaoHanh, sanPham.SoLuong, sanPham.DonViTinh, sanPham.MaLoaiSanPham, sanPham.MaHangSanXuat, sanPham.GhiChu, 1);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public DataTable LayBangSanPham()
        {
            string query = "select * from SanPham sp,HangSanXuat hsx,LoaiSanPham lsp where sp.TrangThai=1 and sp.MaHangSanXuat = hsx.MaHangSanXuat and sp.MaLoaiSanPham = lsp.MaLoaiSanPham";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public DataTable LayBangSanPham(string strMaSP)
        {
            string query = string.Format("select * from SanPham sp,HangSanXuat hsx,LoaiSanPham lsp where sp.TrangThai=1 and sp.MaHangSanXuat = hsx.MaHangSanXuat and sp.MaLoaiSanPham = lsp.MaLoaiSanPham and sp.MaSanPham='{0}'", strMaSP);
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public bool ThemSoLuongSP(string strMaSP, int SL)
        {

            string queryUpdateSP = string.Format("update SanPham set SoLuong={1} where MaSanPham='{0}'", strMaSP, SL);
            if (ThaoTacDuLieu.ThucThi(queryUpdateSP))
            {
                int SoDong = 0;
                for (int i = 0; i < SL; i++)
                {
                    string SoSR = TienIch.GenerateSerial(12);
                    SoDong = ThaoTacDuLieu.DemSoDongCuaBang("Serial");
                    string MaSR = "SER" + (SoDong + 1);
                    ThaoTacDuLieu.ThucThi(string.Format("insert into Serial values('{0}','{1}',NULL,'{2}',NULL,{3})", MaSR, SoSR, strMaSP, 1));

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
            string query = string.Format("select BaoHanh from SanPham where MaSanPham='{0}'", strMaSP);
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
