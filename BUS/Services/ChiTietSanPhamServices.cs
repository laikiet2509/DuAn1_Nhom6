using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ChiTietSanPhamServices
    {
        public ChiTietSanPhamRepository repos;
        public ChiTietSanPhamServices()
        {
            repos = new ChiTietSanPhamRepository();
        }
        public List<ChiTietSanPham> GetAllSanPhamChiTiets()
        {
            return repos.GetAllSanPhamChiTiets();
        }

        public ChiTietSanPham GetAllSanPhamChiTietById(string maSPCT)
        {
            return repos.GetAllSanPhamChiTietById(maSPCT);
        }

        public void UpdateSoLuong(ChiTietSanPham spctNew)
        {
            repos.UpdateSoLuong(spctNew);
        }
    }
}
