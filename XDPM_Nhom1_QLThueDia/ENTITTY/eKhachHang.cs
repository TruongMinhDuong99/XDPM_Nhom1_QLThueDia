using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITTY
{
    public class eKhachHang
    {
        public eKhachHang(string maKhachHang, string hoTen, string diaChi, string sDT)
        {
            this.maKhachHang = maKhachHang;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.sDT = sDT;
        }
        public eKhachHang()
        {
        }
        public string maKhachHang { get; set; }
        public string hoTen { get; set; }
        public string diaChi { get; set; }
        public string sDT { get; set; }
    }
}
