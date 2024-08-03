using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("SanPham")]
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaSanPham { get; set; } = null!;
        [StringLength(255)]
        public string? TenSanPham { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal GiaBan { get; set; }
        [Column("MaMauSP")]
        [StringLength(10)]
        public string? MaMauSp { get; set; }
        [Column("MaKichCoSP")]
        [StringLength(10)]
        public string? MaKichCoSp { get; set; }
        [StringLength(255)]
        public string? ChatLieu { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayNhap { get; set; }
        public string? HinhAnh { get; set; }
        public int? SoLuongTon { get; set; }
        [StringLength(10)]
        public string? MaThuongHieu { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaKichCoSp))]
        [InverseProperty(nameof(KichCo.SanPhams))]
        public virtual KichCo? MaKichCoSpNavigation { get; set; }
        [ForeignKey(nameof(MaMauSp))]
        [InverseProperty(nameof(MauSac.SanPhams))]
        public virtual MauSac? MaMauSpNavigation { get; set; }
        [ForeignKey(nameof(MaThuongHieu))]
        [InverseProperty(nameof(ThuongHieu.SanPhams))]
        public virtual ThuongHieu? MaThuongHieuNavigation { get; set; }
        [InverseProperty(nameof(ChiTietHoaDon.MaSpNavigation))]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
