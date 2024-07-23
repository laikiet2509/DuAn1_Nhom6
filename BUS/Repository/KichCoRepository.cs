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
    public class KichCoRepository
    {
        public DBContext context;
        public KichCoRepository()
        {
            context = new DBContext();
        }
        public List<KichCo> GetAllKC()
        {
            return context.KichCos.ToList();
        }
        public bool AddKC(KichCo kc)
        {
            if (kc == null)
            {
                return false;
            }
            context.KichCos.Add(kc);
            context.SaveChanges();
            return true;
        }
        public bool UpdateKC(KichCo kc)
        {
            if (kc == null)
            {
                return false;
            }
            context.KichCos.Update(kc);
            context.SaveChanges();
            return true;
        }
        public bool DeleteKC(KichCo kc)
        {
            if (kc == null)
            {
                return false;
            }
            context.KichCos.Remove(kc);
            context.SaveChanges();
            return true;
        }
        public KichCo? GetKichCoById(string maKichCo)
        {
            return context.KichCos.FirstOrDefault(kc => kc.MaKichCoSp == maKichCo);
        }
    }
}
