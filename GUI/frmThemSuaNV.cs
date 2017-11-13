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

        private void loadDuLieu()
        {
           cbbChucVu.SelectedIndex=0;
            DataTable table = new DataTable();
            table.Columns.Add("MaQuyen", typeof(int));
            table.Columns.Add("TenQuyen", typeof(char));

         
            table.Rows.Add(1, "Nhân viên");
            table.Rows.Add(2, "f");

          

            cbbChucVu.DataSource = table;
            cbbChucVu.DisplayMember = "TenQuyen";
            cbbChucVu.ValueMember = "MaQuyen";
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
            if (txtTenNV.Text == "" || txtTenDangNhap.Text == "" || txtMK.Text == "" || txtSoDT.Text == "" || txtCMND.Text=="")
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            File.Copy(DuongDanHinh, Application.StartupPath + @"\data\images\users\" + TenHinh, true);
            clsNhanVien_DTO nhanvien = new clsNhanVien_DTO();
            nhanvien.TenNV = txtTenNV.Text;
            nhanvien.TenDangNhap = txtTenDangNhap.Text;
            nhanvien.MatKhau = txtMK.Text;
            nhanvien.SDT = txtSoDT.Text;
            nhanvien.Email = txtEmail.Text;
            nhanvien.CMND = txtCMND.Text;
            nhanvien.DiaChi = txtDiaChi.Text;

            nhanvien.Quyen = cbbChucVu.SelectedIndex==0 ? 1: 0;
            nhanvien.Hinh = @"\data\images\users\" + TenHinh;

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
