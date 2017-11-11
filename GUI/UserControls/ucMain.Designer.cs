namespace GUI
{
    partial class ucMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageBanHang = new System.Windows.Forms.TabPage();
            this.btnBaoCaoBanHang = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.tabPageNhapHang = new System.Windows.Forms.TabPage();
            this.btnBaoCaoNhapHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.tabPageHangHoa = new System.Windows.Forms.TabPage();
            this.btnTonKho = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.tabPageBaoHanh = new System.Windows.Forms.TabPage();
            this.btnBaoCaoBaoHanh = new System.Windows.Forms.Button();
            this.btnGuiBaoHanh = new System.Windows.Forms.Button();
            this.btnNhanBaoHanh = new System.Windows.Forms.Button();
            this.tabPageNhanVien = new System.Windows.Forms.TabPage();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.tabPageThongKe = new System.Windows.Forms.TabPage();
            this.btnLoiNhuan = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.panInfo = new System.Windows.Forms.Panel();
            this.btnAnHien = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.picHinhDaiDien = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.panMain = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabPageBanHang.SuspendLayout();
            this.tabPageNhapHang.SuspendLayout();
            this.tabPageHangHoa.SuspendLayout();
            this.tabPageBaoHanh.SuspendLayout();
            this.tabPageNhanVien.SuspendLayout();
            this.tabPageThongKe.SuspendLayout();
            this.panInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhDaiDien)).BeginInit();
            this.panMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(998, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 21);
            this.toolStripStatusLabel1.Text = "ver. 0.1";
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageBanHang);
            this.tabControlMenu.Controls.Add(this.tabPageNhapHang);
            this.tabControlMenu.Controls.Add(this.tabPageHangHoa);
            this.tabControlMenu.Controls.Add(this.tabPageBaoHanh);
            this.tabControlMenu.Controls.Add(this.tabPageNhanVien);
            this.tabControlMenu.Controls.Add(this.tabPageThongKe);
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(998, 130);
            this.tabControlMenu.TabIndex = 4;
            this.tabControlMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControlMenu_MouseDoubleClick);
            // 
            // tabPageBanHang
            // 
            this.tabPageBanHang.Controls.Add(this.btnBaoCaoBanHang);
            this.tabPageBanHang.Controls.Add(this.btnKhachHang);
            this.tabPageBanHang.Controls.Add(this.btnBanHang);
            this.tabPageBanHang.Location = new System.Drawing.Point(4, 27);
            this.tabPageBanHang.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageBanHang.Name = "tabPageBanHang";
            this.tabPageBanHang.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageBanHang.Size = new System.Drawing.Size(990, 99);
            this.tabPageBanHang.TabIndex = 0;
            this.tabPageBanHang.Text = "Bán Hàng";
            this.tabPageBanHang.UseVisualStyleBackColor = true;
            // 
            // btnBaoCaoBanHang
            // 
            this.btnBaoCaoBanHang.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoBanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoBanHang.Image = global::GUI.Properties.Resources.BaoCao;
            this.btnBaoCaoBanHang.Location = new System.Drawing.Point(207, 7);
            this.btnBaoCaoBanHang.Name = "btnBaoCaoBanHang";
            this.btnBaoCaoBanHang.Size = new System.Drawing.Size(80, 85);
            this.btnBaoCaoBanHang.TabIndex = 2;
            this.btnBaoCaoBanHang.Text = "Báo Cáo";
            this.btnBaoCaoBanHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaoCaoBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCaoBanHang.UseVisualStyleBackColor = true;
            this.btnBaoCaoBanHang.Click += new System.EventHandler(this.btnBaoCaoBanHang_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Image = global::GUI.Properties.Resources.KhachHang;
            this.btnKhachHang.Location = new System.Drawing.Point(98, 7);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(103, 85);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Image = global::GUI.Properties.Resources.BanHang;
            this.btnBanHang.Location = new System.Drawing.Point(7, 7);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(85, 85);
            this.btnBanHang.TabIndex = 0;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // tabPageNhapHang
            // 
            this.tabPageNhapHang.Controls.Add(this.btnBaoCaoNhapHang);
            this.tabPageNhapHang.Controls.Add(this.btnNhaCungCap);
            this.tabPageNhapHang.Controls.Add(this.btnNhapHang);
            this.tabPageNhapHang.Location = new System.Drawing.Point(4, 27);
            this.tabPageNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageNhapHang.Name = "tabPageNhapHang";
            this.tabPageNhapHang.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageNhapHang.Size = new System.Drawing.Size(990, 99);
            this.tabPageNhapHang.TabIndex = 1;
            this.tabPageNhapHang.Text = "Nhập Hàng";
            this.tabPageNhapHang.UseVisualStyleBackColor = true;
            // 
            // btnBaoCaoNhapHang
            // 
            this.btnBaoCaoNhapHang.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoNhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoNhapHang.Image = global::GUI.Properties.Resources.BaoCao;
            this.btnBaoCaoNhapHang.Location = new System.Drawing.Point(234, 7);
            this.btnBaoCaoNhapHang.Name = "btnBaoCaoNhapHang";
            this.btnBaoCaoNhapHang.Size = new System.Drawing.Size(82, 85);
            this.btnBaoCaoNhapHang.TabIndex = 3;
            this.btnBaoCaoNhapHang.Text = "Báo Cáo";
            this.btnBaoCaoNhapHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaoCaoNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCaoNhapHang.UseVisualStyleBackColor = true;
            this.btnBaoCaoNhapHang.Click += new System.EventHandler(this.btnBaoCaoNhapHang_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnNhaCungCap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Image = global::GUI.Properties.Resources.NhaCungCap;
            this.btnNhaCungCap.Location = new System.Drawing.Point(107, 7);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(121, 85);
            this.btnNhaCungCap.TabIndex = 2;
            this.btnNhaCungCap.Text = "Nhà Cung Cấp";
            this.btnNhaCungCap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhaCungCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Image = global::GUI.Properties.Resources.NhapHang;
            this.btnNhapHang.Location = new System.Drawing.Point(7, 7);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(94, 85);
            this.btnNhapHang.TabIndex = 1;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // tabPageHangHoa
            // 
            this.tabPageHangHoa.Controls.Add(this.btnTonKho);
            this.tabPageHangHoa.Controls.Add(this.btnHangHoa);
            this.tabPageHangHoa.Location = new System.Drawing.Point(4, 27);
            this.tabPageHangHoa.Name = "tabPageHangHoa";
            this.tabPageHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHangHoa.Size = new System.Drawing.Size(990, 99);
            this.tabPageHangHoa.TabIndex = 2;
            this.tabPageHangHoa.Text = "Hàng Hoá";
            this.tabPageHangHoa.UseVisualStyleBackColor = true;
            // 
            // btnTonKho
            // 
            this.btnTonKho.FlatAppearance.BorderSize = 0;
            this.btnTonKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonKho.Image = global::GUI.Properties.Resources.TonKho;
            this.btnTonKho.Location = new System.Drawing.Point(99, 6);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Size = new System.Drawing.Size(75, 85);
            this.btnTonKho.TabIndex = 6;
            this.btnTonKho.Text = "Tồn Kho";
            this.btnTonKho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTonKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTonKho.UseVisualStyleBackColor = true;
            this.btnTonKho.Click += new System.EventHandler(this.btnTonKho_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Image = global::GUI.Properties.Resources.HangHoa;
            this.btnHangHoa.Location = new System.Drawing.Point(6, 6);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(87, 85);
            this.btnHangHoa.TabIndex = 5;
            this.btnHangHoa.Text = "Hàng Hoá";
            this.btnHangHoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // tabPageBaoHanh
            // 
            this.tabPageBaoHanh.Controls.Add(this.btnBaoCaoBaoHanh);
            this.tabPageBaoHanh.Controls.Add(this.btnGuiBaoHanh);
            this.tabPageBaoHanh.Controls.Add(this.btnNhanBaoHanh);
            this.tabPageBaoHanh.Location = new System.Drawing.Point(4, 27);
            this.tabPageBaoHanh.Name = "tabPageBaoHanh";
            this.tabPageBaoHanh.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBaoHanh.Size = new System.Drawing.Size(990, 99);
            this.tabPageBaoHanh.TabIndex = 3;
            this.tabPageBaoHanh.Text = "Bảo Hành";
            this.tabPageBaoHanh.UseVisualStyleBackColor = true;
            // 
            // btnBaoCaoBaoHanh
            // 
            this.btnBaoCaoBaoHanh.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoBaoHanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBaoCaoBaoHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoBaoHanh.Image = global::GUI.Properties.Resources.BaoCao;
            this.btnBaoCaoBaoHanh.Location = new System.Drawing.Point(260, 8);
            this.btnBaoCaoBaoHanh.Name = "btnBaoCaoBaoHanh";
            this.btnBaoCaoBaoHanh.Size = new System.Drawing.Size(82, 85);
            this.btnBaoCaoBaoHanh.TabIndex = 9;
            this.btnBaoCaoBaoHanh.Text = "Báo Cáo";
            this.btnBaoCaoBaoHanh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaoCaoBaoHanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBaoCaoBaoHanh.UseVisualStyleBackColor = true;
            this.btnBaoCaoBaoHanh.Click += new System.EventHandler(this.btnBaoCaoBaoHanh_Click);
            // 
            // btnGuiBaoHanh
            // 
            this.btnGuiBaoHanh.FlatAppearance.BorderSize = 0;
            this.btnGuiBaoHanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnGuiBaoHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiBaoHanh.Image = global::GUI.Properties.Resources.GuiBaoHanh;
            this.btnGuiBaoHanh.Location = new System.Drawing.Point(137, 8);
            this.btnGuiBaoHanh.Name = "btnGuiBaoHanh";
            this.btnGuiBaoHanh.Size = new System.Drawing.Size(117, 85);
            this.btnGuiBaoHanh.TabIndex = 8;
            this.btnGuiBaoHanh.Text = "Gửi Bảo Hành";
            this.btnGuiBaoHanh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuiBaoHanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuiBaoHanh.UseVisualStyleBackColor = true;
            this.btnGuiBaoHanh.Click += new System.EventHandler(this.btnGuiBaoHanh_Click);
            // 
            // btnNhanBaoHanh
            // 
            this.btnNhanBaoHanh.FlatAppearance.BorderSize = 0;
            this.btnNhanBaoHanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNhanBaoHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanBaoHanh.Image = global::GUI.Properties.Resources.NhanBaoHanh;
            this.btnNhanBaoHanh.Location = new System.Drawing.Point(6, 8);
            this.btnNhanBaoHanh.Name = "btnNhanBaoHanh";
            this.btnNhanBaoHanh.Size = new System.Drawing.Size(125, 85);
            this.btnNhanBaoHanh.TabIndex = 7;
            this.btnNhanBaoHanh.Text = "Nhận Bảo Hành";
            this.btnNhanBaoHanh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhanBaoHanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhanBaoHanh.UseVisualStyleBackColor = true;
            this.btnNhanBaoHanh.Click += new System.EventHandler(this.btnNhanBaoHanh_Click);
            // 
            // tabPageNhanVien
            // 
            this.tabPageNhanVien.Controls.Add(this.btnNhanVien);
            this.tabPageNhanVien.Location = new System.Drawing.Point(4, 27);
            this.tabPageNhanVien.Name = "tabPageNhanVien";
            this.tabPageNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNhanVien.Size = new System.Drawing.Size(990, 99);
            this.tabPageNhanVien.TabIndex = 5;
            this.tabPageNhanVien.Text = "Nhân Viên";
            this.tabPageNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Image = global::GUI.Properties.Resources.NhanVien;
            this.btnNhanVien.Location = new System.Drawing.Point(6, 6);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(88, 85);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // tabPageThongKe
            // 
            this.tabPageThongKe.Controls.Add(this.btnLoiNhuan);
            this.tabPageThongKe.Controls.Add(this.btnDoanhThu);
            this.tabPageThongKe.Location = new System.Drawing.Point(4, 27);
            this.tabPageThongKe.Name = "tabPageThongKe";
            this.tabPageThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongKe.Size = new System.Drawing.Size(990, 99);
            this.tabPageThongKe.TabIndex = 6;
            this.tabPageThongKe.Text = "Thống Kê";
            this.tabPageThongKe.UseVisualStyleBackColor = true;
            // 
            // btnLoiNhuan
            // 
            this.btnLoiNhuan.FlatAppearance.BorderSize = 0;
            this.btnLoiNhuan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnLoiNhuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoiNhuan.Image = global::GUI.Properties.Resources.LoiNhuan;
            this.btnLoiNhuan.Location = new System.Drawing.Point(107, 8);
            this.btnLoiNhuan.Name = "btnLoiNhuan";
            this.btnLoiNhuan.Size = new System.Drawing.Size(88, 85);
            this.btnLoiNhuan.TabIndex = 7;
            this.btnLoiNhuan.Text = "Lợi Nhuận";
            this.btnLoiNhuan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoiNhuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLoiNhuan.UseVisualStyleBackColor = true;
            this.btnLoiNhuan.Click += new System.EventHandler(this.btnLoiNhuan_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Image = global::GUI.Properties.Resources.DoanhThu;
            this.btnDoanhThu.Location = new System.Drawing.Point(6, 8);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(95, 85);
            this.btnDoanhThu.TabIndex = 5;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // panInfo
            // 
            this.panInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panInfo.Controls.Add(this.btnAnHien);
            this.panInfo.Controls.Add(this.btnDangXuat);
            this.panInfo.Controls.Add(this.lblQuyen);
            this.panInfo.Controls.Add(this.lblTenNV);
            this.panInfo.Controls.Add(this.picHinhDaiDien);
            this.panInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panInfo.Location = new System.Drawing.Point(0, 130);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(196, 441);
            this.panInfo.TabIndex = 5;
            // 
            // btnAnHien
            // 
            this.btnAnHien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnHien.Location = new System.Drawing.Point(-2, -1);
            this.btnAnHien.Name = "btnAnHien";
            this.btnAnHien.Size = new System.Drawing.Size(197, 36);
            this.btnAnHien.TabIndex = 4;
            this.btnAnHien.Text = "<";
            this.btnAnHien.UseVisualStyleBackColor = false;
            this.btnAnHien.Click += new System.EventHandler(this.btnAnHien_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::GUI.Properties.Resources.DangXuat;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(14, 385);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(165, 41);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblQuyen
            // 
            this.lblQuyen.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblQuyen.ForeColor = System.Drawing.Color.White;
            this.lblQuyen.Location = new System.Drawing.Point(14, 249);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(165, 23);
            this.lblQuyen.TabIndex = 2;
            this.lblQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenNV
            // 
            this.lblTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTenNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(-2, 34);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(197, 35);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picHinhDaiDien
            // 
            this.picHinhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhDaiDien.Location = new System.Drawing.Point(14, 83);
            this.picHinhDaiDien.Name = "picHinhDaiDien";
            this.picHinhDaiDien.Size = new System.Drawing.Size(165, 165);
            this.picHinhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhDaiDien.TabIndex = 0;
            this.picHinhDaiDien.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(802, 441);
            this.tabControlMain.TabIndex = 6;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMain_DrawItem);
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            this.tabControlMain.TabIndexChanged += new System.EventHandler(this.tabControlMain_TabIndexChanged);
            this.tabControlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControlMain_MouseClick);
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.tabControlMain);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(196, 130);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(802, 441);
            this.panMain.TabIndex = 7;
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.tabControlMenu);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(998, 597);
            this.Load += new System.EventHandler(this.ucMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageBanHang.ResumeLayout(false);
            this.tabPageNhapHang.ResumeLayout(false);
            this.tabPageHangHoa.ResumeLayout(false);
            this.tabPageBaoHanh.ResumeLayout(false);
            this.tabPageNhanVien.ResumeLayout(false);
            this.tabPageThongKe.ResumeLayout(false);
            this.panInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhDaiDien)).EndInit();
            this.panMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageBanHang;
        private System.Windows.Forms.TabPage tabPageNhapHang;
        private System.Windows.Forms.TabPage tabPageHangHoa;
        private System.Windows.Forms.TabPage tabPageBaoHanh;
        private System.Windows.Forms.TabPage tabPageNhanVien;
        private System.Windows.Forms.TabPage tabPageThongKe;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.PictureBox picHinhDaiDien;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnBaoCaoBanHang;
        private System.Windows.Forms.Button btnBaoCaoNhapHang;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnTonKho;
        private System.Windows.Forms.Button btnNhanBaoHanh;
        private System.Windows.Forms.Button btnGuiBaoHanh;
        private System.Windows.Forms.Button btnBaoCaoBaoHanh;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnLoiNhuan;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnAnHien;
    }
}
