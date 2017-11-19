using BUS;
using ClassLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public delegate void XuLyThemHSX(clsHangSanXuat_DTO hsx);
    public delegate void XuLySuaHSX(clsHangSanXuat_DTO hsx);
    public partial class frmHangSanXuat : Form
    {
        private clsHangSanXuat_BUS _HangSanXuatBUS = new clsHangSanXuat_BUS();

        public event XuLyThemHSX themHSX;
        public event XuLySuaHSX suaHSX;

        string strMaHSX;

        DataTable dtHSX;
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        public frmHangSanXuat(string strMaHSX)
        {
            InitializeComponent();
            this.strMaHSX = strMaHSX;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            if (strMaHSX != null)
            {
                dtHSX = _HangSanXuatBUS.LayBangHangSanXuat(strMaHSX);
                txtTenHSX.Text = dtHSX.Rows[0]["TenHangSanXuat"].ToString();
                txtGhiChu.Text = dtHSX.Rows[0]["GhiChu"].ToString();
            }
            if (themHSX != null)
            {
                Text = "Thêm hãng sản xuất";
                btnLuu.Text = "Thêm";
            }
            else if (suaHSX != null)
            {
                Text = "Sửa hãng sản xuất";
                btnLuu.Text = "Sửa";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themHSX != null)
            {
                ThemHSX();
            }
            else if (suaHSX != null)
            {
                SuaHSX();
            }
        }
        private void ThemHSX()
        {
            if (txtTenHSX.Text == "")
            {
                FormMessage.Show("Bạn chưa nhập tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_HangSanXuatBUS.KiemTraTen(txtTenHSX.Text).Rows.Count > 0)
            {

                FormMessage.Show("Tên này đã tồn tại, vui lòng chọn 1 tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clsHangSanXuat_DTO loai = new clsHangSanXuat_DTO();
                loai.TenHangSanXuat = txtTenHSX.Text;
                loai.GhiChu = txtGhiChu.Text;

                themHSX(loai);
                this.Close();
            }
        }
        private void SuaHSX()
        {
            if (txtTenHSX.Text == "")
            {
                FormMessage.Show("Bạn chưa nhập tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTenHSX.Text != dtHSX.Rows[0]["TenHangSanXuat"].ToString())
            {
                if (_HangSanXuatBUS.KiemTraTen(txtTenHSX.Text).Rows.Count > 0)
                {
                    FormMessage.Show("Tên này đã tồn tại, vui lòng chọn 1 tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clsHangSanXuat_DTO hsx = new clsHangSanXuat_DTO();
                    hsx.MaHangSanXuat = strMaHSX;
                    hsx.TenHangSanXuat = txtTenHSX.Text;
                    hsx.GhiChu = txtGhiChu.Text;

                    suaHSX(hsx);
                    this.Close();
                }
            }
            else
            {
                clsHangSanXuat_DTO hsx = new clsHangSanXuat_DTO();
                hsx.MaHangSanXuat = strMaHSX;
                hsx.TenHangSanXuat = txtTenHSX.Text;
                hsx.GhiChu = txtGhiChu.Text;

                suaHSX(hsx);
                this.Close();

            }
        }
    }
}
