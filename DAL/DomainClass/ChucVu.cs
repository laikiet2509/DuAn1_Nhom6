using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("ChucVu")]
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [StringLength(10)]
        public string MaChucVu { get; set; } = null!;
        [StringLength(30)]
        public string? TenChucVu { get; set; }

        [InverseProperty(nameof(NhanVien.MaChucVuNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
