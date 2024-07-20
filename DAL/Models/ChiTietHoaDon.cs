using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ChiTietHoaDon
    {
        public string MaHd { get; set; } = null!;
        public string MaSp { get; set; } = null!;
        public int? SoLuong { get; set; }
        public decimal? GiaBan { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; } = null!;
        public virtual SanPham MaSpNavigation { get; set; } = null!;
    }
}
