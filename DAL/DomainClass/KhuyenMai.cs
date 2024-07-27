using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaKhuyenMai { get; set; } = null!;
        [Column(TypeName = "decimal(5, 2)")]
        public decimal GiamGia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayBatDau { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayKetThuc { get; set; }
        [StringLength(255)]
        public string? MoTaKhuyenMai { get; set; }

        [InverseProperty(nameof(HoaDon.MaKhuyenMaiNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
