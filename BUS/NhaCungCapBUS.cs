using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAO dao = new NhaCungCapDAO();
        public DataTable LayBangNhaCungCap()
        {
            return dao.LayBangNhaCungCap();
        }
    }
}
