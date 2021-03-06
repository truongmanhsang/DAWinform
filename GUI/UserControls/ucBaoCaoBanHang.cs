﻿using System;
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
    public partial class ucBaoCaoBanHang : UserControl
    {
        clsPhieuXuat_BUS _PhieuXuatBUS = new clsPhieuXuat_BUS();
        clsChiTietPhieuXuat_BUS _ChiTietPhieuXuatBUS = new clsChiTietPhieuXuat_BUS();
        clsNhanVien_BUS _NhanVienBUS = new clsNhanVien_BUS();

        DataTable dtPhieuXuat;
        DataTable dtNhanVien;

        DataView dvPhieuXuat;

        public ucBaoCaoBanHang()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            dtPhieuXuat = _PhieuXuatBUS.LayBangPhieuXuat();
            dvPhieuXuat = new DataView(dtPhieuXuat);
            dgvPhieuXuat.DataSource = dvPhieuXuat;

            dtNhanVien = _NhanVienBUS.LayBangNhanVien();
            cboNV.DataSource = dtNhanVien;
            cboNV.DisplayMember = "TenNhanVien";
            cboNV.ValueMember = "MaNhanVien";

            if (dgvPhieuXuat.Rows.Count == 0)
            {
                foreach (DataGridViewRow dgvRow in dgvCTPhieuXuat.Rows)
                {
                    dgvCTPhieuXuat.Rows.Remove(dgvRow);
                }
            }
        }

        private void ucBaoCaoBanHang_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }

        private void CaiDat()
        {
            dgvPhieuXuat.AutoGenerateColumns = false;
            dgvCTPhieuXuat.AutoGenerateColumns = false;
            cboLoai.SelectedIndex = 0;
        }

        private void dgvPhieuXuat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPhieuXuat.Columns[e.ColumnIndex].Name == "colNgayLap")
            {
                e.Value = TienIch.LayNgayThangVN(Convert.ToDateTime(e.Value.ToString()));
            }
            if (dgvPhieuXuat.Columns[e.ColumnIndex].Name == "colTinhTrang")
            {
                try
                {
                    if (e.Value.ToString() == "1")
                    {

                        e.Value = "Hoàn tất";
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    if (e.Value.ToString() == "2")
                    {
                        e.Value = "Đang chuyển";
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    if (e.Value.ToString() == "3")
                    {
                        e.Value = "Hàng đổi";
                        e.CellStyle.BackColor = Color.OrangeRed;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
                catch
                {

                }
                
            }
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string strMaPhieu = dgvPhieuXuat.SelectedRows[0].Cells["colMaPhieu"].Value.ToString();
                DataTable dtChiTiet = _ChiTietPhieuXuatBUS.LayChiTietPhieu(strMaPhieu);
                dtChiTiet.Columns.Add("ThanhTien", typeof(System.Int64));
                foreach (DataRow dr in dtChiTiet.Rows)
                {
                    dr["ThanhTien"] = Convert.ToInt64(dr["SoLuong"]) * Convert.ToInt64(dr["Gia"]);
                }
                dgvCTPhieuXuat.DataSource = dtChiTiet;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkNgay.Checked || chkNV.Checked || chkMaKH.Checked || chkLoai.Checked)
            {
                dvPhieuXuat.RowFilter = TaoTruyVan();
            }
            else
            {
                dvPhieuXuat.RowFilter = "TRUE";
            }
        }

        private string TaoTruyVan()
        {
            string strTruyVan = string.Empty;
            if (chkNgay.Checked)
            {
                string strNgayDau = dtpDau.Value.ToString("MM/dd/yyyy");
                string strNgayCuoi = dtpCuoi.Value.ToString("MM/dd/yyyy");
                strTruyVan += string.Format("NgayLap >= #{0}# AND NgayLap <= #{1}#", strNgayDau, strNgayCuoi);
            }
            if (chkNV.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " AND ";
                }
                strTruyVan += string.Format("NhanVienLap='{0}'", cboNV.SelectedValue);
            }
            if (chkMaKH.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " AND ";
                }
                strTruyVan += string.Format("MaKhachHang='{0}'", txtMaKH.Text);
            }
            if (chkLoai.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " AND ";
                }
                strTruyVan += string.Format("Loai='{0}'", cboLoai.SelectedIndex + 1);
            }
            return strTruyVan;
        }

        private void btnTraTienNo_Click(object sender, EventArgs e)
        {
            if (dgvPhieuXuat.SelectedRows[0].Index != -1)
            {
                long lTinhTrang = Convert.ToInt64(dgvPhieuXuat.SelectedRows[0].Cells["colTinhTrang"].Value.ToString());
                if (lTinhTrang == 2)
                {
                    string strMaPhieu = dgvPhieuXuat.SelectedRows[0].Cells["colMaPhieu"].Value.ToString();
                    if (FormMessage.Show("Bạn chắc chắn muốn hoàn tất chuyển hàng cho hoá đơn này?", "Xác nhận hoàn tất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_PhieuXuatBUS.HoanTatChuyenHang(strMaPhieu))
                        {
                            FormMessage.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TaiDuLieu();
                        }
                    }
                }
                else
                {
                    FormMessage.Show("Hoá đơn này đã hoàn tất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (FormMessage.Show("Bạn chắc chắn muốn xoá hoá đơn này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvPhieuXuat.SelectedRows[0].Index != -1)
                {
                    string strMaPhieu = dgvPhieuXuat.SelectedRows[0].Cells["colMaPhieu"].Value.ToString();
                    if (_PhieuXuatBUS.XoaPhieuXuat(strMaPhieu))
                    {
                        FormMessage.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TaiDuLieu();
                    }
                }
            }
        }

        private void llblTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTim frm = new frmTim(frmTim.Loai.KhachHang);
            frm.ShowDialog();
            txtMaKH.Text = frm.LayMa();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string strMaPhieu = dgvPhieuXuat.SelectedRows[0].Cells["colMaPhieu"].Value.ToString();
            frmInPhieuXuat frm = new frmInPhieuXuat(strMaPhieu);
            frm.Show();
        }
    }
}
