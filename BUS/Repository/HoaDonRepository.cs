using DAL.Context;
using DAL.DomainClass;
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
        public List<HoaDon> GetAllHD()
        {
            return context.HoaDons.ToList();
        }
        public bool AddHD(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            context.HoaDons.Add(hd);
            context.SaveChanges();
            return true;
        }
        public bool UpdateHD(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            context.HoaDons.Update(hd);
            context.SaveChanges();
            return true;
        }
        public bool DeleteHD(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            context.HoaDons.Remove(hd);
            context.SaveChanges();
            return true;
        }
    }
}
