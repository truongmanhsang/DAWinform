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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdNgay = new System.Windows.Forms.RadioButton();
            this.dgvDuLieu = new System.Windows.Forms.DataGridView();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rdThang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.rdNgay);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(114, 113);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(297, 33);
            this.btnTimKiem.TabIndex = 12;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "-";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 26);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 26);
            this.textBox4.TabIndex = 9;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(6, 81);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(99, 22);
            this.rdNam.TabIndex = 8;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Theo  năm";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 5;
            // 
            // rdThang
            // 
            this.rdThang.AutoSize = true;
            this.rdThang.Location = new System.Drawing.Point(6, 52);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(107, 22);
            this.rdThang.TabIndex = 4;
            this.rdThang.TabStop = true;
            this.rdThang.Text = "Theo  tháng";
            this.rdThang.UseVisualStyleBackColor = true;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(275, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // rdNgay
            // 
            this.rdNgay.AutoSize = true;
            this.rdNgay.Location = new System.Drawing.Point(6, 23);
            this.rdNgay.Name = "rdNgay";
            this.rdNgay.Size = new System.Drawing.Size(102, 22);
            this.rdNgay.TabIndex = 0;
            this.rdNgay.TabStop = true;
            this.rdNgay.Text = "Theo  ngày";
            this.rdNgay.UseVisualStyleBackColor = true;
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.AllowUserToAddRows = false;
            this.dgvDuLieu.AllowUserToDeleteRows = false;
            this.dgvDuLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThoiGian,
            this.colBanHang,
            this.colNhapHang,
            this.colDoanhThu});
            this.dgvDuLieu.Location = new System.Drawing.Point(3, 164);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.ReadOnly = true;
            this.dgvDuLieu.RowHeadersVisible = false;
            this.dgvDuLieu.Size = new System.Drawing.Size(743, 366);
            this.dgvDuLieu.TabIndex = 1;
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
            this.colBanHang.DataPropertyName = "MaPhieuXuat";
            this.colBanHang.HeaderText = "Bán Hàng";
            this.colBanHang.Name = "colBanHang";
            this.colBanHang.ReadOnly = true;
            // 
            // colNhapHang
            // 
            this.colNhapHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNhapHang.DataPropertyName = "MaPhieuNhap";
            this.colNhapHang.HeaderText = "Nhập Hàng";
            this.colNhapHang.Name = "colNhapHang";
            this.colNhapHang.ReadOnly = true;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDoanhThu.HeaderText = "DoanhThu";
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;
            // 
            // ucDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDoanhThu";
            this.Size = new System.Drawing.Size(749, 533);
            this.Load += new System.EventHandler(this.ucDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdNgay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDuLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
    }
}
