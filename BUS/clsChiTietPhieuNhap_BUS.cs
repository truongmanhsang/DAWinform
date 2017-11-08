using DAO;
using DTO;
using System;
using System.Collections.Generic;
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
    }
}
