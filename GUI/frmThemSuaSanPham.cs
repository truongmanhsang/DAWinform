﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public delegate void XuLyThemSanPham(clsSanPham_DTO sanPham);
    public delegate void XuLySuaSanPham(clsSanPham_DTO sanPham);
    public partial class frmThemSuaSanPham : Form
    {
        public event XuLyThemSanPham themSanPham;
        public event XuLySuaSanPham suaSanPham;

        clsLoaiSanPham_BUS _LoaiSanPhamBUS = new clsLoaiSanPham_BUS();
        clsHangSanXuat_BUS _HangSanXuatBUS = new clsHangSanXuat_BUS();
        clsSanPham_BUS _SanPhamBUS = new clsSanPham_BUS();

        DataTable dtSanPham;

        string strDuongDanHinh;
        string strTenHinh;
        string strMaSP;

        public frmThemSuaSanPham()
        {
            InitializeComponent();
            this.Focus();
        }

        public frmThemSuaSanPham(string strMaSP)
        {
            InitializeComponent();
            this.strMaSP = strMaSP;
        }

        private void frmThemSuaSanPham_Load(object sender, EventArgs e)
        {
            if (themSanPham != null)
            {
                Text = "Thêm sản phẩm";
                btnThemLuu.Text = "Thêm";
            }
            else if (suaSanPham != null)
            {
                Text = "Sửa sản phẩm";
                btnThemLuu.Text = "Sửa";
            }
            else
            {
                Text = "Chi tiết sản phẩm";

                txtTenSP.ReadOnly = true;
                txtDonViTinh.ReadOnly = true;
                numBH.Enabled = false;
                txtGiaMua.ReadOnly = true;
                txtGiaBan.ReadOnly = true;
                txtKhuyenMai.ReadOnly = true;
                rtbMota.ReadOnly = true;
                txtGhiChu.ReadOnly = true;
                picHinh.Enabled = false;
                cboHSX.Enabled = false;
                cboLoaiSP.Enabled = false;
                btnThemLuu.Visible = false;
                btnHuy.Text = "Đồng ý";
            }
            TaiDuLieu();
        }
        private void TaiDuLieu()
        {
            DataTable dtLoaiSanPham = _LoaiSanPhamBUS.LayBangLoaiSanPham();
            cboLoaiSP.DataSource = dtLoaiSanPham;
            cboLoaiSP.DisplayMember = "TenLoaiSanPham";
            cboLoaiSP.ValueMember = "MaLoaiSanPham";

            DataTable dtHangSanXuat = _HangSanXuatBUS.LayBangHangSanXuat();
            cboHSX.DataSource = dtHangSanXuat;
            cboHSX.DisplayMember = "TenHangSanXuat";
            cboHSX.ValueMember = "MaHangSanXuat";

            if (strMaSP != null)
            {
                dtSanPham = _SanPhamBUS.LayBangSanPham(strMaSP);
                txtTenSP.Text = dtSanPham.Rows[0]["TenSanPham"].ToString();
                txtDonViTinh.Text = dtSanPham.Rows[0]["DonViTinh"].ToString();
                numBH.Value = Convert.ToInt16(dtSanPham.Rows[0]["BaoHanh"].ToString());
                txtGiaMua.Text = dtSanPham.Rows[0]["GiaMua"].ToString();
                txtGiaBan.Text = dtSanPham.Rows[0]["GiaBan"].ToString();
                txtKhuyenMai.Text = dtSanPham.Rows[0]["KhuyenMai"].ToString();
                cboLoaiSP.SelectedValue = dtSanPham.Rows[0]["MaLoaiSanPham"].ToString();
                cboHSX.SelectedValue = dtSanPham.Rows[0]["MaHangSanXuat"].ToString();
                rtbMota.Text = dtSanPham.Rows[0]["MoTa"].ToString();
                txtGhiChu.Text = dtSanPham.Rows[0]["GhiChu"].ToString();
                picHinh.Image = new Bitmap(dtSanPham.Rows[0]["Hinh"].ToString());
                lblSL.Text = dtSanPham.Rows[0]["SoLuong"].ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLuu_Click(object sender, EventArgs e)
        {
            if (themSanPham != null)
            {
                XuLyThem();
            }
            else if (suaSanPham != null)
            {
                XuLySua();
            }

        }
        private void XuLySua()
        {
            if (txtTenSP.Text == "" || txtDonViTinh.Text == "" || txtGiaMua.Text == "" || txtGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numBH.Value == 0)
            {
                MessageBox.Show("Tháng bảo hành phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (picHinh.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsSanPham_DTO sanPham = new clsSanPham_DTO();

            if (strDuongDanHinh != null && strTenHinh != null)
            {
                File.Copy(strDuongDanHinh, Application.StartupPath + @"\data\images\products\" + strTenHinh, true);
                sanPham.Hinh = @"data\images\products\" + strTenHinh;
            }
            else
            {
                sanPham.Hinh = dtSanPham.Rows[0]["Hinh"].ToString();
            }

            sanPham.MaSanPham = strMaSP;
            sanPham.TenSanPham = txtTenSP.Text;
            sanPham.DonViTinh = txtDonViTinh.Text;
            sanPham.GiaMua = Convert.ToDecimal(txtGiaMua.Text);
            sanPham.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
            sanPham.BaoHanh = Convert.ToInt16(numBH.Value);
            sanPham.KhuyenMai = Convert.ToDecimal(txtKhuyenMai.Text == "" ? "0" : txtKhuyenMai.Text);
            sanPham.MaLoaiSanPham = cboLoaiSP.SelectedValue.ToString();
            sanPham.MaHangSanXuat = cboHSX.SelectedValue.ToString();
            sanPham.MoTa = rtbMota.Text;
            sanPham.GhiChu = txtGhiChu.Text;

            suaSanPham(sanPham);

            this.Close();
        }
        private void XuLyThem()
        {
            if (txtTenSP.Text == "" || txtDonViTinh.Text == "" || txtGiaMua.Text == "" || txtGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numBH.Value == 0)
            {
                MessageBox.Show("Tháng bảo hành phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (picHinh.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.Copy(strDuongDanHinh, Application.StartupPath + @"\data\images\products\" + strTenHinh,true);
            clsSanPham_DTO sanPham = new clsSanPham_DTO();
            sanPham.TenSanPham = txtTenSP.Text;
            sanPham.DonViTinh = txtDonViTinh.Text;
            sanPham.GiaMua = Convert.ToDecimal(txtGiaMua.Text);
            sanPham.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
            sanPham.BaoHanh = Convert.ToInt16(numBH.Value);
            sanPham.KhuyenMai = Convert.ToDecimal(txtKhuyenMai.Text == "" ? "0" : txtKhuyenMai.Text);
            sanPham.MaLoaiSanPham = cboLoaiSP.SelectedValue.ToString();
            sanPham.MaHangSanXuat = cboHSX.SelectedValue.ToString();
            sanPham.MoTa = rtbMota.Text;
            sanPham.GhiChu = txtGhiChu.Text;
            sanPham.Hinh = @"data\images\products\" + strTenHinh;

            themSanPham(sanPham);

            this.Close();
        }

        private void picHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
       + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            openFileDialog.FilterIndex = 6;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinh.Image = new Bitmap(openFileDialog.FileName);
                strDuongDanHinh = openFileDialog.FileName;
                strTenHinh = openFileDialog.SafeFileName;
            }
        }

        public void DatTenForm(string strTen)
        {
            this.Text = strTen;
        }

        private void frmThemSuaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void frmThemSuaSanPham_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void frmThemSuaSanPham_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
