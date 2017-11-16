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
    public partial class ucKhoBaoHanh : UserControl
    {
        clsChiTietBaoHanh_BUS _ChiTietBaoHanhBUS = new clsChiTietBaoHanh_BUS();

        DataTable dtChiTiet;
        DataView dvChiTiet;
        public ucKhoBaoHanh()
        {
            InitializeComponent();
        }

        private void ucKhoBaoHanh_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvSanPhamBH.AutoGenerateColumns = false;
            cboLoai.SelectedIndex = 0;
        }
        private void TaiDuLieu()
        {
            dtChiTiet = _ChiTietBaoHanhBUS.LayBangChiTietKhoBH();
            dvChiTiet = new DataView(dtChiTiet);
            dgvSanPhamBH.DataSource = dvChiTiet;
        }

        private void dgvSanPhamBH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPhamBH.Columns[e.ColumnIndex].Name == "colTinhTrang")
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "Chưa bảo hành";
                }
                else if (e.Value.ToString() == "2")
                {
                    e.Value = "Hàng bị đổi";
                }
                else if (e.Value.ToString() == "3")
                {
                    e.Value = "Hàng trả";
                }
            }
        }

        private void llblTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTim frm = new frmTim(frmTim.Loai.NhaCungCap);
            frm.ShowDialog();
            txtMaNCC.Text = frm.LayMa();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkNgayGui.Checked || chkLoai.Checked || chkMaNCC.Checked)
            {
                dvChiTiet.RowFilter = TaoCauTruyVan();
            }
            else
            {
                dvChiTiet.RowFilter = "TRUE";
            }
        }
        private string TaoCauTruyVan()
        {
            string strTruyVan = string.Empty;
            if (chkNgayGui.Checked)
            {
                strTruyVan += string.Format("NgayBaoHanh >= #{0}# and NgayBaoHanh <= #{1}#",TienIch.LayNgayThangQuocTe(dtpNgayDau.Value), TienIch.LayNgayThangQuocTe(dtpNgayCuoi.Value));
            }
            if (chkLoai.Checked)
            {
                if (strTruyVan != "")
                {
                    strTruyVan += " and ";
                }

                if (cboLoai.SelectedIndex == 0)
                {
                    strTruyVan += "TRUE";
                }else if (cboLoai.SelectedIndex == 1)
                {
                    strTruyVan += "TinhTrang=0";
                }else if (cboLoai.SelectedIndex == 2)
                {
                    strTruyVan += "TinhTrang=2";
                }else if (cboLoai.SelectedIndex == 3)
                {
                    strTruyVan += "TinhTrang=3";
                }
            }
            if (chkMaNCC.Checked)
            {
                if (strTruyVan != "")
                {
                    strTruyVan += " and ";
                }

                strTruyVan += string.Format("MaNhaCungCap='{0}'", txtMaNCC.Text);
            }
            return strTruyVan;
        }
    }
}
