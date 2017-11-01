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
    public partial class ucHangHoa : UserControl
    {
        private static ucHangHoa _instance = null;
        public static ucHangHoa GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucHangHoa();
                }
                return _instance;
            }
        }
        public ucHangHoa()
        {
            InitializeComponent();
        }
    }
}
