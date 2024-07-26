using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ChucVuServices
    {
        public ChucVuRepository repos;
        public ChucVuServices()
        {
            repos = new ChucVuRepository();
        }
        List<ChucVu> lstCV = new List<ChucVu>();
        public List<ChucVu> GetChucVus()
        {
                return repos.GetAllCV();
            
            
        }
        public string ThemCV(ChucVu cv)
        {
            if (repos.AddCV(cv))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaCV(ChucVu cv)
        {
            if (repos.UpdateCV(cv))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string XoaCV(string ma)
        {
            var cv = repos.GetAllCV().Find(x => x.MaChucVu.ToString() == ma);
            if (repos.DeleteCV(cv))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
        public ChucVu? GetChucVuById(string maChucVu)
        {
            return repos.GetChucVuById(maChucVu);
        }
        
    }
}
