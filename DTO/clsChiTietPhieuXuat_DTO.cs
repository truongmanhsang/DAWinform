using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietPhieuXuat_DTO
    {
        private string _maPhieuXuat;
        private string _maSanPham;
        private int _soLuong;
        private long _gia;

        public string MaPhieuXuat
        {
            get
            {
                return _maPhieuXuat;
            }

            set
            {
                _maPhieuXuat = value;
            }
        }

        public string MaSanPham
        {
            get
            {
                return _maSanPham;
            }

            set
            {
                _maSanPham = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }

        public long Gia
        {
            get
            {
                return _gia;
            }

            set
            {
                _gia = value;
            }
        }
    }
}
