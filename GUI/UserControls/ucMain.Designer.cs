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
            this.tabPageNhapHang = new System.Windows.Forms.TabPage();
            this.tabPageHangHoa = new System.Windows.Forms.TabPage();
            this.tabPageBaoHanh = new System.Windows.Forms.TabPage();
            this.tabPageThuChi = new System.Windows.Forms.TabPage();
            this.tabPageNhanVien = new System.Windows.Forms.TabPage();
            this.tabPageThongKe = new System.Windows.Forms.TabPage();
            this.panInfo = new System.Windows.Forms.Panel();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.picHinhDaiDien = new System.Windows.Forms.PictureBox();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabPageBanHang.SuspendLayout();
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
            this.tabControlMenu.Controls.Add(this.tabPageThuChi);
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
            // tabPageNhapHang
            // 
            this.tabPageNhapHang.Location = new System.Drawing.Point(4, 27);
            this.tabPageNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageNhapHang.Name = "tabPageNhapHang";
            this.tabPageNhapHang.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageNhapHang.Size = new System.Drawing.Size(990, 99);
            this.tabPageNhapHang.TabIndex = 1;
            this.tabPageNhapHang.Text = "Nhập Hàng";
            this.tabPageNhapHang.UseVisualStyleBackColor = true;
            // 
            // tabPageHangHoa
            // 
            this.tabPageHangHoa.Location = new System.Drawing.Point(4, 27);
            this.tabPageHangHoa.Name = "tabPageHangHoa";
            this.tabPageHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHangHoa.Size = new System.Drawing.Size(990, 99);
            this.tabPageHangHoa.TabIndex = 2;
            this.tabPageHangHoa.Text = "Hàng Hoá";
            this.tabPageHangHoa.UseVisualStyleBackColor = true;
            // 
            // tabPageBaoHanh
            // 
            this.tabPageBaoHanh.Location = new System.Drawing.Point(4, 27);
            this.tabPageBaoHanh.Name = "tabPageBaoHanh";
            this.tabPageBaoHanh.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBaoHanh.Size = new System.Drawing.Size(990, 99);
            this.tabPageBaoHanh.TabIndex = 3;
            this.tabPageBaoHanh.Text = "Bảo Hành";
            this.tabPageBaoHanh.UseVisualStyleBackColor = true;
            // 
            // tabPageThuChi
            // 
            this.tabPageThuChi.Location = new System.Drawing.Point(4, 27);
            this.tabPageThuChi.Name = "tabPageThuChi";
            this.tabPageThuChi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThuChi.Size = new System.Drawing.Size(990, 99);
            this.tabPageThuChi.TabIndex = 4;
            this.tabPageThuChi.Text = "Thu - Chi";
            this.tabPageThuChi.UseVisualStyleBackColor = true;
            // 
            // tabPageNhanVien
            // 
            this.tabPageNhanVien.Location = new System.Drawing.Point(4, 27);
            this.tabPageNhanVien.Name = "tabPageNhanVien";
            this.tabPageNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNhanVien.Size = new System.Drawing.Size(990, 99);
            this.tabPageNhanVien.TabIndex = 5;
            this.tabPageNhanVien.Text = "Nhân Viên";
            this.tabPageNhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPageThongKe
            // 
            this.tabPageThongKe.Location = new System.Drawing.Point(4, 27);
            this.tabPageThongKe.Name = "tabPageThongKe";
            this.tabPageThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongKe.Size = new System.Drawing.Size(990, 99);
            this.tabPageThongKe.TabIndex = 6;
            this.tabPageThongKe.Text = "Thống Kê";
            this.tabPageThongKe.UseVisualStyleBackColor = true;
            // 
            // panInfo
            // 
            this.panInfo.BackColor = System.Drawing.Color.White;
            this.panInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // lblQuyen
            // 
            this.lblQuyen.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblQuyen.ForeColor = System.Drawing.Color.White;
            this.lblQuyen.Location = new System.Drawing.Point(14, 214);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(165, 23);
            this.lblQuyen.TabIndex = 2;
            this.lblQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenNV
            // 
            this.lblTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTenNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(-1, -1);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(196, 35);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(802, 441);
            this.tabControlMain.TabIndex = 6;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlMain_DrawItem);
            this.tabControlMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControlMain_MouseClick);
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
            // picHinhDaiDien
            // 
            this.picHinhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhDaiDien.Location = new System.Drawing.Point(14, 48);
            this.picHinhDaiDien.Name = "picHinhDaiDien";
            this.picHinhDaiDien.Size = new System.Drawing.Size(165, 165);
            this.picHinhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhDaiDien.TabIndex = 0;
            this.picHinhDaiDien.TabStop = false;
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
            this.btnBanHang.Image = global::GUI.Properties.Resources.cart;
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
        private System.Windows.Forms.TabPage tabPageThuChi;
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
    }
}
