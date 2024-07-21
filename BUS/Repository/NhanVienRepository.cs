using DAL.Context;
using DAL.DomainClass;
using Microsoft.Data.SqlClient;
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
        //public bool ValidateUser(string username, string password)
        //{
        //    return context.TaiKhoans.Any(u => u.TaiKhoan1 == username && u.MatKhau == password);
        //}

    }
}
