﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITTY;

namespace DATA
{
    public class dalPhieuDat
    {
        BangDiaDataClassesDataContext db;
        public dalPhieuDat()
        {
            db = new BangDiaDataClassesDataContext();
        }
        public List<eTieuDe> LayDanhSachTieuDeDuocDat(string maKH)
        {
            
            List<eTieuDe> listTD = new List<eTieuDe>();
            var k = db.KhachHangs.Where(x => x.MaKhachHang.Equals(maKH)).ToList();
            if (k.Count > 0)
            {
                var list = (from td in db.TieuDes join d in db.Dias on td.MaTieuDe equals d.MaTieuDe
                               join ld in db.LoaiDias on td.MaLoaiDia equals ld.MaLoaiDia
                               where(!d.TrangThaiDia.Equals("Sẵn sàng"))

                            select new
                               {
                                
                                td.MaTieuDe,
                                td.TenTieuDe,
                                td.NhaSanXuat,
                                ld.TenLoaiDia
                               });
                foreach (var e in list)
                {
                    eTieuDe tam = new eTieuDe();                   
                        tam.MaTieuDe = e.MaTieuDe;
                        tam.TenTieuDe = e.TenTieuDe;
                        tam.NhaSanXuat = e.NhaSanXuat;
                        tam.MaLoaiDia = e.TenLoaiDia;                                                         
                    listTD.Add(tam);
                }
                return listTD;
            }
            else
                {
                    return null;
                }
        }
        public int ThemDatTruoc(ePhieuDat input)
        {
            try
            {
                var td = db.PhieuDats.Where(x => x.MaTieuDe.Equals(input.MaTieuDe)).Where(y=>y.MaKhachHang.Equals(input.MaKhachHang)).ToList();
                if (td.Count <=0)
                {
                    PhieuDat pt = new PhieuDat();
                    pt.MaDat = PhatSinhDatTruoc();
                    pt.NgayDat = input.NgayDat;
                    pt.TrangThai = "Đang đặt";
                    pt.MaKhachHang = input.MaKhachHang;
                    pt.MaTieuDe = input.MaTieuDe;
                    pt.MaDia = input.MaDia;
                    db.PhieuDats.InsertOnSubmit(pt);
                    db.SubmitChanges();
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
        public string PhatSinhDatTruoc()
        {
            int n = 0;
            string str = "PD";
            PhieuDat dt = db.PhieuDats.ToList().LastOrDefault();
            if (dt != null)
            {
                string str1 = dt.MaDat.Substring(2);
                n = int.Parse(str1) + 1;
                if (n < 10)
                {
                    str = str + "000" + n.ToString();
                }
                else if (n < 100)
                {
                    str = str + "00" + n.ToString();
                }
                else if (n < 1000)
                {
                    str = str + "0" + n.ToString();
                }
                else if (n < 10000)
                {
                    str = str + n.ToString();
                }
            }
            else
            {
                str = "PD0001";
            }
            
            return str;
        }
        public List<eKhachHang> layDanhSachKhachHangDaDatTruoc()
        {
            List<eKhachHang> listKH = new List<eKhachHang>();
            var list = (from kh in db.KhachHangs
                        join pd in db.PhieuDats on kh.MaKhachHang equals pd.MaKhachHang
                        group kh by new
                        {
                            kh.MaKhachHang,
                            kh.HoTen,
                            kh.DiaChi,
                            kh.SDT,
                        } into g
                        select g).ToList();
            foreach (var e in list)
            {
                eKhachHang tam = new eKhachHang();
                tam.Makh = e.Key.MaKhachHang;
                tam.Tenkh= e.Key.HoTen;
                tam.Diachi = e.Key.DiaChi;
                tam.Sodt = e.Key.SDT;
                listKH.Add(tam);
            }
            return listKH;
        }
        public List<eTieuDe> LayDanhSachTieuDeDaDatTruocCuaKhach(string maKH)
        {
            List<eTieuDe> listTD = new List<eTieuDe>();
            var list = (from td in db.TieuDes
                        join pd in db.PhieuDats on td.MaTieuDe equals pd.MaTieuDe
                        join ld in db.LoaiDias on td.MaLoaiDia equals ld.MaLoaiDia
                        where (pd.MaKhachHang.Equals(maKH))
                        group td by new
                        {
                            td.MaTieuDe,
                            td.TenTieuDe,
                            td.NhaSanXuat,
                            ld.TenLoaiDia,
                        } into g

                        select new
                        {
                            g.Key.MaTieuDe,
                            g.Key.TenTieuDe,
                            g.Key.NhaSanXuat,
                            g.Key.TenLoaiDia,
                        });
            foreach (var e in list)
            {
                eTieuDe tam = new eTieuDe();
                tam.MaTieuDe = e.MaTieuDe;
                tam.TenTieuDe = e.TenTieuDe;
                tam.NhaSanXuat = e.NhaSanXuat;
                tam.MaLoaiDia = e.TenLoaiDia;
                listTD.Add(tam);
            }
            return listTD;
        }
        public bool XoaDatTruoc(string maKH,string maTD)
        {
            var dt = db.PhieuDats.Where(x => x.MaKhachHang == maKH).Where(y => y.MaTieuDe == maTD).ToList();
            if (dt.Count > 0)
            {
                db.PhieuDats.DeleteAllOnSubmit(dt);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public int updateGanDiaChoPhieuDatTruoc(string maphieu, string madia)
        {
            PhieuDat pd = db.PhieuDats.Where(x => x.MaDat.Equals(maphieu)).FirstOrDefault();
            if (pd == null)
                return 0;
            pd.MaDia = madia;
            pd.TrangThai = "Đã có đĩa";
            db.SubmitChanges();
            return 1;
        }
        public List<ePhieuDat> layDanhSachPhieuDatTheoTieuDeDat(string matd)
        {
            List<PhieuDat> l = db.PhieuDats.Where(x => x.MaTieuDe == matd && x.TrangThai == "Đang đặt").OrderBy(x => x.NgayDat).ToList();
            List<ePhieuDat> lstPhieuDatLay = new List<ePhieuDat>();
            foreach (var item in l)
            {
                ePhieuDat phieu = new ePhieuDat();
                //phieu.Madia = item.madianew;
                phieu.MaTieuDe = item.MaTieuDe;
                phieu.MaDia = item.MaDia;
                phieu.MaKhachHang = item.MaKhachHang;
                phieu.MaPhieuDat = item.MaDat;
                phieu.NgayDat = item.NgayDat;
                phieu.TrangThai = item.TrangThai;
                lstPhieuDatLay.Add(phieu);
            }
            return lstPhieuDatLay;
        }
        public ePhieuDat layPhieuDatTheoMa(string maphieudat)
        {
            PhieuDat pd = db.PhieuDats.Where(x => x.MaDat.Equals(maphieudat)).FirstOrDefault();
            ePhieuDat phieu = new ePhieuDat();
            phieu.MaTieuDe = pd.MaTieuDe;
            phieu.MaDia = pd.MaDia;
            phieu.MaKhachHang = pd.MaKhachHang;
            phieu.MaPhieuDat = pd.MaDat;
            phieu.NgayDat = pd.NgayDat;
            phieu.TrangThai = pd.TrangThai;
            return phieu;
        }
        public int xoaDatTruoc(string maphieu)
        {
            PhieuDat pd = db.PhieuDats.Where(x => x.MaDat.Equals(maphieu)).FirstOrDefault();
            if (pd == null)
                return 0;
            db.PhieuDats.DeleteOnSubmit(pd);
            db.SubmitChanges();
            return 1;
        }
        public eDia layDiaGanDatTruoc(string maKH, string maTD)
        {
            var dia = (from pd in db.PhieuDats join d in db.Dias on pd.MaDia equals d.MaDia
                where(pd.MaKhachHang.Equals(maKH) && pd.MaTieuDe.Equals(maTD) &&
             pd.TrangThai.Equals("Đã có đĩa")) select d).FirstOrDefault();
            eDia tam = new eDia();
            tam.Matieude = dia.MaTieuDe;
            tam.Madia = dia.MaDia;
            tam.Trangthaidia = dia.TrangThaiDia;
            tam.Tendia = dia.TenDia;
            return tam;
        }
        public List<ePhieuDat> LayDanhSachPhieuDat_TheoMaKhachHang_DaCoDia(string makh)
        {
            List<ePhieuDat> lst = new List<ePhieuDat>();
            List<PhieuDat> dsdat = db.PhieuDats.Where(x => x.MaKhachHang.Equals(makh) && x.TrangThai.Equals("Đã có đĩa")).ToList();
            foreach (var item in dsdat)
            {
                ePhieuDat phieu = new ePhieuDat();
                phieu.MaPhieuDat = item.MaDat;
                phieu.NgayDat = item.NgayDat;
                phieu.TrangThai = item.TrangThai;
                phieu.MaKhachHang = item.MaKhachHang;
                phieu.MaTieuDe = item.MaTieuDe;
                phieu.MaDia = item.MaDia;
                lst.Add(phieu);
            }
            return lst;
        }
        public eThongKeYeuCauDat ThongKeSoLuongDiaYeuCauDat(eTieuDe tieuDe)
        {
            var listphieudat = db.PhieuDats.Where(x => x.MaTieuDe.Equals(tieuDe.MaTieuDe)).ToList();
            var listdia = db.Dias.Where(x => x.MaTieuDe.Equals(tieuDe.MaTieuDe)).ToList();
            List<PhieuDat> listSLDaDuocDat = new List<PhieuDat>();
            List<PhieuDat> listSLChuaDuocTra = new List<PhieuDat>();
            foreach (PhieuDat pd in listphieudat)
            {
                if (pd.MaDia != null)
                    listSLDaDuocDat.Add(pd);
                else
                    listSLChuaDuocTra.Add(pd);
            }
            eThongKeYeuCauDat etk = new eThongKeYeuCauDat();
            etk.TenTieuDe = tieuDe.TenTieuDe;
            etk.SoLuongYeuCau = listphieudat.Count();
            etk.TongSoLuongDia = listdia.Count();
            etk.SoLuongDiaDaDuocDat = listSLDaDuocDat.Count;
            etk.SoLuongDiaChuaDuocDat = listSLChuaDuocTra.Count;
            return etk;
        }
    }
}
