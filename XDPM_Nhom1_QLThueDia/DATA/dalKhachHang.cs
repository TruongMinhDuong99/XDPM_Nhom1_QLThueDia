using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;

namespace DATA
{
    public class dalKhachHang
    {
        BangDiaDataClassesDataContext db;
        public dalKhachHang()
        {
            db = new BangDiaDataClassesDataContext();
        }
        public eKhachHang layKhachHangTheoMaKhachHang(string makhachhang)
        {
            eKhachHang khachhang = new eKhachHang();
            KhachHang khtim = db.KhachHangs.Where(x => x.MaKhachHang == makhachhang).FirstOrDefault();
            if (khtim == null)
                return null;
            khachhang.maKhachHang = khtim.MaKhachHang;
            khachhang.hoTen = khtim.HoTen;
            khachhang.diaChi = khtim.DiaChi;
            khachhang.sDT = khtim.SDT;
            return khachhang;
        }

    }

}
