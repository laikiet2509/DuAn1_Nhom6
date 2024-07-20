using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class BanGiayTheThaoContext : DbContext
    {
        public BanGiayTheThaoContext()
        {
        }

        public BanGiayTheThaoContext(DbContextOptions<BanGiayTheThaoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<KichCo> KichCos { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=GIGABYTE\\SQLEXPRESS;Database=BanGiayTheThao;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSp })
                    .HasName("PK__ChiTietH__F557F66147361E29");

                entity.ToTable("ChiTietHoaDon");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(10)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaSP");

                entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietHoa__MaHD__5EBF139D");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietHoa__MaSP__5FB337D6");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__ChucVu__D463953346550491");

                entity.ToTable("ChucVu");

                entity.Property(e => e.MaChucVu).HasMaxLength(10);

                entity.Property(e => e.TenChucVu).HasMaxLength(30);
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B20ADBDFA");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHoaDon).HasMaxLength(10);

                entity.Property(e => e.MaKhachHang).HasMaxLength(10);

                entity.Property(e => e.MaNhanVien).HasMaxLength(10);

                entity.Property(e => e.NgayLapHoaDon).HasColumnType("datetime");

                entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK__HoaDon__MaKhachH__5AEE82B9");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK__HoaDon__MaNhanVi__5BE2A6F2");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E53B2F6551");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKhachHang).HasMaxLength(10);

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.HinhAnh).HasMaxLength(255);

                entity.Property(e => e.NgayDangKy).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenKhachHang).HasMaxLength(255);

                entity.Property(e => e.TrangThai).HasMaxLength(50);
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.MaKhuyenMai)
                    .HasName("PK__KhuyenMa__6F56B3BDDCB1D165");

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.MaKhuyenMai).HasMaxLength(10);

                entity.Property(e => e.DieuKienApDung).HasMaxLength(255);

                entity.Property(e => e.MoTaKhuyenMai).HasMaxLength(255);

                entity.Property(e => e.ThoiGianApDung).HasColumnType("datetime");
            });

            modelBuilder.Entity<KichCo>(entity =>
            {
                entity.HasKey(e => e.MaKichCoSp)
                    .HasName("PK__KichCo__75335AFFB78476EB");

                entity.ToTable("KichCo");

                entity.Property(e => e.MaKichCoSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaKichCoSP");

                entity.Property(e => e.KichCo1)
                    .HasMaxLength(50)
                    .HasColumnName("KichCo");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasKey(e => e.MaMauSp)
                    .HasName("PK__MauSac__487A0E4C8BBB1F0C");

                entity.ToTable("MauSac");

                entity.Property(e => e.MaMauSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaMauSP");

                entity.Property(e => e.MauSac1)
                    .HasMaxLength(50)
                    .HasColumnName("MauSac");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA472939B4C6");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNhanVien).HasMaxLength(10);

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.MaChucVu).HasMaxLength(10);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .HasColumnName("SDT");

                entity.Property(e => e.Ten).HasMaxLength(255);

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("FK__NhanVien__MaChuc__5165187F");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D340E5879");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanPham).HasMaxLength(10);

                entity.Property(e => e.ChatLieu).HasMaxLength(255);

                entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HinhAnh).HasMaxLength(255);

                entity.Property(e => e.MaKhuyenMai).HasMaxLength(10);

                entity.Property(e => e.MaKichCoSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaKichCoSP");

                entity.Property(e => e.MaMauSp)
                    .HasMaxLength(10)
                    .HasColumnName("MaMauSP");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.Property(e => e.TenSanPham).HasMaxLength(255);

                entity.Property(e => e.ThuongHieu).HasMaxLength(255);

                entity.HasOne(d => d.MaKhuyenMaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaKhuyenMai)
                    .HasConstraintName("FK__SanPham__MaKhuye__5629CD9C");

                entity.HasOne(d => d.MaKichCoSpNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaKichCoSp)
                    .HasConstraintName("FK__SanPham__MaKichC__5535A963");

                entity.HasOne(d => d.MaMauSpNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaMauSp)
                    .HasConstraintName("FK__SanPham__MaMauSP__5441852A");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.Idtk)
                    .HasName("PK__TaiKhoan__B87C3A833C57BBA8");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.Idtk)
                    .HasMaxLength(10)
                    .HasColumnName("IDTK");

                entity.Property(e => e.MaNhanVien).HasMaxLength(10);

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.TaiKhoan1)
                    .HasMaxLength(50)
                    .HasColumnName("TaiKhoan");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK__TaiKhoan__MaNhan__628FA481");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
