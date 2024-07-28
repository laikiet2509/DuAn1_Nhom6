using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [Column("MaHD")]
        [StringLength(10)]
        public string MaHd { get; set; } = null!;
        [Key]
        [Column("MaSP")]
        [StringLength(10)]
        public string MaSp { get; set; } = null!;
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public decimal? ThanhTien { get; set; }

        [ForeignKey(nameof(MaHd))]
        [InverseProperty(nameof(HoaDon.ChiTietHoaDons))]
        public virtual HoaDon MaHdNavigation { get; set; } = null!;
        [ForeignKey(nameof(MaSp))]
        [InverseProperty(nameof(SanPham.ChiTietHoaDons))]
        public virtual SanPham MaSpNavigation { get; set; } = null!;
    }
}
