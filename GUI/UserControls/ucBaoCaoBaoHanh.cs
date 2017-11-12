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
    public partial class ucBaoCaoBaoHanh : UserControl
    {
        clsBaoHanh_BUS _BaoHanhBUS = new clsBaoHanh_BUS();
        clsChiTietBaoHanh_BUS _ChiTietBaoHanhBUS = new clsChiTietBaoHanh_BUS();

        DataTable dtBaoHanh;
        DataView dvBaoHanh;
        public ucBaoCaoBaoHanh()
        {
            InitializeComponent();
        }

        private void ucBaoCaoBaoHanh_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvBaoHanh.AutoGenerateColumns = false;
            dgvChiTietBaoHanh.AutoGenerateColumns = false;
        }
        private void TaiDuLieu()
        {
            dtBaoHanh = _BaoHanhBUS.LayBangBaoHanh();
            dvBaoHanh = new DataView(dtBaoHanh);
            dgvBaoHanh.DataSource = dvBaoHanh;
        }

        private void dgvBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string strMaBH = dgvBaoHanh.SelectedRows[0].Cells["colMaBH"].Value.ToString();
                DataTable dtChiTiet = _ChiTietBaoHanhBUS.LayBangChiTietBH(strMaBH);
                dgvChiTietBaoHanh.DataSource = dtChiTiet;
            }
        }
    }
}
