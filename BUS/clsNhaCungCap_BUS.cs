using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class clsNhaCungCap_BUS
    {
        clsNhaCungCap_DAO dao = new clsNhaCungCap_DAO();
        public DataTable LayBangNhaCungCap()
        {
            return dao.LayBangNhaCungCap();
        }
        public string ThemNCC(clsNhaCungCap_DTO NCC)
        {
            return dao.ThemNCC(NCC);
        }
        public DataTable LayBangNhaCungCapTheoMa(string MaNCC)
        {
            return dao.LayBangNhaCungCapTheoMa(MaNCC);
        }
        public bool SuaNCC(clsNhaCungCap_DTO NCC)
        {
            return dao.SuaNCC(NCC);
        }
    }
}
