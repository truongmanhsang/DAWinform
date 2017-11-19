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
    public partial class ucKhachHang : UserControl
    {
        clsKhachHang_BUS bus = new clsKhachHang_BUS();
        DataTable dt = new DataTable();
        DataView dav;
        string MaKH = "";
        public ucKhachHang()
        {
            InitializeComponent();
        }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            CaiDat();
            loaddgvKhachHang();
        }
        private void loaddgvKhachHang()
        {
            dt = bus.LayBangKhachHang();
            dav = new DataView(dt);
            dgvKhachHang.DataSource = dav;
        }

        private void CaiDat()
        {
            dgvKhachHang.AutoGenerateColumns = false;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dav.RowFilter = string.Format(LenhTimKiem());

            }
            catch (Exception)
            {
                dav.RowFilter = "true";
            }
            //dt = bus.TimKiemKhachHang(LenhTimKiem());
            dgvKhachHang.DataSource = dav;
        }
        private string LenhTimKiem()
        {
            dgvKhachHang.DataSource = null;

            string lenh = "TrangThai=1 and";
            if (cbTenKH.Checked == true)
            {
                lenh += string.Format(" TenKhachHang like '%{0}%'", txtTenKH.Text);
            }


            if (cbCMND.Checked == true)
            {
                if (cbTenKH.Checked == true)
                {
                    lenh += " and ";
                }
                lenh += string.Format(" CMND like '%{0}%'", txtCMND.Text);
            }

            if (cbSDT.Checked == true)
            {
                if (cbTenKH.Checked == true || cbCMND.Checked == true)
                {
                    lenh += " and ";
                }
                lenh += string.Format(" SoDT= '{0}'", txtSDT.Text);
            }
            return lenh;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {

            frmThemSuaKH frm = new frmThemSuaKH();
            frm.themkhachhang += HamThemKhachHang;
            frm.ShowDialog();



        }
        void HamThemKhachHang(clsKhachHang_DTO khachhang)
        {
            if (bus.ThemKhachHang(khachhang) != "")
            {
                FormMessage.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgvKhachHang();
            }
            else
            {
                FormMessage.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            MaKH = dgvKhachHang.SelectedRows[0].Cells["colMaKhachHang"].Value.ToString();
            frmThemSuaKH frm = new frmThemSuaKH(MaKH);
            frm.suakhachhang += HamSuaKhachHang;
            frm.ShowDialog();
        }



        void HamSuaKhachHang(clsKhachHang_DTO khachhang)
        {
            khachhang.MaKhachHang = MaKH;
            if (bus.SuaKhachHang(khachhang))
            {
                FormMessage.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgvKhachHang();

            }
            else
            {
                FormMessage.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (FormMessage.Show("Bạn muốn xoá khách hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MaKH = dgvKhachHang.SelectedRows[0].Cells["colMaKhachHang"].Value.ToString();
                if (bus.XoaKhachHang(MaKH))
                {
                    loaddgvKhachHang();
                    FormMessage.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FormMessage.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            //------------------

        }
    }
}
