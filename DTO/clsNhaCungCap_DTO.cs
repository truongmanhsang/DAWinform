using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsNhaCungCap_DTO
    {
        private string _maNhaCungCap;
        private string _tenNhaCungCap;
        private string _soDT;
        private string _diaChi;
        private string _ghiChu;
        private string _trangThai;

        public string MaNhaCungCap
        {
            get
            {
                return _maNhaCungCap;
            }

            set
            {
                _maNhaCungCap = value;
            }
        }

        public string TenNhaCungCap
        {
            get
            {
                return _tenNhaCungCap;
            }

            set
            {
                _tenNhaCungCap = value;
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
