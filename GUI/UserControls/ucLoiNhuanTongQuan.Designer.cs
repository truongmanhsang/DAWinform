namespace GUI
{
    partial class ucLoiNhuanTongQuan
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
            this.dgvLoiNhuanTongQuan = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDau = new System.Windows.Forms.DateTimePicker();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongLoiNhuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTriGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoiNhuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoiNhuanTongQuan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoiNhuanTongQuan
            // 
            this.dgvLoiNhuanTongQuan.AllowUserToAddRows = false;
            this.dgvLoiNhuanTongQuan.AllowUserToDeleteRows = false;
            this.dgvLoiNhuanTongQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoiNhuanTongQuan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoiNhuanTongQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoiNhuanTongQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThoiGian,
            this.colDoanhThu,
            this.colTriGia,
            this.colLoiNhuan});
            this.dgvLoiNhuanTongQuan.Location = new System.Drawing.Point(3, 102);
            this.dgvLoiNhuanTongQuan.MultiSelect = false;
            this.dgvLoiNhuanTongQuan.Name = "dgvLoiNhuanTongQuan";
            this.dgvLoiNhuanTongQuan.ReadOnly = true;
            this.dgvLoiNhuanTongQuan.RowHeadersVisible = false;
            this.dgvLoiNhuanTongQuan.RowTemplate.ReadOnly = true;
            this.dgvLoiNhuanTongQuan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoiNhuanTongQuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoiNhuanTongQuan.Size = new System.Drawing.Size(743, 390);
            this.dgvLoiNhuanTongQuan.TabIndex = 3;
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
            this.radNgay.Size = new System.Drawing.Size(98, 22);
            this.radNgay.TabIndex = 0;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Theo ngày";
            this.radNgay.UseVisualStyleBackColor = true;
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
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtTongLoiNhuan
            // 
            this.txtTongLoiNhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongLoiNhuan.BackColor = System.Drawing.Color.Moccasin;
            this.txtTongLoiNhuan.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLoiNhuan.Location = new System.Drawing.Point(443, 497);
            this.txtTongLoiNhuan.Name = "txtTongLoiNhuan";
            this.txtTongLoiNhuan.Size = new System.Drawing.Size(303, 32);
            this.txtTongLoiNhuan.TabIndex = 5;
            this.txtTongLoiNhuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(279, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng Lợi Nhuận";
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
            // colDoanhThu
            // 
            this.colDoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDoanhThu.DataPropertyName = "DoanhThu";
            dataGridViewCellStyle1.Format = "#,##0 VNĐ";
            this.colDoanhThu.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDoanhThu.HeaderText = "Doanh Thu Bán Hàng";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;
            // 
            // colTriGia
            // 
            this.colTriGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTriGia.DataPropertyName = "TriGia";
            dataGridViewCellStyle2.Format = "#,##0 VNĐ";
            this.colTriGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTriGia.HeaderText = "Trị Giá Nhập Hàng";
            this.colTriGia.Name = "colTriGia";
            this.colTriGia.ReadOnly = true;
            // 
            // colLoiNhuan
            // 
            this.colLoiNhuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLoiNhuan.DataPropertyName = "LoiNhuan";
            dataGridViewCellStyle3.Format = "#,##0 VNĐ";
            this.colLoiNhuan.DefaultCellStyle = dataGridViewCellStyle3;
            this.colLoiNhuan.HeaderText = "Lợi Nhuận";
            this.colLoiNhuan.Name = "colLoiNhuan";
            this.colLoiNhuan.ReadOnly = true;
            // 
            // ucLoiNhuanTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTongLoiNhuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvLoiNhuanTongQuan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucLoiNhuanTongQuan";
            this.Size = new System.Drawing.Size(749, 533);
            this.Load += new System.EventHandler(this.ucLoiNhuanTongQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoiNhuanTongQuan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLoiNhuanTongQuan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDau;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongLoiNhuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTriGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoiNhuan;
    }
}
