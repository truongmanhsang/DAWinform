using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNhanVien_DTO
    {
        private string _MaNV;
        private string _TenDangNhap;
        private string _TenNV;
        private string _MatKhau;
        private string _Hinh;
        private string _DiaChi;
        private string _CMND;
        private string _SDT;
        private string _Email;
        private int _Quyen;
        private string _GhiChu;
        private int _TrangThai;

        public string MaNV
        {
            get
            {
                return _MaNV;
            }

            set
            {
                this._MaNV = value;
            }
        }

        public string TenNV
        {
            get
            {
                return _TenNV;
            }

            set
            {
                this._TenNV = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }

            set
            {
                this._MatKhau = value;
            }
        }

        public string Hinh
        {
            get
            {
                return _Hinh;
            }

            set
            {
                this._Hinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                this._DiaChi = value;
            }
        }

        public string CMND
        {
            get
            {
                return _CMND;
            }

            set
            {
                this._CMND = value;
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                this._SDT = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                this._Email = value;
            }
        }

        public int Quyen
        {
            get
            {
                return _Quyen;
            }

            set
            {
                this._Quyen = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return _GhiChu;
            }

            set
            {
                this._GhiChu = value;
            }
        }

        public int TrangThai
        {
            get
            {
                return _TrangThai;
            }

            set
            {
                this._TrangThai = value;
            }
        }

        public string TenDangNhap
        {
            get
            {
                return _TenDangNhap;
            }

            set
            {
                this._TenDangNhap = value;
            }
        }
    }
}
