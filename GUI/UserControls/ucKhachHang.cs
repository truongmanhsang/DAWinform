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
    public partial class ucKhachHang : UserControl
    {
        KhachHangBUS bus = new KhachHangBUS();
        DataTable dt = new DataTable();
        DataView dav;
        public ucKhachHang()
        {
            InitializeComponent();
        }

        private void ucKhachHang_Load(object sender, EventArgs e)
        {
            dt = bus.LayBangKhachHang();
            dav = new DataView(dt);
            dgvKhachHang.AutoGenerateColumns = false;

        }

        private void CaiDat()
        {
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

    }
}
