namespace GUI
{
    partial class ucNhanBaoHanh
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
            this.dgvChiTietBH = new System.Windows.Forms.DataGridView();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTaLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaSuaChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHenTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTimSoSerial = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChiTietBH
            // 
            this.dgvChiTietBH.AllowUserToAddRows = false;
            this.dgvChiTietBH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSanPham,
            this.colSoSerial,
            this.colMoTaLoi,
            this.colGiaSuaChua,
            this.colNgayHenTra,
            this.colGhiChu});
            this.dgvChiTietBH.Location = new System.Drawing.Point(3, 271);
            this.dgvChiTietBH.MultiSelect = false;
            this.dgvChiTietBH.Name = "dgvChiTietBH";
            this.dgvChiTietBH.ReadOnly = true;
            this.dgvChiTietBH.RowHeadersVisible = false;
            this.dgvChiTietBH.RowTemplate.ReadOnly = true;
            this.dgvChiTietBH.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBH.Size = new System.Drawing.Size(808, 203);
            this.dgvChiTietBH.TabIndex = 0;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.ReadOnly = true;
            // 
            // colSoSerial
            // 
            this.colSoSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSoSerial.HeaderText = "Số Serial";
            this.colSoSerial.Name = "colSoSerial";
            this.colSoSerial.ReadOnly = true;
            this.colSoSerial.Width = 90;
            // 
            // colMoTaLoi
            // 
            this.colMoTaLoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMoTaLoi.HeaderText = "Mô Tả Lỗi";
            this.colMoTaLoi.Name = "colMoTaLoi";
            this.colMoTaLoi.ReadOnly = true;
            this.colMoTaLoi.Width = 95;
            // 
            // colGiaSuaChua
            // 
            this.colGiaSuaChua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGiaSuaChua.HeaderText = "Giá Sữa Chữa";
            this.colGiaSuaChua.Name = "colGiaSuaChua";
            this.colGiaSuaChua.ReadOnly = true;
            this.colGiaSuaChua.Width = 125;
            // 
            // colNgayHenTra
            // 
            this.colNgayHenTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNgayHenTra.HeaderText = "Ngày Hẹn Trả";
            this.colNgayHenTra.Name = "colNgayHenTra";
            this.colNgayHenTra.ReadOnly = true;
            this.colNgayHenTra.Width = 96;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            this.colGhiChu.Width = 82;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(808, 262);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnTimSoSerial);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm bảo hành";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ngày hẹn trả";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(284, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ghi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnTimSoSerial
            // 
            this.btnTimSoSerial.Location = new System.Drawing.Point(109, 216);
            this.btnTimSoSerial.Name = "btnTimSoSerial";
            this.btnTimSoSerial.Size = new System.Drawing.Size(109, 30);
            this.btnTimSoSerial.TabIndex = 10;
            this.btnTimSoSerial.Text = "Tìm số Serial";
            this.btnTimSoSerial.UseVisualStyleBackColor = true;
            this.btnTimSoSerial.Click += new System.EventHandler(this.btnTimSoSerial_Click);
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(109, 152);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(284, 26);
            this.textBox8.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giá sửa";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenHang.Location = new System.Drawing.Point(109, 24);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(284, 26);
            this.txtTenHang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Serial";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(109, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(284, 26);
            this.textBox4.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(109, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(109, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 26);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả lỗi";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(274, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Thêm mới";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 30);
            this.button3.TabIndex = 15;
            this.button3.Text = "Tìm KH";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(129, 88);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(254, 26);
            this.textBox7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên khách hàng";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(129, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(254, 26);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(129, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(254, 26);
            this.textBox5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số ĐT";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(587, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 30);
            this.button5.TabIndex = 15;
            this.button5.Text = "Lưu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(702, 512);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 30);
            this.button6.TabIndex = 16;
            this.button6.Text = "Huỷ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Location = new System.Drawing.Point(587, 480);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(224, 26);
            this.textBox9.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tổng cộng";
            // 
            // ucNhanBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dgvChiTietBH);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucNhanBaoHanh";
            this.Size = new System.Drawing.Size(814, 545);
            this.Load += new System.EventHandler(this.ucNhanBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBH)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietBH;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTimSoSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTaLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaSuaChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHenTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
    }
}
