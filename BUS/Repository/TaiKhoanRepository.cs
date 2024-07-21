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
    public class TaiKhoanRepository
    {
        
        public DBContext context;
        public TaiKhoanRepository()
        {
            context = new DBContext();
        }
        public List<TaiKhoan> GetAll()
        {
            return context.TaiKhoans.ToList();
        }

        //public bool ValidateUser(string username, string password)
        //{
        //    return context.TaiKhoans.Any(u => u.TaiKhoan1 == username && u.MatKhau == password);
        //}

        //public bool RegisterUser(string username, string password)
        //{
        //    if (context.TaiKhoans.Any(u => u.TaiKhoan1 == username))
        //    {
        //        return false; // Người dùng đã tồn tại
        //    }

        //    var newUser = new TaiKhoan
        //    {
        //        TaiKhoan1 = username,
        //        MatKhau = password
        //    };

        //    context.TaiKhoans.Add(newUser);
        //    context.SaveChanges();
        //    return true;
        //}
        public bool ValidateUser(string username, string password)
        {
            return context.TaiKhoans.Any(u => u.TaiKhoan1 == username && u.MatKhau == password);
        }
    }
}
