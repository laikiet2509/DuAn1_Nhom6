using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaKhuyenMai { get; set; } = null!;
        public string? DieuKienApDung { get; set; }
        public DateTime? ThoiGianApDung { get; set; }
        public string? MoTaKhuyenMai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
