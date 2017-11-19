using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class clsThongKe_BUS
    {
        clsThongKe_DAO dao = new clsThongKe_DAO();
        public DataTable TinhThongKe()
        {
            return dao.TinhThongKe();
        }
        public DataTable TinhLoiNhuan()
        {
            return dao.TinhLoiNhuan();
        }
        public int LaySLBan(string strNgay)
        {
            return dao.LaySLBan(strNgay);
        }
        public int LaySLNhap(string strNgay)
        {
            return dao.LaySLNhap(strNgay);
        }
    }
}
