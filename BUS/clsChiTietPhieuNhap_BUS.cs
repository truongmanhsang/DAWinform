using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class clsChiTietPhieuNhap_BUS
    {
        clsChiTietPhieuNhap_DAO dao = new clsChiTietPhieuNhap_DAO();
        public void TaoChiTieuPhieuNhap(List<clsChiTietPhieuNhap_DTO> dsChiTiet, string strMaPhieuNhap)
        {
            dao.TaoChiTieuPhieuNhap(dsChiTiet, strMaPhieuNhap);
        }
        public DataTable LayChiTietPhieu(string strMaPhieu)
        {
            return dao.LayChiTietPhieu(strMaPhieu);
        }
    }
}
