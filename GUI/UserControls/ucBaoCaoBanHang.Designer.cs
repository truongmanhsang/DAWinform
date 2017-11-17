namespace GUI
{
    partial class ucBaoCaoBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTraTienNo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.llblTim = new System.Windows.Forms.LinkLabel();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.chkMaKH = new System.Windows.Forms.CheckBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.chkNV = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpDau = new System.Windows.Forms.DateTimePicker();
            this.chkNgay = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCTPhieuXuat = new System.Windows.Forms.DataGridView();
            this.colSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.AllowUserToAddRows = false;
            this.dgvPhieuXuat.AllowUserToDeleteRows = false;
            this.dgvPhieuXuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuXuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colNgayLap,
            this.colNhanVien,
            this.colKhachHang,
            this.colNo,
            this.colTongTien,
            this.colTinhTrang});
            this.dgvPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(3, 22);
            this.dgvPhieuXuat.MultiSelect = false;
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.ReadOnly = true;
            this.dgvPhieuXuat.RowHeadersVisible = false;
            this.dgvPhieuXuat.RowTemplate.ReadOnly = true;
            this.dgvPhieuXuat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(739, 265);
            this.dgvPhieuXuat.TabIndex = 0;
            this.dgvPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuat_CellClick);
            this.dgvPhieuXuat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieuXuat_CellFormatting);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.btnInHoaDon);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnTraTienNo);
            this.groupBox4.Location = new System.Drawing.Point(3, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 418);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(6, 99);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(334, 33);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTraTienNo
            // 
            this.btnTraTienNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraTienNo.Location = new System.Drawing.Point(6, 21);
            this.btnTraTienNo.Name = "btnTraTienNo";
            this.btnTraTienNo.Size = new System.Drawing.Size(334, 33);
            this.btnTraTienNo.TabIndex = 0;
            this.btnTraTienNo.Text = "Trả tiền";
            this.btnTraTienNo.UseVisualStyleBackColor = true;
            this.btnTraTienNo.Click += new System.EventHandler(this.btnTraTienNo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.llblTim);
            this.groupBox3.Controls.Add(this.chkNo);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtMaKH);
            this.groupBox3.Controls.Add(this.chkMaKH);
            this.groupBox3.Controls.Add(this.cboNV);
            this.groupBox3.Controls.Add(this.chkNV);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpCuoi);
            this.groupBox3.Controls.Add(this.dtpDau);
            this.groupBox3.Controls.Add(this.chkNgay);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // llblTim
            // 
            this.llblTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblTim.AutoSize = true;
            this.llblTim.Location = new System.Drawing.Point(216, 90);
            this.llblTim.Name = "llblTim";
            this.llblTim.Size = new System.Drawing.Size(33, 18);
            this.llblTim.TabIndex = 10;
            this.llblTim.TabStop = true;
            this.llblTim.Text = "Tìm";
            this.llblTim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTim_LinkClicked);
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(259, 88);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(79, 22);
            this.chkNo.TabIndex = 9;
            this.chkNo.Text = "Còn nợ";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(6, 118);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(332, 33);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(111, 86);
            this.txtMaKH.MaxLength = 10;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(142, 26);
            this.txtMaKH.TabIndex = 7;
            // 
            // chkMaKH
            // 
            this.chkMaKH.AutoSize = true;
            this.chkMaKH.Location = new System.Drawing.Point(6, 88);
            this.chkMaKH.Name = "chkMaKH";
            this.chkMaKH.Size = new System.Drawing.Size(75, 22);
            this.chkMaKH.TabIndex = 6;
            this.chkMaKH.Text = "Mã KH";
            this.chkMaKH.UseVisualStyleBackColor = true;
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(111, 54);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(227, 26);
            this.cboNV.TabIndex = 5;
            // 
            // chkNV
            // 
            this.chkNV.AutoSize = true;
            this.chkNV.Location = new System.Drawing.Point(6, 56);
            this.chkNV.Name = "chkNV";
            this.chkNV.Size = new System.Drawing.Size(95, 22);
            this.chkNV.TabIndex = 4;
            this.chkNV.Text = "Nhân viên";
            this.chkNV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // dtpCuoi
            // 
            this.dtpCuoi.CustomFormat = "dd/MM/yyyy";
            this.dtpCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCuoi.Location = new System.Drawing.Point(219, 22);
            this.dtpCuoi.Name = "dtpCuoi";
            this.dtpCuoi.Size = new System.Drawing.Size(119, 26);
            this.dtpCuoi.TabIndex = 2;
            // 
            // dtpDau
            // 
            this.dtpDau.CustomFormat = "dd/MM/yyyy";
            this.dtpDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDau.Location = new System.Drawing.Point(75, 22);
            this.dtpDau.Name = "dtpDau";
            this.dtpDau.Size = new System.Drawing.Size(119, 26);
            this.dtpDau.TabIndex = 1;
            // 
            // chkNgay
            // 
            this.chkNgay.AutoSize = true;
            this.chkNgay.Location = new System.Drawing.Point(6, 25);
            this.chkNgay.Name = "chkNgay";
            this.chkNgay.Size = new System.Drawing.Size(63, 22);
            this.chkNgay.TabIndex = 0;
            this.chkNgay.Text = "Ngày";
            this.chkNgay.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhieuXuat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 290);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCTPhieuXuat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu xuất";
            // 
            // dgvCTPhieuXuat
            // 
            this.dgvCTPhieuXuat.AllowUserToAddRows = false;
            this.dgvCTPhieuXuat.AllowUserToDeleteRows = false;
            this.dgvCTPhieuXuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTPhieuXuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSanPham,
            this.colSoLuong,
            this.colGia,
            this.colThanhTien});
            this.dgvCTPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPhieuXuat.Location = new System.Drawing.Point(3, 22);
            this.dgvCTPhieuXuat.MultiSelect = false;
            this.dgvCTPhieuXuat.Name = "dgvCTPhieuXuat";
            this.dgvCTPhieuXuat.ReadOnly = true;
            this.dgvCTPhieuXuat.RowHeadersVisible = false;
            this.dgvCTPhieuXuat.RowTemplate.ReadOnly = true;
            this.dgvCTPhieuXuat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPhieuXuat.Size = new System.Drawing.Size(739, 262);
            this.dgvCTPhieuXuat.TabIndex = 0;
            // 
            // colSanPham
            // 
            this.colSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSanPham.DataPropertyName = "TenSanPham";
            this.colSanPham.HeaderText = "Sản Phẩm";
            this.colSanPham.Name = "colSanPham";
            this.colSanPham.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 105;
            // 
            // colGia
            // 
            this.colGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGia.DataPropertyName = "Gia";
            dataGridViewCellStyle5.Format = "#,### VNĐ";
            this.colGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 58;
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Format = "#,### VNĐ";
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 108;
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.DataPropertyName = "MaPhieuXuat";
            this.colMaPhieu.HeaderText = "Mã Phiếu";
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.ReadOnly = true;
            // 
            // colNgayLap
            // 
            this.colNgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNgayLap.DataPropertyName = "NgayLap";
            this.colNgayLap.HeaderText = "Ngày";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            this.colNgayLap.Width = 69;
            // 
            // colNhanVien
            // 
            this.colNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNhanVien.DataPropertyName = "TenNhanVien";
            this.colNhanVien.HeaderText = "Nhân Viên";
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.ReadOnly = true;
            // 
            // colKhachHang
            // 
            this.colKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKhachHang.DataPropertyName = "TenKhachHang";
            this.colKhachHang.HeaderText = "Khách Hàng";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.ReadOnly = true;
            // 
            // colNo
            // 
            this.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNo.DataPropertyName = "TienNo";
            dataGridViewCellStyle7.Format = "#,##0 VNĐ";
            this.colNo.DefaultCellStyle = dataGridViewCellStyle7;
            this.colNo.HeaderText = "Nợ";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 55;
            // 
            // colTongTien
            // 
            this.colTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle8.Format = "#,### VNĐ";
            this.colTongTien.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            this.colTongTien.Width = 101;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.DataPropertyName = "TinhTrang";
            this.colTinhTrang.HeaderText = "Tình Trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(355, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(747, 585);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(6, 60);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(334, 33);
            this.btnInHoaDon.TabIndex = 2;
            this.btnInHoaDon.Text = "In hoá đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // ucBaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBaoCaoBanHang";
            this.Size = new System.Drawing.Size(1105, 594);
            this.Load += new System.EventHandler(this.ucBaoCaoBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuXuat)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCTPhieuXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTraTienNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.CheckBox chkMaKH;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.CheckBox chkNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCuoi;
        private System.Windows.Forms.DateTimePicker dtpDau;
        private System.Windows.Forms.CheckBox chkNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.LinkLabel llblTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}
