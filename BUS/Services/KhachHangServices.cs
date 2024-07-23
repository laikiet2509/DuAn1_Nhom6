using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KhachHangServices
    {
        private KhachHangRepository repos;
        List<KhachHang> lst = new List<KhachHang>();
        public KhachHangServices()
        {
            repos = new KhachHangRepository();
        }
        public List<KhachHang> GetKhachHangs(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAll();
            }
            return repos.GetAll().FindAll(x => x.TenKhachHang.ToString().Contains(search) || x.Sdt.Contains(search));
        }
        public string Them(KhachHang kh)
        {
            if (repos.Add(kh))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string Sua(KhachHang kh)
        {
            if (repos.Update(kh))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string Xoa(string ma)
        {
            var kh = repos.GetAll().Find(x => x.Sdt.ToString() == ma);
            if (repos.Delete(kh))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
        public KhachHang? GetKhachHangBySDT(string sdt)
        {
            return repos.GetKhachHangBySDT(sdt);
        }
    }
}
