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
    public partial class ucNhanVien : UserControl
    {
        private static ucNhanVien _instance = null;
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
    }
}
