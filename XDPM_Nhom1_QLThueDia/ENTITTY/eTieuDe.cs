using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITTY
{
    public class eTieuDe
    {
        public eTieuDe(string maTieuDe, string tenTieuDe, string nhaSanXuat, string maLoaiDia)
        {
            this.maTieuDe = maTieuDe;
            this.tenTieuDe = tenTieuDe;
            this.nhaSanXuat = nhaSanXuat;
            this.maLoaiDia = maLoaiDia;
        }
        public eTieuDe() { }

        public string maTieuDe { get; set; }
        public string tenTieuDe { get; set; }
        public string nhaSanXuat { get; set; }
        public string maLoaiDia { get; set; }
    }
}
