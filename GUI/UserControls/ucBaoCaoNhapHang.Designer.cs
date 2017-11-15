namespace GUI
{
    partial class ucBaoCaoNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.chkMaNCC = new System.Windows.Forms.CheckBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.chkNV = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpDau = new System.Windows.Forms.DateTimePicker();
            this.chkNgay = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTraTienNo = new System.Windows.Forms.Button();
            this.llblTim = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTPhieuNhap
            // 
            this.dgvCTPhieuNhap.AllowUserToAddRows = false;
            this.dgvCTPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvCTPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSanPham,
            this.colSoLuong,
            this.colGia,
            this.colThanhTien});
            this.dgvCTPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPhieuNhap.Location = new System.Drawing.Point(3, 22);
            this.dgvCTPhieuNhap.MultiSelect = false;
            this.dgvCTPhieuNhap.Name = "dgvCTPhieuNhap";
            this.dgvCTPhieuNhap.ReadOnly = true;
            this.dgvCTPhieuNhap.RowHeadersVisible = false;
            this.dgvCTPhieuNhap.RowTemplate.ReadOnly = true;
            this.dgvCTPhieuNhap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPhieuNhap.Size = new System.Drawing.Size(354, 551);
            this.dgvCTPhieuNhap.TabIndex = 0;
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
            dataGridViewCellStyle9.Format = "#,### VNĐ";
            this.colGia.DefaultCellStyle = dataGridViewCellStyle9;
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 58;
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle10.Format = "#,### VNĐ";
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle10;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 108;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvCTPhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(594, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dgvPhieuNhap);
            this.groupBox2.Location = new System.Drawing.Point(3, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 409);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colNgayLap,
            this.colNhanVien,
            this.colKhachHang,
            this.colNo,
            this.colTongTien});
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(3, 22);
            this.dgvPhieuNhap.MultiSelect = false;
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersVisible = false;
            this.dgvPhieuNhap.RowTemplate.ReadOnly = true;
            this.dgvPhieuNhap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(582, 384);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            this.dgvPhieuNhap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieuNhap_CellFormatting);
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.DataPropertyName = "MaPhieuNhap";
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
            this.colKhachHang.DataPropertyName = "TenNhaCungCap";
            this.colKhachHang.HeaderText = "Nhà Cung Cấp";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.ReadOnly = true;
            // 
            // colNo
            // 
            this.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNo.DataPropertyName = "TienNo";
            dataGridViewCellStyle11.Format = "#,##0 VNĐ";
            this.colNo.DefaultCellStyle = dataGridViewCellStyle11;
            this.colNo.HeaderText = "Nợ";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 55;
            // 
            // colTongTien
            // 
            this.colTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle12.Format = "#,### VNĐ";
            this.colTongTien.DefaultCellStyle = dataGridViewCellStyle12;
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            this.colTongTien.Width = 93;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(6, 118);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(408, 33);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(157, 86);
            this.txtMaNCC.MaxLength = 10;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(168, 26);
            this.txtMaNCC.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.llblTim);
            this.groupBox3.Controls.Add(this.chkNo);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtMaNCC);
            this.groupBox3.Controls.Add(this.chkMaNCC);
            this.groupBox3.Controls.Add(this.cboNV);
            this.groupBox3.Controls.Add(this.chkNV);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpCuoi);
            this.groupBox3.Controls.Add(this.dtpDau);
            this.groupBox3.Controls.Add(this.chkNgay);
            this.groupBox3.Location = new System.Drawing.Point(3, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(335, 88);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(79, 22);
            this.chkNo.TabIndex = 10;
            this.chkNo.Text = "Còn nợ";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // chkMaNCC
            // 
            this.chkMaNCC.AutoSize = true;
            this.chkMaNCC.Location = new System.Drawing.Point(6, 88);
            this.chkMaNCC.Name = "chkMaNCC";
            this.chkMaNCC.Size = new System.Drawing.Size(145, 22);
            this.chkMaNCC.TabIndex = 6;
            this.chkMaNCC.Text = "Mã nhà cung cấp";
            this.chkMaNCC.UseVisualStyleBackColor = true;
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(111, 54);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(303, 26);
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
            this.label1.Location = new System.Drawing.Point(238, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // dtpCuoi
            // 
            this.dtpCuoi.Location = new System.Drawing.Point(257, 22);
            this.dtpCuoi.Name = "dtpCuoi";
            this.dtpCuoi.Size = new System.Drawing.Size(157, 26);
            this.dtpCuoi.TabIndex = 2;
            // 
            // dtpDau
            // 
            this.dtpDau.Location = new System.Drawing.Point(75, 22);
            this.dtpDau.Name = "dtpDau";
            this.dtpDau.Size = new System.Drawing.Size(157, 26);
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
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(6, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 33);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnTraTienNo);
            this.groupBox4.Location = new System.Drawing.Point(431, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 161);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnTraTienNo
            // 
            this.btnTraTienNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraTienNo.Location = new System.Drawing.Point(6, 21);
            this.btnTraTienNo.Name = "btnTraTienNo";
            this.btnTraTienNo.Size = new System.Drawing.Size(148, 33);
            this.btnTraTienNo.TabIndex = 0;
            this.btnTraTienNo.Text = "Trả Tiền Nợ";
            this.btnTraTienNo.UseVisualStyleBackColor = true;
            this.btnTraTienNo.Click += new System.EventHandler(this.btnTraTienNo_Click);
            // 
            // llblTim
            // 
            this.llblTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblTim.AutoSize = true;
            this.llblTim.Location = new System.Drawing.Point(288, 89);
            this.llblTim.Name = "llblTim";
            this.llblTim.Size = new System.Drawing.Size(33, 18);
            this.llblTim.TabIndex = 11;
            this.llblTim.TabStop = true;
            this.llblTim.Text = "Tìm";
            this.llblTim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTim_LinkClicked);
            // 
            // ucBaoCaoNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBaoCaoNhapHang";
            this.Size = new System.Drawing.Size(957, 586);
            this.Load += new System.EventHandler(this.ucBaoCaoNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCTPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkMaNCC;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.CheckBox chkNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCuoi;
        private System.Windows.Forms.DateTimePicker dtpDau;
        private System.Windows.Forms.CheckBox chkNgay;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTraTienNo;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.LinkLabel llblTim;
    }
}
