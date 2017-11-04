﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
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
            RegisterMessageBoxManager();
            Application.Run(new frmMain());
            UnregisterMessageBoxManager();
        }
        public static void RegisterMessageBoxManager()
        {
            MessageBoxManager.Yes = "Có";
            MessageBoxManager.No = "Không";
            MessageBoxManager.Register();
        }
        public static void UnregisterMessageBoxManager()
        {
            MessageBoxManager.Unregister();
        }

        // Thông tin nhân viên
        public static string MA_NV = "";
        public static string HINH_NV = "";
        public static string TEN_NV = "";
        public static int QUYEN = 0;
    }
}
