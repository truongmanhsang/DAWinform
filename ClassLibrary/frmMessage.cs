using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public partial class frmMessage : Form
    {
        MessageBoxButtons msbButtons;
        DialogResult result;
        public frmMessage()
        {
            InitializeComponent();
        }
        public frmMessage(string strNoiDung, string strTieuDe, MessageBoxButtons msbButtons, Bitmap bmpBieuTuong)
        {
            InitializeComponent();
            lblNoiDung.Text = strNoiDung;
            Text = strTieuDe;
            picBieuTuong.Image = new Bitmap( bmpBieuTuong, new Size(45,45));
            this.msbButtons = msbButtons;

            if (msbButtons == MessageBoxButtons.YesNo)
            {
                btnChucNang1.Text = "Có";
                btnChucNang2.Text = "Không";
                btnChucNang1.Focus();
            }
            else if (msbButtons == MessageBoxButtons.OK)
            {
                btnChucNang2.Text = "Đồng ý";
                btnChucNang1.Visible = false;
            }
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {

        }

        public DialogResult LayDialogResult()
        {
            return result;
        }

        private void btnChucNang1_Click(object sender, EventArgs e)
        {
            if (msbButtons == MessageBoxButtons.YesNo)
            {
                result = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnChucNang2_Click(object sender, EventArgs e)
        {
            if (msbButtons == MessageBoxButtons.YesNo)
            {
                result = DialogResult.No;
                this.Close();
            }
            else if (msbButtons == MessageBoxButtons.OK)
            {
                result = DialogResult.OK;
                this.Close();
            }
        }

        private void frmMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (msbButtons == MessageBoxButtons.YesNo)
            {
                if (result == DialogResult.Yes)
                    result = DialogResult.Yes;
                else if (result == DialogResult.No)
                    result = DialogResult.No;
                else
                    result = DialogResult.No;                  
            }
        }
    }
}
