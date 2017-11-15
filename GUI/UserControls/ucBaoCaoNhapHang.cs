using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using ClassLibrary;

namespace GUI
{
    public partial class ucBaoCaoNhapHang : UserControl
    {
        clsPhieuNhap_BUS _PhieuNhapBUS = new clsPhieuNhap_BUS();
        clsNhanVien_BUS _NhanVienBUS = new clsNhanVien_BUS();
        clsChiTietPhieuNhap_BUS _ChiTietPhieuNhapBUS = new clsChiTietPhieuNhap_BUS();

        DataTable dtPhieuNhap;
        DataTable dtNhanVien;

        DataView dvPhieuNhap;
        public ucBaoCaoNhapHang()
        {
            InitializeComponent();
        }

        private void ucBaoCaoNhapHang_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvPhieuNhap.AutoGenerateColumns = false;
            dgvCTPhieuNhap.AutoGenerateColumns = false;
        }
        private void TaiDuLieu()
        {
            dtPhieuNhap = _PhieuNhapBUS.LayBangPhieuNhap();
            dvPhieuNhap = new DataView(dtPhieuNhap);
            dgvPhieuNhap.DataSource = dvPhieuNhap;

            dtNhanVien = _NhanVienBUS.LayBangNhanVien();
            cboNV.DataSource = dtNhanVien;
            cboNV.DisplayMember = "TenNhanVien";
            cboNV.ValueMember = "MaNhanVien";

            if (dgvPhieuNhap.Rows.Count == 0)
            {
                foreach (DataGridViewRow dgvRow in dgvCTPhieuNhap.Rows)
                {
                    dgvCTPhieuNhap.Rows.Remove(dgvRow);
                }
            }
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string strMaPhieu = dgvPhieuNhap.SelectedRows[0].Cells["colMaPhieu"].Value.ToString();
                DataTable dtChiTiet = _ChiTietPhieuNhapBUS.LayChiTietPhieu(strMaPhieu);
                dtChiTiet.Columns.Add("ThanhTien", typeof(System.Int64));
                foreach (DataRow dr in dtChiTiet.Rows)
                {
                    dr["ThanhTien"] = Convert.ToInt64(dr["SoLuong"]) * Convert.ToInt64(dr["Gia"]);
                }
                dgvCTPhieuNhap.DataSource = dtChiTiet;
            }
        }

        private void btnTraTienNo_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows[0].Index != -1)
            {
                long lTienNo = Convert.ToInt64(dgvPhieuNhap.SelectedRows[0].Cells["colNo"].Value.ToString());
                if (lTienNo > 0)
                {
                    string strMaPhieu = dgvPhieuNhap.SelectedRows[0].Cells["colMaPhieu"].Value.ToString();
                    if (FormMessage.Show("Bạn chắc chắn muốn trả tiền nợ cho hoá đơn này?", "Xác nhận trả tiền", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (_PhieuNhapBUS.TraTienNo(strMaPhieu))
                        {
                            FormMessage.Show("Trả tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TaiDuLieu();
                        }
                    }
                }
                else
                {
                    FormMessage.Show("Hoá đơn này không nợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (FormMessage.Show("Bạn chắc chắn muốn xoá hoá đơn này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvPhieuNhap.SelectedRows[0].Index != -1)
                {
                    string strMaPhieu = dgvPhieuNhap.SelectedRows[0].Cells["colMaPhieu"].Value.ToString();
                    if (_PhieuNhapBUS.XoaPhieuNhap(strMaPhieu))
                    {
                        FormMessage.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TaiDuLieu();
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkNgay.Checked || chkNV.Checked || chkMaNCC.Checked || chkNo.Checked)
            {
                dvPhieuNhap.RowFilter = TaoTruyVan();
            }
            else
            {
                dvPhieuNhap.RowFilter = "TRUE";
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
            if (chkMaNCC.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " AND ";
                }
                strTruyVan += string.Format("MaNhaCungCap='{0}'", txtMaNCC.Text);
            }
            if (chkNo.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " AND ";
                }
                strTruyVan += string.Format("TienNo > 0");
            }
            return strTruyVan;
        }

        private void dgvPhieuNhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPhieuNhap.Columns[e.ColumnIndex].Name == "colNgayLap")
            {
                e.Value = TienIch.LayNgayThangVN(Convert.ToDateTime(e.Value.ToString()));
            }
        }

        private void llblTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTim frm = new frmTim(frmTim.Loai.NhaCungCap);
            frm.ShowDialog();
            txtMaNCC.Text = frm.LayMa();
        }
    }
}
