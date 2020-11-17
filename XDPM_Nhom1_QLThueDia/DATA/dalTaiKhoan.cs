﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;

namespace DATA
{
    public class dalTaiKhoan
    {
        eTaiKhoan eTK = new eTaiKhoan();
        BangDiaDataClassesDataContext db;
        public dalTaiKhoan()
        {
            db = new BangDiaDataClassesDataContext();
        }
        public bool DangNhap(eTaiKhoan input)
        {
            var listTK = db.TaiKhoans.ToList();
            foreach(TaiKhoan tam in listTK)
            {
                if(tam.TenDN==input.tenDN && tam.MatKhau == input.matKhau)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
