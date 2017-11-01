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
    public partial class ucNhapHang : UserControl
    {
        private static ucNhapHang _instance = null;
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

        }
    }
}
