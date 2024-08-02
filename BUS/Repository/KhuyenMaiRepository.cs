using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class KhuyenMaiRepository
    {
        public DBContext context;
        public KhuyenMaiRepository()
        {
            context = new DBContext();
        }
        public KhuyenMai GetKhuyenMaiByMa(string maKhuyenMai)
        {
            return context.KhuyenMais.FirstOrDefault(km => km.MaVoucher == maKhuyenMai);
        }

        public List<KhuyenMai> GetAllKM()
        {
            return context.KhuyenMais.ToList();
        }
        public bool AddKM(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Add(km);
            context.SaveChanges();
            return true;
        }
        public bool UpdateKM(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Update(km);
            context.SaveChanges();
            return true;
        }
        public bool DeleteKM(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Remove(km);
            context.SaveChanges();
            return true;
        }
    }
}
