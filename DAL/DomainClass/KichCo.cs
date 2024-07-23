using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("KichCo")]
    public partial class KichCo
    {
        public KichCo()
        {
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [Column("MaKichCoSP")]
        [StringLength(10)]
        public string MaKichCoSp { get; set; } = null!;
        [Column("KichCo")]
        [StringLength(50)]
        public string? KichCo1 { get; set; }

        [InverseProperty(nameof(ChiTietSanPham.MaKichCoSpNavigation))]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
        [InverseProperty(nameof(SanPham.MaKichCoSpNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
