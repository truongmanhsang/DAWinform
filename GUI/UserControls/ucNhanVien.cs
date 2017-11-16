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
using ClassLibrary;

namespace GUI
{
    public partial class ucNhanVien : UserControl
    {
        private static ucNhanVien _instance = null;
        clsNhanVien_BUS bus = new clsNhanVien_BUS();
        DataTable dt ;
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
            loaddgvNhanVien();
        }

        private void loadTimKiem()
        {
            DataTable dtTemp = new DataTable();
            DataColumn col;
            DataRow row;

            col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "TenQuyen";
            dtTemp.Columns.Add(col);
            col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "MaQuyen";
            dtTemp.Columns.Add(col);
            row = dtTemp.NewRow();
            row["TenQuyen"] = "Nhân viên";
            row["MaQuyen"] = "0";
            dtTemp.Rows.Add(row);
            row = dtTemp.NewRow();
            row["TenQuyen"] = "Quản lý";
            row["MaQuyen"] = "1";
            dtTemp.Rows.Add(row);

            cbbChucVu.DataSource = dtTemp;
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
                FormMessage.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                FormMessage.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaNV = dgvNhanVien.SelectedRows[0].Cells["colMaNhanVien"].Value.ToString();
            frmThemSuaNV frm = new frmThemSuaNV(MaNV);
            frm.suanhanvien += XuLySuaNhanVien;
            frm.ShowDialog();
        }

        private void XuLySuaNhanVien(clsNhanVien_DTO nhanvien)
        {
            if (bus.SuaNhanVien(nhanvien))
            {
                FormMessage.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                FormMessage.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected string LenhTimKiem()
        {

            string lenh = "TrangThai=1";
            if (cbTenNV.Checked == true)
            {
                lenh += string.Format(" and TenNhanVien like '%{0}%'", txtTenNV.Text);
            }


            if (cbChucVu.Checked == true)
            {
              
                lenh += string.Format("and  Quyen='{0}'", cbbChucVu.SelectedValue.ToString());
            }
            return lenh;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string len = LenhTimKiem();
            dav.RowFilter = string.Format(len);
            loaddgvNhanVien();
        }
      
        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "colQuyen")
            {
                if (e.Value.ToString() == "1")
                {
                    e.Value = "Quản lý";
                }
                else
                {
                    e.Value = "Nhân viên";
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                if (FormMessage.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string MaNV = dgvNhanVien.SelectedRows[0].Cells["colMaNhanVien"].Value.ToString();
                    if (bus.XoaNhanVien(MaNV))
                    {
                        FormMessage.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        FormMessage.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                FormMessage.Show("vui lòng chọn nnhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            
        }
    }
}
