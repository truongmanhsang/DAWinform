using BUS;
using ClassLibrary;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmInPhieuXuat : Form
    {
        clsPhieuXuat_BUS _PhieuXuatBUS = new clsPhieuXuat_BUS();
        string strMaPhieu;
        public frmInPhieuXuat(string strMaPhieu)
        {
            InitializeComponent();
            this.strMaPhieu = strMaPhieu;
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            decimal dTongCong = 0;
            DataTable dtPhieuXuat = _PhieuXuatBUS.LayBanInPhieuXuat(strMaPhieu);
            DataTable dtKH = _PhieuXuatBUS.LayBangKhachHangPX(strMaPhieu);
            foreach (DataRow dr in dtPhieuXuat.Rows)
            {
                dTongCong += Convert.ToDecimal(dr["ThanhTien"]);
            }

            string strLogo = string.Empty;
            string strTenCongTy = string.Empty;
            string strDiaChi = string.Empty;
            string strDienThoai = string.Empty;
            string strWebsite = string.Empty;
            string strTenKH = dtKH.Rows[0]["TenKhachHang"].ToString();
            string strDiaChiKH = dtKH.Rows[0]["DiaChi"].ToString();
            string strSoDT = dtKH.Rows[0]["SoDT"].ToString();
            try
            {
                using (StreamReader sr = new StreamReader("settings.ini"))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        if (str.Split('=')[0] == "tenCongTy")
                        {
                            strTenCongTy = str.Split('=')[1];
                        }
                        if (str.Split('=')[0] == "diaChi")
                        {
                            strDiaChi = str.Split('=')[1];
                        }
                        if (str.Split('=')[0] == "dienThoai")
                        {
                            strDienThoai = str.Split('=')[1];
                        }
                        if (str.Split('=')[0] == "website")
                        {
                            strWebsite = str.Split('=')[1];
                        }
                        if (str.Split('=')[0] == "logo")
                        {
                           strLogo = "file:///" + Application.StartupPath + "/" + str.Split('=')[1];
                        }
                    }
                    sr.Close();
                }
            }
            catch
            {
                FormMessage.Show("Không tìm thấy file cấu hình!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.rptPhieuXuat.LocalReport.EnableExternalImages = true;
            this.rptPhieuXuat.LocalReport.ReportEmbeddedResource = "GUI.rptPhieuXuat.rdlc";
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramLogo", strLogo));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramTenCongTy", strTenCongTy));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramDiaChi", strDiaChi));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramDienThoai", strDienThoai));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramWebsite", strWebsite));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramTongCong", string.Format("{0:#,##0} VNĐ",dTongCong)));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramDocSo", TienIch.ChuyenSoSangChu(dTongCong)));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramTenKH", strTenKH));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramDiaChiKH", strDiaChiKH));
            this.rptPhieuXuat.LocalReport.SetParameters(new ReportParameter("paramSoDT", strSoDT));
            this.rptPhieuXuat.LocalReport.DataSources.Add(new ReportDataSource("dsPhieuXuat", dtPhieuXuat));

            this.rptPhieuXuat.RefreshReport();
        }
    }
}
