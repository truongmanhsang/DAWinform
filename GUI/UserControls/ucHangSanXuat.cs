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

namespace GUI
{
    public partial class ucHangSanXuat : UserControl
    {
        clsHangSanXuat_BUS _HangSanXuatBUS = new clsHangSanXuat_BUS();

        DataTable dtHSX;

        DataView dvHSX;
        public ucHangSanXuat()
        {
            InitializeComponent();
        }

        private void ucHangSanXuat_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvHSX.AutoGenerateColumns = false;
        }

        private void TaiDuLieu()
        {
            dtHSX = _HangSanXuatBUS.LayBangHangSanXuat();
            dvHSX = new DataView(dtHSX);
            dgvHSX.DataSource = dvHSX;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dvHSX.RowFilter = string.Format("TenHangSanXuat like '%{0}%'", txtTenHSX.Text);
        }
        private void XuLiThemHSX(clsHangSanXuat_DTO hsx)
        {
            if (_HangSanXuatBUS.ThemHSX(hsx))
            {
                MessageBox.Show("Thêm hãng sản xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm hãng sản xuất không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLiSuaHSX(clsHangSanXuat_DTO hsx)
        {
            if (_HangSanXuatBUS.SuaHSX(hsx))
            {
                MessageBox.Show("Sửa hãng sản xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Sửa hãng sản xuất không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHangSanXuat frm = new frmHangSanXuat();
            frm.themHSX += XuLiThemHSX;
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvHSX.SelectedRows[0].Index != -1)
            {
                string strMaHSX = dgvHSX.SelectedRows[0].Cells["colMaLoai"].Value.ToString();
                frmHangSanXuat frm = new frmHangSanXuat(strMaHSX);
                frm.suaHSX += XuLiSuaHSX;
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvHSX.SelectedRows[0].Index != -1)
            {
                string strMaHSX = dgvHSX.SelectedRows[0].Cells["colMaLoai"].Value.ToString();
                if (MessageBox.Show("Bạn chắc chắn muốn xoá hãng sản xuất này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_HangSanXuatBUS.XoaHSX(strMaHSX))
                    {
                        MessageBox.Show("Xoá hãng sản xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TaiDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Xoá hãng sản xuất không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
