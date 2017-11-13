namespace ClassLibrary
{
    partial class frmMessage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChucNang2 = new System.Windows.Forms.Button();
            this.btnChucNang1 = new System.Windows.Forms.Button();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.picBieuTuong = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBieuTuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(813, 11);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(162, 53);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(642, 11);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(162, 53);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnChucNang2);
            this.panel1.Controls.Add(this.btnChucNang1);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 55);
            this.panel1.TabIndex = 79;
            // 
            // btnChucNang2
            // 
            this.btnChucNang2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChucNang2.Location = new System.Drawing.Point(256, 9);
            this.btnChucNang2.Name = "btnChucNang2";
            this.btnChucNang2.Size = new System.Drawing.Size(108, 38);
            this.btnChucNang2.TabIndex = 1;
            this.btnChucNang2.UseVisualStyleBackColor = true;
            this.btnChucNang2.Click += new System.EventHandler(this.btnChucNang2_Click);
            // 
            // btnChucNang1
            // 
            this.btnChucNang1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChucNang1.Location = new System.Drawing.Point(142, 9);
            this.btnChucNang1.Name = "btnChucNang1";
            this.btnChucNang1.Size = new System.Drawing.Size(108, 38);
            this.btnChucNang1.TabIndex = 0;
            this.btnChucNang1.UseVisualStyleBackColor = true;
            this.btnChucNang1.Click += new System.EventHandler(this.btnChucNang1_Click);
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Location = new System.Drawing.Point(99, 12);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(265, 83);
            this.lblNoiDung.TabIndex = 80;
            this.lblNoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBieuTuong
            // 
            this.picBieuTuong.Location = new System.Drawing.Point(12, 12);
            this.picBieuTuong.Name = "picBieuTuong";
            this.picBieuTuong.Size = new System.Drawing.Size(81, 83);
            this.picBieuTuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBieuTuong.TabIndex = 81;
            this.picBieuTuong.TabStop = false;
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 162);
            this.Controls.Add(this.picBieuTuong);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMessageBox_FormClosing);
            this.Load += new System.EventHandler(this.frmMessageBox_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBieuTuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChucNang2;
        private System.Windows.Forms.Button btnChucNang1;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.PictureBox picBieuTuong;
    }
}