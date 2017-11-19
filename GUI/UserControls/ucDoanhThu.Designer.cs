namespace GUI
{
    partial class ucDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDau = new System.Windows.Forms.DateTimePicker();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.dgvThongKeDoanhThu = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayCuoi);
            this.groupBox1.Controls.Add(this.dtpNgayDau);
            this.groupBox1.Controls.Add(this.radNgay);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(114, 53);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(297, 33);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayCuoi.Location = new System.Drawing.Point(275, 21);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(136, 26);
            this.dtpNgayCuoi.TabIndex = 2;
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDau.Location = new System.Drawing.Point(114, 21);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(136, 26);
            this.dtpNgayDau.TabIndex = 1;
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Location = new System.Drawing.Point(6, 23);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(102, 22);
            this.radNgay.TabIndex = 0;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Theo  ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            // 
            // dgvThongKeDoanhThu
            // 
            this.dgvThongKeDoanhThu.AllowUserToAddRows = false;
            this.dgvThongKeDoanhThu.AllowUserToDeleteRows = false;
            this.dgvThongKeDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKeDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKeDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThoiGian,
            this.colBanHang,
            this.colNhapHang,
            this.colDoanhThu});
            this.dgvThongKeDoanhThu.Location = new System.Drawing.Point(3, 102);
            this.dgvThongKeDoanhThu.MultiSelect = false;
            this.dgvThongKeDoanhThu.Name = "dgvThongKeDoanhThu";
            this.dgvThongKeDoanhThu.ReadOnly = true;
            this.dgvThongKeDoanhThu.RowHeadersVisible = false;
            this.dgvThongKeDoanhThu.RowTemplate.ReadOnly = true;
            this.dgvThongKeDoanhThu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKeDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKeDoanhThu.Size = new System.Drawing.Size(743, 390);
            this.dgvThongKeDoanhThu.TabIndex = 1;
            this.dgvThongKeDoanhThu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvThongKeDoanhThu_CellFormatting);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(274, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng Doanh Thu";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongDoanhThu.BackColor = System.Drawing.Color.Moccasin;
            this.txtTongDoanhThu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDoanhThu.Location = new System.Drawing.Point(443, 498);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(303, 32);
            this.txtTongDoanhThu.TabIndex = 3;
            this.txtTongDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colThoiGian
            // 
            this.colThoiGian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colThoiGian.DataPropertyName = "NgayLap";
            this.colThoiGian.HeaderText = "Thời Gian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.ReadOnly = true;
            this.colThoiGian.Width = 102;
            // 
            // colBanHang
            // 
            this.colBanHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBanHang.DataPropertyName = "BanHang";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,##0 VNĐ";
            this.colBanHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.colBanHang.HeaderText = "Bán Hàng";
            this.colBanHang.Name = "colBanHang";
            this.colBanHang.ReadOnly = true;
            // 
            // colNhapHang
            // 
            this.colNhapHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNhapHang.DataPropertyName = "NhapHang";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0 VNĐ";
            this.colNhapHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNhapHang.HeaderText = "Nhập Hàng";
            this.colNhapHang.Name = "colNhapHang";
            this.colNhapHang.ReadOnly = true;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDoanhThu.DataPropertyName = "DoanhThu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0 VNĐ";
            this.colDoanhThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDoanhThu.HeaderText = "DoanhThu";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;
            // 
            // ucDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvThongKeDoanhThu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDoanhThu";
            this.Size = new System.Drawing.Size(749, 533);
            this.Load += new System.EventHandler(this.ucDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDau;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvThongKeDoanhThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
    }
}
