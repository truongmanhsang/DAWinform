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
    public delegate void XuLiGuiMa(string strMa);
    public partial class ucTimKiemKH : UserControl
    {
        public event XuLiGuiMa guiMa;
        clsKhachHang_BUS _KhachHangBUS = new clsKhachHang_BUS();

        DataTable dtKhachHang;
        DataView dvKhachHang;
        public ucTimKiemKH()
        {
            InitializeComponent();
        }

        private void ucTimKiemKH_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }

        private void CaiDat()
        {
            dgvKhachHang.AutoGenerateColumns = false;
        }

        private void TaiDuLieu()
        {
            dtKhachHang = _KhachHangBUS.LayBangKhachHang();
            dvKhachHang = new DataView(dtKhachHang);
            dgvKhachHang.DataSource = dvKhachHang;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!chkSoDT.Checked && !chkTenKH.Checked)
            {
                dvKhachHang.RowFilter = "TRUE";
            }
            else
            {
                dvKhachHang.RowFilter = TaoCauTruyVan();
            }
        }
        private string TaoCauTruyVan()
        {
            string strTruyVan = string.Empty;
            if (chkTenKH.Checked)
            {
                strTruyVan += string.Format("TenKhachHang like '%{0}%'", txtTenKH.Text);
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.Rows[0].Index != -1)
            {
                string strMa = dgvKhachHang.SelectedRows[0].Cells["colMaKH"].Value.ToString();
                if (guiMa != null)
                    guiMa(strMa);
            }
        }
    }
}
