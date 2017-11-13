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

namespace GUI
{
    public partial class ucDangNhap : UserControl
    {
        public delegate void XuLyDangNhap();
        public event XuLyDangNhap xuLyDangNhap;
        clsNhanVien_BUS _NhanVienBUS = new clsNhanVien_BUS();
        public ucDangNhap()
        {
            InitializeComponent();
        }

        private void ucDangNhap_Load(object sender, EventArgs e)
        {
            BatTatControls(false);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap(); 
        }

        private void DangNhap()
        {
            DataTable dtNV = _NhanVienBUS.LayThongTinNV(txtTaiKhoan.Text, txtMatKhau.Text);
            if (dtNV != null)
            {
                if (dtNV.Rows.Count > 0)
                {
                    Program.MA_NV = dtNV.Rows[0]["MaNhanVien"].ToString(); // Lấy mã nv làm biến tĩnh toàn chương trình
                    Program.TEN_NV = dtNV.Rows[0]["TenNhanVien"].ToString();
                    Program.HINH_NV = dtNV.Rows[0]["HinhDaiDien"].ToString();
                    Program.QUYEN = Convert.ToInt16(dtNV.Rows[0]["Quyen"].ToString());

                    xuLyDangNhap(); // gọi hàm xử lý đăng nhập đã đc định nghĩa ở form main

                    lblTinNhan.Text = "Vui lòng nhập mật khẩu để tiếp tục!";
                    lblTinNhan.ForeColor = Color.Green;
                    BatTatControls(true);
                    txtMatKhau.Text = "";
                    txtMatKhau.Focus();
                }
                else
                {
                    lblTinNhan.Text = "Mật khẩu không đúng, vui lòng thử lại!";
                    lblTinNhan.ForeColor = Color.Red;
                }
            }
            else
            {
                lblTinNhan.Text = "Không thể hack vào hệ thống!";
                lblTinNhan.ForeColor = Color.Red;
            }
        }

        private void BatTatControls(bool b)
        {
            lblMatKhau.Visible = b;
            txtMatKhau.Visible = b;
            btnDangNhap.Visible = b;
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            DataTable dtNV = _NhanVienBUS.LayThongTinNV(txtTaiKhoan.Text);
            if (dtNV.Rows.Count > 0)
            {
                string strUrlAnh = dtNV.Rows[0]["HinhDaiDien"].ToString();
                picAnh.Image = new Bitmap(strUrlAnh);
                lblTinNhan.Text = string.Format("Xin chào {0}!, vui lòng nhập mật khẩu để tiếp tục!",dtNV.Rows[0]["TenNhanVien"]);
                lblTinNhan.ForeColor = Color.Green;
                BatTatControls(true);
                txtMatKhau.Focus();
            }
            else
            {
                picAnh.Image = GUI.Properties.Resources.AnhMacDinh;
                lblTinNhan.Text = txtTaiKhoan.Text == "" ? "" : "Tên tài khoản không tồn tại!";
                BatTatControls(false);
                lblTinNhan.ForeColor = Color.Red;
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
    }
}
