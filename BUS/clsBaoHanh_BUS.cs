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
    public class clsBaoHanh_BUS
    {
        clsBaoHanh_DAO dao = new clsBaoHanh_DAO();
        public string ThemBaoHanh(clsBaoHanh_DTO baoHanh)
        {
            return dao.ThemBaoHanh(baoHanh);
        }
        public DataTable LayBangBaoHanh()
        {
            return dao.LayBangBaoHanh();
        }
    }
}
