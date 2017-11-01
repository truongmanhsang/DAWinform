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
    public partial class ucThuChi : UserControl
    {
        private static ucThuChi _instance = null;
        public static ucThuChi GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucThuChi();
                }
                return _instance;
            }
        }
        public ucThuChi()
        {
            InitializeComponent();
        }
    }
}
