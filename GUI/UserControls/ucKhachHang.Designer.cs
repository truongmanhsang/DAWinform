namespace GUI
{
    partial class ucKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbSDT = new System.Windows.Forms.CheckBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.cbCMND = new System.Windows.Forms.CheckBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cbTenKH = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuaKhachHang = new System.Windows.Forms.Button();
            this.btnXoaKhachHang = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenKhachHang,
            this.colMaKhachHang,
            this.colCMND,
            this.colSoDT,
            this.colDiaChi});
            this.dgvKhachHang.Location = new System.Drawing.Point(360, 4);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowTemplate.ReadOnly = true;
            this.dgvKhachHang.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(667, 514);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKhachHang.DataPropertyName = "TenKhachHang";
            this.colTenKhachHang.HeaderText = "Tên Khách Hàng";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.ReadOnly = true;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.DataPropertyName = "MaKhachHang";
            this.colMaKhachHang.HeaderText = "MaKhachHang";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.ReadOnly = true;
            this.colMaKhachHang.Visible = false;
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
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa Chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
            this.colDiaChi.Width = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.cbSDT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.cbCMND);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.cbTenKH);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(349, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm khách hàng";
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
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCMND.Location = new System.Drawing.Point(149, 68);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(193, 26);
            this.txtCMND.TabIndex = 3;
            // 
            // cbCMND
            // 
            this.cbCMND.AutoSize = true;
            this.cbCMND.Location = new System.Drawing.Point(7, 71);
            this.cbCMND.Name = "cbCMND";
            this.cbCMND.Size = new System.Drawing.Size(75, 22);
            this.cbCMND.TabIndex = 2;
            this.cbCMND.Text = "CMND";
            this.cbCMND.UseVisualStyleBackColor = true;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKH.Location = new System.Drawing.Point(149, 34);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(193, 26);
            this.txtTenKH.TabIndex = 1;
            // 
            // cbTenKH
            // 
            this.cbTenKH.AutoSize = true;
            this.cbTenKH.Location = new System.Drawing.Point(7, 36);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(109, 22);
            this.cbTenKH.TabIndex = 0;
            this.cbTenKH.Text = "Khách hàng";
            this.cbTenKH.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnSuaKhachHang);
            this.groupBox2.Controls.Add(this.btnXoaKhachHang);
            this.groupBox2.Controls.Add(this.btnThemKhachHang);
            this.groupBox2.Location = new System.Drawing.Point(4, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 321);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin / Chức năng";
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaKhachHang.Location = new System.Drawing.Point(244, 38);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(98, 34);
            this.btnSuaKhachHang.TabIndex = 2;
            this.btnSuaKhachHang.Text = "Sửa";
            this.btnSuaKhachHang.UseVisualStyleBackColor = true;
            this.btnSuaKhachHang.Click += new System.EventHandler(this.btnSuaKhachHang_Click);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKhachHang.Location = new System.Drawing.Point(126, 38);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(98, 34);
            this.btnXoaKhachHang.TabIndex = 1;
            this.btnXoaKhachHang.Text = "Xoá";
            this.btnXoaKhachHang.UseVisualStyleBackColor = true;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKhachHang.Location = new System.Drawing.Point(8, 38);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(98, 34);
            this.btnThemKhachHang.TabIndex = 0;
            this.btnThemKhachHang.Text = "Thêm";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(1031, 522);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuaKhachHang;
        private System.Windows.Forms.Button btnXoaKhachHang;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox cbSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.CheckBox cbCMND;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.CheckBox cbTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}
