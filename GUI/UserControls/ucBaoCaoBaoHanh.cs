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
                LayChiTietBaoHanh();
            }
        }

        private void LayChiTietBaoHanh()
        {
            string strMaBH = dgvBaoHanh.SelectedRows[0].Cells["colMaBH"].Value.ToString();
            DataTable dtChiTiet = _ChiTietBaoHanhBUS.LayBangChiTietBH(strMaBH);
            dgvChiTietBaoHanh.DataSource = dtChiTiet;
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
                strTruyVan += string.Format("MaNhanVien = '{0}'", cboNV.SelectedValue);
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
            if (dgvChiTietBaoHanh.Columns[e.ColumnIndex].Name == "colTinhTrang")
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "Chưa trả hàng";
                }
                else if (e.Value.ToString() == "1")
                {
                    e.Value = "Đã giao hàng";
                }
                else if (e.Value.ToString() == "2")
                {
                    e.Value = "Đã đổi hàng";
                }
                else if (e.Value.ToString() == "3")
                {
                    e.Value = "Đã trả lại";
                }
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (dgvChiTietBaoHanh.Rows.Count > 0)
            {
                string strSoSerial = dgvChiTietBaoHanh.SelectedRows[0].Cells["colSoSerial"].Value.ToString();
                int iTinhTrang = Convert.ToInt16(dgvChiTietBaoHanh.SelectedRows[0].Cells["colTinhTrang"].Value.ToString());
                string strTenSanPham = dgvChiTietBaoHanh.SelectedRows[0].Cells["colTenSanPham"].Value.ToString();
                if (iTinhTrang == 0)
                {
                    DialogResult result = FormMessage.Show("Bạn muốn trả sản phẩm: '" + strTenSanPham + "'?", "Xác nhận trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        _ChiTietBaoHanhBUS.CapNhapBaoHanh(strSoSerial);
                        LayChiTietBaoHanh();
                    }
                }
                else
                {
                    FormMessage.Show("Sản phẩm này không thể trả!", "Xác nhận trả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTraHet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietBaoHanh.Rows.Count > 0)
            {
                string strMaBH = dgvBaoHanh.SelectedRows[0].Cells["colMaBH"].Value.ToString();
                DialogResult result = FormMessage.Show("Bạn muốn trả hết tất cả sản phẩm trong phiếu bảo hành " + strMaBH + "?", "Xác nhận trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                foreach (DataGridViewRow dgvRow in dgvChiTietBaoHanh.Rows)
                {
                    string strSoSerial = dgvRow.Cells["colSoSerial"].Value.ToString();
                    int iTinhTrang = Convert.ToInt16(dgvRow.Cells["colTinhTrang"].Value.ToString());
                    if (iTinhTrang == 0)
                    {
                        _ChiTietBaoHanhBUS.CapNhapBaoHanh(strSoSerial);
                    }
                    LayChiTietBaoHanh();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strMaBH = dgvBaoHanh.SelectedRows[0].Cells["colMaBH"].Value.ToString();
            DialogResult result = FormMessage.Show("Bạn chắc chắn muốn xoá phiếu bảo hành " + strMaBH + "?", "Xác nhận trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_BaoHanhBUS.XoaPhieuBaoHanh(strMaBH))
                {
                    FormMessage.Show("Xoá phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieu();
                    dgvChiTietBaoHanh.DataSource = null;
                }
                else
                {
                    FormMessage.Show("Xoá phiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
