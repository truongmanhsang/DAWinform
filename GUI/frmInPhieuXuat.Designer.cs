namespace GUI
{
    partial class frmInPhieuXuat
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
            this.rptPhieuXuat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptPhieuXuat
            // 
            this.rptPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptPhieuXuat.Location = new System.Drawing.Point(0, 0);
            this.rptPhieuXuat.Name = "rptPhieuXuat";
            this.rptPhieuXuat.Size = new System.Drawing.Size(913, 669);
            this.rptPhieuXuat.TabIndex = 0;
            // 
            // frmInPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 669);
            this.Controls.Add(this.rptPhieuXuat);
            this.Name = "frmInPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Xuất";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPhieuXuat;
    }
}