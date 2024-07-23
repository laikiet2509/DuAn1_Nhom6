﻿using DAL.Context;
using DAL.DomainClass;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class NhanVienRepository
    {
        public DBContext context;
        public NhanVienRepository()
        {
            context = new DBContext();
        }
        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }
        public bool Add(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Add(nv);
            context.SaveChanges();
            return true;
        }
        public bool Update(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Update(nv);
            context.SaveChanges();
            return true;
        }
        public bool Delete(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Remove(nv);
            context.SaveChanges();
            return true;
        }
    }
}
