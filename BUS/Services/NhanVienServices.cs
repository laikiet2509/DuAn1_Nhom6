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
        public List<NhanVien> GetNhanViens()
        {
                return repos.GetAll();
 
        }
        public string Them(NhanVien nv)
        {
            if (repos.Add(nv))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string Sua(NhanVien nv)
        {
            if (repos.Update(nv))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string Xoa(string ma)
        {
            var nv = repos.GetAll().Find(x => x.Ten.ToString() == ma);
            if (repos.Delete(nv))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
        public NhanVien GetNhanVienById(string id)
        {
            return repos.GetNhanVienById(id);
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            return repos.UpdateNhanVien(nhanVien);
        }
        public NhanVien? DangNhap(string username, string password)
        {
            return repos.DangNhap(username, password);
        }

    }
}
