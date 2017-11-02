﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO dao = new NhanVienDAO();
        public DataTable LayThongTinNV(string strTenDN)
        {
            return dao.LayThongTinNV(strTenDN);
        }
        public DataTable LayThongTinNV(string strTenDN, string strMatKhau)
        {
            return dao.LayThongTinNV(strTenDN, strMatKhau);
        }
    }
}