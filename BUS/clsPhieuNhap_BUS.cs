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
    public class clsPhieuNhap_BUS
    {
        clsPhieuNhap_DAO dao = new clsPhieuNhap_DAO();
        public string TaoPhieuNhap(clsPhieuNhap_DTO phieuNhap)
        {
            return dao.TaoPhieuNhap(phieuNhap);
        }
        public DataTable LayBangPhieuNhap()
        {
            return dao.LayBangPhieuNhap();
        }
        public bool TraTienNo(string strMaPhieu)
        {
            return dao.TraTienNo(strMaPhieu);
        }
        public bool XoaPhieuNhap(string strMaPhieu)
        {
            return dao.XoaPhieuNhap(strMaPhieu);
        }
        public DataTable LayBangInPhieuNhap(string strMaPhieu)
        {
            return dao.LayBangInPhieuNhap(strMaPhieu);
        }
        public DataTable LayBangNCCPhieuNhap(string strMaPhieu)
        {
            return dao.LayBangNCCPhieuNhap(strMaPhieu);
        }
    }
}
