using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITTY
{
    public class ePhieuDat
    {
        public ePhieuDat(string maDat, DateTime ngayDat, string trangThai, string maKhachHang, string maTieuDe,string maDia)
        {
            this.maDat = maDat;
            this.ngayDat = ngayDat;
            this.trangThai = trangThai;
            this.maKhachHang = maKhachHang;
            this.maTieuDe = maTieuDe;
            this.maDia = maDia;

        }
        public ePhieuDat() { }

        public string maDat { get; set; }
        public DateTime ngayDat { get; set; }
        public string trangThai { get; set; }
        public string maKhachHang { get; set; }
        public string maTieuDe { get; set; }
        public string maDia { get; set; }
    }
}
