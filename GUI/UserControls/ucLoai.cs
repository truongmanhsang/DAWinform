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
    public partial class ucLoai : UserControl
    {
        clsLoai_BUS _LoaiBUS = new clsLoai_BUS();

        DataTable dtLoai;

        DataView dvLoai;
        public ucLoai()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmLoai frm = new frmLoai();
            frm.themLoai += XuLiThemLoai;
            frm.ShowDialog();
        }

        private void ucLoai_Load(object sender, EventArgs e)
        {
            CaiDat();
            TaiDuLieu();
        }
        private void CaiDat()
        {
            dgvLoaiSP.AutoGenerateColumns = false;
        }

        private void TaiDuLieu()
        {
            dtLoai = _LoaiBUS.LayBangLoai();
            dvLoai = new DataView(dtLoai);
            dgvLoaiSP.DataSource = dvLoai;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dvLoai.RowFilter = string.Format("TenLoaiSanPham like '%{0}%'", txtTenLoai.Text);
        }

        private void XuLiThemLoai(clsLoai_DTO loai)
        {
            if (_LoaiBUS.ThemLoai(loai))
            {
                MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm loại sản phẩm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLiSuaLoai(clsLoai_DTO loai)
        {
            if (_LoaiBUS.SuaLoai(loai))
            {
                MessageBox.Show("Sửa loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Sửa loại sản phẩm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSP.SelectedRows[0].Index != -1)
            {
                string strMaLoai = dgvLoaiSP.SelectedRows[0].Cells["colMaLoai"].Value.ToString();
                frmLoai frm = new frmLoai(strMaLoai);
                frm.suaLoai += XuLiSuaLoai;
                frm.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSP.SelectedRows[0].Index != -1)
            {
                string strMaLoai = dgvLoaiSP.SelectedRows[0].Cells["colMaLoai"].Value.ToString();
                if (MessageBox.Show("Bạn chắc chắn muốn xoá loại này?","Xác nhận xoá",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_LoaiBUS.XoaLoai(strMaLoai))
                    {
                        MessageBox.Show("Xoá loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TaiDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Xoá loại sản phẩm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
