using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsPhieuNhap_DTO
    {
        private string _maPhieuNhap;
        private string _maNhaCungCap;
        private decimal _tongTien;
        private decimal _tienNo;
        private float _chietKhau;
        private float _thue;
        private string _ngayLap;
        private string _maNVLap;
        private string _ghiChu;
        private int _tinhTrang;
        private int _trangThai;

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

        public decimal TienNo
        {
            get
            {
                return _tienNo;
            }

            set
            {
                _tienNo = value;
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

        public int TinhTrang
        {
            get
            {
                return _tinhTrang;
            }

            set
            {
                _tinhTrang = value;
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
