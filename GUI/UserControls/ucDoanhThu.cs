using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class ucDoanhThu : UserControl
    {
        DataTable dtPhieuXuat;
        DataTable dtPhieuNhap;
        clsPhieuXuat_BUS _PhieuXuatBUS = new clsPhieuXuat_BUS();
        clsPhieuNhap_BUS _PhieuNhapBUS = new clsPhieuNhap_BUS();

        public ucDoanhThu()
        {
            InitializeComponent();
        }

        private void ucDoanhThu_Load(object sender, EventArgs e)
        {
            caiDat();
            loadDuLieu();
        }

        private void caiDat()
        {
            dgvDuLieu.AutoGenerateColumns = false;
        }

        private void loadDuLieu()
        {
            
            dgvDuLieu.DataSource = _PhieuXuatBUS.LayBangPhieuXuat();
            dgvDuLieu.DataSource = _PhieuNhapBUS.LayBangPhieuNhap();
        }
    }
}
