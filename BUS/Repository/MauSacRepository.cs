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
    public class MauSacRepository
    {
        public DBContext context;
        public MauSacRepository()
        {
            context = new DBContext();
        }
        public List<MauSac> GetAllMS()
        {
            return context.MauSacs.ToList();
        }
        public bool AddMS(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            context.MauSacs.Add(ms);
            context.SaveChanges();
            return true;
        }
        public bool UpdateMS(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            context.MauSacs.Update(ms);
            context.SaveChanges();
            return true;
        }
        public bool DeleteMS(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            context.MauSacs.Remove(ms);
            context.SaveChanges();
            return true;
        }
        public MauSac? GetMauSacById(string maMauSac)
        {
            return context.MauSacs.FirstOrDefault(ms => ms.MaMauSp == maMauSac);
        }
    }
}
