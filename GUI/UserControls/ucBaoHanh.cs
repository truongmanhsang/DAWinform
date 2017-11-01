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
    public partial class ucBaoHanh : UserControl
    {
        private static ucBaoHanh _instance = null;
        public static ucBaoHanh GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucBaoHanh();
                }
                return _instance;
            }
        }
        public ucBaoHanh()
        {
            InitializeComponent();
        }
    }
}
