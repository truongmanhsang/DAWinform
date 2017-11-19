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
using ClassLibrary;

namespace GUI
{
    public partial class ucNhaCungCap : UserControl
    {
        DataTable dt;
        DataView dav;
        string MaNCC;
        clsNhaCungCap_BUS bus = new clsNhaCungCap_BUS();
        public ucNhaCungCap()
        {
            InitializeComponent();
        }

        private void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            loadDVDL();
        }

        private void loadDVDL()
        {
            dgvNhaCungCap.AutoGenerateColumns = false;
            dt = bus.LayBangNhaCungCap();
            dgvNhaCungCap.DataSource = dt;
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dav = new DataView(dt);
            dav.RowFilter = LenhTimKiem();
            dgvNhaCungCap.AutoGenerateColumns = false;
            dgvNhaCungCap.DataSource = dav;
        }
        protected string LenhTimKiem()
        {

            string lenh = "TrangThai=1";
            if (cbTenNCC.Checked == true)
            {
                lenh += string.Format(" and TenNhaCungCap like '%{0}%'", txtTenNCC.Text);
            }
            if (cbMaNCC.Checked == true)
            {

                lenh += string.Format("and  MaNhaCungCap='{0}'", txtMaNCC.Text);
            }
            if (cbSDT.Checked == true)
            {

                lenh += string.Format("and  SoDT='{0}'", txtSDT.Text);
            }
            return lenh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSuaNCC frm = new frmThemSuaNCC();
            frm.themnhacungcap += HamTHemNCC;
            frm.ShowDialog();
        }

        private void HamTHemNCC(clsNhaCungCap_DTO nhacungcap)
        {
            if (bus.ThemNCC(nhacungcap)!="")
            {
                FormMessage.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDVDL();
            }
            else
            {
                FormMessage.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MaNCC = dgvNhaCungCap.SelectedRows[0].Cells["colMaNCC"].Value.ToString();
            frmThemSuaNCC frm = new frmThemSuaNCC(MaNCC);
            frm.suanhacungcap += HamSuaNCC;
            frm.ShowDialog();
        }
        private void HamSuaNCC(clsNhaCungCap_DTO nhacungcap)
        {
            if (bus.SuaNCC(nhacungcap))
            {
                FormMessage.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDVDL();
            }
            else
            {
                FormMessage.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvNhaCungCap.SelectedRows.Count > 0)
            {
                if (FormMessage.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MaNCC = dgvNhaCungCap.SelectedRows[0].Cells["colMaNCC"].Value.ToString();
                    if (bus.XoaNCC(MaNCC))
                    {
                        FormMessage.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDVDL();

                    }
                    else
                    {
                        FormMessage.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                FormMessage.Show("vui lòng chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
