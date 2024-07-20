using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TaiKhoan
    {
        public string Idtk { get; set; } = null!;
        public string? TaiKhoan1 { get; set; }
        public string? MatKhau { get; set; }
        public string? TrangThai { get; set; }
        public string? MaNhanVien { get; set; }

        public virtual NhanVien? MaNhanVienNavigation { get; set; }
    }
}
