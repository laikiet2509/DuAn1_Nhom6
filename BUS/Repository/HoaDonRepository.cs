using DAL.Context;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class HoaDonRepository
    {
        public DBContext context;
        public HoaDonRepository()
        {
            context = new DBContext();
        }
        
        public HoaDon? GetHoaDonbyMaHoaDon(string maHoaDon)
        {
            return context.HoaDons.Find(maHoaDon);
        }

        public List<HoaDon> GetAllHoaDons()
        {
            return context.HoaDons.ToList();
        }

        public void TaoHoaDonCho(HoaDon hoaDon)
        {
            context.HoaDons.Add(hoaDon);
            context.SaveChanges();
        }

        public void SuaTrangThai(string maHoaDon, int trangThai)
        {
            var hoaDonSua = context.HoaDons.Find(maHoaDon);
            if (hoaDonSua != null)
            {
                hoaDonSua.TrangThai = trangThai;
            }
            context.SaveChanges();
        }
    }
}
