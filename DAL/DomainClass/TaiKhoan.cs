using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column("IDTK")]
        [StringLength(10)]
        public string Idtk { get; set; } = null!;
        [Column("TaiKhoan")]
        [StringLength(50)]
        public string? TaiKhoan1 { get; set; }
        [StringLength(50)]
        public string? MatKhau { get; set; }
        [StringLength(50)]
        public string? TrangThai { get; set; }
        [StringLength(10)]
        public string? MaNhanVien { get; set; }

        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(NhanVien.TaiKhoans))]
        public virtual NhanVien? MaNhanVienNavigation { get; set; }
    }
}
