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
using DTO;
using System.Collections;

namespace GUI
{
    public partial class ucNhapHang : UserControl
    {
        private static ucNhapHang _instance = null;
        private SanPhamBUS _SanPhamBUS = new SanPhamBUS();

        // khai báo các datatable cần thiết để lấy dữ liệu
        DataTable dtSanPham;
        DataView dvSanPham;
        // Chuyển dtSanPham thành htSanPham cho việc truy xuất dễ hơn
        Hashtable htSanPham;
        public static ucNhapHang GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucNhapHang();
                }
                return _instance;
            }
        }
        public ucNhapHang()
        {
            InitializeComponent();
        }

        private void ucNhapHang_Load(object sender, EventArgs e)
        {
            Setup();
            LoadDatabase();
        }
        private void Setup()
        {
            // cài đặt datagrid
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.AllowUserToAddRows = false;
            // ẩn cột không cần thiết
            dgvSanPham.Columns["colMaSP"].Visible = false;
        }

        private void LoadDatabase()
        {
           
            dtSanPham = _SanPhamBUS.LayBangSanPham();
            dvSanPham = new DataView(dtSanPham);
            dgvSanPham.DataSource = dvSanPham;
            LoadHashTableSP();
        }
        private void LoadHashTableSP()
        {
            htSanPham = new Hashtable();
            foreach (DataRow dr in dtSanPham.Rows)
            {
                string strMa = dr["MaSanPham"].ToString();
                htSanPham[strMa] = dr;
            }
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!dgvSanPham.Rows[e.RowIndex].IsNewRow)
            {
                if (dgvSanPham.Columns[e.ColumnIndex].Name == "colHinh" && e.Value.ToString() != "")
                {
                    e.Value = new Bitmap(e.Value.ToString());
                }
               
            }
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colTrangThai")
            {
                if ((int)e.Value == 1)
                {
                    e.Value = "Còn kinh doanh";
                }
            }
        }

        private void txtTimSP_TextChanged(object sender, EventArgs e)
        {
            dvSanPham.RowFilter = string.Format("TenSanPham like '%{0}%'", txtTimSP.Text);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                lblTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["colTenSanPham"].Value.ToString();
                lblSL.Text = dgvSanPham.Rows[e.RowIndex].Cells["colSoLuong"].Value.ToString();
                lblMaSP.Text= dgvSanPham.Rows[e.RowIndex].Cells["colMaSP"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lamlai:
            string SLTrongKho = lblSL.Text;
            string SL = txtSL.Text;
            int SLMoi = int.Parse(SL) + int.Parse(SLTrongKho);
            string MaSP = lblMaSP.Text;
            if(_SanPhamBUS.ThemSoLuongSP(MaSP, SLMoi))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(MessageBox.Show("Thêm thất bại!", "Thông báo!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)==DialogResult.Retry){
                    goto lamlai;
                }
            }
        }
    }
}
