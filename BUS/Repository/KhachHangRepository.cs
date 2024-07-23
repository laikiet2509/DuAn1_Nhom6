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
    public class KhachHangRepository
    {
        public DBContext context;
        public KhachHangRepository()
        {
            context = new DBContext();
        }
        public List<KhachHang> GetAll()
        {
            return context.KhachHangs.ToList();
        }
        public bool Add(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            context.KhachHangs.Add(kh);
            context.SaveChanges();
            return true;
        }
        public bool Update(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            context.KhachHangs.Update(kh);
            context.SaveChanges();
            return true;
        }
        public bool Delete(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            context.KhachHangs.Remove(kh);
            context.SaveChanges();
            return true;
        }
        public KhachHang? GetKhachHangBySDT(string sdt)
        {
            return context.KhachHangs.FirstOrDefault(kh => kh.Sdt == sdt);
        }
    }
}
