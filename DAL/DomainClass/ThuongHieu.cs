using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("ThuongHieu")]
    public partial class ThuongHieu
    {
        public ThuongHieu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [StringLength(10)]
        public string MaThuongHieu { get; set; } = null!;
        [StringLength(255)]
        public string? TenThuongHieu { get; set; }

        [InverseProperty(nameof(SanPham.MaThuongHieuNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
