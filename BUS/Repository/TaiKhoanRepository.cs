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
            return context.TaiKhoans
                .Include(tk => tk.MaNhanVienNavigation)
                .ThenInclude(nv => nv.MaChucVuNavigation)
                .ToList();
        }

        public bool ValidateUser(string username, string password)
        {
            return context.TaiKhoans.Any(u => u.TaiKhoan1 == username && u.MatKhau == password);
        }

        public string GetUserRole(string username)
        {
            var user = context.TaiKhoans.Include(tk => tk.MaNhanVienNavigation)
                                        .ThenInclude(nv => nv.MaChucVuNavigation)
                                        .FirstOrDefault(u => u.TaiKhoan1 == username);

            return user?.MaNhanVienNavigation?.MaChucVuNavigation?.TenChucVu;
        }

        public bool RegisterUser(TaiKhoan newUser)
        {
            if (context.TaiKhoans.Any(u => u.TaiKhoan1 == newUser.TaiKhoan1))
            {
                return false; // User already exists
            }

            context.TaiKhoans.Add(newUser);
            context.SaveChanges();
            return true;
        }
    }
}
