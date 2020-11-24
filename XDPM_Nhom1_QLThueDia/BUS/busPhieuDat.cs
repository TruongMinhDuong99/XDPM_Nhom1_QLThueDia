using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;
using DATA;
 
namespace BUS
{
    public class busPhieuDat
    {
        dalPhieuDat dalDT;
        public busPhieuDat()
        {
            dalDT = new dalPhieuDat();
        }
        public List<eTieuDe> LayDanhSachTieuDeDuocDat(string maKH)
        {
            return dalDT.LayDanhSachTieuDeDuocDat(maKH);
        }
        public int ThemDatTruoc(ePhieuDat input)
        {
            return dalDT.ThemDatTruoc(input);
        }
        public string PhatSinhDatTruoc()
        {
            return dalDT.PhatSinhDatTruoc();
        }
        public List<eKhachHang> layDanhSachKhachHangDaDatTruoc()
        {
            return dalDT.layDanhSachKhachHangDaDatTruoc();
        }
        public List<eTieuDe> LayDanhSachTieuDeDaDatTruocCuaKhach(string maKH)
        {
            return dalDT.LayDanhSachTieuDeDaDatTruocCuaKhach(maKH);
        }
        public bool XoaDatTruoc(string maKH, string maTD)
        {
            return dalDT.XoaDatTruoc(maKH,maTD);
        }
    }
}
