using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucLoiNhuan : UserControl
    {
        ucLoiNhuanTongQuan _ucLoiNhuanTongQuan;
        public ucLoiNhuan()
        {
            InitializeComponent();
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            _ucLoiNhuanTongQuan = new ucLoiNhuanTongQuan();
            panMain.Controls.Add(_ucLoiNhuanTongQuan);
            _ucLoiNhuanTongQuan.Dock = DockStyle.Fill;
        }

        private void ucLoiNhuan_Load(object sender, EventArgs e)
        {
            panMain.Controls.Clear();
            _ucLoiNhuanTongQuan = new ucLoiNhuanTongQuan();
            panMain.Controls.Add(_ucLoiNhuanTongQuan);
            _ucLoiNhuanTongQuan.Dock = DockStyle.Fill;
        }
    }
}
