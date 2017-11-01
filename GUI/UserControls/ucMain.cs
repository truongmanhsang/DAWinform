using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucMain : UserControl
    {
        public delegate void XuLyDangXuat();
        public event XuLyDangXuat xuLyDangXuat;
        private static ucMain _instance = null;

        // Cac UC chinh
        private ucBanHang _ucBanHang;
        private ucNhapHang _ucNhapHang;
        private ucHangHoa _ucHangHoa;
        private ucBaoHanh _ucBaoHanh;
        private ucThuChi _ucThuChi;
        private ucNhanVien _ucNhanVien;
        private ucThongKe _ucThongKe;

        public static ucMain GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMain();
                }
                return _instance;
            }
        }
        private ucMain()
        {
            InitializeComponent();
        }

        private void tbtnBanHang_Click(object sender, EventArgs e)
        {
            _ucBanHang = ucBanHang.GetInstance;
            panelMain.Controls.Add(_ucBanHang);
            _ucBanHang.Dock = DockStyle.Fill;
            _ucBanHang.BringToFront();
        }

        private void tbtnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                xuLyDangXuat();
        }

        private void ucMain_Load(object sender, EventArgs e)
        {
        }

        private void tbtnNhapHang_Click(object sender, EventArgs e)
        {
            _ucNhapHang = ucNhapHang.GetInstance;
            panelMain.Controls.Add(_ucNhapHang);
            _ucNhapHang.Dock = DockStyle.Fill;
            _ucNhapHang.BringToFront();
        }

        private void tbtnHangHoa_Click(object sender, EventArgs e)
        {
            _ucHangHoa = ucHangHoa.GetInstance;
            panelMain.Controls.Add(_ucHangHoa);
            _ucHangHoa.Dock = DockStyle.Fill;
            _ucHangHoa.BringToFront();
        }

        private void tbtnBaoHanh_Click(object sender, EventArgs e)
        {
            _ucBaoHanh = ucBaoHanh.GetInstance;
            panelMain.Controls.Add(_ucBaoHanh);
            _ucBaoHanh.Dock = DockStyle.Fill;
            _ucBaoHanh.BringToFront();
        }

        private void tbtnThuChi_Click(object sender, EventArgs e)
        {
            _ucThuChi = ucThuChi.GetInstance;
            panelMain.Controls.Add(_ucThuChi);
            _ucThuChi.Dock = DockStyle.Fill;
            _ucThuChi.BringToFront();
        }

        private void tbtnNhanVien_Click(object sender, EventArgs e)
        {
            _ucNhanVien = ucNhanVien.GetInstance;
            panelMain.Controls.Add(_ucNhanVien);
            _ucNhanVien.Dock = DockStyle.Fill;
            _ucNhanVien.BringToFront();
        }

        private void tbtnThongKe_Click(object sender, EventArgs e)
        {
            _ucThongKe = ucThongKe.GetInstance;
            panelMain.Controls.Add(_ucThongKe);
            _ucThongKe.Dock = DockStyle.Fill;
            _ucThongKe.BringToFront();
        }

        private void tbtnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
