namespace GUI
{
    partial class ucNhaCungCap
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbSDT = new System.Windows.Forms.CheckBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.cbMaNCC = new System.Windows.Forms.CheckBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.cbTenNCC = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(149, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(193, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(149, 65);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(193, 34);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(149, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(193, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(149, 136);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(193, 34);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbSDT
            // 
            this.cbSDT.AutoSize = true;
            this.cbSDT.Location = new System.Drawing.Point(7, 106);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(72, 22);
            this.cbSDT.TabIndex = 5;
            this.cbSDT.Text = "Số ĐT";
            this.cbSDT.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Location = new System.Drawing.Point(149, 102);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(193, 26);
            this.txtSDT.TabIndex = 4;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNCC.Location = new System.Drawing.Point(149, 68);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(193, 26);
            this.txtMaNCC.TabIndex = 3;
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.AutoSize = true;
            this.cbMaNCC.Location = new System.Drawing.Point(7, 71);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(149, 22);
            this.cbMaNCC.TabIndex = 2;
            this.cbMaNCC.Text = "Mã  nhà cung cấp";
            this.cbMaNCC.UseVisualStyleBackColor = true;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNCC.Location = new System.Drawing.Point(149, 34);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(193, 26);
            this.txtTenNCC.TabIndex = 1;
            // 
            // cbTenNCC
            // 
            this.cbTenNCC.AutoSize = true;
            this.cbTenNCC.Location = new System.Drawing.Point(7, 36);
            this.cbTenNCC.Name = "cbTenNCC";
            this.cbTenNCC.Size = new System.Drawing.Size(122, 22);
            this.cbTenNCC.TabIndex = 0;
            this.cbTenNCC.Text = "Nhà cung cấp";
            this.cbTenNCC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbSDT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.cbMaNCC);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.cbTenNCC);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(349, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm khách hàng";
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AllowUserToAddRows = false;
            this.dgvNhaCungCap.AllowUserToDeleteRows = false;
            this.dgvNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colTenKhachHang,
            this.colSoDT,
            this.colDiaChi});
            this.dgvNhaCungCap.Location = new System.Drawing.Point(360, 3);
            this.dgvNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhaCungCap.MultiSelect = false;
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.ReadOnly = true;
            this.dgvNhaCungCap.RowHeadersVisible = false;
            this.dgvNhaCungCap.RowTemplate.ReadOnly = true;
            this.dgvNhaCungCap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(667, 593);
            this.dgvNhaCungCap.TabIndex = 2;
            this.dgvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellClick);
            // 
            // colMaNCC
            // 
            this.colMaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMaNCC.DataPropertyName = "MaNhaCungCap";
            this.colMaNCC.HeaderText = "Mã";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            this.colMaNCC.Width = 55;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKhachHang.DataPropertyName = "TenNhaCungCap";
            this.colTenKhachHang.HeaderText = "Tên Nhà Cung Cấp";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.ReadOnly = true;
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
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(4, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 400);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin / Chức năng";
            // 
            // ucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhaCungCap);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucNhaCungCap";
            this.Size = new System.Drawing.Size(1031, 601);
            this.Load += new System.EventHandler(this.ucNhaCungCap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox cbSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.CheckBox cbMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.CheckBox cbTenNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}
