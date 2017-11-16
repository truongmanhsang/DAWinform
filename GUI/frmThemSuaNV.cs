using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;
using ClassLibrary;

namespace GUI
{
    public delegate void XulyThemNhanVien(clsNhanVien_DTO sanPham);
    public delegate void XulySuaNhanVien(clsNhanVien_DTO sanPham);
    public partial class frmThemSuaNV : Form
    {
        public event XulyThemNhanVien themnhanvien;
        public event XulySuaNhanVien suanhanvien;
        clsNhanVien_BUS _NhanVienBUS = new clsNhanVien_BUS();
        string MaNV;
        string DuongDanHinh;
        string TenHinh;
       

        DataTable dt;
        public frmThemSuaNV()
        {
            InitializeComponent();
        }
        public frmThemSuaNV(string strMaNV)
        {
            InitializeComponent();
            MaNV = strMaNV;
        }
        
       

        private void frmThemSuaNV_Load(object sender, EventArgs e)
        {
            if (themnhanvien != null)
            {

                Text = "Thêm nhân viên";
                btnLuu.Text = "Thêm";
               
            }
            else
            {
                if (suanhanvien != null)
                {
                    Text = "Sửa nhân viên";
                    btnLuu.Text = "Sửa";
                    loadNV();
                }
                else
                {
                    Text = "Thông tin nhân viên";
                    txtTenDangNhap.ReadOnly = true;
                    txtTenNV.ReadOnly = true;
                    txtMK.UseSystemPasswordChar = true;
                    txtSoDT.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtDiaChi.ReadOnly = true;
                    txtCMND.ReadOnly = true;
                    cbbChucVu.Enabled=false;
                    btnLuu.Visible = false;
                    btnHuy.Text = "Đóng";

                }
            }
            loadDuLieu();
        }

        private void loadNV()
        {
            if (MaNV != null)
            {
                dt = _NhanVienBUS.LayNVTheoMaNV(MaNV);
                txtTenDangNhap.Text = dt.Rows[0]["TenDangNhap"].ToString();
                txtTenNV.Text = dt.Rows[0]["TenNhanVien"].ToString();
                txtMK.Text = dt.Rows[0]["MatKhau"].ToString();
                txtSoDT.Text = dt.Rows[0]["SoDT"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtCMND.Text = dt.Rows[0]["CMND"].ToString();
            }
        }

        private void loadDuLieu()
        {
           cbbChucVu.SelectedIndex=0;
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themnhanvien != null)
            {
                themNV();
            }
            else
            {
                if (suanhanvien != null)
                {
                    suaNV();
                }
            }
        }

        private void suaNV()
        {
            if (txtTenNV.Text == "" || txtTenDangNhap.Text == "" || txtMK.Text == "" || txtSoDT.Text == "" || txtCMND.Text == "")
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsNhanVien_DTO nhanvien = new clsNhanVien_DTO();
            nhanvien.TenNV = txtTenNV.Text;
            nhanvien.TenDangNhap = txtTenDangNhap.Text;
            nhanvien.MatKhau = txtMK.Text;
            nhanvien.SDT = txtSoDT.Text;
            nhanvien.Email = txtEmail.Text;
            nhanvien.CMND = txtCMND.Text;
            nhanvien.DiaChi = txtDiaChi.Text;
            nhanvien.Quyen = cbbChucVu.SelectedIndex == 0 ? 1 : 0;
            suanhanvien(nhanvien);
            this.Close();

        }

        private void themNV()
        {
            if (txtTenNV.Text == "" || txtTenDangNhap.Text == "" || txtMK.Text == "" || txtSoDT.Text == "" || txtCMND.Text=="" || picHinhAnh.Image == null)
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
            
            clsNhanVien_DTO nhanvien = new clsNhanVien_DTO();
            nhanvien.TenNV = txtTenNV.Text;
            nhanvien.TenDangNhap = txtTenDangNhap.Text;
            nhanvien.MatKhau = txtMK.Text;
            nhanvien.SDT = txtSoDT.Text;
            nhanvien.Email = txtEmail.Text;
            nhanvien.CMND = txtCMND.Text;
            nhanvien.DiaChi = txtDiaChi.Text;

            nhanvien.Quyen = cbbChucVu.SelectedIndex==0 ? 1: 0;
            try
            {
                File.Copy(DuongDanHinh, Application.StartupPath + @"data\images\users\" + TenHinh, true);
                nhanvien.Hinh = @"data\images\users\" + TenHinh;
            }
            catch
            {

            }

            themnhanvien(nhanvien);
            this.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
       + "tat ca Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";//loc ra nhung file can hien thi
            openFileDialog.FilterIndex = 6;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = new Bitmap(openFileDialog.FileName);
                DuongDanHinh = openFileDialog.FileName;
                TenHinh = openFileDialog.SafeFileName;
            }
            
            picHinhAnh.ImageLocation =DuongDanHinh;
        }
    }
}
