﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class clsPhieuXuat_DAO
    {
        public DataTable LayBangPhieuXuat()
        {
            string query = "select * from PhieuXuat px, NhanVien nv, KhachHang kh where px.NhanVienLap = nv.MaNhanVien and px.MaKhachHang = kh.MaKhachHang and px.TrangThai=1";
            DataTable dt = ThaoTacDuLieu.LayBang(query);
            return dt;
        }
        public string TaoPhieuXuat(clsPhieuXuat_DTO phieuXuat)
        {
            int iResult = 0;
            SqlConnection conn = ThaoTacDuLieu.TaoVaMoKetNoi();
            string strMaPhieu = "PX" + (ThaoTacDuLieu.DemSoDongCuaBang("PhieuXuat") + 1); // Tạo mã mới
            string sqlInsertPhieu = string.Format("insert into PhieuXuat values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}',1)", strMaPhieu, phieuXuat.MaKhachHang, phieuXuat.TongTien, phieuXuat.TienNo, phieuXuat.ChietKhau, phieuXuat.Thue, phieuXuat.NgayLap, phieuXuat.MaNVLap, phieuXuat.GhiChu, phieuXuat.TinhTrang);
            SqlCommand cmd = new SqlCommand(sqlInsertPhieu, conn);
            iResult = cmd.ExecuteNonQuery();
            ThaoTacDuLieu.DongKetNoi(conn);
            return strMaPhieu;
        }
        public bool TraTienNo(string strMaPhieu)
        {
            string query = string.Format("update PhieuXuat set TienNo=0 where MaPhieuXuat='{0}'",strMaPhieu);
            return ThaoTacDuLieu.ThucThi(query);
        }
        public bool XoaPhieuXuat(string strMaPhieu)
        {
            string query = string.Format("update PhieuXuat set TrangThai=0 where MaPhieuXuat='{0}'", strMaPhieu);
            return ThaoTacDuLieu.ThucThi(query);
        }
    }
}
