using System;
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
        [Column("SDT")]
        [StringLength(15)]
        public string Sdt { get; set; } = null!;
        [StringLength(255)]
        public string? TenKhachHang { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayDangKy { get; set; }
        [StringLength(255)]
        public string? DiaChi { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        public bool GioiTinh { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }
        [StringLength(255)]
        public string? HinhAnh { get; set; }
        [StringLength(255)]
        public string? GhiChu { get; set; }

        [InverseProperty(nameof(HoaDon.SdtNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
