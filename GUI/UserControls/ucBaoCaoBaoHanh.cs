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
using ClassLibrary;

namespace GUI
{
    public partial class ucBaoCaoBaoHanh : UserControl
    {
        clsBaoHanh_BUS _BaoHanhBUS = new clsBaoHanh_BUS();
        clsChiTietBaoHanh_BUS _ChiTietBaoHanhBUS = new clsChiTietBaoHanh_BUS();
        clsNhanVien_BUS _NhanVienBUS = new clsNhanVien_BUS();

        DataTable dtBaoHanh;
        DataTable dtNhanVien;

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

            dtNhanVien = _NhanVienBUS.LayBangNhanVien();
            cboNV.DataSource = dtNhanVien;
            cboNV.DisplayMember = "TenNhanVien";
            cboNV.ValueMember = "MaNhanVien";
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (chkNgay.Checked || chkNV.Checked || chkMaKH.Checked)
            {
                dvBaoHanh.RowFilter = TaoCauTruyVan();
            }
            else
            {
                dvBaoHanh.RowFilter = "TRUE";
            }
        }

        private string TaoCauTruyVan()
        {
            string strTruyVan = string.Empty;
            if (chkNgay.Checked)
            {
                strTruyVan += string.Format("NgayBaoHanh >= #{0}# and NgayBaoHanh <= #{1}#", TienIch.LayNgayThangQuocTe(dtpNgayDau.Value), TienIch.LayNgayThangQuocTe(dtpNgayCuoi.Value));
            }
            if (chkNV.Checked)
            {
                if (strTruyVan != "")
                {
                    strTruyVan += " and ";
                }
                strTruyVan += string.Format("MaNhanVien = '{0}'",cboNV.SelectedValue);
            }
            if (chkMaKH.Checked)
            {
                if (strTruyVan != "")
                {
                    strTruyVan += " and ";
                }
                strTruyVan += string.Format("MaKhachHang = '{0}'", txtMaKH.Text);
            }
            return strTruyVan;
        }

        private void llblTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTim frm = new frmTim(frmTim.Loai.KhachHang);
            frm.ShowDialog();
            txtMaKH.Text = frm.LayMa();
        }

        private void dgvBaoHanh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBaoHanh.Columns[e.ColumnIndex].Name == "colNgayBaoHanh")
            {
                e.Value = TienIch.LayNgayThangVN(Convert.ToDateTime(e.Value.ToString()));
            }
        }

        private void dgvChiTietBaoHanh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvChiTietBaoHanh.Columns[e.ColumnIndex].Name == "colNgayHenTra")
            {
                e.Value = TienIch.LayNgayThangVN(Convert.ToDateTime(e.Value.ToString()));
            }
        }
    }
}
