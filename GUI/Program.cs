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

        public static string MA_NV = "";
    }
}
