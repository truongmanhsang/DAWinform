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

namespace GUI
{
    public partial class ucSerial : UserControl
    {
        clsSerial_BUS _SerialBUS = new clsSerial_BUS();

        DataTable dtSerial;
        DataView dvSerial;
        public ucSerial()
        {
            InitializeComponent();
        }

        private void ucSerial_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }

        private void CaiDat()
        {
            dgvSerial.AutoGenerateColumns = false;
            cboLoai.SelectedIndex = 0;
        }
        private void TaiDuLieu()
        {
            dtSerial = _SerialBUS.LayBangSerial();
            dvSerial = new DataView(dtSerial);
            dgvSerial.DataSource = dvSerial;
        }

        private void dgvSerial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSerial.Columns[e.ColumnIndex].Name == "colNgayHetBH")
            {
                if (e.Value.ToString() != "")
                    e.Value = Convert.ToDateTime(e.Value.ToString()).ToString("dd/MM/yyyy");
            }
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoai.SelectedIndex == 0)
            {
                panMain.Controls.Clear();
                if (dvSerial != null)
                    dvSerial.RowFilter = "TRUE";
            }
            if (cboLoai.SelectedIndex == 1)
            {
                panMain.Controls.Clear();
                ucTimKiemKH uc = new ucTimKiemKH();
                uc.guiMa += NhanMa;
                panMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
            if (cboLoai.SelectedIndex == 2)
            {
                panMain.Controls.Clear();
                ucTimKiemNCC uc = new ucTimKiemNCC();
                uc.guiMa += NhanMa;
                panMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }
        }

        private void NhanMa(string strMa)
        {
            if (strMa.Substring(0, 2) == "KH")
            {
                dvSerial.RowFilter = string.Format("MaKhachHang = '{0}'", strMa);
            }
            if (strMa.Substring(0, 2) == "NC")
            {
                dvSerial.RowFilter = string.Format("MaNhaCungCap = '{0}'", strMa);
            }
        }

        private void dgvSerial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSerial.SelectedRows[0].Index != -1)
            {
                txtTenSP.Text = dgvSerial.SelectedRows[0].Cells["colTenSanPham"].Value.ToString();
                txtSoSerial.Text = dgvSerial.SelectedRows[0].Cells["colSoSerial"].Value.ToString();
            }

        }
    }
}
