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
    public class clsChiTietPhieuXuat_BUS
    {
        clsChiTietPhieuXuat_DAO _ChiTietPhieuXuatDAO = new clsChiTietPhieuXuat_DAO();
        public void TaoChiTieuPhieuXuat(List<clsChiTietPhieuXuat_DTO> dsChiTiet, string strMaPhieuXuat)
        {
            _ChiTietPhieuXuatDAO.TaoChiTieuPhieuXuat(dsChiTiet, strMaPhieuXuat);
        }
        public DataTable LayChiTietPhieu(string strMaPhieu)
        {
            return _ChiTietPhieuXuatDAO.LayChiTietPhieu(strMaPhieu);
        }
    }
}
