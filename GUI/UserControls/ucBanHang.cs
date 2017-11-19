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
using System.Collections;
using ClassLibrary;

namespace GUI
{
    public partial class ucBanHang : UserControl, IDieuKhien
    {
        public void TaiLaiDuLieu()
        {
            TaiDuLieu();
        }

        // các bus cần thiết
        private clsKhachHang_BUS _KhachHangBUS = new clsKhachHang_BUS();
        private clsSanPham_BUS _SanPhamBUS = new clsSanPham_BUS();
        private clsSerial_BUS _SerialBUS = new clsSerial_BUS();
        private clsPhieuXuat_BUS _PhieuXuatBUS = new clsPhieuXuat_BUS();
        private clsChiTietPhieuXuat_BUS _ChiTietPhieuXuatBUS = new clsChiTietPhieuXuat_BUS();

        string strMaSP = string.Empty; // Mã để nhận biết có đang chọn 1 sản phẩm ko
        string strMaKH = string.Empty; // Mã để nhận biết có đang chọn 1 sản phẩm ko


        // khai báo các datatable cần thiết để lấy dữ liệu
        DataTable dtKhachHang;
        DataTable dtSanPham;
        DataView dvSanPham;

        bool bThemKH = false; // Mặc định không thêm khách hàng

        public ucBanHang()
        {
            InitializeComponent();
        }

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }

        private void CaiDat()
        {
            // cài đặt datagrid
            dgvSanPham.AutoGenerateColumns = false;

            // ẩn cột không cần thiết
            dgvSanPham.Columns["colMaSP"].Visible = false;
            dgvBanHang.Columns["colMaSanPham"].Visible = false;

            // cài đặt mặt định cbo
            cboHinhThucTra.SelectedIndex = 0;
        }

        private void TaiDuLieu()
        {
            dtSanPham = _SanPhamBUS.LayBangSanPham();
            foreach (DataRow dr in dtSanPham.Rows)
            {
                dr["GiaBan"] = Convert.ToDecimal(dr["GiaBan"]) - (Convert.ToDecimal(dr["GiaBan"]) / 100 * Convert.ToInt16(dr["KhuyenMai"])); 
            }
            dvSanPham = new DataView(dtSanPham);
            dgvSanPham.DataSource = dvSanPham;
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!dgvSanPham.Rows[e.RowIndex].IsNewRow)
            {
                if (dgvSanPham.Columns[e.ColumnIndex].Name == "colHinh" && e.Value.ToString() != "")
                {
                    e.Value = new Bitmap(e.Value.ToString());
                }
                if (dgvSanPham.Columns[e.ColumnIndex].Name == "colSoLuong")
                {
                    if (Convert.ToInt16(e.Value.ToString()) > 0)
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Gray;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
                if (dgvSanPham.Columns[e.ColumnIndex].Name == "colMua")
                {
                    //DataGridViewButtonColumn b = (DataGridViewButtonColumn)dgvSanPham.Columns[e.ColumnIndex];
                    e.Value = "Thêm";
                    //b.Text = "Thêm";
                    //b.FlatStyle = FlatStyle.Flat;
                }
            }
        }

