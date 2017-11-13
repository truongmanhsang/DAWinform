using BUS;
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
    public delegate void XuLyThemLoai(clsLoai_DTO loai);
    public delegate void XuLySuaLoai(clsLoai_DTO loai);
    public partial class frmLoai : Form
    {
        private clsLoai_BUS _LoaiBUS = new clsLoai_BUS();

        public event XuLyThemLoai themLoai;
        public event XuLySuaLoai suaLoai;

        string strMaLoai;

        DataTable dtLoai;

        public frmLoai()
        {
            InitializeComponent();
        }

        public frmLoai(string strMaLoai)
        {
            InitializeComponent();
            this.strMaLoai = strMaLoai;
        }

        private void frmLoai_Load(object sender, EventArgs e)
        {
            if (strMaLoai != null)
            {
                dtLoai = _LoaiBUS.LayBangLoai(strMaLoai);
                txtTenLoai.Text = dtLoai.Rows[0]["TenLoaiSanPham"].ToString();
                txtGhiChu.Text = dtLoai.Rows[0]["GhiChu"].ToString();
            }
            if (themLoai != null)
            {
                Text = "Thêm loại sản phẩm";
                btnLuu.Text = "Thêm";
            }else if (suaLoai != null)
            {
                Text = "Sửa loại sản phẩm";
                btnLuu.Text = "Sửa";
            }
        }

        private void ThemLoai()
        {
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_LoaiBUS.KiemTraTen(txtTenLoai.Text).Rows.Count > 0)
            {

                MessageBox.Show("Tên này đã tồn tại, vui lòng chọn 1 tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clsLoai_DTO loai = new clsLoai_DTO();
                loai.TenLoaiSanPham = txtTenLoai.Text;
                loai.GhiChu = txtGhiChu.Text;

                themLoai(loai);
                this.Close();
            }
        }
        private void SuaLoai()
        {
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTenLoai.Text != dtLoai.Rows[0]["TenLoaiSanPham"].ToString())
            {
                if (_LoaiBUS.KiemTraTen(txtTenLoai.Text).Rows.Count > 0)
                {
                    MessageBox.Show("Tên này đã tồn tại, vui lòng chọn 1 tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    clsLoai_DTO loai = new clsLoai_DTO();
                    loai.MaLoaiSanPham = strMaLoai;
                    loai.TenLoaiSanPham = txtTenLoai.Text;
                    loai.GhiChu = txtGhiChu.Text;

                    suaLoai(loai);
                    this.Close();
                }
            }
            else
            {
                clsLoai_DTO loai = new clsLoai_DTO();
                loai.MaLoaiSanPham = strMaLoai;
                loai.TenLoaiSanPham = txtTenLoai.Text;
                loai.GhiChu = txtGhiChu.Text;

                suaLoai(loai);
                this.Close();

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themLoai != null)
            {
                ThemLoai();
            }
            else if (suaLoai != null)
            {
                SuaLoai();
            }
        }
    }
}
