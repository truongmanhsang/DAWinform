using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsLoai_DTO
    {
        private string maLoaiSanPham;
        private string tenLoaiSanPham;
        private string ghiChu;

        public string MaLoaiSanPham
        {
            get
            {
                return maLoaiSanPham;
            }

            set
            {
                maLoaiSanPham = value;
            }
        }

        public string TenLoaiSanPham
        {
            get
            {
                return tenLoaiSanPham;
            }

            set
            {
                tenLoaiSanPham = value;
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
