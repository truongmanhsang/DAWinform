using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsChiTietBaoHanh_DTO
    {
        private string _maBaoHanh;
        private string _maSerial;
        private string _ngayHenTra;
        private int _tinhTrang;
        private string _motaLoi;
        private string _ghiChu;

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

        public string NgayHenTra
        {
            get
            {
                return _ngayHenTra;
            }

            set
            {
                _ngayHenTra = value;
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

        public string MotaLoi
        {
            get
            {
                return _motaLoi;
            }

            set
            {
                _motaLoi = value;
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
    }
}
