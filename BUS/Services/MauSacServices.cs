using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class MauSacServices
    {
        public MauSacRepository repos;
        public MauSacServices()
        {
            repos = new MauSacRepository();
        }
        List<MauSac> lstMS = new List<MauSac>();
        public List<MauSac> GetMauSacs(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllMS();
            }
            return repos.GetAllMS().FindAll(x => x.MaMauSp.ToString().Contains(search) || x.MauSac1.Contains(search));
        }
        public string ThemMS(MauSac ms)
        {
            if (repos.AddMS(ms))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaMS(MauSac ms)
        {
            if (repos.UpdateMS(ms))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string XoaMS(string ma)
        {
            var ms = repos.GetAllMS().Find(x => x.MaMauSp.ToString() == ma);
            if (repos.DeleteMS(ms))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
