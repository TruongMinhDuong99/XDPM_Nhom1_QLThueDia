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
        dalPhieuDat dalPD;
        public busPhieuDat()
        {
            dalPD = new dalPhieuDat();
        }
        public List<eTieuDe> LayDanhSachTieuDeDuocDat(string maKH)
        {
            return dalPD.LayDanhSachTieuDeDuocDat(maKH);
        }
        public int ThemDatTruoc(ePhieuDat input)
        {
            return dalPD.ThemDatTruoc(input);
        }
        public string PhatSinhDatTruoc()
        {
            return dalPD.PhatSinhDatTruoc();
        }
        public List<eKhachHang> layDanhSachKhachHangDaDatTruoc()
        {
            return dalPD.layDanhSachKhachHangDaDatTruoc();
        }
        public List<eTieuDe> LayDanhSachTieuDeDaDatTruocCuaKhach(string maKH)
        {
            return dalPD.LayDanhSachTieuDeDaDatTruocCuaKhach(maKH);
        }
        public bool XoaDatTruoc(string maKH, string maTD)
        {
            return dalPD.XoaDatTruoc(maKH,maTD);
        }
        public int updateGanDiaChoPhieuDatTruoc(string maphieu, string madia)
        {
            return dalPD.updateGanDiaChoPhieuDatTruoc(maphieu, madia);
        }
        public List<ePhieuDat> layDanhSachPhieuDatTheoDiaTra(string matd)
        {
            return dalPD.layDanhSachPhieuDatTheoTieuDeDat(matd);
        }
        public ePhieuDat layPhieuDatTheoMa(string maphieudat)
        {
            return dalPD.layPhieuDatTheoMa(maphieudat);
        }
        public int xoaDatTruoc(string maphieu)
        {
            return dalPD.xoaDatTruoc(maphieu);
        }
        public eDia layDiaGanDatTruoc(string maKH, string maTD)
        {
            return dalPD.layDiaGanDatTruoc(maKH,maTD);
        }
    }
}
