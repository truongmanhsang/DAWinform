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
using ClassLibrary;

namespace GUI
{
    public delegate void XuLyThemNhaCungCap(clsNhaCungCap_DTO nhacungcap);
    public delegate void XuLySuaNhaCungCap(clsNhaCungCap_DTO nhacungcap);
    public partial class frmThemSuaNCC : Form
    {
        public event XuLyThemNhaCungCap themnhacungcap;
        public event XuLySuaNhaCungCap suanhacungcap;
        clsNhaCungCap_BUS bus = new clsNhaCungCap_BUS();
        DataTable dt;
        string MaNCC;
        public frmThemSuaNCC()
        {
            InitializeComponent();
        }
        public frmThemSuaNCC(string mancc)
        {
            InitializeComponent();
            MaNCC = mancc;
        }

       

        private void frmThemSuaNCC_Load(object sender, EventArgs e)
        {
            if (themnhacungcap != null)
            {
                this.Text = "Thêm nhà cung cấp";
                btnThemLuu.Text = "Thêm";
            }
            else
            {
                if (suanhacungcap != null)
                {
                    this.Text = "Sửa nhà cung cấp";
                    btnThemLuu.Text = "Sửa";
                    loadDL();
                }
            }
        }
        private void btnThemLuu_Click(object sender, EventArgs e)
        {
            if (themnhacungcap != null)
            {
                themNCC();
            }
            else
            {
                if (suanhacungcap != null)
                {
                    SuaNCC();
                    loadDL();
                }
            }

        }

        private void loadDL()
        {
            dt = bus.LayBangNhaCungCapTheoMa(MaNCC);
            txtTenNCC.Text = dt.Rows[0]["TenNhaCungCap"].ToString();
            txtSDT.Text = dt.Rows[0]["SoDT"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();

        }

        private void SuaNCC()
        {
            if (txtTenNCC.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsNhaCungCap_DTO nhacungcap = new clsNhaCungCap_DTO();
            nhacungcap.MaNhaCungCap = MaNCC;
            nhacungcap.TenNhaCungCap = txtTenNCC.Text;
            nhacungcap.SoDT = txtSDT.Text;
            nhacungcap.DiaChi = txtDiaChi.Text;
            nhacungcap.GhiChu = "";
            suanhacungcap(nhacungcap);
            this.Close();
        }

        private void themNCC()
        {
            if (txtTenNCC.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                FormMessage.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsNhaCungCap_DTO nhacungcap = new clsNhaCungCap_DTO();
            nhacungcap.TenNhaCungCap = txtTenNCC.Text;
            nhacungcap.SoDT = txtSDT.Text;
            nhacungcap.DiaChi = txtDiaChi.Text;
            nhacungcap.GhiChu = "";
            themnhacungcap(nhacungcap);
            this.Close();
        }
    }
}
