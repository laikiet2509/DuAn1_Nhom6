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
    public class ChucVuRepository
    {
        public DBContext context;
        public ChucVuRepository()
        {
            context = new DBContext();
        }
        public List<ChucVu> GetAllCV()
        {
            return context.ChucVus.ToList();
        }
        public bool AddCV(ChucVu cv)
        {
            if (cv == null)
            {
                return false;
            }
            context.ChucVus.Add(cv);
            context.SaveChanges();
            return true;
        }
        public bool UpdateCV(ChucVu cv)
        {
            if (cv == null)
            {
                return false;
            }
            context.ChucVus.Update(cv);
            context.SaveChanges();
            return true;
        }
        public bool DeleteCV(ChucVu cv)
        {
            if (cv == null)
            {
                return false;
            }
            context.ChucVus.Remove(cv);
            context.SaveChanges();
            return true;
        }
        public ChucVu? GetChucVuById(string maChucVu)
        {
            return context.ChucVus.FirstOrDefault(cv => cv.MaChucVu == maChucVu);
        }
    }
}
