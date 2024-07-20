using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public string MaSanPham { get; set; } = null!;
        public string? TenSanPham { get; set; }
        public decimal? GiaBan { get; set; }
        public string? MaMauSp { get; set; }
        public string? MaKichCoSp { get; set; }
        public string? ChatLieu { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string? HinhAnh { get; set; }
        public int? SoLuongTon { get; set; }
        public string? MaKhuyenMai { get; set; }
        public string? ThuongHieu { get; set; }

        public virtual KhuyenMai? MaKhuyenMaiNavigation { get; set; }
        public virtual KichCo? MaKichCoSpNavigation { get; set; }
        public virtual MauSac? MaMauSpNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
