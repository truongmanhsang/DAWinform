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
        private string strDuongDanTuyetDoi;
        private string strTenHinh;
        private string strDuongDanTuongDoi;

        private List<string> lstThongTinCaiDat;

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
            lstThongTinCaiDat = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader("settings.ini"))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        lstThongTinCaiDat.Add(str);

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
                            strDuongDanTuongDoi = str.Split('=')[1];
                        }
                    }
                    sr.Close();
                }
            }
            catch
            {
                FormMessage.Show("Không tìm thấy file cấu hình!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    picLogo.Image = new Bitmap(openFileDialog.FileName);
                    strDuongDanTuyetDoi = openFileDialog.FileName;
                    strTenHinh = openFileDialog.SafeFileName;
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
            string temp = string.Empty;
            if (picLogo.Image != null && strDuongDanTuyetDoi != null)
            {
                try
                {
                    File.Copy(strDuongDanTuyetDoi, Application.StartupPath + @"\data\images\logo\" + strTenHinh, true);
                }
                catch
                {

                }
                strDuongDanTuongDoi = @"data\images\logo\" + strTenHinh;
            }
            else
            {
                if (picLogo.Image == null)
                    strDuongDanTuongDoi = @"data\images\empty.png";
            }
            for (int i = 0; i < lstThongTinCaiDat.Count; i++)
            {
                if (lstThongTinCaiDat[i].Split('=')[0] == "tenCongTy")
                {
                    temp = "tenCongTy=" + txtTenCongTy.Text;
                    lstThongTinCaiDat[i] = temp;
                }
                if (lstThongTinCaiDat[i].Split('=')[0] == "diaChi")
                {
                    temp = "diaChi=" + txtDiaChi.Text;
                    lstThongTinCaiDat[i] = temp;
                }
                if (lstThongTinCaiDat[i].Split('=')[0] == "dienThoai")
                {
                    temp = "dienThoai=" + txtDienThoai.Text;
                    lstThongTinCaiDat[i] = temp;
                }
                if (lstThongTinCaiDat[i].Split('=')[0] == "website")
                {
                    temp = "website=" + txtWebsite.Text;
                    lstThongTinCaiDat[i] = temp;
                }
                if (lstThongTinCaiDat[i].Split('=')[0] == "logo")
                {
                    temp = "logo=" + strDuongDanTuongDoi;
                    lstThongTinCaiDat[i] = temp;
                }
            }
            try
            {
                using (StreamWriter sw = new StreamWriter("settings.ini"))
                {
                    foreach (string sr in lstThongTinCaiDat)
                    {
                        sw.WriteLine(sr);
                    }
                    sw.Close();
                }
                FormMessage.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                FormMessage.Show("Không thể lưu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThongTinCongTy_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
