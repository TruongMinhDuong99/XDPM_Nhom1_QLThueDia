using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITTY;

namespace BUS
{
    public class busKhachHang
    {
        dalKhachHang dalKH = new dalKhachHang();
        public eKhachHang layKhachHangTheoMaKhachHang(string ma)
        {
            return dalKH.layKhachHangTheoMaKhachHang(ma);
        }
    }
}
