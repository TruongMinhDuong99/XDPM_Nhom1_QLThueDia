using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;

namespace DATA
{
    public class dalTieuDe
    {
        BangDiaDataClassesDataContext db;
        public dalTieuDe()
        {
            db = new BangDiaDataClassesDataContext();
        }
        public List<eTieuDe> LayDanhSachieuDe()
        {
            List<eTieuDe> listTD = new List<eTieuDe>();
            var list = (from td in db.TieuDes
                        join ld in db.LoaiDias on td.MaLoaiDia equals ld.MaLoaiDia
                        group td by new { td.MaTieuDe, td.TenTieuDe, td.NhaSanXuat, ld.TenLoaiDia } into g
                        select new { g.Key.MaTieuDe, g.Key.TenLoaiDia, g.Key.NhaSanXuat,g.Key.TenTieuDe });
            foreach(var e in list)
            {
                eTieuDe tam = new eTieuDe();
                tam.maTieuDe = e.MaTieuDe;
                tam.tenTieuDe = e.TenTieuDe;
                tam.nhaSanXuat = e.NhaSanXuat;
                tam.maLoaiDia = e.TenLoaiDia;
                listTD.Add(tam);
            }
            return listTD;
        }
        public int KiemTraDiaTrongTieuDe(string maTD)
        {
            int soLuong =db.Dias.Where(x=>x.MaTieuDe.Equals(maTD)).Where(y=>y.TrangThaiDia.Equals("Trên kệ")).Count();
            if (soLuong > 0)
            {
                return soLuong;
            }
            else
            {
                return 0;
            }
        }
        public List<eTieuDe> TimKiemTieuDeTheoTen(string tenTD)
        {
            List<eTieuDe> listTD = new List<eTieuDe>();
            var list = (from td in db.TieuDes
                        join ld in db.LoaiDias on td.MaLoaiDia equals ld.MaLoaiDia
                        where(td.TenTieuDe.Contains(tenTD))
                        select new { td.MaTieuDe, ld.TenLoaiDia, td.NhaSanXuat, td.TenTieuDe });
            foreach (var e in list)
            {
                eTieuDe tam = new eTieuDe();
                tam.maTieuDe = e.MaTieuDe;
                tam.tenTieuDe = e.TenTieuDe;
                tam.nhaSanXuat = e.NhaSanXuat;
                tam.maLoaiDia = e.TenLoaiDia;
                listTD.Add(tam);
            }
            return listTD;
        }
    }
}
