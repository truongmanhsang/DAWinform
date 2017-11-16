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
    public delegate void XuLyTimSoSerial();
    public partial class ucNhanBaoHanh : UserControl
    {
        public event XuLyTimSoSerial timSoSerial;
        clsSerial_BUS _SerialBUS = new clsSerial_BUS();
        clsKhachHang_BUS _KhachHangBUS = new clsKhachHang_BUS();
        clsBaoHanh_BUS _BaoHanhBUS = new clsBaoHanh_BUS();
        clsChiTietBaoHanh_BUS _ChiTietBaoHanhBUS = new clsChiTietBaoHanh_BUS();

        string strMaKH;

        bool bThemKH;

        public ucNhanBaoHanh()
        {
            InitializeComponent();
        }

        private void ucNhanBaoHanh_Load(object sender, EventArgs e)
        {
            dgvChiTietBH.Columns[3].ValueType = typeof(decimal);
        }

        private void btnTimSoSerial_Click(object sender, EventArgs e)
        {
            timSoSerial();
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            txtTenHang.Text = _SerialBUS.LayTenSanPhamConBH(txtSerial.Text);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text != "")
            {
                XuLyThem();
            }
            else
            {
                FormMessage.Show("Số serial không đúng hoặc hết bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void XuLyThem()
        {

            foreach (DataGridViewRow dgvRow in dgvChiTietBH.Rows)
            {
                if (dgvRow.Cells[1].Value.ToString() == txtSerial.Text)
                {
                    dgvRow.Cells[0].Value = txtTenHang.Text;
                    dgvRow.Cells[1].Value = txtSerial.Text;
                    dgvRow.Cells[2].Value = txtMoTaLoi.Text;
                    dgvRow.Cells[3].Value = dtpNgayHenTra.Value.ToString();
                    dgvRow.Cells[4].Value = txtGhiChu.Text;
                    dgvRow.Cells[5].Value = chkDoiHang.Checked ? 2 : chkTraHang.Checked ? 3 : 0;
                    return;
                }
            }

            dgvChiTietBH.Rows.Add(txtTenHang.Text, txtSerial.Text, txtMoTaLoi.Text, dtpNgayHenTra.Value.ToString(), txtGhiChu.Text, chkDoiHang.Checked ? 2 : chkTraHang.Checked ? 3 : 0);
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            frmTim frm = new frmTim(frmTim.Loai.KhachHang);
            frm.ShowDialog();
            strMaKH = frm.LayMa();
            if (strMaKH != null)
            {
                DataTable dtKH = _KhachHangBUS.LayBangKhachHang(strMaKH);
                txtTenKH.Text = dtKH.Rows[0]["TenKhachHang"].ToString();
                txtSoDT.Text = dtKH.Rows[0]["SoDT"].ToString();
                txtDiaChi.Text = dtKH.Rows[0]["DiaChi"].ToString();
                strMaKH = dtKH.Rows[0]["MaKhachHang"].ToString();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            bThemKH = !bThemKH;
            btnThemMoi.Text = btnThemMoi.Text == "Thêm mới" ? "Huỷ" : "Thêm mới";
            txtTenKH.ReadOnly = !txtTenKH.ReadOnly;
            txtSoDT.ReadOnly = !txtSoDT.ReadOnly;
            txtDiaChi.ReadOnly = !txtDiaChi.ReadOnly;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamSach();
        }

        private void LamSach()
        {
            dgvChiTietBH.Rows.Clear();
            txtTenKH.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";

            txtTenHang.Text = "";
            txtMoTaLoi.Text = "";
            txtGhiChu.Text = "";
            txtSerial.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvChiTietBH.Rows.Count == 0 || txtTenKH.Text == "")
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bThemKH)
            {
                clsKhachHang_DTO khachHang = new clsKhachHang_DTO();
                khachHang.TenKhachHang = txtTenKH.Text;
                khachHang.SoDT = txtSoDT.Text;
                khachHang.DiaChi = txtDiaChi.Text;

                strMaKH = _KhachHangBUS.ThemKhachHang(khachHang);
            }
            clsBaoHanh_DTO baoHanh = new clsBaoHanh_DTO();
            baoHanh.MaKhachHang = strMaKH;
            baoHanh.MaNhanVien = Program.MA_NV;
            baoHanh.NgayBaoHanh = TienIch.LayNgayThangHienTaiQuocTe();
            string strMaBH = _BaoHanhBUS.ThemBaoHanh(baoHanh);

            List<clsChiTietBaoHanh_DTO> dsChiTiet = new List<clsChiTietBaoHanh_DTO>();
            foreach (DataGridViewRow dgvRow in dgvChiTietBH.Rows)
            {
                clsChiTietBaoHanh_DTO chiTiet = new clsChiTietBaoHanh_DTO();
                chiTiet.MaBaoHanh = strMaBH;
                chiTiet.MaSerial = _SerialBUS.LayMaSerial(dgvRow.Cells[1].Value.ToString());
                chiTiet.NgayHenTra = TienIch.LayNgayThangQuocTe(Convert.ToDateTime(dgvRow.Cells[3].Value.ToString()));
                int iTinhTrang = dgvRow.Cells[5].Value.ToString() == "Chưa trả hàng" ? 0 : dgvRow.Cells[5].Value.ToString() == "Đổi hàng" ? 2 : 3;
                chiTiet.TinhTrang = Convert.ToInt16(dgvRow.Cells[5].Value);
                chiTiet.MotaLoi = dgvRow.Cells[2].Value.ToString();
                chiTiet.GhiChu = dgvRow.Cells[4].Value.ToString();

                dsChiTiet.Add(chiTiet);
            }
            _ChiTietBaoHanhBUS.ThemChiTietBaoHanh(dsChiTiet, strMaBH);
            FormMessage.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamSach();
        }

        private void dgvChiTietBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtTenHang.Text = dgvChiTietBH.SelectedRows[0].Cells[0].Value.ToString();
                txtSerial.Text = dgvChiTietBH.SelectedRows[0].Cells[1].Value.ToString();
                txtMoTaLoi.Text = dgvChiTietBH.SelectedRows[0].Cells[2].Value.ToString();
                dtpNgayHenTra.Value = Convert.ToDateTime(dgvChiTietBH.SelectedRows[0].Cells[3].Value);
                txtGhiChu.Text = dgvChiTietBH.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void dgvChiTietBH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvChiTietBH.Columns[e.ColumnIndex].Name == "colTinhTrang")
            {
                if (e.Value.ToString() == "0")
                {
                    e.Value = "Chưa trả hàng";
                }else if (e.Value.ToString() == "2")
                {
                    e.Value = "Đổi hàng";
                }
                else if (e.Value.ToString() == "3")
                {
                    e.Value = "Trả lại hàng";
                }
            }
        }

        private void dgvChiTietBH_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void txtGiaSua_KeyPress(object sender, KeyPressEventArgs e)
        {
            TienIch.BuocNhapSo(e);
        }

        private void txtGiaSua_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTongCong_TextChanged(object sender, EventArgs e)
        {
        }

        private void chkDoiHang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTraHang.Checked)
                chkTraHang.Checked = false;
        }

        private void chkTraHang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoiHang.Checked)
                chkDoiHang.Checked = false;
        }
    }
}
