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
    public partial class ucTimKiemNCC : UserControl
    {
        public event XuLiGuiMa guiMa;
        clsNhaCungCap_BUS _NhaCungCapBUS = new clsNhaCungCap_BUS();

        DataTable dtNhaCungCap;
        DataView dvNhaCungCap;

        public ucTimKiemNCC()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!chkSoDT.Checked && !chkTenKH.Checked)
            {
                dvNhaCungCap.RowFilter = "TRUE";
            }
            else
            {
                dvNhaCungCap.RowFilter = TaoCauTruyVan();
            }
        }

        private void ucTimKiemNCC_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvNCC.AutoGenerateColumns = false;
        }

        private void TaiDuLieu()
        {
            dtNhaCungCap = _NhaCungCapBUS.LayBangNhaCungCap();
            dvNhaCungCap = new DataView(dtNhaCungCap);
            dgvNCC.DataSource = dvNhaCungCap;
        }

        private string TaoCauTruyVan()
        {
            string strTruyVan = string.Empty;
            if (chkTenKH.Checked)
            {
                strTruyVan += string.Format("TenNhaCungCap like '%{0}%'", txtTenNCC.Text);
            }
            if (chkSoDT.Checked)
            {
                if (strTruyVan != "")
                {
                    strTruyVan += " and ";
                }
                strTruyVan += string.Format("SoDT like '%{0}%'", txtSoDT.Text);
            }
            return strTruyVan;
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNCC.Rows[0].Index != -1)
            {
                string strMa = dgvNCC.SelectedRows[0].Cells["colMaNCC"].Value.ToString();
                if (guiMa != null)
                    guiMa(strMa);
            }
        }
    }
}
