using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO dao = new KhachHangDAO();
        public DataTable LayBangKhachHang()
        {
            return dao.LayBangKhachHang();
        }
        public string ThemKhachHang(KhachHangDTO khachHang)
        {
            return dao.ThemKhachHang(khachHang);
        }
    }
}
