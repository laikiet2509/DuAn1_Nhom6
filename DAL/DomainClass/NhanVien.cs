﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; } = null!;
        [StringLength(255)]
        public string? Ten { get; set; }
        [StringLength(10)]
        public string? GioiTinh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgaySinh { get; set; }
        [Column("SDT")]
        [StringLength(15)]
        public string? Sdt { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [StringLength(255)]
        public string? DiaChi { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }
        [StringLength(10)]
        public string? MaChucVu { get; set; }

        [ForeignKey(nameof(MaChucVu))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu? MaChucVuNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.MaNhanVienNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [InverseProperty(nameof(TaiKhoan.MaNhanVienNavigation))]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
