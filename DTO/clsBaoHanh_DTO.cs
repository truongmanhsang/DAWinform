using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsBaoHanh_DTO
    {
        private string _maBaoHanh;
        private string _maKhachHang;
        private string _maNhanVien;
        private string _ngayBaoHanh;
        private decimal _tongTien;
        private int _loaiBaoHanh;
        private int _trangThai;

        public string MaBaoHanh
        {
            get
            {
                return _maBaoHanh;
            }

            set
            {
                _maBaoHanh = value;
            }
        }

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

        public string MaNhanVien
        {
            get
            {
                return _maNhanVien;
            }

            set
            {
                _maNhanVien = value;
            }
        }

        public string NgayBaoHanh
        {
            get
            {
                return _ngayBaoHanh;
            }

            set
            {
                _ngayBaoHanh = value;
            }
        }

        public decimal TongTien
        {
            get
            {
                return _tongTien;
            }

            set
            {
                _tongTien = value;
            }
        }

        public int LoaiBaoHanh
        {
            get
            {
                return _loaiBaoHanh;
            }

            set
            {
                _loaiBaoHanh = value;
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
