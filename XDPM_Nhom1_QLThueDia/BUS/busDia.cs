using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using ENTITTY;

namespace BUS
{
    public class busDia
    {
        dalDia dalDIA = new dalDia();
        public int updateTrangThaiDiaChoDatTruoc(string madia)
        {
            return dalDIA.updateTrangThaiDiaChoDatTruoc(madia);
        }
        public int updateTrangThaiDiaTra(string madia)
        {
            return dalDIA.updateTrangThaiDiaTra(madia);
        }
    }
}
