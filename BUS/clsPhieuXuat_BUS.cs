using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class clsPhieuXuat_BUS
    {
        clsPhieuXuat_DAO dao = new clsPhieuXuat_DAO();
        public string TaoPhieuXuat(clsPhieuXuat_DTO phieuXuat)
        {
            return dao.TaoPhieuXuat(phieuXuat);
        }
    }
}
