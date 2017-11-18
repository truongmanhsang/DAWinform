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
using System.Collections;
using ClassLibrary;
using DTO;

namespace GUI
{
    public partial class ucNhapHang : UserControl, IDieuKhien
    {
        public void TaiLaiDuLieu()
        {
            TaiDuLieu();
        }

        clsSanPham_BUS _SanPhamBUS = new clsSanPham_BUS();
        clsNhaCungCap_BUS _NhaCungCapBUS = new clsNhaCungCap_BUS();
        clsPhieuNhap_BUS _PhieuNhapBUS = new clsPhieuNhap_BUS();
        clsChiTietPhieuNhap_BUS _ChiTietPhieuNhapBUS = new clsChiTietPhieuNhap_BUS();
        clsSerial_BUS _SerialBUS = new clsSerial_BUS();

        DataTable dtNhaCungCap;
        DataTable dtSanPham;

        Hashtable htSanPham;
        private string strMaNCC;
        private string strMaSP;

        bool bThemNCC = false;

        public ucNhapHang()
        {
            InitializeComponent();
        }

        private void ucNhapHang_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }

        private void CaiDat()
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.Columns["colMaSP"].Visible = false;
            dgvNhapHang.Columns["colMaSanPham"].Visible = false;

            cboHinhThucTra.SelectedIndex = 0;
        }

        private void TaiDuLieu()
        {
            dtSanPham = _SanPhamBUS.LayBangSanPham();
            dgvSanPham.DataSource = dtSanPham;

            TaiHashtableSP();
        }

        private void TaiHashtableSP()
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
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colHinh")
            {
                if (e.Value.ToString() != "" && !dgvSanPham.Rows[e.RowIndex].IsNewRow)
                {
                    e.Value = new Bitmap(e.Value.ToString());
                }
            }
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colThem")
            {
                e.Value = "Thêm";
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
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //numSL.Value = 1;
                //txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["colTenSanPham"].Value.ToString();
                //long lDonGia = Convert.ToInt64(dgvSanPham.Rows[e.RowIndex].Cells["colGiaMua"].Value.ToString());
                //txtDonGia.Text = TienIch.ChuyenSoSangVND(lDonGia);
                //strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
            }
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //txtTenSP.Text = dgvNhapHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                //long lDonGia = Convert.ToInt64(dgvNhapHang.Rows[e.RowIndex].Cells[2].Value.ToString());
                //txtDonGia.Text = TienIch.ChuyenSoSangVND(lDonGia);
                //numSL.Value = Convert.ToDecimal(dgvNhapHang.Rows[e.RowIndex].Cells[3].Value.ToString());
                //strMaSP = dgvNhapHang.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void ThemSanPhamVaoHoaDon(string strMaSP, int iSL)
        {
            string strTenSP = dgvSanPham.SelectedRows[0].Cells["colTenSanPham"].Value.ToString();
            decimal iDonGia = Convert.ToDecimal(dgvSanPham.SelectedRows[0].Cells["colGiaMua"].Value.ToString());
            decimal iSoLuong = iSL;
            decimal iThanhTien = iDonGia * iSoLuong;

            if (dgvNhapHang.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgvRow in dgvNhapHang.Rows)
                {
                    if (strMaSP == dgvRow.Cells[0].Value.ToString())
                    {
                        dgvRow.Cells[0].Value = strMaSP;
                        dgvRow.Cells[1].Value = strTenSP;
                        dgvRow.Cells[2].Value = iDonGia;
                        dgvRow.Cells[3].Value = iSoLuong;
                        dgvRow.Cells[4].Value = iThanhTien;
                        TinhTongTien();
                        TinhTongTien();
                        return;
                    }
                }
            }


            dgvNhapHang.Rows.Add(strMaSP, strTenSP, iDonGia, iSoLuong, iThanhTien); 
            TinhTongTien();
        }
        private void TinhTongTien()
        {
            long ltongTien = 0;
            foreach (DataGridViewRow dgvRow in dgvNhapHang.Rows)
            {
                ltongTien += Convert.ToInt64(dgvRow.Cells[4].Value.ToString());
            }
            txtTongCong.Text = TienIch.ChuyenSoSangVND(ltongTien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Text = btnThem.Text == "Thêm" ? "Huỷ" : "Thêm";
            txtTenNCC.Focus();
            txtTenNCC.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";

            txtTenNCC.ReadOnly = !txtTenNCC.ReadOnly;
            txtSoDT.ReadOnly = !txtSoDT.ReadOnly;
            txtDiaChi.ReadOnly = !txtDiaChi.ReadOnly;

            bThemNCC = !bThemNCC;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text != "" && txtSoDT.Text != "" && txtDiaChi.Text != "")
            {
                if (dgvNhapHang.Rows.Count > 0)
                {
                    TaoPhieuNhap();

                }
                else
                {
                    FormMessage.Show("Vui lòng chọn sản phẩm để nhập, bạn có thể chọn ở mục bên trái nhập số lượng và nhấn ghi!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp, bạn có thể chọn ở mục bên trái hoặc thêm!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TaoPhieuNhap()
        {
            if (bThemNCC) // nếu đúng thì thêm nhà cung cấp này vào csdl trước rồi lập hoá đơn
            {
                clsNhaCungCap_DTO nhaCungCap = new clsNhaCungCap_DTO();
                nhaCungCap.TenNhaCungCap = txtTenNCC.Text;
                nhaCungCap.SoDT = txtSoDT.Text;
                nhaCungCap.DiaChi = txtDiaChi.Text;

                strMaNCC = _NhaCungCapBUS.ThemNCC(nhaCungCap);
            }

            //=== Thêm phiếu nhập
            clsPhieuNhap_DTO phieuNhap = new clsPhieuNhap_DTO();
            phieuNhap.MaNhaCungCap = strMaNCC;
            if (cboHinhThucTra.SelectedIndex == 1)
                phieuNhap.TienNo = TienIch.ChuyenVNDSangSo(txtTongCong.Text);
            phieuNhap.TongTien = TienIch.ChuyenVNDSangSo(txtTongCong.Text);
            phieuNhap.NgayLap = DateTime.Now.ToString("MM/dd/yyyy");
            phieuNhap.MaNVLap = Program.MA_NV;

            string strMaPhieuXuat = _PhieuNhapBUS.TaoPhieuNhap(phieuNhap); // tạo phiếu nhập và lấy mã

            //== Thêm chi tiết phiếu nhập
            List<clsChiTietPhieuNhap_DTO> dsChiTietSP = new List<clsChiTietPhieuNhap_DTO>(); // danh sách các sản phẩm trong hoá đơn
            foreach (DataGridViewRow dgvRow in dgvNhapHang.Rows)
            {
                DataRow drSP = (DataRow)htSanPham[dgvRow.Cells[0].Value.ToString()]; // lấy mã sp của từng dòng trong dgvBanHang

                clsChiTietPhieuNhap_DTO chitiet = new clsChiTietPhieuNhap_DTO();
                chitiet.MaSanPham = dgvRow.Cells[0].Value.ToString();
                chitiet.SoLuong = Convert.ToInt16(dgvRow.Cells[3].Value.ToString());
                chitiet.Gia = Convert.ToInt64(dgvRow.Cells[2].Value.ToString());

                // Thêm số serial
                _SerialBUS.ThemSoSerial(chitiet.MaSanPham, chitiet.SoLuong, strMaPhieuXuat);

                dsChiTietSP.Add(chitiet);
            }

            _ChiTietPhieuNhapBUS.TaoChiTieuPhieuNhap(dsChiTietSP, strMaPhieuXuat);

            FormMessage.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamSach(); // làm sạch controls
            Program.TaiLaiDuLieu(); // tải lại dữ liệu toàn bộ
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamSach();
        }
        private void LamSach()
        {
            txtTenNCC.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";

            txtTongCong.Text = "";

            dgvNhapHang.Rows.Clear();
        }

        private void dgvNhapHang_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnNCCCu_Click(object sender, EventArgs e)
        {
            frmTim frm = new frmTim(frmTim.Loai.NhaCungCap);
            frm.ShowDialog();
            if (frm.LayMa() != null)
            {
                strMaNCC = frm.LayMa();
                dtNhaCungCap = _NhaCungCapBUS.LayBangNhaCungCapTheoMa(strMaNCC);
                txtTenNCC.Text = dtNhaCungCap.Rows[0]["TenNhaCungCap"].ToString();
                txtSoDT.Text = dtNhaCungCap.Rows[0]["SoDT"].ToString();
                txtDiaChi.Text = dtNhaCungCap.Rows[0]["DiaChi"].ToString();
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colThem" && e.RowIndex != -1)
            {
                int iSLMua = 0;
                string strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
                foreach (DataGridViewRow dgvRow in dgvNhapHang.Rows)
                {
                    if (dgvRow.Cells["colMaSanPham"].Value.ToString() == strMaSP)
                    {
                        iSLMua = Convert.ToInt16(dgvRow.Cells["colSL"].Value.ToString());
                    }
                }
                frmThemSLSP frm = new frmThemSLSP(strMaSP, iSLMua, frmThemSLSP.Loai.Mua);
                frm.ShowDialog();
                if (frm.LaySoLuong() > 0)
                    ThemSanPhamVaoHoaDon(strMaSP, frm.LaySoLuong());

            }
        }

        private void dgvNhapHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhapHang.Columns[e.ColumnIndex].Name == "colChinhSua")
            {
                e.Value = "Sửa";
            }
            if (dgvNhapHang.Columns[e.ColumnIndex].Name == "colXoa")
            {
                e.Value = "Xoá";
            }
        }

        private void dgvNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhapHang.Columns[e.ColumnIndex].Name == "colChinhSua")
            {
                int iSL = Convert.ToUInt16(dgvNhapHang.SelectedRows[0].Cells["colSL"].Value.ToString());
                string strMaSP = dgvNhapHang.SelectedRows[0].Cells["colMaSanPham"].Value.ToString();
                frmThemSLSP frm = new frmThemSLSP(strMaSP, iSL, frmThemSLSP.Loai.ChinhSuaMua);
                frm.ShowDialog();
                if (frm.LaySoLuong() > 0)
                    ThemSanPhamVaoHoaDon(strMaSP, frm.LaySoLuong());
            }
            if (dgvNhapHang.Columns[e.ColumnIndex].Name == "colXoa")
            {
                dgvNhapHang.Rows.RemoveAt(dgvNhapHang.SelectedRows[0].Index);
            }
        }

        private void dgvNhapHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTongTien();
        }

        private void dgvNhapHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TinhTongTien();
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
    }
}
