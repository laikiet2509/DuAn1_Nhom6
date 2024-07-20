using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KichCo
    {
        public KichCo()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaKichCoSp { get; set; } = null!;
        public string? KichCo1 { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
