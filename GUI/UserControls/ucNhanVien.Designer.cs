namespace GUI
{
    partial class ucNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbChucVu = new System.Windows.Forms.CheckBox();
            this.cbTenNV = new System.Windows.Forms.CheckBox();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbChucVu);
            this.groupBox1.Controls.Add(this.cbTenNV);
            this.groupBox1.Controls.Add(this.cbbChucVu);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(6, 85);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(288, 31);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbChucVu
            // 
            this.cbChucVu.AutoSize = true;
            this.cbChucVu.Location = new System.Drawing.Point(6, 57);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(85, 22);
            this.cbChucVu.TabIndex = 5;
            this.cbChucVu.Text = "Chức vụ";
            this.cbChucVu.UseVisualStyleBackColor = true;
            // 
            // cbTenNV
            // 
            this.cbTenNV.AutoSize = true;
            this.cbTenNV.Location = new System.Drawing.Point(6, 25);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(79, 22);
            this.cbTenNV.TabIndex = 4;
            this.cbTenNV.Text = "Tên NV";
            this.cbTenNV.UseVisualStyleBackColor = true;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(91, 55);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(203, 26);
            this.cbbChucVu.TabIndex = 3;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(91, 22);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(203, 26);
            this.txtTenNV.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenNhanVien,
            this.colMaNhanVien,
            this.colTenDangNhap,
            this.colMatKhau,
            this.colDiaChi,
            this.colCMND,
            this.colSoDT,
            this.colEmail,
            this.colQuyen});
            this.dgvNhanVien.Location = new System.Drawing.Point(309, 3);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(559, 518);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhanVien_CellFormatting);
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(3, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 383);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(6, 99);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(284, 31);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 62);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(284, 31);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(284, 31);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTenNhanVien.DataPropertyName = "TenNhanVien";
            this.colTenNhanVien.HeaderText = "Tên Nhân Viên";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.ReadOnly = true;
            this.colTenNhanVien.Width = 123;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.DataPropertyName = "MaNhanVien";
            this.colMaNhanVien.HeaderText = "MANV";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.ReadOnly = true;
            this.colMaNhanVien.Visible = false;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTenDangNhap.DataPropertyName = "TenDangNhap";
            this.colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.ReadOnly = true;
            this.colTenDangNhap.Width = 130;
            // 
            // colMatKhau
            // 
            this.colMatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.ReadOnly = true;
            this.colMatKhau.Width = 88;
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            // 
            // colCMND
            // 
            this.colCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCMND.DataPropertyName = "CMND";
            this.colCMND.HeaderText = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.ReadOnly = true;
            this.colCMND.Width = 81;
            // 
            // colSoDT
            // 
            this.colSoDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoDT.DataPropertyName = "SoDT";
            this.colSoDT.HeaderText = "Số ĐT";
            this.colSoDT.Name = "colSoDT";
            this.colSoDT.ReadOnly = true;
            this.colSoDT.Width = 72;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 73;
            // 
            // colQuyen
            // 
            this.colQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colQuyen.DataPropertyName = "Quyen";
            this.colQuyen.HeaderText = "Chức Vụ";
            this.colQuyen.Name = "colQuyen";
            this.colQuyen.ReadOnly = true;
            this.colQuyen.Width = 87;
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(871, 524);
            this.Load += new System.EventHandler(this.ucNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox cbChucVu;
        private System.Windows.Forms.CheckBox cbTenNV;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuyen;
    }
}
