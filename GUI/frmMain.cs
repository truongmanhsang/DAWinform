using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        ucDangNhap ucDN;
        ucMain ucManHinhChinh;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ucDN = new ucDangNhap();
            ucDN.xuLyDangNhap += XuLyDangNhapThanhCong;
            this.Controls.Add(ucDN);
            ucDN.Dock = DockStyle.Fill;

            // ==
            Program.xuLyThoat += Thoat;
        }

        private void XuLyDangNhapThanhCong()
        {
            ucManHinhChinh = ucMain.GetInstance;
            ucManHinhChinh.xuLyDangXuat += XuLyDangXuat;
            this.Controls.Add(ucManHinhChinh);
            ucManHinhChinh.Dock = DockStyle.Fill;
            ucManHinhChinh.BringToFront();
        }

        private void XuLyDangXuat()
        {
            ucDN.BringToFront();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FormMessage.Show("Bạn chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Thoat()
        {
            this.Close();
        }
    }
}
