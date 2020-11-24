using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITTY
{
    public class eDia
    {
        public eDia(string maDia, string tenDia, string trangThaiDia, string maTieuDe)
        {
            this.maDia = maDia;
            this.tenDia = tenDia;
            this.trangThaiDia = trangThaiDia;
            this.maTieuDe = maTieuDe;
        }
        public eDia() { }
        public string maDia { get; set; }
        public string tenDia { get; set; }
        public string trangThaiDia { get; set; }
        public string maTieuDe { get; set; }
    }
}
