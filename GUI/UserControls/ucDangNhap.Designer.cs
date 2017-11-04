namespace GUI
{
    partial class ucDangNhap
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
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTinNhan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAnh
            // 
            this.picAnh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picAnh.Image = global::GUI.Properties.Resources._default;
            this.picAnh.Location = new System.Drawing.Point(263, 5);
            this.picAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(149, 153);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaiKhoan.Location = new System.Drawing.Point(207, 188);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(262, 26);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhau.Location = new System.Drawing.Point(207, 244);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(262, 26);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Text = "123456";
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(206, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatKhau.Location = new System.Drawing.Point(207, 219);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(262, 20);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangNhap.Location = new System.Drawing.Point(206, 280);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(264, 35);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picAnh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMatKhau, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMatKhau, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTaiKhoan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDangNhap, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTinNhan, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 370);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblTinNhan
            // 
            this.lblTinNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinNhan.ForeColor = System.Drawing.Color.Green;
            this.lblTinNhan.Location = new System.Drawing.Point(3, 320);
            this.lblTinNhan.Name = "lblTinNhan";
            this.lblTinNhan.Size = new System.Drawing.Size(670, 50);
            this.lblTinNhan.TabIndex = 6;
            this.lblTinNhan.Text = "Vui lòng nhập tên tài khoản để tiếp tục!";
            this.lblTinNhan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ucDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucDangNhap";
            this.Size = new System.Drawing.Size(676, 459);
            this.Load += new System.EventHandler(this.ucDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTinNhan;
    }
}
