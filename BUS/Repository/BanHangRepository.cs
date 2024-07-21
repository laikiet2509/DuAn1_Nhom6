using BUS.Services;
using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class BanHangRepository
    {
        public DBContext context;
        public BanHangRepository()
        {
            context = new DBContext();
        }
        // SP ----------------------
        public List<SanPham> GetAllSP()
        {
            return context.SanPhams.ToList();
        }
        public bool AddSP(SanPham sp)
        {
            if (sp == null)
            {
                return false;
            }
            context.SanPhams.Add(sp);
            context.SaveChanges();
            return true;
        }
        public bool UpdateSP(SanPham sp)
        {
            if (sp == null)
            {
                return false;
            }
            context.SanPhams.Update(sp);
            context.SaveChanges();
            return true;
        }
        public bool DeleteSP(SanPham sp)
        {
            if (sp == null)
            {
                return false;
            }
            context.SanPhams.Remove(sp);
            context.SaveChanges();
            return true;
        }

        // KH ---------------------------------

        public List<KhachHang> GetAllKH()
        {
            return context.KhachHangs.ToList();
        }
        public bool AddKH(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            context.KhachHangs.Add(kh);
            context.SaveChanges();
            return true;
        }
        public bool UpdateKH(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            context.KhachHangs.Update(kh);
            context.SaveChanges();
            return true;
        }
        public bool DeleteKH(KhachHang kh)
        {
            if (kh == null)
            {
                return false;
            }
            context.KhachHangs.Remove(kh);
            context.SaveChanges();
            return true;
        }

        // NV ----------------------------

        public List<NhanVien> GetAllNV()
        {
            return context.NhanViens.ToList();
        }
        public bool AddNV(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Add(nv);
            context.SaveChanges();
            return true;
        }
        public bool UpdateNV(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Update(nv);
            context.SaveChanges();
            return true;
        }
        public bool DeleteNV(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Remove(nv);
            context.SaveChanges();
            return true;
        }

        // KM -----------------------------

        public List<KhuyenMai> GetAllKM()
        {
            return context.KhuyenMais.ToList();
        }
        public bool AddKM(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Add(km);
            context.SaveChanges();
            return true;
        }
        public bool UpdateKM(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Update(km);
            context.SaveChanges();
            return true;
        }
        public bool DeleteKM(KhuyenMai km)
        {
            if (km == null)
            {
                return false;
            }
            context.KhuyenMais.Remove(km);
            context.SaveChanges();
            return true;
        }

        // HD --------------------

        public List<HoaDon> GetAllHD()
        {
            return context.HoaDons.ToList();
        }
        public bool AddHD(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            context.HoaDons.Add(hd);
            context.SaveChanges();
            return true;
        }
        public bool UpdateHD(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            context.HoaDons.Update(hd);
            context.SaveChanges();
            return true;
        }
        public bool DeleteHD(HoaDon hd)
        {
            if (hd == null)
            {
                return false;
            }
            context.HoaDons.Remove(hd);
            context.SaveChanges();
            return true;
        }

        // MS ----------------------------

        public List<MauSac> GetAllMS()
        {
            return context.MauSacs.ToList();
        }
        public bool AddMS(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            context.MauSacs.Add(ms);
            context.SaveChanges();
            return true;
        }
        public bool UpdateMS(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            context.MauSacs.Update(ms);
            context.SaveChanges();
            return true;
        }
        public bool DeleteMS(MauSac ms)
        {
            if (ms == null)
            {
                return false;
            }
            context.MauSacs.Remove(ms);
            context.SaveChanges();
            return true;
        }

        // KC ----------------------------

        public List<KichCo> GetAllKC()
        {
            return context.KichCos.ToList();
        }
        public bool AddKC(KichCo kc)
        {
            if (kc == null)
            {
                return false;
            }
            context.KichCos.Add(kc);
            context.SaveChanges();
            return true;
        }
        public bool UpdateKC(KichCo kc)
        {
            if (kc == null)
            {
                return false;
            }
            context.KichCos.Update(kc);
            context.SaveChanges();
            return true;
        }
        public bool DeleteKC(KichCo kc)
        {
            if (kc == null)
            {
                return false;
            }
            context.KichCos.Remove(kc);
            context.SaveChanges();
            return true;
        }

        // CV --------------------

        public List<ChucVu> GetAllCV()
        {
            return context.ChucVus.ToList();
        }
        public bool AddCV(ChucVu cv)
        {
            if (cv == null)
            {
                return false;
            }
            context.ChucVus.Add(cv);
            context.SaveChanges();
            return true;
        }
        public bool UpdateCV(ChucVu cv)
        {
            if (cv == null)
            {
                return false;
            }
            context.ChucVus.Update(cv);
            context.SaveChanges();
            return true;
        }
        public bool DeleteCV(ChucVu cv)
        {
            if (cv == null)
            {
                return false;
            }
            context.ChucVus.Remove(cv);
            context.SaveChanges();
            return true;
        }
    }
}
