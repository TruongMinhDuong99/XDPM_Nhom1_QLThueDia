using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;

namespace DATA
{
    public class dalDia
    {
        BangDiaDataClassesDataContext db = new BangDiaDataClassesDataContext();
        public int updateTrangThaiDiaChoDatTruoc(string madia)
        {
            Dia d = db.Dias.Where(x => x.MaDia == madia).FirstOrDefault();
            if (d == null)
                return 0;
            d.TrangThaiDia = "Đã đặt";
            db.SubmitChanges();
            return 1;
        }
        public int updateTrangThaiDiaTra(string madia)
        {
            Dia d = db.Dias.Where(x => x.MaDia == madia).FirstOrDefault();
            if (d == null)
                return 0;
            d.TrangThaiDia = "Trên kệ";
            db.SubmitChanges();
            return 1;
        }
    }
}
