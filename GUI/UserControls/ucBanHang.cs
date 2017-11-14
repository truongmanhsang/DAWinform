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
    public partial class ucBanHang : UserControl
    {
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
        DataView dvKhachHang;
        DataView dvSanPham;

        // Chuyển dtSanPham thành htSanPham cho việc truy xuất dễ hơn
        Hashtable htSanPham;

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
            dgvKhachHang.AutoGenerateColumns = false;
            dgvSanPham.AutoGenerateColumns = false;

            // ẩn cột không cần thiết
            dgvSanPham.Columns["colMaSP"].Visible = false;
            dgvBanHang.Columns["colMaSanPham"].Visible = false;
            dgvKhachHang.Columns["colMaKH"].Visible = false;
            dgvKhachHang.Columns["colDiaChi"].Visible = false;

            // cài đặt mặt định cbo
            cboHinhThucTra.SelectedIndex = 0;
        }

        private void TaiDuLieu()
        {
            dtKhachHang = _KhachHangBUS.LayBangKhachHang();
            dvKhachHang = new DataView(dtKhachHang);
            dgvKhachHang.DataSource = dvKhachHang;
            dtSanPham = _SanPhamBUS.LayBangSanPham();
            dvSanPham = new DataView(dtSanPham);
            dgvSanPham.DataSource = dvSanPham;
            TaiHashTableSP();
        }

        private void TaiHashTableSP()
        {
            htSanPham = new Hashtable();
            foreach (DataRow dr in dtSanPham.Rows)
            {
                string strMa = dr["MaSanPham"].ToString();
                htSanPham[strMa] = dr;
            }
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!dgvSanPham.Rows[e.RowIndex].IsNewRow)
            {
                if (dgvSanPham.Columns[e.ColumnIndex].Name == "colHinh" && e.Value.ToString() != "")
                {
                    e.Value = new Bitmap(e.Value.ToString());
                }
            }
        }

        private void txtTimKhachHang_TextChanged(object sender, EventArgs e)
        {
            dvKhachHang.RowFilter = string.Format("TenKhachHang like '%{0}%'", txtTimKhachHang.Text);
        }

        private void txtTimSP_TextChanged(object sender, EventArgs e)
        {
            dvSanPham.RowFilter = string.Format("TenSanPham like '%{0}%'", txtTimSP.Text);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                numSL.Value = 1;
                txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["colTenSanPham"].Value.ToString();
                long lDonGia = Convert.ToInt64(dgvSanPham.Rows[e.RowIndex].Cells["colGiaTien"].Value.ToString());
                txtDonGia.Text = TienIch.ChuyenSoSangVND(lDonGia);
                strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
            }
        }

        private void btnGhiSP_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != string.Empty)
            {
                if (numSL.Value > 0)
                {
                    ThemSanPhamVaoHoaDon();
                    TinhTongTien();
                }
                else
                {
                    FormMessage.Show("Vui lòng Nhập số lượng sản phẩm lớn hơn 0!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                FormMessage.Show("Vui lòng chọn 1 sản phẩm ở mục bên trái để mua!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ThemSanPhamVaoHoaDon()
        {
            DataRow dr = (DataRow)htSanPham[strMaSP];

            string strTenSP = txtTenSP.Text;
            long iDonGia = Convert.ToInt64(dr["GiaBan"]);
            decimal iSoLuong = numSL.Value;
            long iSoLuongConLai = Convert.ToInt64(dr["SoLuong"]);
            decimal iThanhTien = iDonGia * iSoLuong;

            if (iSoLuong > iSoLuongConLai)
            {
                FormMessage.Show(string.Format("Số lượng sản phẩm còn trong kho không đủ!\nCòn: {0}", iSoLuongConLai), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        return;
                    }
                }
            }


            dgvBanHang.Rows.Add(strMaSP, strTenSP, iDonGia, iSoLuong, iThanhTien);
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtTenSP.Text = dgvBanHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                long lDonGia = Convert.ToInt64(dgvBanHang.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtDonGia.Text = TienIch.ChuyenSoSangVND(lDonGia);
                numSL.Value = Convert.ToDecimal(dgvBanHang.Rows[e.RowIndex].Cells[3].Value.ToString());
                strMaSP = dgvBanHang.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                strMaKH = dgvKhachHang.Rows[e.RowIndex].Cells["colMaKH"].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells["colTenKhachHang"].Value.ToString();
                txtSoDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells["colSoDT"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Text = btnThem.Text == "Thêm" ? "Huỷ" : "Thêm";
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

            txtTenSP.Text = "";
            txtDonGia.Text = "";
            numSL.Value = 1;

            txtTongCong.Text = "";

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
            if (cboHinhThucTra.SelectedIndex == 1) // 0 là tiền mặt, 1 là công nợ
            {
                phieuXuat.TienNo = TienIch.ChuyenVNDSangSo(txtTongCong.Text);
            }
            phieuXuat.TongTien = TienIch.ChuyenVNDSangSo(txtTongCong.Text);
            phieuXuat.NgayLap = TienIch.LayNgayThangHienTaiQuocTe();
            phieuXuat.MaNVLap = Program.MA_NV;

            string strMaPhieuXuat = _PhieuXuatBUS.TaoPhieuXuat(phieuXuat); // tạo phiếu xuất và lấy mã

            //== Thêm chi tiết phiếu xuất
            List<clsChiTietPhieuXuat_DTO> dsChiTietSP = new List<clsChiTietPhieuXuat_DTO>(); // danh sách các sản phẩm trong hoá đơn
            foreach (DataGridViewRow dgvRow in dgvBanHang.Rows)
            {
                DataRow drSP = (DataRow)htSanPham[dgvRow.Cells[0].Value.ToString()]; // lấy mã sp của từng dòng trong dgvBanHang

                clsChiTietPhieuXuat_DTO chitiet = new clsChiTietPhieuXuat_DTO();
                chitiet.MaSanPham = dgvRow.Cells[0].Value.ToString();
                chitiet.SoLuong = Convert.ToInt16(dgvRow.Cells[3].Value.ToString());
                chitiet.Gia = Convert.ToInt64(dgvRow.Cells[2].Value.ToString());

                // Update mã serial với số tháng bảo hành
                _SerialBUS.BatDauBaoHanh(chitiet.MaSanPham, chitiet.SoLuong, strMaPhieuXuat);

                dsChiTietSP.Add(chitiet);
            }

            _ChiTietPhieuXuatBUS.TaoChiTieuPhieuXuat(dsChiTietSP, strMaPhieuXuat);

            FormMessage.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamSach(); // làm sạch controls
            TaiDuLieu(); // tải lại dữ liệu
        }

        private void dgvBanHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvBanHang.Rows.Count == 0)
                txtTongCong.Text = "";
            if (e.KeyCode == Keys.Delete && dgvBanHang.Rows.Count > 0)
            {
                TinhTongTien();
            }
        }

    }
}
