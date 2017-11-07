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

namespace GUI
{
    public partial class ucNhapHang : UserControl
    {
        SanPhamBUS _SanPhamBUS = new SanPhamBUS();
        NhaCungCapBUS _NhaCungCapBUS = new NhaCungCapBUS();

        DataTable dtNhaCungCap;
        DataTable dtSanPham;

        Hashtable htSanPham;
        private string strMaNCC;
        private string strMaSP;

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
            dgvNhaCungCap.AutoGenerateColumns = false;
            dgvSanPham.AutoGenerateColumns = false;
        }

        private void TaiDuLieu()
        {
            dtNhaCungCap = _NhaCungCapBUS.LayBangNhaCungCap();
            dgvNhaCungCap.DataSource = dtNhaCungCap;

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
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                strMaNCC = dgvNhaCungCap.Rows[e.RowIndex].Cells["colMaNhaCungCap"].Value.ToString();
                txtTenNCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["colTenNhaCungCap"].Value.ToString();
                txtSoDT.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["colSoDT"].Value.ToString();
                txtDiaChi.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtSL.Text = "1";
                txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["colTenSanPham"].Value.ToString();
                long lDonGia = Convert.ToInt64(dgvSanPham.Rows[e.RowIndex].Cells["colGiaMua"].Value.ToString());
                txtDonGia.Text = Utilities.ChuyenSoSangVND(lDonGia);
                strMaSP = dgvSanPham.SelectedRows[0].Cells["colMaSP"].Value.ToString();
            }
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtTenSP.Text = dgvNhapHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                long lDonGia = Convert.ToInt64(dgvNhapHang.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtDonGia.Text = Utilities.ChuyenSoSangVND(lDonGia);
                txtSL.Text = dgvNhapHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                strMaSP = dgvNhapHang.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnGhiSP_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != string.Empty)
            {
                if (txtSL.Text != string.Empty && Utilities.ChuyenVNDSangSo(txtSL.Text) > 0)
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
            long iSoLuong = Convert.ToInt64(txtSL.Text);
            long iSoLuongConLai = Convert.ToInt64(dr["SoLuong"]);
            long iThanhTien = iDonGia * iSoLuong;

            if (iSoLuong > iSoLuongConLai)
            {
                MessageBox.Show(string.Format("Số lượng sản phẩm còn trong kho không đủ!\nCòn: {0}", iSoLuongConLai), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        return;
                    }
                }
            }


            dgvNhapHang.Rows.Add(strMaSP, strTenSP, iDonGia, iSoLuong, iThanhTien);
        }
        private void TinhTongTien()
        {
            long ltongTien = 0;
            foreach (DataGridViewRow dgvRow in dgvNhapHang.Rows)
            {
                ltongTien += Convert.ToInt64(dgvRow.Cells[4].Value.ToString());
            }
            txtTongCong.Text = Utilities.ChuyenSoSangVND(ltongTien);
        }
    }
}
