using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class KhuyenMaiRepo
    {
        public DBContext context;

        public KhuyenMaiRepo() 
        {
            context = new DBContext();           
        }

        public List<KhuyenMai> GetAll()
        {
            return context.KhuyenMais.ToList();
        }

        public bool Add(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Add(km);
            context.SaveChanges();
            return true;
        }

        public bool Update(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Add(km);
            context.SaveChanges();
            return true;
        }

        public bool Delete(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Add(km);
            context.SaveChanges();
            return true;
        }


    }
}
