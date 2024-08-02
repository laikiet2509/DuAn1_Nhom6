using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class BanHangServices
    {
        public BanHangRepository repos;
        public BanHangServices()
        {
            repos = new BanHangRepository();
        }

        // SP ----------

        List<SanPham> lstSP = new List<SanPham>();
        public List<SanPham> GetSanPhams(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllSP();
            }
            return repos.GetAllSP().FindAll(x => x.TenSanPham.ToString().Contains(search) || x.MaSanPham.Contains(search));
        }
        public string ThemSP(SanPham sp)
        {
            if (repos.AddSP(sp))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaSP(SanPham sp)
        {
            if (repos.UpdateSP(sp))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string XoaSP(string ma)
        {
            var sp = repos.GetAllSP().Find(x => x.MaSanPham.ToString() == ma);
            if (repos.DeleteSP(sp))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }

        // KH ---------

        List<KhachHang> lstKH = new List<KhachHang>();
        public List<KhachHang> GetKhachHangs(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllKH();
            }
            return repos.GetAllKH().FindAll(x => x.TenKhachHang.ToString().Contains(search) || x.Sdt.Contains(search));
        }
        public string ThemKH(KhachHang kh)
        {
            if (repos.AddKH(kh))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaKH(KhachHang kh)
        {
            if (repos.UpdateKH(kh))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string XoaKH(string ma)
        {
            var kh = repos.GetAllKH().Find(x => x.Sdt.ToString() == ma);
            if (repos.DeleteKH(kh))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }

        // NV ------------------------

        List<NhanVien> lstNV = new List<NhanVien>();
        public List<NhanVien> GetNhanViens(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllNV();
            }
            return repos.GetAllNV().FindAll(x => x.Ten.ToString().Contains(search) || x.MaNhanVien.Contains(search));
        }
        public string ThemNV(NhanVien nv)
        {
            if (repos.AddNV(nv))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaNV(NhanVien nv)
        {
            if (repos.UpdateNV(nv))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        public string XoaNV(string ma)
        {
            var nv = repos.GetAllNV().Find(x => x.MaNhanVien.ToString() == ma);
            if (repos.DeleteNV(nv))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }

        // KM -------------------------

        List<KhuyenMai> lstKM = new List<KhuyenMai>();
        public List<KhuyenMai> GetKhuyenMais(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllKM();
            }
            return repos.GetAllKM().FindAll(x => x.MaVoucher.ToString().Contains(search));
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

        // HD ----------------------

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

        // MS -------------------------

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

        // KC ------------------------

        List<KichCo> lstKC = new List<KichCo>();
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

        // CV ---------------------------

        List<ChucVu> lstCV = new List<ChucVu>();
        public List<ChucVu> GetChucVus(string search)
        {
            if (search == null || search == string.Empty)
            {
                return repos.GetAllCV();
            }
            return repos.GetAllCV().FindAll(x => x.MaChucVu.ToString().Contains(search) || x.TenChucVu.Contains(search));
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
    }
}
