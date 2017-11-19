using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using DTO;
using BUS;

namespace GUI
{
    public delegate void XuLyThemKhachHang(clsKhachHang_DTO khachhang);
    public delegate void XuLySuaKhachHang(clsKhachHang_DTO khachhang);
    public partial class frmThemSuaKH : Form
    {
        clsKhachHang_BUS bus = new clsKhachHang_BUS();
        DataTable dt = new DataTable();
        
        string MaKH = "";

        public event XuLyThemKhachHang themkhachhang;
        public event XuLySuaKhachHang suakhachhang;
        public frmThemSuaKH(string MaKhach)
        {
            InitializeComponent();
            MaKH = MaKhach;
        }
        public frmThemSuaKH()
        {
            InitializeComponent();
           
        }

        private void frmThemSuaKH_Load_1(object sender, EventArgs e)
        {
            if (themkhachhang != null)
            {
                this.Text = "Thêm khách hàng";
                btnThemLuu.Text = "Thêm";
            }
            else
            {
                if (suakhachhang != null)
                {
                    this.Text = "Sửa khách hàng";
                    btnThemLuu.Text = "Sửa";
                    loadKH();
                }
                else
                {
                    this.Text = "Thông tin khách hàng";
                    loadKH();
                }
            }
        }
        private void loadKH()
        {
            if (MaKH != "")
            {
                dt = bus.LayBangKhachHang(MaKH);
                txtTenKH.Text = dt.Rows[0]["TenKhachHang"].ToString();
                txtSDT.Text = dt.Rows[0]["SoDT"].ToString();
                txtCMND.Text = dt.Rows[0]["CMND"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            }
        }
        private void VoidSuaKhachHang()
        {
            clsKhachHang_DTO khachhang = new clsKhachHang_DTO();
            if (txtTenKH.Text == "" || txtCMND.Text == "" || txtSDT.Text == "")
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            khachhang.MaKhachHang = MaKH;
            khachhang.TenKhachHang = txtTenKH.Text;
            khachhang.CMND = txtCMND.Text;
            khachhang.SoDT = txtSDT.Text;
            khachhang.DiaChi = txtDiaChi.Text;
            suakhachhang(khachhang);
            this.Close();
        }

        private void VoidThemKhachHang()
        {
            clsKhachHang_DTO khachhang = new clsKhachHang_DTO();
            if (txtTenKH.Text == "" || txtCMND.Text == "" || txtSDT.Text == "")
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            khachhang.TenKhachHang = txtTenKH.Text;
            khachhang.CMND = txtCMND.Text;
            khachhang.SoDT = txtSDT.Text;
            khachhang.DiaChi = txtDiaChi.Text;

            themkhachhang(khachhang);
            this.Close();
        }

        private void btnThemLuu_Click(object sender, EventArgs e)
        {
            if (themkhachhang != null)
            {
                VoidThemKhachHang();
            }
            else
            {
                if (suakhachhang != null)
                {
                    VoidSuaKhachHang();
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


