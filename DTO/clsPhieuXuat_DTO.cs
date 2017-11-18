using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsPhieuXuat_DTO
    {
        private string _maPhieuXuat;
        private string _maKhachHang;
        private decimal _tongTien;
        private float _chietKhau;
        private float _thue;
        private string _ngayLap;
        private string _maNVLap;
        private string _ghiChu;
        private int _loai;
        private int _trangThai;

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

        public float ChietKhau
        {
            get
            {
                return _chietKhau;
            }

            set
            {
                _chietKhau = value;
            }
        }

        public float Thue
        {
            get
            {
                return _thue;
            }

            set
            {
                _thue = value;
            }
        }

        public string NgayLap
        {
            get
            {
                return _ngayLap;
            }

            set
            {
                _ngayLap = value;
            }
        }

        public string MaNVLap
        {
            get
            {
                return _maNVLap;
            }

            set
            {
                _maNVLap = value;
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

        public int Loai
        {
            get
            {
                return _loai;
            }

            set
            {
                _loai = value;
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
