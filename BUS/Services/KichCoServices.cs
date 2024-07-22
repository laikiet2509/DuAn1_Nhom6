using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KichCoServices
    {
        public KichCoRepository repos;
        public KichCoServices()
        {
            repos = new KichCoRepository();
        }
        public List<KichCo> GetKichCos(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllKC();
            }
            return repos.GetAllKC().FindAll(x => x.MaKichCoSp.ToString().Contains(search) || x.KichCo1.Contains(search));
        }
        public string ThemKC(KichCo kc)
        {
            if (repos.AddKC(kc))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaKC(KichCo kc)
        {
            if (repos.UpdateKC(kc))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string XoaKC(string ma)
        {
            var kc = repos.GetAllKC().Find(x => x.MaKichCoSp.ToString() == ma);
            if (repos.DeleteKC(kc))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
