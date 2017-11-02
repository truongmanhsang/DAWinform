﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucThongKe : UserControl
    {
        private static ucThongKe _instance = null;
        public static ucThongKe GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucThongKe();
                }
                return _instance;
            }
        }
        public ucThongKe()
        {
            InitializeComponent();
        }
    }
}