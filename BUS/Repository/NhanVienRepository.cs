using DAL.Context;
using DAL.DomainClass;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    public class NhanVienRepository
    {
        public DBContext context;
        public NhanVienRepository()
        {
            context = new DBContext();
        }
        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }
        public bool Add(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Add(nv);
            context.SaveChanges();
            return true;
        }
        public bool Update(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Update(nv);
            context.SaveChanges();
            return true;
        }
        public bool Delete(NhanVien nv)
        {
            if (nv == null)
            {
                return false;
            }
            context.NhanViens.Remove(nv);
            context.SaveChanges();
            return true;
        }
        public NhanVien GetNhanVienById(string id)
        {
            return context.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == id);
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            var existingNhanVien = context.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == nhanVien.MaNhanVien);
            if (existingNhanVien == null) return false;

            existingNhanVien.Ten = nhanVien.Ten;
            existingNhanVien.GioiTinh = nhanVien.GioiTinh;
            existingNhanVien.NgaySinh = nhanVien.NgaySinh;
            existingNhanVien.Sdt = nhanVien.Sdt;
            existingNhanVien.Email = nhanVien.Email;
            existingNhanVien.DiaChi = nhanVien.DiaChi;
            existingNhanVien.MaChucVu = nhanVien.MaChucVu;

            context.SaveChanges();
            return true;
        }
        //public NhanVien? DangNhap(string username, string password)
        //{
        //    return context.NhanViens.FirstOrDefault(nv => nv.TaiKhoan == username
        //    && nv.MatKhau == password);
        //}
        public NhanVien? DangNhap(string username, string password)
        {
            return context.NhanViens.FirstOrDefault(nv => nv.TaiKhoan == username
                                                          && nv.MatKhau == password
                                                          && nv.TrangThai == 1); // Giả sử 1 là trạng thái hoạt động
        }


    }
}
