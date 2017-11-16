namespace GUI
{
    partial class ucKhoBaoHanh
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
            this.dgvSanPhamBH = new System.Windows.Forms.DataGridView();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMaNCC = new System.Windows.Forms.CheckBox();
            this.llblTim = new System.Windows.Forms.LinkLabel();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.chkLoai = new System.Windows.Forms.CheckBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.chkNgayGui = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDau = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuiTra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPhamBH
            // 
            this.dgvSanPhamBH.AllowUserToAddRows = false;
            this.dgvSanPhamBH.AllowUserToDeleteRows = false;
            this.dgvSanPhamBH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPhamBH.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPhamBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSanPham,
            this.colSoSerial,
            this.colMoTaLoi,
            this.colTinhTrang,
            this.colTenNhaCungCap});
            this.dgvSanPhamBH.Location = new System.Drawing.Point(314, 3);
            this.dgvSanPhamBH.MultiSelect = false;
            this.dgvSanPhamBH.Name = "dgvSanPhamBH";
            this.dgvSanPhamBH.ReadOnly = true;
            this.dgvSanPhamBH.RowHeadersVisible = false;
            this.dgvSanPhamBH.RowTemplate.ReadOnly = true;
            this.dgvSanPhamBH.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPhamBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPhamBH.Size = new System.Drawing.Size(478, 499);
            this.dgvSanPhamBH.TabIndex = 0;
            this.dgvSanPhamBH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSanPhamBH_CellFormatting);
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            // 
            // colSoSerial
            // 
            this.colSoSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoSerial.DataPropertyName = "SoSerial";
            this.colSoSerial.HeaderText = "Số Serial";
            this.colSoSerial.Name = "colSoSerial";
            this.colSoSerial.ReadOnly = true;
            this.colSoSerial.Width = 90;
            // 
            // colMoTaLoi
            // 
            this.colMoTaLoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMoTaLoi.DataPropertyName = "MoTaLoi";
            this.colMoTaLoi.HeaderText = "Mô Tả Lỗi";
            this.colMoTaLoi.Name = "colMoTaLoi";
            this.colMoTaLoi.ReadOnly = true;
            this.colMoTaLoi.Width = 95;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTinhTrang.DataPropertyName = "TinhTrang";
            this.colTinhTrang.HeaderText = "Tình Trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
            this.colTinhTrang.Width = 96;
            // 
            // colTenNhaCungCap
            // 
            this.colTenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            this.colTenNhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.colTenNhaCungCap.Name = "colTenNhaCungCap";
            this.colTenNhaCungCap.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMaNCC);
            this.groupBox1.Controls.Add(this.llblTim);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.chkLoai);
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.chkNgayGui);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpNgayCuoi);
            this.groupBox1.Controls.Add(this.dtpNgayDau);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // chkMaNCC
            // 
            this.chkMaNCC.AutoSize = true;
            this.chkMaNCC.Location = new System.Drawing.Point(6, 88);
            this.chkMaNCC.Name = "chkMaNCC";
            this.chkMaNCC.Size = new System.Drawing.Size(88, 22);
            this.chkMaNCC.TabIndex = 17;
            this.chkMaNCC.Text = "Mã NCC";
            this.chkMaNCC.UseVisualStyleBackColor = true;
            // 
            // llblTim
            // 
            this.llblTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblTim.AutoSize = true;
            this.llblTim.Location = new System.Drawing.Point(262, 90);
            this.llblTim.Name = "llblTim";
            this.llblTim.Size = new System.Drawing.Size(33, 18);
            this.llblTim.TabIndex = 16;
            this.llblTim.TabStop = true;
            this.llblTim.Text = "Tìm";
            this.llblTim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTim_LinkClicked);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(103, 86);
            this.txtMaNCC.MaxLength = 10;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(196, 26);
            this.txtMaNCC.TabIndex = 15;
            // 
            // chkLoai
            // 
            this.chkLoai.AutoSize = true;
            this.chkLoai.Location = new System.Drawing.Point(6, 56);
            this.chkLoai.Name = "chkLoai";
            this.chkLoai.Size = new System.Drawing.Size(58, 22);
            this.chkLoai.TabIndex = 7;
            this.chkLoai.Text = "Loại";
            this.chkLoai.UseVisualStyleBackColor = true;
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa bảo hành",
            "Hàng bị đổi",
            "Hàng trả"});
            this.cboLoai.Location = new System.Drawing.Point(103, 54);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(196, 26);
            this.cboLoai.TabIndex = 6;
            // 
            // chkNgayGui
            // 
            this.chkNgayGui.AutoSize = true;
            this.chkNgayGui.Location = new System.Drawing.Point(6, 24);
            this.chkNgayGui.Name = "chkNgayGui";
            this.chkNgayGui.Size = new System.Drawing.Size(91, 22);
            this.chkNgayGui.TabIndex = 5;
            this.chkNgayGui.Text = "Ngày gửi";
            this.chkNgayGui.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(6, 118);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(293, 35);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.Location = new System.Drawing.Point(219, 22);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(80, 26);
            this.dtpNgayCuoi.TabIndex = 2;
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.Location = new System.Drawing.Point(103, 22);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(80, 26);
            this.dtpNgayDau.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnGuiTra);
            this.groupBox2.Location = new System.Drawing.Point(3, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 331);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnGuiTra
            // 
            this.btnGuiTra.Location = new System.Drawing.Point(6, 25);
            this.btnGuiTra.Name = "btnGuiTra";
            this.btnGuiTra.Size = new System.Drawing.Size(293, 35);
            this.btnGuiTra.TabIndex = 8;
            this.btnGuiTra.Text = "Gửi trả nhà cung cấp";
            this.btnGuiTra.UseVisualStyleBackColor = true;
            // 
            // ucKhoBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSanPhamBH);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucKhoBaoHanh";
            this.Size = new System.Drawing.Size(795, 505);
            this.Load += new System.EventHandler(this.ucKhoBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamBH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPhamBH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLoai;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.CheckBox chkNgayGui;
        private System.Windows.Forms.Button btnGuiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaCungCap;
        private System.Windows.Forms.CheckBox chkMaNCC;
        private System.Windows.Forms.LinkLabel llblTim;
        private System.Windows.Forms.TextBox txtMaNCC;
    }
}
