using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonServices
    {
        public HoaDonRepository repos;
        public HoaDonServices()
        {
            repos = new HoaDonRepository();
        }
        public HoaDon? GetHoaDonbyMaHoaDon(string maHoaDon)
        {
            return repos.GetHoaDonbyMaHoaDon(maHoaDon);
        }

        public List<HoaDon> GetAllHoaDons()
        {
            return repos.GetAllHoaDons();
        }

        public List<HoaDon> GetAllHoaDonChos()
        {
            return repos.GetAllHoaDons().Where(hd => hd.TrangThai == 0).ToList();
        }

        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            repos.TaoHoaDonCho(hoaDon);
        }   

        public void SuaTrangThai(string maHoaDon, int trangThai)
        {
            repos.SuaTrangThai(maHoaDon, trangThai);
        }
    }
}
