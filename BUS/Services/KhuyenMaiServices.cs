using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KhuyenMaiServices
    {
        public KhuyenMaiRepository repos;
        public KhuyenMaiServices()
        {
            repos = new KhuyenMaiRepository();
        }
        List<KhuyenMai> lstKM = new List<KhuyenMai>();
        public List<KhuyenMai> GetKhuyenMais(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllKM();
            }
            return repos.GetAllKM().FindAll(x => x.MaVoucher.ToString().Contains(search));
        }
        public KhuyenMai GetKhuyenMaiByMa(string maKhuyenMai)
        {
            return repos.GetKhuyenMaiByMa(maKhuyenMai);
        }
        public string ThemKM(KhuyenMai km)
        {
            if (repos.AddKM(km))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaKM(KhuyenMai km)
        {
            if (repos.UpdateKM(km))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string XoaKM(string ma)
        {
            var km = repos.GetAllKM().Find(x => x.MaVoucher.ToString() == ma);
            if (repos.DeleteKM(km))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
