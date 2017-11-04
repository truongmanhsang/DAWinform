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
        public string TaoPhieuXuat(PhieuXuatDTO phieuXuat)
        {
            return dao.TaoPhieuXuat(phieuXuat);
        }
    }
}
