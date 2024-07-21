using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanVienServices
    {
        private NhanVienRepository repos;
        List<NhanVien> lst = new List<NhanVien>();
        public NhanVienServices()
        {
            repos = new NhanVienRepository();
        }
        public List<NhanVien> GetNhanViens(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAll();
            }
            return repos.GetAll().FindAll(x => x.Ten.ToString().Contains(search) || x.MaNhanVien.Contains(search));
        }
        //public bool Dangki(string ten, string sdt, string email, string diachi, string username, string password)
        //{
        //    // Thêm các logic nghiệp vụ nếu cần
        //    return repos.Dangki(ten, sdt, email, diachi, username, password);
        //}
    }
}
