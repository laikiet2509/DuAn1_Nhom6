﻿
using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class SanPhamRepository
    {
        public DBContext context;
        public SanPhamRepository()
        {
            context = new DBContext();
        }
        public List<SanPham> GetAll()
        {
            return context.SanPhams.ToList();
        }
        public bool Add(SanPham sp)
        {
            if (sp == null)
            {
                return false;
            }
            context.SanPhams.Add(sp);
            context.SaveChanges();
            return true;
        }
        public bool Update(SanPham sp)
        {
            if (sp == null)
            {
                return false;
            }
            context.SanPhams.Update(sp);
            context.SaveChanges();
            return true;
        }
        public bool Delete(SanPham sp)
        {
            if (sp == null)
            {
                return false;
            }
            context.SanPhams.Remove(sp);
            context.SaveChanges();
            return true;
        }       
    }
}