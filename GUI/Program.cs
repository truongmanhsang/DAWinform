using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public delegate void XuLyTaiLaiDuLieu();
    public delegate void XuLyThoat();

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static event XuLyTaiLaiDuLieu xuLyTaiLaiDuLieu;
        public static event XuLyThoat xuLyThoat;

        public static void TaiLaiDuLieu()
        {
            if (xuLyTaiLaiDuLieu != null)
                xuLyTaiLaiDuLieu();
        }
        public static void Thoat()
        {
            if (xuLyThoat != null)
                xuLyThoat();
        }

        // Thông tin nhân viên
        public static string MA_NV = "";
        public static string HINH_NV = "";
        public static string TEN_NV = "";
        public static int QUYEN = 0;
    }
}
