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
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [StringLength(10)]
        public string MaKhuyenMai { get; set; } = null!;
        [StringLength(255)]
        public string? DieuKienApDung { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayBatDau { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayKetThuc { get; set; }
        [StringLength(255)]
        public string? MoTaKhuyenMai { get; set; }

        [InverseProperty(nameof(SanPham.MaKhuyenMaiNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
