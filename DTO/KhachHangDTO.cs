using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string _maKhachHang;
        private string _tenKhachHang;
        private string _cMND;
        private string _soDT;
        private string _diaChi;
        private string _ghiChu;
        private string _trangThai;

        public string MaKhachHang
        {
            get
            {
                return _maKhachHang;
            }

            set
            {
                _maKhachHang = value;
            }
        }

        public string TenKhachHang
        {
            get
            {
                return _tenKhachHang;
            }

            set
            {
                _tenKhachHang = value;
            }
        }

        public string CMND
        {
            get
            {
                return _cMND;
            }

            set
            {
                _cMND = value;
            }
        }

        public string SoDT
        {
            get
            {
                return _soDT;
            }

            set
            {
                _soDT = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
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

        public string TrangThai
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
