using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MauSac
    {
        public MauSac()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaMauSp { get; set; } = null!;
        public string? MauSac1 { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
