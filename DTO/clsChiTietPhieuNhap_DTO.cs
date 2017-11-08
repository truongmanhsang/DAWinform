using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietPhieuNhap_DTO
    {
        private string _maPhieuNhap;
        private string _maSanPham;
        private int _soLuong;
        private long _gia;

        public string MaPhieuNhap
        {
            get
            {
                return _maPhieuNhap;
            }

            set
            {
                _maPhieuNhap = value;
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
