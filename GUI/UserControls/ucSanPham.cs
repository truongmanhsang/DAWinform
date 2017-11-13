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
using DTO;
using ClassLibrary;

namespace GUI
{
    public partial class ucSanPham : UserControl
    {
        clsSanPham_BUS _SanPhamBUS = new clsSanPham_BUS();
        clsLoaiSanPham_BUS _LoaiSanPhamBUS = new clsLoaiSanPham_BUS();
        clsHangSanXuat_BUS _HangSanXuatBUS = new clsHangSanXuat_BUS();

        DataTable dtSanPham;
        DataTable dtLoaiSanPham;
        DataTable dtHangSanXuat;

        DataView dvSanPham;

        public ucSanPham()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSuaSanPham frm = new frmThemSuaSanPham();
            frm.themSanPham += XuLyThemSanPham;
            frm.ShowDialog();
        }

        private void ucSanPham_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvSanPham.AutoGenerateColumns = false;
        }
        private void TaiDuLieu()
        {
            dtSanPham = _SanPhamBUS.LayBangSanPham();
            dvSanPham = new DataView(dtSanPham);
            dgvSanPham.DataSource = dvSanPham;

            dtLoaiSanPham = _LoaiSanPhamBUS.LayBangLoaiSanPham();
            cboLoaiSP.DataSource = dtLoaiSanPham;
            cboLoaiSP.DisplayMember = "TenLoaiSanPham";
            cboLoaiSP.ValueMember = "MaLoaiSanPham";

            dtHangSanXuat = _HangSanXuatBUS.LayBangHangSanXuat();
            cboHSX.DataSource = dtHangSanXuat;
            cboHSX.DisplayMember = "TenHangSanXuat";
            cboHSX.ValueMember = "MaHangSanXuat";
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colHinh")
            {
                if (e.Value != null)
                {
                    e.Value = new Bitmap(e.Value.ToString());
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkTenSP.Checked || chkGiaMua.Checked || chkGiaBan.Checked || chkLoaiSP.Checked || chkHSX.Checked)
            {
                dvSanPham.RowFilter = TaoTruyVan();
                FormMessage.Show(string.Format("Đã tìm thấy {0} sản phẩm!",dvSanPham.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dvSanPham.RowFilter = "TRUE";
            }
        }

        private string TaoTruyVan()
        {
            string strTruyVan = string.Empty;
            if (chkTenSP.Checked)
            {
                strTruyVan += string.Format("TenSanPham like '%{0}%'", txtTenSP.Text);
            }
            if (chkGiaMua.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " and ";
                }
                strTruyVan += string.Format("GiaMua >= {0} and GiaMua <= {1}",TienIch.HuyDinhDangSo(txtGiaMuaTu.Text), TienIch.HuyDinhDangSo(txtGiaMuaDen.Text));
            }
            if (chkGiaBan.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " and ";
                }
                strTruyVan += string.Format("GiaBan >= {0} and GiaBan <= {1}", TienIch.HuyDinhDangSo(txtGiaMuaTu.Text), TienIch.HuyDinhDangSo(txtGiaMuaDen.Text));
            }
            if (chkLoaiSP.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " and ";
                }
                strTruyVan += string.Format("MaLoaiSanPham = '{0}'", cboLoaiSP.SelectedValue);
            }
            if (chkHSX.Checked)
            {
                if (strTruyVan != string.Empty)
                {
                    strTruyVan += " and ";
                }
                strTruyVan += string.Format("MaHangSanXuat = '{0}'", cboHSX.SelectedValue);
            }
            return strTruyVan;
        }

        void XuLyThemSanPham(clsSanPham_DTO sanPham)
        {
            if (_SanPhamBUS.ThemSanPham(sanPham))
            {
                FormMessage.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                FormMessage.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void XuLySuaSanPham(clsSanPham_DTO sanPham)
        {
            if (_SanPhamBUS.SuaSanPham(sanPham))
            {
                FormMessage.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                FormMessage.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows[0].Index != -1)
            {
                string strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
                frmThemSuaSanPham frm = new frmThemSuaSanPham(strMaSP);
                frm.suaSanPham += XuLySuaSanPham;
                frm.ShowDialog();
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvSanPham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.SelectedRows[0].Index != -1)
            {
                string strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
                frmThemSuaSanPham frm = new frmThemSuaSanPham(strMaSP);
                frm.ShowDialog();
            }
        }

        private void txtGiaMuaTu_KeyUp(object sender, KeyEventArgs e)
        {
            TienIch.DinhDangSoTextBox(txtGiaMuaTu);
        }

        private void txtGiaMuaDen_KeyUp(object sender, KeyEventArgs e)
        {
            TienIch.DinhDangSoTextBox(txtGiaMuaDen);
        }

        private void txtGiaBanTu_KeyUp(object sender, KeyEventArgs e)
        {
            TienIch.DinhDangSoTextBox(txtGiaBanTu);
        }

        private void txtGiaBanDen_KeyUp(object sender, KeyEventArgs e)
        {
            TienIch.DinhDangSoTextBox(txtGiaBanDen);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows[0].Index != -1)
            {
                string strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
                if (FormMessage.Show("Bạn chắc chắn muốn xoá sản phẩm này?","Xác nhận xoá",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_SanPhamBUS.XoaSanPham(strMaSP))
                    {
                        FormMessage.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TaiDuLieu();
                    }
                    else
                    {
                        FormMessage.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
