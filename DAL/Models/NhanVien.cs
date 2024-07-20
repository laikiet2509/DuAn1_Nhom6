using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public string MaNhanVien { get; set; } = null!;
        public string? Ten { get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string? TrangThai { get; set; }
        public string? MaChucVu { get; set; }

        public virtual ChucVu? MaChucVuNavigation { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
