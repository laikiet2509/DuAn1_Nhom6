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
        //public bool Dangki(string ten, string sdt, string email, string diachi, string username, string password)
        //{
        //    // Thêm các logic nghiệp vụ nếu cần
        //    return repos.Dangki(ten, sdt, email, diachi, username, password);
        //}

        //public bool Login(string username, string password)
        //{
        //    // Thêm các logic nghiệp vụ nếu cần
        //    return repos.ValidateUser(username, password);
        //}

        //public bool Register(string username, string password)
        //{
        //    // Thêm các logic nghiệp vụ nếu cần
        //    return repos.RegisterUser(username, password);
        //}
        public bool Login(string username, string password)
        {
            // Thêm các logic nghiệp vụ nếu cần
            return repos.ValidateUser(username, password);
        }
    }
}
