using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietPhieuXuatBUS
    {
        ChiTietPhieuXuatDAO _ChiTietPhieuXuatDAO = new ChiTietPhieuXuatDAO();
        public void TaoChiTieuPhieuXuat(List<ChiTietPhieuXuatDTO> dsChiTiet, string strMaPhieuXuat)
        {
            _ChiTietPhieuXuatDAO.TaoChiTieuPhieuXuat(dsChiTiet, strMaPhieuXuat);
        }
    }
}
