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

namespace GUI
{
    public partial class ucBanHang : UserControl
    {
        private static ucBanHang _instance = null;
        // các bus cần thiết
        private KhachHangBUS _KhachHangBUS = new KhachHangBUS();
        private SanPhamBUS _SanPhamBUS = new SanPhamBUS();
        private SerialBUS _SerialBUS = new SerialBUS();
        private PhieuXuatBUS _PhieuXuatBUS = new PhieuXuatBUS();

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
        public static ucBanHang GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucBanHang();
                }
                return _instance;
            }
        }
        public ucBanHang()
        {
            InitializeComponent();
        }

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            Setup();
            LoadDatabase();
        }

        private void Setup()
        {
            // cài đặt datagrid
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.AllowUserToAddRows = false;
            dgvBanHang.AllowUserToAddRows = false;

            // ẩn cột không cần thiết
            dgvSanPham.Columns["colMaSP"].Visible = false;
            dgvBanHang.Columns["colMaSanPham"].Visible = false;
            dgvKhachHang.Columns["colMaKH"].Visible = false;
            dgvKhachHang.Columns["colDiaChi"].Visible = false;

            // cài đặt mặt định cbo
            cboHinhThucTra.SelectedIndex = 0;
        }

        private void LoadDatabase()
        {
            dtKhachHang = _KhachHangBUS.LayBangKhachHang();
            dvKhachHang = new DataView(dtKhachHang);
            dgvKhachHang.DataSource = dvKhachHang;
            dtSanPham = _SanPhamBUS.LayBangSanPham();
            dvSanPham = new DataView(dtSanPham);
            dgvSanPham.DataSource = dvSanPham;
            LoadHashTableSP();
        }

        private void LoadHashTableSP()
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
                txtSL.Text = "1";
                txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["colTenSanPham"].Value.ToString();
                long lDonGia = Convert.ToInt64(dgvSanPham.Rows[e.RowIndex].Cells["colGiaTien"].Value.ToString());
                txtDonGia.Text = string.Format("{0:#,###} VNĐ", lDonGia);
                strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
            }
        }

        private void btnGhiSP_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != string.Empty)
            {
                if (txtSL.Text != string.Empty && Convert.ToInt16(txtSL.Text.Replace(".","").Replace("VNĐ","")) > 0)
                {
                    ThemSanPhamVaoHoaDon();
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Vui lòng Nhập số lượng sản phẩm lớn hơn 0!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm ở mục bên trái để mua!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ThemSanPhamVaoHoaDon()
        {
            DataRow dr = (DataRow)htSanPham[strMaSP];

            string strTenSP = txtTenSP.Text;
            long iDonGia = Convert.ToInt64(dr["GiaBan"]);
            int iSoLuong = Convert.ToInt16(txtSL.Text);
            int iSoLuongConLai = Convert.ToInt16(dr["SoLuong"]);
            long iThanhTien = iDonGia * iSoLuong;

            if (iSoLuong > iSoLuongConLai)
            {
                MessageBox.Show(string.Format("Số lượng sản phẩm còn trong kho không đủ!\nCòn: {0}",iSoLuongConLai), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtDonGia.Text = string.Format("{0:#,###} VNĐ", lDonGia);
                txtSL.Text = dgvBanHang.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            txtTongCong.Text = string.Format("{0:#,###} VNĐ",ltongTien);
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
            txtSL.Text = "1";

            txtTongCong.Text = "";

            dgvBanHang.Rows.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtSoDT.Text != "" && txtDiaChi.Text != "")
            {
                if (dgvBanHang.Rows.Count > 0)
                {
                    XuatHoaDon();

                }else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để mua, bạn có thể chọn ở mục bên trái nhập số lượng và nhấn ghi!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng, bạn có thể chọn ở mục bên trái hoặc thêm!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void XuatHoaDon()
        {
            if (bThemKH) // nếu đúng thì thêm khách hàng này vào csdl trước rồi lập hoá đơn
            {
                KhachHangDTO khachHang = new KhachHangDTO();
                khachHang.TenKhachHang = txtTenKH.Text;
                khachHang.SoDT = txtSoDT.Text;
                khachHang.DiaChi = txtDiaChi.Text;

                strMaKH = _KhachHangBUS.ThemKhachHang(khachHang);
            }

            // Thêm hoá đơn xuất
            PhieuXuatDTO phieuXuat = new PhieuXuatDTO();
            phieuXuat.MaKhachHang = strMaKH;
            phieuXuat.TongTien = Convert.ToInt64(txtTongCong.Text.Replace(",", "").Replace("VNĐ", ""));
            phieuXuat.NgayLap = DateTime.Now.ToString("dd/MM/yyyy");
            phieuXuat.MaNVLap = Program.MA_NV;

            // Thêm chi tiết hoá đơn xuất
            List<ChiTietPhieuXuatDTO> dsChiTietSP = new List<ChiTietPhieuXuatDTO>(); // danh sách các sản phẩm trong hoá đơn
            foreach (DataGridViewRow dgvRow in dgvBanHang.Rows)
            {
                DataRow drSP = (DataRow)htSanPham[dgvRow.Cells[0].Value.ToString()]; // lấy mã sp của từng dòng trong dgvBanHang

                ChiTietPhieuXuatDTO chitiet = new ChiTietPhieuXuatDTO();
                chitiet.MaSanPham = dgvRow.Cells[0].Value.ToString();
                chitiet.SoLuong = Convert.ToInt16(dgvRow.Cells[3].Value.ToString());
                chitiet.Gia = Convert.ToInt64(dgvRow.Cells[2].Value.ToString());
                chitiet.MaSerial = _SerialBUS.LayMaSerial(drSP["MaSanPham"].ToString(),Convert.ToUInt16(drSP["BaoHanh"]));

                dsChiTietSP.Add(chitiet);
            }

            // xuất hoá đơn
            if (_PhieuXuatBUS.TaoPhieuXuat(phieuXuat, dsChiTietSP) == 1)
            {
                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamSach(); // làm sạch controls
                LoadDatabase(); // tải lại dữ liệu
            }else
            {
                MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
