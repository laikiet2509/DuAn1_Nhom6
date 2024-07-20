using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class NhanVienServices
    {
        NhanVienRepos _repo = new NhanVienRepos();
        public NhanVienServices()
        {
            _repo = new NhanVienRepos();
        }
        
        public List<NhanVien> CNShow()
        {
            return _repo.GetAll();
        }

        public List<NhanVien> CNTim(string ten)
        {
            return _repo.GetNV(ten);
        }
   
        public string CNThem(string ma, string ten, string gioitinh, DateTime ngaysinh, string sdt, string email, string diachi, string trangthai, string machucvu)
        {
            NhanVien nv = new NhanVien()
            {
                MaNhanVien = ma,
                Ten = ten,
                GioiTinh = gioitinh,
                NgaySinh = ngaysinh,
                Sdt = sdt,
                Email = email,
                DiaChi = diachi,
                TrangThai = trangthai,
                MaChucVu = machucvu
            };
            if (_repo.AddNV(nv))
            {
                return "Thêm thành công";
            }
            else
                return "Thêm thất bại";
        }

        
        public string CNSua(string ma, string ten, string gioitinh, DateTime ngaysinh, string sdt, string email, string diachi, string trangthai, string machucvu)
        {
            NhanVien nv = new NhanVien() 
            {
                MaNhanVien = ma,
                Ten = ten,
                GioiTinh = gioitinh,
                NgaySinh = ngaysinh,
                Sdt = sdt,
                Email = email,
                DiaChi = diachi,
                TrangThai = trangthai,
                MaChucVu = machucvu
            };
            if (_repo.UpdateNV(nv))
            {
                return "Sửa thành công";
            }
            else
                return "Sửa thất bại";
        }
       
        public string CNXoa(string ma)
        {
            if (_repo.DeleteNV(ma))
            {
                return "Xoá thành công";
            }
            else
                return "Xoá thất bại";
        }
       
        public bool CheckSDT(string sdt)
        {
            if (sdt.Length > 10 || sdt.Trim().Length == 0) return false;
            else return true;
        }
    }
}
