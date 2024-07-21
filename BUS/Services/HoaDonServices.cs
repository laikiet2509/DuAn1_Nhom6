using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonServices
    {
        public HoaDonRepository repos;
        public HoaDonServices()
        {
            repos = new HoaDonRepository();
        }
        List<HoaDon> lstHD = new List<HoaDon>();
        public List<HoaDon> GetHoaDons(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllHD();
            }
            return repos.GetAllHD().FindAll(x => x.MaHoaDon.ToString().Contains(search) || x.MaNhanVien.Contains(search));
        }
        public string ThemHD(HoaDon hd)
        {
            if (repos.AddHD(hd))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaHD(HoaDon hd)
        {
            if (repos.UpdateHD(hd))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";

        }
        public string XoaHD(string ma)
        {
            var hd = repos.GetAllHD().Find(x => x.MaHoaDon.ToString() == ma);
            if (repos.DeleteHD(hd))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
