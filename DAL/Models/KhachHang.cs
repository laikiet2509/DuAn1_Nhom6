﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaKhachHang { get; set; } = null!;
        public string? TenKhachHang { get; set; }
        public string? Sdt { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string? GioiTinh { get; set; }
        public string? TrangThai { get; set; }
        public string? HinhAnh { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