        private void txtTimSP_TextChanged(object sender, EventArgs e)
        {
            dvSanPham.RowFilter = string.Format("TenSanPham like '%{0}%'", txtTimSP.Text);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
            }
        }


        private void ThemSanPhamVaoHoaDon(string strMaSP, int iSL)
        {
            string strTenSP = dgvSanPham.SelectedRows[0].Cells["colTenSanPham"].Value.ToString();
            decimal iDonGia = Convert.ToDecimal(dgvSanPham.SelectedRows[0].Cells["colGiaTien"].Value.ToString());
            decimal iSoLuong = iSL;
            decimal iThanhTien = iDonGia * iSoLuong;

            if (dgvBanHang.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgvRow in dgvBanHang.Rows)
                {
                    if (strMaSP == dgvRow.Cells[0].Value.ToString())
                    {
                        dgvRow.Cells[0].Value = strMaSP;
                        dgvRow.Cells[1].Value = strTenSP;
                        dgvRow.Cells[2].Value = iDonGia;
                        dgvRow.Cells[3].Value = iSoLuong;
                        dgvRow.Cells[4].Value = iThanhTien;
                        TinhTongTien();
                        return;
                    }
                }
            }


            dgvBanHang.Rows.Add(strMaSP, strTenSP, iDonGia, iSoLuong, iThanhTien);
            TinhTongTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                strMaSP = dgvBanHang.SelectedRows[0].Cells[0].Value.ToString();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Text = btnThem.Text == "Khách mới" ? "Huỷ" : "Khách mới";
            txtTenKH.Focus();
            txtTenKH.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";

            txtTenKH.ReadOnly = !txtTenKH.ReadOnly;
            txtSoDT.ReadOnly = !txtSoDT.ReadOnly;
            txtDiaChi.ReadOnly = !txtDiaChi.ReadOnly;

            bThemKH = !bThemKH;
        }

        private void dgvBanHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TinhTongTien()
        {
            long ltongTien = 0;
            foreach (DataGridViewRow dgvRow in dgvBanHang.Rows)
            {
                ltongTien += Convert.ToInt64(dgvRow.Cells[4].Value.ToString());
            }
            txtTongCong.Text = TienIch.ChuyenSoSangVND(ltongTien);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamSach();
        }

        private void LamSach()
        {
            txtTenKH.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";


            txtTongCong.Text = "0";

            dgvBanHang.Rows.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtSoDT.Text != "" && txtDiaChi.Text != "")
            {
                if (dgvBanHang.Rows.Count > 0)
                {
                    TaoPhieuXuat();

                }
                else
                {
                    FormMessage.Show("Vui lòng chọn sản phẩm để mua, bạn có thể chọn ở mục bên trái nhập số lượng và nhấn ghi!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin khách hàng, bạn có thể chọn ở mục bên trái hoặc thêm!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TaoPhieuXuat()
        {
            if (bThemKH) // nếu đúng thì thêm khách hàng này vào csdl trước rồi lập hoá đơn
            {
                clsKhachHang_DTO khachHang = new clsKhachHang_DTO();
                khachHang.TenKhachHang = txtTenKH.Text;
                khachHang.SoDT = txtSoDT.Text;
                khachHang.DiaChi = txtDiaChi.Text;

                strMaKH = _KhachHangBUS.ThemKhachHang(khachHang);
            }

            //=== Thêm phiếu xuất
            clsPhieuXuat_DTO phieuXuat = new clsPhieuXuat_DTO();
            phieuXuat.MaKhachHang = strMaKH;
            if (cboHinhThucTra.SelectedIndex == 0) //
            {
                phieuXuat.Loai = 1;
            }
            else if (cboHinhThucTra.SelectedIndex == 1)
            {
                phieuXuat.Loai = 2;
            }
            else if (cboHinhThucTra.SelectedIndex == 2)
            {
                phieuXuat.Loai = 3;
            }
            phieuXuat.TongTien = TienIch.ChuyenVNDSangSo(txtTongCong.Text);
            phieuXuat.NgayLap = TienIch.LayNgayThangHienTaiQuocTe();
            phieuXuat.MaNVLap = Program.MA_NV;

            string strMaPhieuXuat = _PhieuXuatBUS.TaoPhieuXuat(phieuXuat); // tạo phiếu xuất và lấy mã

            //== Thêm chi tiết phiếu xuất
            List<clsChiTietPhieuXuat_DTO> dsChiTietSP = new List<clsChiTietPhieuXuat_DTO>(); // danh sách các sản phẩm trong hoá đơn
            foreach (DataGridViewRow dgvRow in dgvBanHang.Rows)
            {
                clsChiTietPhieuXuat_DTO chitiet = new clsChiTietPhieuXuat_DTO();
                chitiet.MaSanPham = dgvRow.Cells[0].Value.ToString();
                chitiet.SoLuong = Convert.ToInt16(dgvRow.Cells[3].Value.ToString());
                chitiet.Gia = Convert.ToInt64(dgvRow.Cells[2].Value.ToString());

                // Update mã serial với số tháng bảo hành
                _SerialBUS.BatDauBaoHanh(chitiet.MaSanPham, chitiet.SoLuong, strMaPhieuXuat);

                dsChiTietSP.Add(chitiet);
            }

            _ChiTietPhieuXuatBUS.TaoChiTieuPhieuXuat(dsChiTietSP, strMaPhieuXuat);

            if (FormMessage.Show("Lưu thành công!, bạn có muốn in hoá đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes){
                frmInPhieuXuat frm = new frmInPhieuXuat(strMaPhieuXuat);
                frm.ShowDialog();
            }
            LamSach(); // làm sạch controls
            Program.TaiLaiDuLieu(); // tải lại toàn bộ dữ liệu
        }

        private void dgvBanHang_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void cboHinhThucTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHinhThucTra.SelectedIndex == 2)
            {
                lblTongCong.Visible = false;
                txtTongCong.Visible = false;
            }
            else
            {
                lblTongCong.Visible = true;
                txtTongCong.Visible = true;
            }
        }

        private void btnKhachCu_Click(object sender, EventArgs e)
        {
            if (bThemKH)
            {
                btnThem.Text = btnThem.Text == "Khách mới" ? "Huỷ" : "Khách mới";
                txtTenKH.Focus();
                txtTenKH.Text = "";
                txtSoDT.Text = "";
                txtDiaChi.Text = "";

                txtTenKH.ReadOnly = bThemKH;
                txtSoDT.ReadOnly = bThemKH;
                txtDiaChi.ReadOnly = bThemKH;

                bThemKH = !bThemKH;
            }

            frmTim frm = new frmTim(frmTim.Loai.KhachHang);
            frm.ShowDialog();
            if (frm.LayMa() != null)
            {
                strMaKH = frm.LayMa();
                dtKhachHang = _KhachHangBUS.LayBangKhachHang(strMaKH);
                txtTenKH.Text = dtKhachHang.Rows[0]["TenKhachHang"].ToString();
                txtSoDT.Text = dtKhachHang.Rows[0]["SoDT"].ToString();
                txtDiaChi.Text = dtKhachHang.Rows[0]["DiaChi"].ToString();

            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colMua" && e.RowIndex != -1)
            {
                int iSL = Convert.ToInt16(dgvSanPham.SelectedRows[0].Cells["colSoLuong"].Value.ToString());

                if (iSL > 0)
                {
                    int iSLMua = 0;
                    string strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
                    foreach (DataGridViewRow dgvRow in dgvBanHang.Rows)
                    {
                        if (dgvRow.Cells["colMaSanPham"].Value.ToString() == strMaSP)
                        {
                            iSLMua = Convert.ToInt16(dgvRow.Cells["colSL"].Value.ToString());
                        }
                    }
                    frmThemSLSP frm = new frmThemSLSP(strMaSP, iSLMua, frmThemSLSP.Loai.Them);
                    frm.ShowDialog();
                    if (frm.LaySoLuong() > 0)
                        ThemSanPhamVaoHoaDon(strMaSP, frm.LaySoLuong());
                }
                else
                {
                    FormMessage.Show("Sản phẩm không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvBanHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBanHang.Columns[e.ColumnIndex].Name == "colChinhSua")
            {
                e.Value = "Sửa";
            }
            if (dgvBanHang.Columns[e.ColumnIndex].Name == "colXoa")
            {
                e.Value = "Xoá";
            }
        }

        private void dgvBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBanHang.Columns[e.ColumnIndex].Name == "colChinhSua")
            {
                int iSL = Convert.ToUInt16(dgvBanHang.SelectedRows[0].Cells["colSL"].Value.ToString());
                string strMaSP = dgvBanHang.SelectedRows[0].Cells["colMaSanPham"].Value.ToString();
                frmThemSLSP frm = new frmThemSLSP(strMaSP, iSL, frmThemSLSP.Loai.ChinhSua);
                frm.ShowDialog();
                if (frm.LaySoLuong() > 0)
                    ThemSanPhamVaoHoaDon(strMaSP, frm.LaySoLuong());
            }
            if (dgvBanHang.Columns[e.ColumnIndex].Name == "colXoa")
            {
                dgvBanHang.Rows.RemoveAt(dgvBanHang.SelectedRows[0].Index);
            }
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

        private void dgvBanHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTongTien();
        }

        private void dgvBanHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TinhTongTien();
        }
    }
}
