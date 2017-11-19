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
    public partial class ucLoiNhuanTongQuan : UserControl
    {
        clsThongKe_BUS _ThongKeBUS = new clsThongKe_BUS();
        DataTable dtLoiNhuan;
        DataView dvLoiNhuan;
        public ucLoiNhuanTongQuan()
        {
            InitializeComponent();
        }

        private void ucLoiNhuanTongQuan_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvLoiNhuanTongQuan.AutoGenerateColumns = false;
            radNgay.Checked = true;
        }
        private void TaiDuLieu()
        {
            dtLoiNhuan = _ThongKeBUS.TinhLoiNhuan();
            dtLoiNhuan.Columns.Add("LoiNhuan", typeof(decimal));
            foreach (DataRow dr in dtLoiNhuan.Rows)
            {
                dr["LoiNhuan"] = Convert.ToDecimal(dr["Doanhthu"]) - Convert.ToDecimal(dr["TriGia"]);
            }
            dvLoiNhuan = new DataView(dtLoiNhuan);
            dgvLoiNhuanTongQuan.DataSource = dvLoiNhuan;
            TinhTongLoiNhuan();
        }

        private void TinhTongLoiNhuan()
        {
            decimal dTongLoiNhuan = 0;
            foreach (DataGridViewRow dgvRow in dgvLoiNhuanTongQuan.Rows)
            {
                dTongLoiNhuan += Convert.ToDecimal(dgvRow.Cells["colLoiNhuan"].Value.ToString());
            }
            txtTongLoiNhuan.Text = TienIch.ChuyenSoSangVND(dTongLoiNhuan);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dvLoiNhuan.RowFilter = TaoCauTruyVan();
            TinhTongLoiNhuan();
        }
        private string TaoCauTruyVan()
        {
            string strTruyVan = string.Empty;
            if (radNgay.Checked)
            {
                strTruyVan += string.Format("NgayLap >= #{0}# and NgayLap <= #{1}#",TienIch.LayNgayThangQuocTe(dtpNgayDau.Value), TienIch.LayNgayThangQuocTe(dtpNgayCuoi.Value));
            }
            return strTruyVan;
        }
    }
}
