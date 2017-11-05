namespace GUI
{
    partial class ucHangHoa
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
            this.panMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHangSanXuat = new System.Windows.Forms.Button();
            this.btnLoai = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Location = new System.Drawing.Point(209, 13);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(673, 526);
            this.panMain.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnHangSanXuat);
            this.groupBox1.Controls.Add(this.btnLoai);
            this.groupBox1.Controls.Add(this.btnSanPham);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục";
            // 
            // btnHangSanXuat
            // 
            this.btnHangSanXuat.Location = new System.Drawing.Point(6, 101);
            this.btnHangSanXuat.Name = "btnHangSanXuat";
            this.btnHangSanXuat.Size = new System.Drawing.Size(188, 32);
            this.btnHangSanXuat.TabIndex = 2;
            this.btnHangSanXuat.Text = "Hãng Sản Xuất";
            this.btnHangSanXuat.UseVisualStyleBackColor = true;
            this.btnHangSanXuat.Click += new System.EventHandler(this.btnHangSanXuat_Click);
            // 
            // btnLoai
            // 
            this.btnLoai.Location = new System.Drawing.Point(6, 63);
            this.btnLoai.Name = "btnLoai";
            this.btnLoai.Size = new System.Drawing.Size(188, 32);
            this.btnLoai.TabIndex = 1;
            this.btnLoai.Text = "Loại";
            this.btnLoai.UseVisualStyleBackColor = true;
            this.btnLoai.Click += new System.EventHandler(this.btnLoai_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Location = new System.Drawing.Point(6, 25);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(188, 32);
            this.btnSanPham.TabIndex = 0;
            this.btnSanPham.Text = "Sản Phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // ucHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucHangHoa";
            this.Size = new System.Drawing.Size(885, 542);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHangSanXuat;
        private System.Windows.Forms.Button btnLoai;
        private System.Windows.Forms.Button btnSanPham;
    }
}
