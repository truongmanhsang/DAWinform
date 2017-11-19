using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ClassLibrary;

namespace GUI
{
    public partial class ucDoanhThu : UserControl
    {
        clsThongKe_BUS _ThongKeBUS = new clsThongKe_BUS();
        DataTable dtThongKe;
        DataView dvThongKe;
        public ucDoanhThu()
        {
            InitializeComponent();
        }

        private void ucDoanhThu_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }

        private void CaiDat()
        {
            dgvThongKeDoanhThu.AutoGenerateColumns = false;
            radNgay.Checked = true;
        }

        private void TaiDuLieu()
        {
            dtThongKe = _ThongKeBUS.TinhThongKe();
            dtThongKe.Columns.Add("DoanhThu", typeof(decimal));
            foreach (DataRow dr in dtThongKe.Rows)
            {
                if (dr["NhapHang"].ToString() == "")
                {
                    dr["NhapHang"] = 0;
                }
                dr["NhapHang"] = -Convert.ToDecimal(dr["NhapHang"]);
                dr["DoanhThu"] = Convert.ToDecimal(dr["BanHang"]) + Convert.ToDecimal(dr["NhapHang"]);
            }
            dvThongKe = new DataView(dtThongKe);
            dgvThongKeDoanhThu.DataSource = dvThongKe;
            TinhTongDoanhThu();
        }

        private void TinhTongDoanhThu()
        {
            decimal dTongDoanhthu = 0;
            foreach (DataGridViewRow dgvRow in dgvThongKeDoanhThu.Rows)
            {
                dTongDoanhthu += Convert.ToDecimal(dgvRow.Cells["colDoanhThu"].Value.ToString());
            }
            txtTongDoanhThu.Text = TienIch.ChuyenSoSangVND(dTongDoanhthu);
        }

        private void dgvThongKeDoanhThu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dvThongKe.RowFilter = TaoCauTruyVan();
            TinhTongDoanhThu();
        }
        private string TaoCauTruyVan()
        {
            string strTruyVan = string.Empty;
            if (radNgay.Checked)
            {
                strTruyVan += string.Format("NgayLap >= #{0}# and NgayLap <= #{1}#", TienIch.LayNgayThangQuocTe(dtpNgayDau.Value), TienIch.LayNgayThangQuocTe(dtpNgayCuoi.Value));
            }
            return strTruyVan;
        }
    }
}
