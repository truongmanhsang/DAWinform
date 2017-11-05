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

        // khai báo image cho close button tabpage
        Image imgCloseButtonActive;
        Image imgCloseButton;

        // Enum Chức năng
        enum ChucNang
        {
            BanHang, KhachHang
        }

        // khai báo tất cả tabpage chức năng
        TabPage tabBanHang;
        TabPage tabKhachHang;

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
            if (cn == ChucNang.BanHang)
            {
                string strTenTabpage = "Bán Hàng";
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

            }
            if (cn == ChucNang.KhachHang)
            {
                string strTenTabpage = "Khách Hàng";
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

            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            TaoTabpage(ChucNang.KhachHang);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất chứ?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                xuLyDangXuat();
        }
    }
}
