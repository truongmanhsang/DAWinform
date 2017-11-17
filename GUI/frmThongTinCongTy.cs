using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinCongTy : Form
    {
        public frmThongTinCongTy()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTinCongTy_Load(object sender, EventArgs e)
        {
            string[] strThongTinCaiDat = File.ReadAllLines("settings.ini");
            foreach (string str in strThongTinCaiDat)
            {
                if (str.Split('=')[0] == "tenCongTy")
                {
                    txtTenCongTy.Text = str.Split('=')[1];
                }
                if (str.Split('=')[0] == "diaChi")
                {
                    txtDiaChi.Text = str.Split('=')[1];
                }
                if (str.Split('=')[0] == "dienThoai")
                {
                    txtDienThoai.Text = str.Split('=')[1];
                }
                if (str.Split('=')[0] == "website")
                {
                    txtWebsite.Text = str.Split('=')[1];
                }
                if (str.Split('=')[0] == "logo")
                {
                    picLogo.Image = new Bitmap(str.Split('=')[1]);
                }
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
       + "Tất cả định dạng ảnh|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            openFileDialog.FilterIndex = 6;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   // picHinh.Image = new Bitmap(openFileDialog.FileName);
                    //strDuongDanHinh = openFileDialog.FileName;
                    //strTenHinh = openFileDialog.SafeFileName;
                }
                catch
                {
                    FormMessage.Show("Hình lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string strThongTinCaiDat
        }
    }
}
