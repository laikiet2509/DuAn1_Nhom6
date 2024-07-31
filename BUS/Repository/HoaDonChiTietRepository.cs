using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class HoaDonChiTietRepository
    {
        DBContext context = new DBContext();

        public List<ChiTietHoaDon> GetAllHoaDonCTByMaHoaDon(string maHoaDon)
        {
            return context.ChiTietHoaDons.Where(hdct => hdct.MaHd == maHoaDon).ToList();
        }

        public ChiTietHoaDon? GetHDCTById(string maHoaDon, string maSPCT)
        {
            return context.ChiTietHoaDons
                .FirstOrDefault(hdct => hdct.MaHd == maHoaDon && hdct.MaSp == maSPCT);
        }

        public void ThemMoiHDCT(ChiTietHoaDon hdct)
        {
            context.ChiTietHoaDons.Add(hdct);
            context.SaveChanges();
        }

        public void UpdateSoLuong(ChiTietHoaDon hdctNew)
        {
            var cthd = GetHDCTById(hdctNew.MaHd, hdctNew.MaSp);
            if (cthd != null)
            {
                cthd.SoLuong = hdctNew.SoLuong;
            }
            context.SaveChanges();
        }
        public List<ChiTietHoaDon> GetAll()
        {
            return context.ChiTietHoaDons.ToList();
        }
        public void SuaThanhTien(string MaHd, decimal thanhTien)
        {
            var hoaDonSua = context.ChiTietHoaDons.Find(MaHd);
            if (hoaDonSua != null)
            {
                hoaDonSua.ThanhTien = thanhTien;
            }
            context.SaveChanges();
        }
    }
}
