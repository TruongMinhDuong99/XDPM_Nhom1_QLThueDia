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
                               where(!d.TrangThaiDia.Equals("Trên kệ"))
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
                        tam.maTieuDe = e.MaTieuDe;
                        tam.tenTieuDe = e.TenTieuDe;
                        tam.nhaSanXuat = e.NhaSanXuat;
                        tam.maLoaiDia = e.TenLoaiDia;                                                         
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
                var td = db.PhieuDats.Where(x => x.MaTieuDe.Equals(input.maTieuDe)).Where(y=>y.MaKhachHang.Equals(input.maKhachHang)).ToList();
                if (td.Count <=0)
                {
                    PhieuDat pt = new PhieuDat();
                    pt.MaDat = PhatSinhDatTruoc();
                    pt.NgayDat = input.ngayDat;
                    pt.TrangThai = "Đặt trước";
                    pt.MaKhachHang = input.maKhachHang;
                    pt.MaTieuDe = input.maTieuDe;
                    pt.MaDia = input.maDia;
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
                tam.maKhachHang = e.Key.MaKhachHang;
                tam.hoTen= e.Key.HoTen;
                tam.diaChi = e.Key.DiaChi;
                tam.sDT = e.Key.SDT;
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
                tam.maTieuDe = e.MaTieuDe;
                tam.tenTieuDe = e.TenTieuDe;
                tam.nhaSanXuat = e.NhaSanXuat;
                tam.maLoaiDia = e.TenLoaiDia;
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
    }
}