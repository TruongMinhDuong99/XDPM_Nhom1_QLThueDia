using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITTY;

namespace BUS
{
    public class busTieuDe
    {
        dalTieuDe dalTD;
        public busTieuDe()
        {
            dalTD = new dalTieuDe();
        }
        public List<eTieuDe> LayDanhSachieuDe()
        {
            return dalTD.LayDanhSachieuDe();
        }
        public int KiemTraDiaTrongTieuDe(string maTD)
        {
            return dalTD.KiemTraDiaTrongTieuDe(maTD);
        }
        public List<eTieuDe> TimKiemTieuDeTheoTen(string tenTD)
        {
            return dalTD.TimKiemTieuDeTheoTen(tenTD);
        }
    }
}
