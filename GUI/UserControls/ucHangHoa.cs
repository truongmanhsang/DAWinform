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
    public partial class ucHangHoa : UserControl
    {
        ucSanPham _ucSanPham;
        ucLoai _ucLoai;
        ucHangSanXuat _ucHangSanXuat;
        ucSerial _ucSerial;
        public ucHangHoa()
        {
            InitializeComponent();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            _ucSanPham = new ucSanPham();
            panMain.Controls.Add(_ucSanPham);
            _ucSanPham.Dock = DockStyle.Fill;
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            _ucLoai = new ucLoai();
            panMain.Controls.Add(_ucLoai);
            _ucLoai.Dock = DockStyle.Fill;
        }

        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            _ucHangSanXuat = new ucHangSanXuat();
            panMain.Controls.Add(_ucHangSanXuat);
            _ucHangSanXuat.Dock = DockStyle.Fill;
        }

        private void ucHangHoa_Load(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            _ucSanPham = new ucSanPham();
            panMain.Controls.Add(_ucSanPham);
            _ucSanPham.Dock = DockStyle.Fill;
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            _ucSerial = new ucSerial();
            panMain.Controls.Add(_ucSerial);
            _ucSerial.Dock = DockStyle.Fill;
        }

        public void BatUCSerial()
        {
            btnSerial_Click(null, null);
        }
    }
}
