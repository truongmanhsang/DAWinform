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
    public partial class frmInPhieuNhap : Form
    {
        clsPhieuNhap_BUS _PhieuNhapBUS = new clsPhieuNhap_BUS();
        clsNhaCungCap_BUS _NhaCungCapBUS = new clsNhaCungCap_BUS();
        string strMaPhieu;
        public frmInPhieuNhap(string strMaPhieu)
        {
            InitializeComponent();
            this.strMaPhieu = strMaPhieu;
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            decimal dTongCong = 0;
            DataTable dtPhieuNhap = _PhieuNhapBUS.LayBangInPhieuNhap(strMaPhieu);
            DataTable dtNCC = _PhieuNhapBUS.LayBangNCCPhieuNhap(strMaPhieu);
            foreach (DataRow dr in dtPhieuNhap.Rows)
            {
                dTongCong += Convert.ToDecimal(dr["ThanhTien"]);
            }

            string strLogo = string.Empty;
            string strTenCongTy = string.Empty;
            string strDiaChi = string.Empty;
            string strDienThoai = string.Empty;
            string strWebsite = string.Empty;
            string strTenNCC = dtNCC.Rows[0]["TenNhaCungCap"].ToString();
            string strDiaChiNCC = dtNCC.Rows[0]["DiaChi"].ToString();
            string strSoDT = dtNCC.Rows[0]["SoDT"].ToString();
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
            this.rptPhieuNhap.LocalReport.EnableExternalImages = true;
            this.rptPhieuNhap.LocalReport.ReportEmbeddedResource = "GUI.rptPhieuNhap.rdlc";
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramLogo", strLogo));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramTenCongTy", strTenCongTy));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramDiaChi", strDiaChi));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramSoDT", strDienThoai));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramWebsite", strWebsite));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramTongCong", string.Format("{0:#,##0} VNĐ", dTongCong)));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramDocSo", TienIch.ChuyenSoSangChu(dTongCong)));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramTenNCC", strTenNCC));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramDiaChiNCC", strDiaChiNCC));
            this.rptPhieuNhap.LocalReport.SetParameters(new ReportParameter("paramSoDTNCC", strSoDT));
            this.rptPhieuNhap.LocalReport.DataSources.Add(new ReportDataSource("dsPhieuNhap", dtPhieuNhap));

            this.rptPhieuNhap.RefreshReport();
        }
    }
}
