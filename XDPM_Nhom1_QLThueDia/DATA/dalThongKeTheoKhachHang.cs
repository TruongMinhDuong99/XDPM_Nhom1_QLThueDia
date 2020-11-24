using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;

namespace DATA
{
    public class dalThongKeTheoKhachHang
    {
        BangDiaDataClassesDataContext db;
        public dalThongKeTheoKhachHang()
        {
            db = new BangDiaDataClassesDataContext();
        }
        public List<eKhachHang> XemThongTinKhachHang(int loai)
        {
            List<KhachHang> list = new List<KhachHang>();
            List<eKhachHang> list1 = new List<eKhachHang>();
            if (loai == 0)
            {
                list = db.KhachHangs.ToList();
            }
            else if (loai == 1)
            {
                list = (from kh in db.KhachHangs
                        join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                        where (pt.NgayTra>pt.NgayHenTra || (DateTime.Now>pt.NgayHenTra && pt.NgayTra==null) )
                        group kh by kh into g
                        select g.Key).ToList();
            }
            else if (loai == 2)
            {
                list = (from kh in db.KhachHangs
                        join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                        where (pt.PhiTraMuon > 0)
                        group kh by kh into g
                        select g.Key).ToList();
            }
            foreach (KhachHang e in list)
            {
                eKhachHang tam = new eKhachHang();
                tam.maKhachHang = e.MaKhachHang;
                tam.hoTen = e.HoTen;
                tam.diaChi = e.DiaChi;
                tam.sDT = e.SDT;
                list1.Add(tam);
            }
            return list1;
        }
        public List<eThongKeDiaDangThue> ThongKeDiaDangThue(int loai)
        {
            List<eThongKeDiaDangThue> list1 = new List<eThongKeDiaDangThue>();
            if (loai == 0)
            {
                var list = (from kh in db.KhachHangs 
                        join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                            where (pt.TrangThaiThue.Equals("Đang thuê"))
                            group pt by new { kh.MaKhachHang,kh.HoTen,kh.DiaChi,kh.SDT } into g
                            orderby g.Count(k => Convert.ToBoolean(k.MaKhachHang.Count())) descending
                            select new
                            {
                                g.Key.MaKhachHang,
                                g.Key.HoTen,
                                g.Key.DiaChi,
                                g.Key.SDT,
                                SoLuong = g.Count(k => Convert.ToBoolean(k.MaThue.Count()))
                            }).ToList();
                foreach (var e in list)
                {
                    eThongKeDiaDangThue tam = new eThongKeDiaDangThue();
                    tam.maKhachHang = e.MaKhachHang;
                    tam.hoTen = e.HoTen;
                    tam.diaChi = e.DiaChi;
                    tam.sDT = e.SDT;
                    tam.soLuong = e.SoLuong;
                    list1.Add(tam);
                }
            }
            else if (loai == 1)
            {
                var list = (from kh in db.KhachHangs
                        join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                            where (pt.NgayTra > pt.NgayHenTra || (DateTime.Now > pt.NgayHenTra && pt.NgayTra == null))
                            where (pt.TrangThaiThue.Equals("Đang thuê"))
                            group pt by new { kh.MaKhachHang, kh.HoTen, kh.DiaChi, kh.SDT } into g
                            orderby g.Count(k => Convert.ToBoolean(k.MaKhachHang.Count())) descending
                            select new
                            {
                                g.Key.MaKhachHang,
                                g.Key.HoTen,
                                g.Key.DiaChi,
                                g.Key.SDT,
                                SoLuong = g.Count(k => Convert.ToBoolean(k.MaThue.Count()))
                            }).ToList();
                foreach (var e in list)
                {
                    eThongKeDiaDangThue tam = new eThongKeDiaDangThue();
                    tam.maKhachHang = e.MaKhachHang;
                    tam.hoTen = e.HoTen;
                    tam.diaChi = e.DiaChi;
                    tam.sDT = e.SDT;
                    tam.soLuong = e.SoLuong;
                    list1.Add(tam);
                }
            }
            else if (loai == 2)
            {
                var list = (from kh in db.KhachHangs
                        join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                        where (pt.PhiTraMuon > 0)
                        where (pt.TrangThaiThue.Equals("Đang thuê"))
                            group pt by new { kh.MaKhachHang, kh.HoTen, kh.DiaChi, kh.SDT } into g
                            orderby g.Count(k => Convert.ToBoolean(k.MaKhachHang.Count())) descending
                            select new
                            {
                                g.Key.MaKhachHang,
                                g.Key.HoTen,
                                g.Key.DiaChi,
                                g.Key.SDT,
                                SoLuong = g.Count(k => Convert.ToBoolean(k.MaThue.Count()))
                            }).ToList();
                foreach (var e in list)
                {
                    eThongKeDiaDangThue tam = new eThongKeDiaDangThue();
                    tam.maKhachHang = e.MaKhachHang;
                    tam.hoTen = e.HoTen;
                    tam.diaChi = e.DiaChi;
                    tam.sDT = e.SDT;
                    tam.soLuong = e.SoLuong;
                    list1.Add(tam);
                }
            }           
            return list1;
        }
        public List<eThongKeDiaTraTre> ThongKeDiaTraTre(int loai)
        {
            List<eThongKeDiaTraTre> list1 = new List<eThongKeDiaTraTre>();
            if (loai == 0)
            {
                var list = (from kh in db.KhachHangs
                            join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                            join d in db.Dias on pt.MaDia equals d.MaDia
                            join td in db.TieuDes on d.MaTieuDe equals td.MaTieuDe
                            where (pt.NgayTra > pt.NgayHenTra || (DateTime.Now > pt.NgayHenTra && pt.NgayTra == null))
                            select new
                            {
                                kh.MaKhachHang,
                                kh.HoTen,
                                kh.DiaChi,
                                kh.SDT,
                                td.TenTieuDe,
                                d.TenDia,
                                pt.NgayHenTra
                            }).ToList();
                foreach (var e in list)
                {
                    eThongKeDiaTraTre tam = new eThongKeDiaTraTre();
                    tam.maKhachHang = e.MaKhachHang;
                    tam.hoTen = e.HoTen;
                    tam.diaChi = e.DiaChi;
                    tam.sDT = e.SDT;
                    tam.tenTieuDe = e.TenTieuDe;
                    tam.tenDia = e.TenDia;
                    tam.ngayHenTra = Convert.ToDateTime(e.NgayHenTra.ToString("yyyy/MM/dd"));
                    list1.Add(tam);
                }
            }
            else if (loai == 1)
            {
                var list = (from kh in db.KhachHangs
                            join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                            join d in db.Dias on pt.MaDia equals d.MaDia
                            join td in db.TieuDes on d.MaTieuDe equals td.MaTieuDe
                            where (pt.NgayTra > pt.NgayHenTra || (DateTime.Now > pt.NgayHenTra && pt.NgayTra == null))
                            select new
                            {
                                kh.MaKhachHang,
                                kh.HoTen,
                                kh.DiaChi,
                                kh.SDT,
                                td.TenTieuDe,
                                d.TenDia,
                                pt.NgayHenTra
                            }).ToList();
                foreach (var e in list)
                {
                    eThongKeDiaTraTre tam = new eThongKeDiaTraTre();
                    tam.maKhachHang = e.MaKhachHang;
                    tam.hoTen = e.HoTen;
                    tam.diaChi = e.DiaChi;
                    tam.sDT = e.SDT;
                    tam.tenTieuDe = e.TenTieuDe;
                    tam.tenDia = e.TenDia;
                    tam.ngayHenTra = Convert.ToDateTime(e.NgayHenTra.ToString("yyyy/MM/dd"));
                    list1.Add(tam);
                }
            }
            else if (loai == 2)
            {
                var list = (from kh in db.KhachHangs
                            join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                            join d in db.Dias on pt.MaDia equals d.MaDia
                            join td in db.TieuDes on d.MaTieuDe equals td.MaTieuDe
                            where (pt.PhiTraMuon > 0)
                            where (pt.NgayTra > pt.NgayHenTra || (DateTime.Now > pt.NgayHenTra && pt.NgayTra == null))
                            select new
                            {
                                kh.MaKhachHang,
                                kh.HoTen,
                                kh.DiaChi,
                                kh.SDT,
                                td.TenTieuDe,
                                d.TenDia,
                                pt.NgayHenTra
                            }).ToList();
                foreach (var e in list)
                {
                    eThongKeDiaTraTre tam = new eThongKeDiaTraTre();
                    tam.maKhachHang = e.MaKhachHang;
                    tam.hoTen = e.HoTen;
                    tam.diaChi = e.DiaChi;
                    tam.sDT = e.SDT;
                    tam.tenTieuDe = e.TenTieuDe;
                    tam.tenDia = e.TenDia;
                    tam.ngayHenTra = Convert.ToDateTime(e.NgayHenTra.ToString("yyyy/MM/dd"));
                    list1.Add(tam);
                }
            }
            return list1;
        }
        public List<eThongKeNoCuaKhachHang> ThongKeNoCuaKhachHang(string maKH)
        {
            List<eThongKeNoCuaKhachHang> list1 = new List<eThongKeNoCuaKhachHang>();
                var list = (from kh in db.KhachHangs
                            join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                            join d in db.Dias on pt.MaDia equals d.MaDia
                            join td in db.TieuDes on d.MaTieuDe equals td.MaTieuDe
                            where (pt.PhiTraMuon > 0)
                            where (pt.MaKhachHang.Equals(maKH))
                            select new
                            {
                                td.TenTieuDe,
                                d.TenDia,
                                pt.NgayHenTra,
                                pt.NgayTra,
                                pt.PhiTraMuon
                            }).ToList();
                foreach (var e in list)
                {
                    eThongKeNoCuaKhachHang tam = new eThongKeNoCuaKhachHang();
                    tam.tenTieuDe = e.TenTieuDe;
                    tam.tenDia = e.TenDia;
                    tam.ngayHenTra = Convert.ToDateTime(e.NgayHenTra.ToString("yyyy/MM/dd"));
                    tam.ngayTra = Convert.ToDateTime(e.NgayTra);
                    tam.phiTraMuon =Convert.ToDouble(e.PhiTraMuon);
                    list1.Add(tam);
                }
            return list1;
        }
        public List<eKhachHang> LayDanhSachKhachHangNo(int loai)
        {
            List<KhachHang> list = new List<KhachHang>();
            List<eKhachHang> list1 = new List<eKhachHang>();
            if (loai == 0)
            {
                list = (from kh in db.KhachHangs
                        join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                        where (pt.PhiTraMuon > 0)
                        group kh by kh into g
                        select g.Key).ToList();
            }
            else if (loai == 1)
            {
                list = (from kh in db.KhachHangs
                        join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                        where (pt.PhiTraMuon > 0)
                        where (pt.NgayTra > pt.NgayHenTra || (DateTime.Now > pt.NgayHenTra && pt.NgayTra == null))
                        group kh by kh into g
                        select g.Key).ToList();
            }
            else if (loai == 2)
            {
                list = (from kh in db.KhachHangs
                        join pt in db.PhieuThues on kh.MaKhachHang equals pt.MaKhachHang
                        where (pt.PhiTraMuon > 0)
                        group kh by kh into g
                        select g.Key).ToList();
            }
            foreach (KhachHang e in list)
            {
                eKhachHang tam = new eKhachHang();
                tam.maKhachHang = e.MaKhachHang;
                tam.hoTen = e.HoTen;
                tam.diaChi = e.DiaChi;
                tam.sDT = e.SDT;
                list1.Add(tam);
            }
            return list1;
        }
    }
}
