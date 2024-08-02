using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamServices
    {
        private SanPhamRepository repos;
        List<SanPham> lst = new List<SanPham>();
        public SanPhamServices()
        {
            repos = new SanPhamRepository();
        }
        //public List<SanPham> GetSanPhams(string search)
        //{
        //    if (search == null || search == string.Empty)
        //    {
        //        return repos.GetAll();
        //    }
        //    return repos.GetAll().FindAll(x => x.TenSanPham.ToString().Contains(search) || x.MaSanPham.Contains(search));
        //}
        public List<SanPham> GetSanPhams()
        {
            return repos.GetAll();
        }
        public string Them(SanPham sp)
        {
            if (repos.Add(sp))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string Sua(SanPham sp)
        {
            if (repos.Update(sp))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string Xoa(string ma)
        {
            var sp = repos.GetAll().Find(x => x.MaSanPham.ToString() == ma);
            if (repos.Delete(sp))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
        

        public SanPham GetAllSanPhamChiTietById(string maSPCT)
        {
            return repos.GetAllSanPhamChiTietById(maSPCT);
        }

        public void UpdateSoLuong(SanPham spctNew)
        {
            repos.UpdateSoLuong(spctNew);
        }
        

       
    }
}
