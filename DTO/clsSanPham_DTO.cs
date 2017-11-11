using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsSanPham_DTO
    {
        private string _maSanPham;
        private string _tenSanPham;
        private string _hinh;
        private decimal _giaMua;
        private decimal _giaBan;
        private decimal _khuyenMai;
        private string _moTa;
        private int _baoHanh;
        private int _soLuong;
        private string _donViTinh;
        private string _maLoaiSanPham;
        private string _maHangSanXuat;
        private string _ghiChu;
        private int _trangThai;

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

        public string TenSanPham
        {
            get
            {
                return _tenSanPham;
            }

            set
            {
                _tenSanPham = value;
            }
        }

        public string Hinh
        {
            get
            {
                return _hinh;
            }

            set
            {
                _hinh = value;
            }
        }

        public decimal GiaMua
        {
            get
            {
                return _giaMua;
            }

            set
            {
                _giaMua = value;
            }
        }

        public decimal GiaBan
        {
            get
            {
                return _giaBan;
            }

            set
            {
                _giaBan = value;
            }
        }

        public decimal KhuyenMai
        {
            get
            {
                return _khuyenMai;
            }

            set
            {
                _khuyenMai = value;
            }
        }

        public string MoTa
        {
            get
            {
                return _moTa;
            }

            set
            {
                _moTa = value;
            }
        }

        public int BaoHanh
        {
            get
            {
                return _baoHanh;
            }

            set
            {
                _baoHanh = value;
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

        public string DonViTinh
        {
            get
            {
                return _donViTinh;
            }

            set
            {
                _donViTinh = value;
            }
        }

        public string MaLoaiSanPham
        {
            get
            {
                return _maLoaiSanPham;
            }

            set
            {
                _maLoaiSanPham = value;
            }
        }

        public string MaHangSanXuat
        {
            get
            {
                return _maHangSanXuat;
            }

            set
            {
                _maHangSanXuat = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }

            set
            {
                _ghiChu = value;
            }
        }

        public int TrangThai
        {
            get
            {
                return _trangThai;
            }

            set
            {
                _trangThai = value;
            }
        }
    }
}
