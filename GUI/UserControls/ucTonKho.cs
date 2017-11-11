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
    public partial class ucTonKho : UserControl
    {
        clsSanPham_BUS _SanPhamBUS = new clsSanPham_BUS();

        DataTable dtSanPham;

        public ucTonKho()
        {
            InitializeComponent();
        }

        private void ucTonKho_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvTonKho.AutoGenerateColumns = false;
        }
        private void TaiDuLieu()
        {
            dtSanPham = _SanPhamBUS.LayBangSanPham();
            dtSanPham.Columns.Add("TongTriGia", typeof(System.Int64));

            long lSL = 0;
            long lTongTriGia = 0;

            foreach (DataRow dr in dtSanPham.Rows)
            {
                dr["TongTriGia"] = Convert.ToInt64(dr["SoLuong"]) * Convert.ToInt64(dr["GiaMua"]);
            }
            foreach (DataRow dr in dtSanPham.Rows)
            {
                lSL += Convert.ToInt64(dr["SoLuong"]);
                lTongTriGia += Convert.ToInt64(dr["TongTriGia"]);
            }

            txtTongSL.Text = lSL.ToString();
            txtTongTriGia.Text = Utilities.ChuyenSoSangVND(lTongTriGia);

            dgvTonKho.DataSource = dtSanPham;
        }
    }
}
