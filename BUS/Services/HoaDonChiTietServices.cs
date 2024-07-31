using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonChiTietServices
    {
        HoaDonChiTietRepository repos = new HoaDonChiTietRepository();

        public List<ChiTietHoaDon> GetAllHoaDonCTByMaHoaDon(string maHoaDon)
        {
            return repos.GetAllHoaDonCTByMaHoaDon(maHoaDon);
        }

        public ChiTietHoaDon? GetHDCTById(string maHoaDon, string maSPCT)
        {
            return repos.GetHDCTById(maHoaDon, maSPCT);
        }

        public void ThemMoiHDCT(ChiTietHoaDon hdct)
        {
            repos.ThemMoiHDCT(hdct);
        }

        public void UpdateSoLuong(ChiTietHoaDon hdctNew)
        {
            repos.UpdateSoLuong(hdctNew);
        }
        public List<ChiTietHoaDon> GetChiTietHoaDons()
        {
            return repos.GetAll();
        }
        public void SuaThanhTien(string maHoaDon, decimal thanhTien)
        {
            repos.SuaThanhTien(maHoaDon, thanhTien);
        }
    }
}
