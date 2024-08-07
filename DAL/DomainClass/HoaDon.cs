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
        [Column("SDT")]
        [StringLength(15)]
        public string? Sdt { get; set; }
        [StringLength(10)]
        public string? MaNhanVien { get; set; }
        [StringLength(10)]
        public string? MaVoucher { get; set; }

        public decimal? TienKhachDua { get; set; }

        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien? MaNhanVienNavigation { get; set; }
        [ForeignKey(nameof(MaVoucher))]
        [InverseProperty(nameof(KhuyenMai.HoaDons))]
        public virtual KhuyenMai? MaVoucherNavigation { get; set; }
        [ForeignKey(nameof(Sdt))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang? SdtNavigation { get; set; }
        [InverseProperty(nameof(ChiTietHoaDon.MaHdNavigation))]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
