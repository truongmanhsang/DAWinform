using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTim : Form
    {
        public enum Loai
        {
            KhachHang,
            NhaCungCap
        }

        Loai loai;
        string strMa;

        public frmTim()
        {
            InitializeComponent();
        }
        public frmTim(Loai loai)
        {
            InitializeComponent();
            this.loai = loai;
        }

        private void frmTim_Load(object sender, EventArgs e)
        {
            if (loai == Loai.KhachHang)
            {
                ucTimKiemKH uc = new ucTimKiemKH();
                uc.guiMa += NhanMa;
                panMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
        }

        private void NhanMa(string strMa)
        {
            this.strMa = strMa;
        }

        public string LayMa()
        {
            return strMa;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (strMa == null)
            {
                FormMessage.Show("Vui lòng chọn 1 KH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
