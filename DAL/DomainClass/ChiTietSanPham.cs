using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("ChiTietSanPham")]
    public partial class ChiTietSanPham
    {
        [Key]
        [Column("MaChiTietSP")]
        [StringLength(10)]
        public string MaChiTietSp { get; set; } = null!;
        [StringLength(10)]
        public string? MaSanPham { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }
        [Column("MaKichCoSP")]
        [StringLength(10)]
        public string? MaKichCoSp { get; set; }

        [ForeignKey(nameof(MaKichCoSp))]
        [InverseProperty(nameof(KichCo.ChiTietSanPhams))]
        public virtual KichCo? MaKichCoSpNavigation { get; set; }
        [ForeignKey(nameof(MaSanPham))]
        [InverseProperty(nameof(SanPham.ChiTietSanPhams))]
        public virtual SanPham? MaSanPhamNavigation { get; set; }
    }
}
