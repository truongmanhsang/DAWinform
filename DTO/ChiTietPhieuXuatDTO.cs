using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuXuatDTO
    {
        private string _maPhieuXuat;
        private string _maSanPham;
        private int _soLuong;
        private long _gia;
        private string _maSerial;

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

        public string MaSerial
        {
            get
            {
                return _maSerial;
            }

            set
            {
                _maSerial = value;
            }
        }
    }
}
