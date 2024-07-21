﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaKhachHang { get; set; } = null!;
        [StringLength(255)]
        public string? TenKhachHang { get; set; }
        [Column("SDT")]
        [StringLength(15)]
        public string? Sdt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayDangKy { get; set; }
        [StringLength(255)]
        public string? DiaChi { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [StringLength(10)]
        public string? GioiTinh { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }
        [StringLength(255)]
        public string? HinhAnh { get; set; }
        [StringLength(255)]
        public string? GhiChu { get; set; }

        [InverseProperty(nameof(HoaDon.MaKhachHangNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
