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
    public delegate void XuLyTimSoSerial();
    public partial class ucNhanBaoHanh : UserControl
    {
        public event XuLyTimSoSerial timSoSerial;
        public ucNhanBaoHanh()
        {
            InitializeComponent();
        }

        private void ucNhanBaoHanh_Load(object sender, EventArgs e)
        {

        }

        private void btnTimSoSerial_Click(object sender, EventArgs e)
        {
            timSoSerial();
        }
    }
}
