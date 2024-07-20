using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhanVienRepos
    {
        BanGiayTheThaoContext _context = new BanGiayTheThaoContext();
        public NhanVienRepos()
        {
            _context = new BanGiayTheThaoContext();
        }
      
        public List<NhanVien> GetAll()
        {
            return _context.NhanViens.ToList();
        }
        
        public List<NhanVien> GetNV(string ten)
        {
            return _context.NhanViens.Where(p => p.Ten.Contains(ten)).ToList(); 

        }
       
        public bool AddNV(NhanVien nv)
        {
            try
            {
                _context.NhanViens.Add(nv);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool UpdateNV(NhanVien nv)
        {
            try
            {              
                var updateItem = _context.NhanViens.Find(nv.MaNhanVien);              
                updateItem.MaNhanVien = nv.MaNhanVien;
                updateItem.Ten = nv.Ten;
                updateItem.GioiTinh = nv.GioiTinh;
                updateItem.NgaySinh = nv.NgaySinh;
                updateItem.Sdt = nv.Sdt;
                updateItem.Email = nv.Email;
                updateItem.DiaChi = nv.DiaChi;
                updateItem.TrangThai = nv.TrangThai;
                updateItem.MaChucVu = nv.MaChucVu;        
                _context.NhanViens.Update(updateItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool DeleteNV(string maNV)
        {
            try
            {               
                var deleteItem = _context.NhanViens.Find(maNV);        
                _context.NhanViens.Remove(deleteItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
