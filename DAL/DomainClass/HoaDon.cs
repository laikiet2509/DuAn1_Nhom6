using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaHoaDon { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? NgayLapHoaDon { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? TongTien { get; set; }
        public int? TrangThai { get; set; }
        [StringLength(10)]
        public string? MaKhachHang { get; set; }
        [StringLength(10)]
        public string? MaNhanVien { get; set; }

        [ForeignKey(nameof(MaKhachHang))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang? MaKhachHangNavigation { get; set; }
        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien? MaNhanVienNavigation { get; set; }
        [InverseProperty(nameof(ChiTietHoaDon.MaHdNavigation))]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
