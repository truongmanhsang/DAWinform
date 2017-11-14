using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace GUI
{
    public partial class ucMain : UserControl
    {
        public delegate void XuLyDangXuat();
        public event XuLyDangXuat xuLyDangXuat;
        private static ucMain _instance = null;

        // khai báo image cho close button tabpage
        Image imgCloseButtonActive;
        Image imgCloseButton;

        // Enum Chức năng
        enum ChucNang
        {
            BanHang, KhachHang, CongNoBanHang, BaoCaoBanHang,
            NhapHang, NhaCungCap, CongNoNhapHang, BaoCaoNhapHang,
            HangHoa, TonKho,
            NhanBaoHanh, GuiBaoHanh, BaoCaoBaoHanh,
            ThuChi,
            NhanVien,
            DoanhThu,DoanhSo,LoiNhuan
        }

        // khai báo tất cả tabpage chức năng
        TabPage tabBanHang;
        TabPage tabKhachHang;
        TabPage tabNhaCungCap;
        TabPage tabBaoCaoBanHang;
        TabPage tabBaoCaoNhapHang;
        TabPage tabTonKho;
        TabPage tabNhanBaoHanh;
        TabPage tabGuiBaoHanh;
        TabPage tabBaoCaoBaoHanh;
        TabPage tabNhanVien;
        TabPage tabDoanhthu;
        TabPage tabLoiNhuan;
        TabPage tabNhapHang;

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

        private void ucMain_Load(object sender, EventArgs e)
        {
            // lấy thông tin cho phần thông tin panel trái
            picHinhDaiDien.Image = new Bitmap(Program.HINH_NV);
            lblTenNV.Text = Program.TEN_NV;
            if (Program.QUYEN == 1)
                lblQuyen.Text = "Quản lý";
            else
                lblQuyen.Text = "Nhân viên";
            // ===

            // Cài đặt tabpage close button size
            Size mySize = new Size(15, 15);
            Bitmap bmp = new Bitmap(GUI.Properties.Resources.CloseActive, mySize);
            imgCloseButtonActive = bmp;

            Bitmap bmp2 = new Bitmap(GUI.Properties.Resources.Close, mySize);
            imgCloseButton = bmp2;
            tabControlMain.Padding = new Point(50);
            // ==

        }

        private void tabControlMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Rectangle rect = new Rectangle();
            for (int i = 0; i < tabControlMenu.TabCount; i++)
            {
                if (tabControlMenu.SelectedTab == tabControlMenu.TabPages[i])
                {
                    rect = tabControlMenu.GetTabRect(i);
                }
            }
            if (rect.Contains(e.Location))
            {
                if (tabControlMenu.Height > 25)
                {
                    tabControlMenu.Height = 25;
                }
                else
                {
                    tabControlMenu.Height = 130;
                }
            }
        }

        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            // lấy rect của tabpage
            Rectangle rect = tabControlMain.GetTabRect(e.Index);
            // tính toán image rect của button
            Rectangle imageRec = new Rectangle(rect.Right - imgCloseButton.Width - 5,
                rect.Top + (rect.Height - imgCloseButton.Height) / 2,
                imgCloseButton.Width, imgCloseButton.Height);
            rect.Size = new Size(rect.Width + 20, 38);
            // tính toán fill tabpage
            Rectangle rectFill = new Rectangle(rect.Left, rect.Top, rect.Width - 20, rect.Height - 16);
            // rect dùng để vẽ chữ
            Rectangle rectString = new Rectangle(rect.Left + 3, rect.Top + 3, rect.Width, rect.Height);

            Font f;
            Brush brAct = Brushes.Black;
            Brush br = Brushes.Black;
            StringFormat strF = new StringFormat(StringFormat.GenericDefault);
            // Brush dùng để vẽ màu tab
            Brush brTabAct = Brushes.White;
            Brush brTab = Brushes.DarkGray;
            if (tabControlMain.SelectedTab == tabControlMain.TabPages[e.Index]) // tab được chọn
            {
                e.Graphics.FillRectangle(brTabAct, rectFill);
                // vẽ button
                e.Graphics.DrawImage(imgCloseButtonActive, imageRec);
                f = new Font("Arial", 12, FontStyle.Bold);
                // vẽ tên chữ
                e.Graphics.DrawString(tabControlMain.TabPages[e.Index].Text,
                    f, brAct, rectString, strF);
            }
            else
            {
                e.Graphics.FillRectangle(brTab, rectFill);
                // vẽ button
                e.Graphics.DrawImage(imgCloseButton, imageRec);
                f = new Font("Arial", 12, FontStyle.Regular);
                // vẽ tên chữ
                e.Graphics.DrawString(tabControlMain.TabPages[e.Index].Text,
                    f, br, rectString, strF);
            }
        }

        private void tabControlMain_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControlMain.TabCount; i++)
            {
                // giống trên
                Rectangle rect = tabControlMain.GetTabRect(i);
                Rectangle imageRec = new Rectangle(rect.Right - imgCloseButton.Width - 5,
                    rect.Top + (rect.Height - imgCloseButton.Height) / 2,
                    imgCloseButton.Width, imgCloseButton.Height);

                if (imageRec.Contains(e.Location))
                    tabControlMain.TabPages.Remove(tabControlMain.SelectedTab);
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.BanHang);
        }

        private void TaoTabpage(ChucNang cn)
        {
            string strTenTabpage = string.Empty;
            switch (cn)
            {
                case ChucNang.BanHang:
                    strTenTabpage = "Bán Hàng";
                    if (!tabControlMain.Contains(tabBanHang))
                    {
                        tabBanHang = new TabPage(strTenTabpage);
                        ucBanHang _ucBanHang = new ucBanHang();
                        tabBanHang.Controls.Add(_ucBanHang);
                        _ucBanHang.Dock = DockStyle.Fill;

                        tabControlMain.TabPages.Add(tabBanHang);
                        tabControlMain.SelectedTab = tabBanHang;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabBanHang;
                    }
                    break;
                case ChucNang.KhachHang:
                    strTenTabpage = "Khách Hàng";
                    if (!tabControlMain.Contains(tabKhachHang))
                    {
                        tabKhachHang = new TabPage(strTenTabpage);
                        ucKhachHang _ucKhachHang = new ucKhachHang();
                        tabKhachHang.Controls.Add(_ucKhachHang);
                        _ucKhachHang.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabKhachHang);
                        tabControlMain.SelectedTab = tabKhachHang;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabKhachHang;
                    }
                    break;
                case ChucNang.BaoCaoBanHang:
                    strTenTabpage = "Báo Cáo Bán Hàng";
                    if (!tabControlMain.Contains(tabBaoCaoBanHang))
                    {
                        tabBaoCaoBanHang = new TabPage(strTenTabpage);
                        ucBaoCaoBanHang _ucBaoCaoBanHang = new ucBaoCaoBanHang();
                        tabBaoCaoBanHang.Controls.Add(_ucBaoCaoBanHang);
                        _ucBaoCaoBanHang.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabBaoCaoBanHang);
                        tabControlMain.SelectedTab = tabBaoCaoBanHang;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabBaoCaoBanHang;
                    }
                    break;
                case ChucNang.NhapHang:
                    strTenTabpage = "Nhập Hàng";
                    if (!tabControlMain.Contains(tabNhapHang))
                    {
                        tabNhapHang = new TabPage(strTenTabpage);
                        ucNhapHang _ucNhapHang = new ucNhapHang();
                        tabNhapHang.Controls.Add(_ucNhapHang);
                        _ucNhapHang.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabNhapHang);
                        tabControlMain.SelectedTab = tabNhapHang;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabNhapHang;
                    }
                    break;
                case ChucNang.NhaCungCap:
                    strTenTabpage = "Nhà Cung Cấp";
                    if (!tabControlMain.Contains(tabNhaCungCap))
                    {
                        tabNhaCungCap = new TabPage(strTenTabpage);
                        ucNhaCungCap _ucNhaCungCap = new ucNhaCungCap();
                        tabNhaCungCap.Controls.Add(_ucNhaCungCap);
                        _ucNhaCungCap.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabNhaCungCap);
                        tabControlMain.SelectedTab = tabNhaCungCap;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabNhaCungCap;
                    }
                    break;
                case ChucNang.BaoCaoNhapHang:
                    strTenTabpage = "Báo Cáo Nhập Hàng";
                    if (!tabControlMain.Contains(tabBaoCaoNhapHang))
                    {
                        tabBaoCaoNhapHang = new TabPage(strTenTabpage);
                        ucBaoCaoNhapHang _ucBaoCaoNhapHang = new ucBaoCaoNhapHang();
                        tabBaoCaoNhapHang.Controls.Add(_ucBaoCaoNhapHang);
                        _ucBaoCaoNhapHang.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabBaoCaoNhapHang);
                        tabControlMain.SelectedTab = tabBaoCaoNhapHang;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabBaoCaoNhapHang;
                    }
                    break;
                case ChucNang.HangHoa:
                    strTenTabpage = "Hàng Hoá";
                    if (!tabControlMain.Contains(tabPageHangHoa))
                    {
                        tabPageHangHoa = new TabPage(strTenTabpage);
                        ucHangHoa _ucHangHoa = new ucHangHoa();
                        tabPageHangHoa.Controls.Add(_ucHangHoa);
                        _ucHangHoa.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabPageHangHoa);
                        tabControlMain.SelectedTab = tabPageHangHoa;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabPageHangHoa;
                    }
                    break;
                case ChucNang.TonKho:
                    strTenTabpage = "Tồn Kho";
                    if (!tabControlMain.Contains(tabTonKho))
                    {
                        tabTonKho = new TabPage(strTenTabpage);
                        ucTonKho _ucTonKho = new ucTonKho();
                        tabTonKho.Controls.Add(_ucTonKho);
                        _ucTonKho.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabTonKho);
                        tabControlMain.SelectedTab = tabTonKho;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabTonKho;
                    }
                    break;
                case ChucNang.NhanBaoHanh:
                    strTenTabpage = "Nhận Bảo Hành";
                    if (!tabControlMain.Contains(tabNhanBaoHanh))
                    {
                        tabNhanBaoHanh = new TabPage(strTenTabpage);
                        ucNhanBaoHanh _ucNhanBaoHanh = new ucNhanBaoHanh();
                        _ucNhanBaoHanh.timSoSerial += BatTabTimSoSerial;
                        tabNhanBaoHanh.Controls.Add(_ucNhanBaoHanh);
                        _ucNhanBaoHanh.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabNhanBaoHanh);
                        tabControlMain.SelectedTab = tabNhanBaoHanh;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabNhanBaoHanh;
                    }
                    break;
                case ChucNang.GuiBaoHanh:
                    strTenTabpage = "Gửi Bảo Hành";
                    if (!tabControlMain.Contains(tabGuiBaoHanh))
                    {
                        tabGuiBaoHanh = new TabPage(strTenTabpage);
                        ucGuiBaoHanh _ucGuiBaoHanh = new ucGuiBaoHanh();
                        tabGuiBaoHanh.Controls.Add(_ucGuiBaoHanh);
                        _ucGuiBaoHanh.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabGuiBaoHanh);
                        tabControlMain.SelectedTab = tabGuiBaoHanh;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabGuiBaoHanh;
                    }
                    break;
                case ChucNang.BaoCaoBaoHanh:
                    strTenTabpage = "Báo Cáo Bảo Hành";
                    if (!tabControlMain.Contains(tabBaoCaoBaoHanh))
                    {
                        tabBaoCaoBaoHanh = new TabPage(strTenTabpage);
                        ucBaoCaoBaoHanh _ucBaoCaoBaoHanh = new ucBaoCaoBaoHanh();
                        tabBaoCaoBaoHanh.Controls.Add(_ucBaoCaoBaoHanh);
                        _ucBaoCaoBaoHanh.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabBaoCaoBaoHanh);
                        tabControlMain.SelectedTab = tabBaoCaoBaoHanh;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabBaoCaoBaoHanh;
                    }
                    break;
                case ChucNang.NhanVien:
                    strTenTabpage = "Nhân Viên";
                    if (!tabControlMain.Contains(tabNhanVien))
                    {
                        tabNhanVien = new TabPage(strTenTabpage);
                        ucNhanVien _ucNhanVien = new ucNhanVien();
                        tabNhanVien.Controls.Add(_ucNhanVien);
                        _ucNhanVien.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabNhanVien);
                        tabControlMain.SelectedTab = tabNhanVien;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabNhanVien;
                    }
                    break;
                case ChucNang.DoanhThu:
                    strTenTabpage = "Doanh Thu";
                    if (!tabControlMain.Contains(tabDoanhthu))
                    {
                        tabDoanhthu = new TabPage(strTenTabpage);
                        ucDoanhThu _ucDoanhThu = new ucDoanhThu();
                        tabDoanhthu.Controls.Add(_ucDoanhThu);
                        _ucDoanhThu.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabDoanhthu);
                        tabControlMain.SelectedTab = tabDoanhthu;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabDoanhthu;
                    }
                    break;
                case ChucNang.LoiNhuan:
                    strTenTabpage = "Lợi Nhuận";
                    if (!tabControlMain.Contains(tabLoiNhuan))
                    {
                        tabLoiNhuan = new TabPage(strTenTabpage);
                        ucLoiNhuan _ucLoiNhuan = new ucLoiNhuan();
                        tabLoiNhuan.Controls.Add(_ucLoiNhuan);
                        _ucLoiNhuan.Dock = DockStyle.Fill;


                        tabControlMain.TabPages.Add(tabLoiNhuan);
                        tabControlMain.SelectedTab = tabLoiNhuan;
                    }
                    else
                    {
                        tabControlMain.SelectedTab = tabLoiNhuan;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.KhachHang);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = FormMessage.Show("Bạn chắc chắn muốn đăng xuất chứ?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                xuLyDangXuat();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.NhaCungCap);
        }

        private void btnBaoCaoBanHang_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.BaoCaoBanHang);
        }

        private void btnAnHien_Click(object sender, EventArgs e)
        {
            btnAnHien.Text = btnAnHien.Text == "<" ? ">" : "<";
            if (panInfo.Width > 16)
            {
                panInfo.Width = 16;
                btnAnHien.Width = 17;
            }

            else
            {
                panInfo.Width = 196;
                btnAnHien.Width = 197;

            }

        }

        private void btnBaoCaoNhapHang_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.BaoCaoNhapHang);
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.HangHoa);
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.TonKho);
        }

        private void btnNhanBaoHanh_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.NhanBaoHanh);
        }

        private void btnGuiBaoHanh_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.GuiBaoHanh);
        }

        private void btnBaoCaoBaoHanh_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.BaoCaoBaoHanh);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.NhanVien);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.DoanhThu);
        }

        private void btnLoiNhuan_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.LoiNhuan);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.NhapHang);
        }

        private void tabControlMain_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {       
        }

        private void BatTabTimSoSerial()
        {
            string strTenTabpage = "Hàng Hoá";
            ucHangHoa _ucHangHoa = new ucHangHoa();
            if (!tabControlMain.Contains(tabPageHangHoa))
            {
                tabPageHangHoa = new TabPage(strTenTabpage);
                tabPageHangHoa.Controls.Add(_ucHangHoa);
                _ucHangHoa.Dock = DockStyle.Fill;


                tabControlMain.TabPages.Add(tabPageHangHoa);
                tabControlMain.SelectedTab = tabPageHangHoa;
            }
            else
            {
                tabPageHangHoa.Controls.Clear();
                tabPageHangHoa.Controls.Add(_ucHangHoa);
                _ucHangHoa.Dock = DockStyle.Fill;


                tabControlMain.SelectedTab = tabPageHangHoa;
            }
            _ucHangHoa.BatUCSerial();
        }
    }
}
