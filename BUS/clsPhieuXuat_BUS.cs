using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class clsPhieuXuat_BUS
    {
        clsPhieuXuat_DAO dao = new clsPhieuXuat_DAO();
        public DataTable LayBangKhachHangPX(string strMaPhieu)
        {
            return dao.LayBangKhachHangPX(strMaPhieu);
        }
        public DataTable LayBanInPhieuXuat(string strMaPhieu)
        {
            return dao.LayBanInPhieuXuat(strMaPhieu);
        }
        public string TaoPhieuXuat(clsPhieuXuat_DTO phieuXuat)
        {
            return dao.TaoPhieuXuat(phieuXuat);
        }
        public DataTable LayBangPhieuXuat()
        {
            return dao.LayBangPhieuXuat();
        }
        public bool TraTienNo(string strMaPhieu)
        {
            return dao.TraTienNo(strMaPhieu);
        }
        public bool XoaPhieuXuat(string strMaPhieu)
        {
            return dao.XoaPhieuXuat(strMaPhieu);
        }
    }
}
