﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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


        public static String ChuyenSoSangChu(decimal total)  //đọc đc 18 số vd: 999999999999999999
        {
            try
            {
                string rs = "";
                total = Math.Round(total, 0);
                string[] ch = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] rch = { "lẻ", "mốt", "", "", "", "lăm" };
                string[] u = { "", "mươi", "trăm", "ngàn", "", "", "triệu", "", "", "tỷ", "", "", "ngàn", "", "", "triệu" };
                string nstr = total.ToString();
                int[] n = new int[nstr.Length];
                int len = n.Length;
                for (int i = 0; i < len; i++)
                {
                    n[len - 1 - i] = Convert.ToInt32(nstr.Substring(i, 1));
                }
                for (int i = len - 1; i >= 0; i--)
                {
                    if (i % 3 == 2)// số 0 ở hàng trăm
                    {
                        if (n[i] == 0 && n[i - 1] == 0 && n[i - 2] == 0) continue;//nếu cả 3 số là 0 thì bỏ qua không đọc
                    }
                    else if (i % 3 == 1) // số ở hàng chục
                    {
                        if (n[i] == 0)
                        {
                            if (n[i - 1] == 0) { continue; }// nếu hàng chục và hàng đơn vị đều là 0 thì bỏ qua.
                            else
                            {
                                rs += " " + rch[n[i]]; continue;// hàng chục là 0 thì bỏ qua, đọc số hàng đơn vị
                            }
                        }
                        if (n[i] == 1)//nếu số hàng chục là 1 thì đọc là mười
                        {
                            rs += " mười"; continue;
                        }
                    }
                    else if (i != len - 1)// số ở hàng đơn vị (không phải là số đầu tiên)
                    {
                        if (n[i] == 0)// số hàng đơn vị là 0 thì chỉ đọc đơn vị
                        {
                            if (i + 2 <= len - 1 && n[i + 2] == 0 && n[i + 1] == 0) continue;
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 1)// nếu là 1 thì tùy vào số hàng chục mà đọc: 0,1: một / còn lại: mốt
                        {
                            rs += " " + ((n[i + 1] == 1 || n[i + 1] == 0) ? ch[n[i]] : rch[n[i]]);
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 5) // cách đọc số 5
                        {
                            if (n[i + 1] != 0) //nếu số hàng chục khác 0 thì đọc số 5 là lăm
                            {
                                rs += " " + rch[n[i]];// đọc số 
                                rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                                continue;
                            }
                        }
                    }
                    rs += (rs == "" ? " " : " ") + ch[n[i]];// đọc số
                    rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                }
                if (rs[rs.Length - 1] != ' ')
                    rs += " đồng.";
                else
                    rs += "đồng.";
                if (rs.Length > 2)
                {
                    string rs1 = rs.Substring(0, 2);
                    rs1 = rs1.ToUpper();
                    rs = rs.Substring(2);
                    rs = rs1 + rs;
                }
                return rs.Trim().Replace("lẻ,", "lẻ").Replace("mươi,", "mươi").Replace("trăm,", "trăm").Replace("mười,", "mười");
            }
            catch
            {
                return "Số bạn nhập vào quá lớn";
            }
        }


        public static string MaHoaMatKhau(string strMK)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(strMK));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

    }
}
