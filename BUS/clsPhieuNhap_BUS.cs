using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class clsPhieuNhap_BUS
    {
        clsPhieuNhap_DAO dao = new clsPhieuNhap_DAO();
        public string TaoPhieuNhap(clsPhieuNhap_DTO phieuNhap)
        {
            return dao.TaoPhieuNhap(phieuNhap);
        }
    }
}
