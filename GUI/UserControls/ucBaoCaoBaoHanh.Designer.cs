﻿namespace GUI
{
    partial class ucBaoCaoBaoHanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDau = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvBaoHanh = new System.Windows.Forms.DataGridView();
            this.colMaBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietBaoHanh = new System.Windows.Forms.DataGridView();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHenTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTraHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNgay = new System.Windows.Forms.CheckBox();
            this.chkNV = new System.Windows.Forms.CheckBox();
            this.llblTim = new System.Windows.Forms.LinkLabel();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.chkMaKH = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBaoHanh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMaKH);
            this.groupBox1.Controls.Add(this.llblTim);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.chkNV);
            this.groupBox1.Controls.Add(this.chkNgay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboNV);
            this.groupBox1.Controls.Add(this.dtpNgayCuoi);
            this.groupBox1.Controls.Add(this.dtpNgayDau);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(83, 57);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(200, 26);
            this.cboNV.TabIndex = 5;
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.Location = new System.Drawing.Point(195, 25);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(88, 26);
            this.dtpNgayCuoi.TabIndex = 2;
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.Location = new System.Drawing.Point(83, 25);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(88, 26);
            this.dtpNgayDau.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(6, 120);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(277, 31);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cập nhập";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(298, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(538, 534);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvBaoHanh);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 268);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách bảo hành";
            // 
            // dgvBaoHanh
            // 
            this.dgvBaoHanh.AllowUserToAddRows = false;
            this.dgvBaoHanh.AllowUserToDeleteRows = false;
            this.dgvBaoHanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBH,
            this.colNgayBaoHanh,
            this.colTenKhachHang,
            this.colTenNhanVien,
            this.colTongTien});
            this.dgvBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoHanh.Location = new System.Drawing.Point(3, 22);
            this.dgvBaoHanh.MultiSelect = false;
            this.dgvBaoHanh.Name = "dgvBaoHanh";
            this.dgvBaoHanh.ReadOnly = true;
            this.dgvBaoHanh.RowHeadersVisible = false;
            this.dgvBaoHanh.RowTemplate.ReadOnly = true;
            this.dgvBaoHanh.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoHanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoHanh.Size = new System.Drawing.Size(524, 243);
            this.dgvBaoHanh.TabIndex = 0;
            this.dgvBaoHanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoHanh_CellClick);
            this.dgvBaoHanh.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBaoHanh_CellFormatting);
            // 
            // colMaBH
            // 
            this.colMaBH.DataPropertyName = "MaBaoHanh";
            this.colMaBH.HeaderText = "Mã";
            this.colMaBH.Name = "colMaBH";
            this.colMaBH.ReadOnly = true;
            // 
            // colNgayBaoHanh
            // 
            this.colNgayBaoHanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNgayBaoHanh.DataPropertyName = "NgayBaoHanh";
            this.colNgayBaoHanh.HeaderText = "Ngày Bảo Hành";
            this.colNgayBaoHanh.Name = "colNgayBaoHanh";
            this.colNgayBaoHanh.ReadOnly = true;
            this.colNgayBaoHanh.Width = 130;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKhachHang.DataPropertyName = "TenKhachHang";
            this.colTenKhachHang.HeaderText = "Tên Khách Hàng";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.ReadOnly = true;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenNhanVien.DataPropertyName = "TenNhanVien";
            this.colTenNhanVien.HeaderText = "Nhân Viên Nhận";
            this.colTenNhanVien.Name = "colTenNhanVien";
            this.colTenNhanVien.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0 VNĐ";
            this.colTongTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            this.colTongTien.Width = 93;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvChiTietBaoHanh);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết bảo hành";
            // 
            // dgvChiTietBaoHanh
            // 
            this.dgvChiTietBaoHanh.AllowUserToAddRows = false;
            this.dgvChiTietBaoHanh.AllowUserToDeleteRows = false;
            this.dgvChiTietBaoHanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietBaoHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSanPham,
            this.colSoSerial,
            this.colMoTaLoi,
            this.colGiaSuaChua,
            this.colNgayHenTra,
            this.colTraHang});
            this.dgvChiTietBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietBaoHanh.Location = new System.Drawing.Point(3, 22);
            this.dgvChiTietBaoHanh.MultiSelect = false;
            this.dgvChiTietBaoHanh.Name = "dgvChiTietBaoHanh";
            this.dgvChiTietBaoHanh.ReadOnly = true;
            this.dgvChiTietBaoHanh.RowHeadersVisible = false;
            this.dgvChiTietBaoHanh.RowTemplate.ReadOnly = true;
            this.dgvChiTietBaoHanh.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietBaoHanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBaoHanh.Size = new System.Drawing.Size(527, 221);
            this.dgvChiTietBaoHanh.TabIndex = 0;
            this.dgvChiTietBaoHanh.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvChiTietBaoHanh_CellFormatting);
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
            // colGiaSuaChua
            // 
            this.colGiaSuaChua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGiaSuaChua.DataPropertyName = "GiaSuaChua";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0 VNĐ";
            this.colGiaSuaChua.DefaultCellStyle = dataGridViewCellStyle5;
            this.colGiaSuaChua.HeaderText = "Giá Sửa Chữa";
            this.colGiaSuaChua.Name = "colGiaSuaChua";
            this.colGiaSuaChua.ReadOnly = true;
            this.colGiaSuaChua.Width = 125;
            // 
            // colNgayHenTra
            // 
            this.colNgayHenTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNgayHenTra.DataPropertyName = "NgayHenTra";
            this.colNgayHenTra.HeaderText = "Ngày Hẹn Trả";
            this.colNgayHenTra.Name = "colNgayHenTra";
            this.colNgayHenTra.ReadOnly = true;
            this.colNgayHenTra.Width = 80;
            // 
            // colTraHang
            // 
            this.colTraHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTraHang.DataPropertyName = "TraHang";
            this.colTraHang.HeaderText = "Trả Hàng";
            this.colTraHang.Name = "colTraHang";
            this.colTraHang.ReadOnly = true;
            this.colTraHang.Width = 88;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(3, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 371);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // chkNgay
            // 
            this.chkNgay.AutoSize = true;
            this.chkNgay.Location = new System.Drawing.Point(6, 26);
            this.chkNgay.Name = "chkNgay";
            this.chkNgay.Size = new System.Drawing.Size(63, 22);
            this.chkNgay.TabIndex = 10;
            this.chkNgay.Text = "Ngày";
            this.chkNgay.UseVisualStyleBackColor = true;
            // 
            // chkNV
            // 
            this.chkNV.AutoSize = true;
            this.chkNV.Location = new System.Drawing.Point(6, 59);
            this.chkNV.Name = "chkNV";
            this.chkNV.Size = new System.Drawing.Size(49, 22);
            this.chkNV.TabIndex = 11;
            this.chkNV.Text = "NV";
            this.chkNV.UseVisualStyleBackColor = true;
            // 
            // llblTim
            // 
            this.llblTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblTim.AutoSize = true;
            this.llblTim.Location = new System.Drawing.Point(246, 92);
            this.llblTim.Name = "llblTim";
            this.llblTim.Size = new System.Drawing.Size(33, 18);
            this.llblTim.TabIndex = 13;
            this.llblTim.TabStop = true;
            this.llblTim.Text = "Tìm";
            this.llblTim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTim_LinkClicked);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(83, 88);
            this.txtMaKH.MaxLength = 10;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(200, 26);
            this.txtMaKH.TabIndex = 12;
            // 
            // chkMaKH
            // 
            this.chkMaKH.AutoSize = true;
            this.chkMaKH.Location = new System.Drawing.Point(6, 90);
            this.chkMaKH.Name = "chkMaKH";
            this.chkMaKH.Size = new System.Drawing.Size(75, 22);
            this.chkMaKH.TabIndex = 14;
            this.chkMaKH.Text = "Mã KH";
            this.chkMaKH.UseVisualStyleBackColor = true;
            // 
            // ucBaoCaoBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBaoCaoBaoHanh";
            this.Size = new System.Drawing.Size(839, 540);
            this.Load += new System.EventHandler(this.ucBaoCaoBaoHanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBaoHanh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvBaoHanh;
        private System.Windows.Forms.DataGridView dgvChiTietBaoHanh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHenTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTraHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkNV;
        private System.Windows.Forms.CheckBox chkNgay;
        private System.Windows.Forms.CheckBox chkMaKH;
        private System.Windows.Forms.LinkLabel llblTim;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}
