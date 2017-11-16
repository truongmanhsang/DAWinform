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
    public class clsChiTietBaoHanh_BUS
    {
        clsChiTietBaoHanh_DAO dao = new clsChiTietBaoHanh_DAO();
        public void ThemChiTietBaoHanh(List<clsChiTietBaoHanh_DTO> dsChiTiet, string strMaBH)
        {
            dao.ThemChiTietBaoHanh(dsChiTiet, strMaBH);
        }
        public DataTable LayBangChiTietBH(string strMaBH)
        {
            return dao.LayBangChiTietBH(strMaBH);
        }
        public DataTable LayBangChiTietKhoBH()
        {
            return dao.LayBangChiTietKhoBH();
        }
        public void CapNhapBaoHanh(string strSoSerial)
        {
            dao.CapNhapBaoHanh(strSoSerial);
        }
    }
}
