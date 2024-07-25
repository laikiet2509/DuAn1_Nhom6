using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class ThuongHieuRepository
    {
        public DBContext context;
        public ThuongHieuRepository()
        {
            context = new DBContext();
        }
        public List<ThuongHieu> GetAllMS()
        {
            return context.ThuongHieus.ToList();
        }
        public bool AddTH(ThuongHieu th)
        {
            if (th == null)
            {
                return false;
            }
            context.ThuongHieus.Add(th);
            context.SaveChanges();
            return true;
        }
        public bool UpdateTH(ThuongHieu th)
        {
            if (th == null)
            {
                return false;
            }
            context.ThuongHieus.Update(th);
            context.SaveChanges();
            return true;
        }
        public bool DeleteTH(ThuongHieu th)
        {
            if (th == null)
            {
                return false;
            }
            context.ThuongHieus.Remove(th);
            context.SaveChanges();
            return true;
        }
        public ThuongHieu? GetThuongHieuById(string maThuongHieu)
        {
            return context.ThuongHieus.FirstOrDefault(ms => ms.MaThuongHieu == maThuongHieu);
        }
    }
}
