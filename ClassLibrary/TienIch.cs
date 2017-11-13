using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class TienIch
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
        public static string ChuyenSoSangVND(decimal iSo)
        {
            return string.Format("{0:#,##0} VNĐ", iSo);
        }
        public static decimal ChuyenVNDSangSo(string strVND)
        {
            return Convert.ToInt64(strVND.Replace(".", "").Replace(",", "").Replace("VNĐ",""));
        }
        public static void DinhDangSoTextBox(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                decimal valueBefore = Decimal.Parse(textBox.Text);
                textBox.Text = String.Format("{0:#,##0}", valueBefore);
                textBox.Select(textBox.Text.Length, 0);
            }
        }
        public static string HuyDinhDangSo(string str)
        {
            return str.Replace(",", "").Replace(".", "");
        }
        public static void BuocNhapSo(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static string LayNgayThangHienTaiQuocTe()
        {
            return DateTime.Now.ToString("MM/dd/yyyy");
        }
        public static string LayNgayThangQuocTe(DateTime dt)
        {
            return dt.ToString("MM/dd/yyyy");
        }
        public static string LayNgayThangVN(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy");
        }
        
    }
}
