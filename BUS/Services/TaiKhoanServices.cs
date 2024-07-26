using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class TaiKhoanServices
    {
        public TaiKhoanRepository repos;
        List<TaiKhoan> lst = new List<TaiKhoan>();
        public TaiKhoanServices()
        {
            repos = new TaiKhoanRepository();
        }
        public List<TaiKhoan> GetTaiKhoans(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAll();
            }
            return repos.GetAll().FindAll(x => x.TaiKhoan1.ToString().Contains(search) || x.Idtk.Contains(search));
        }
        public bool Login(string username, string password)
        {
            // Thêm các logic nghiệp vụ nếu cần
            return repos.ValidateUser(username, password);
        }

        public string GetUserRole(string username)
        {
            return repos.GetUserRole(username);
        }

        public string GetUserFullName(string username)
        {
            var user = repos.GetAll().FirstOrDefault(u => u.TaiKhoan1 == username);
            return user?.MaNhanVienNavigation?.Ten;
        }

        public string GetUserId(string username)
        {
            var user = repos.GetAll().FirstOrDefault(u => u.TaiKhoan1 == username);
            return user?.MaNhanVien;
        }

        public bool Register(TaiKhoan newUser)
        {
            return repos.RegisterUser(newUser);
        }
    }
}
