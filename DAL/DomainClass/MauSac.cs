using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("MauSac")]
    public partial class MauSac
    {
        public MauSac()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [Column("MaMauSP")]
        [StringLength(10)]
        public string MaMauSp { get; set; } = null!;
        [Column("MauSac")]
        [StringLength(50)]
        public string? MauSac1 { get; set; }

        [InverseProperty(nameof(SanPham.MaMauSpNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
