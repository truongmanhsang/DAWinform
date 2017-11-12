using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class clsSerial_BUS
    {
        clsSerial_DAO dao = new clsSerial_DAO();
        public DataTable LayBangSerial()
        {
            return dao.LayBangSerial();
        }
        public string LayMaSerial(string strMaSP, int iSoThangBH)
        {
            return dao.LayMaSerial(strMaSP, iSoThangBH);
        }
        public void BatDauBaoHanh(string strMaSP, int iSL, string strMaPhieuXuat)
        {
            dao.BatDauBaoHanh(strMaSP, iSL, strMaPhieuXuat);
        }
        public void ThemSoSerial(string strMaSP, int iSL, string strMaPhieu)
        {
            dao.ThemSoSerial(strMaSP, iSL, strMaPhieu);
        }
    }
}
