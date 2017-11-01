using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuXuatBUS
    {
        PhieuXuatDAO dao = new PhieuXuatDAO();
        public int TaoPhieuXuat(PhieuXuatDTO phieuXuat, List<ChiTietPhieuXuatDTO> dsChiTiet)
        {
            return dao.TaoPhieuXuat(phieuXuat, dsChiTiet);
        }
    }
}
