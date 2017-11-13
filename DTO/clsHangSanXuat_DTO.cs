using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsHangSanXuat_DTO
    {
        private string maHangSanXuat;
        private string tenHangSanXuat;
        private string ghiChu;

        public string MaHangSanXuat
        {
            get
            {
                return maHangSanXuat;
            }

            set
            {
                maHangSanXuat = value;
            }
        }

        public string TenHangSanXuat
        {
            get
            {
                return tenHangSanXuat;
            }

            set
            {
                tenHangSanXuat = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }
    }
}
