using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ThuongHieuServices
    {
        public ThuongHieuRepository repos;
        public ThuongHieuServices()
        {
            repos = new ThuongHieuRepository();
        }
        List<ThuongHieu> lstMS = new List<ThuongHieu>();
        public List<ThuongHieu> GetThuongHieus()
        {
                return repos.GetAllMS();
        }
        public string ThemTH(ThuongHieu th)
        {
            if (repos.AddTH(th))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaTH(ThuongHieu th)
        {
            if (repos.UpdateTH(th))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string XoaMS(string ma)
        {
            var ms = repos.GetAllMS().Find(x => x.MaThuongHieu.ToString() == ma);
            if (repos.DeleteTH(ms))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
        public ThuongHieu? GetThuongHieuById(string maThuongHieu)
        {
            return repos.GetThuongHieuById(maThuongHieu);
        }
    }
}
