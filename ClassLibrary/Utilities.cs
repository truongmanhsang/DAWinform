using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Utilities
    {
        public static string GenerateSerial(int iLength)
        {
            StringBuilder strSerial = new StringBuilder();
            string strTemp = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            for (int i = 0; i < iLength; i++)
            {
                char c = strTemp[rand.Next(0, strTemp.Length)];
                strSerial.Append(c);
            }
            return strSerial.ToString();
        }
    }
}
