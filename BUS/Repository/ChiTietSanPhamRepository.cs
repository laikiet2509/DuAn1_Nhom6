using DAL.Context;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class ChiTietSanPhamRepository
    {
        DBContext context;
        public ChiTietSanPhamRepository()
        {
            context = new DBContext();
        }
        public List<ChiTietSanPham> GetAllSanPhamChiTiets()
        {
            return context.ChiTietSanPhams.ToList();
        }

        public ChiTietSanPham GetAllSanPhamChiTietById(string maSPCT)
        {
            return context.ChiTietSanPhams.Find(maSPCT);
        }

        public void UpdateSoLuong(ChiTietSanPham spctNew)
        {
            var spctOld = GetAllSanPhamChiTietById(spctNew.MaChiTietSp);
            if (spctOld != null)
            {
                spctOld.SoLuong = spctNew.SoLuong;
            }
            context.SaveChanges();
        }
    }
}
