using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class SerialBUS
    {
        SerialDAO dao = new SerialDAO();
        public string LayMaSerial(string strMaSP, int iSoThangBH)
        {
            return dao.LayMaSerial(strMaSP, iSoThangBH);
        }
    }
}
