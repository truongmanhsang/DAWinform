using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class ucNhanVien : UserControl
    {
        private static ucNhanVien _instance = null;
        clsNhanVien_BUS bus = new clsNhanVien_BUS();
        DataTable dt = new DataTable();
        DataView dav;
        public static ucNhanVien GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucNhanVien();
                }
                return _instance;
            }
        }
        public ucNhanVien()
        {
            InitializeComponent();
        }
        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            loadDataViewNV();
            loadTimKiem();
        }

        private void loadTimKiem()
        {
            DataTable dtTemp = new DataTable();
            DataColumn col;
            DataRow row;

            col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "TenQuyen";
            dt.Columns.Add(col);
            col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "MaQuyen";
            dt.Columns.Add(col);
            row = dt.NewRow();
            row["TenQuyen"] = "Nhân viên";
            row["MaQuyen"] = "1";
            dt.Rows.Add(row);

            cbbChucVu.DataSource = dt;
            cbbChucVu.DisplayMember = "TenQuyen";
            cbbChucVu.ValueMember = "MaQuyen";
        }

        private void loadDataViewNV()
        {
            dt = bus.LayBangNhanVien();
            dav = new DataView(dt);
        }
        private void loaddgvNhanVien()
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = dav;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSuaNV frm = new frmThemSuaNV();
            frm.themnhanvien += XulyThemNhanVien;
            frm.ShowDialog();
        }
        void XulyThemNhanVien(clsNhanVien_DTO nhanvien)
        {
           if(bus.ThemNhanVien(nhanvien))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            frmThemSuaNV frm = new frmThemSuaNV();
            frm.suanhanvien += XuLySuaNhanVien;
            frm.ShowDialog();
        }

        private void XuLySuaNhanVien(clsNhanVien_DTO nhanvien)
        {
            if (bus.SuaNhanVien(nhanvien))
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dav.RowFilter = string.Format(LenhTimKiem());
            loaddgvNhanVien();
        }
        private string LenhTimKiem()
        {

            string lenh = "TrangThai=1";
            if (cbChucVu.Checked == true)
            {
                lenh += string.Format(" and TenNhanVien like '%{0}%'", txtTenNV.Text);
            }


            if (cbChucVu.Checked == true)
            {
                if (cbTenNV.Checked == true)
                {
                    lenh += " and ";
                }
                lenh += string.Format(" Quyen='{0}'",cbbChucVu.SelectedValue.ToString());
            }
            return lenh;
        }

       
    }
}
