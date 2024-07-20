using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public string MaHoaDon { get; set; } = null!;
        public DateTime? NgayLapHoaDon { get; set; }
        public decimal? TongTien { get; set; }
        public string? TrangThai { get; set; }
        public string? MaKhachHang { get; set; }
        public string? MaNhanVien { get; set; }

        public virtual KhachHang? MaKhachHangNavigation { get; set; }
        public virtual NhanVien? MaNhanVienNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
