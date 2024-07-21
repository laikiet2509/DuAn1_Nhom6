using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class KhuyenMaiService
    {
        private KhuyenMaiRepo repo;
        List<KhuyenMai> lkm = new List<KhuyenMai>();

        public KhuyenMaiService()
        {
            repo = new KhuyenMaiRepo();
        }

        public List<KhuyenMai> GetKhuyenMais(String search)
        {
            if (search == null || search == string.Empty)
            {
                return repo.GetAll();
            }
            return repo.GetAll().FindAll(x => x.MaKhuyenMai.ToString().Contains(search)); 
        }

        public string them(KhuyenMai km)
        {
            if (repo.Add(km))
            {
                return "Thêm Thành Công!";
            }
            return "Thêm Thất Bại";
        }
        public string Sua(KhuyenMai km)
        {
            if (repo.Update(km))
            {
                return "Sửa Thành Công!";
            }
            return "Sửa Thất Bại";
        }
        public string Xoa(KhuyenMai km)
        {
            if (repo.Delete(km))
            {
                return "Xóa Thành Công!";
            }
            return "Xóa Thất Bại";
        }
    }
}
