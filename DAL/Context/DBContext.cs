using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.DomainClass;

namespace DAL.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;
        public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<KichCo> KichCos { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<ThuongHieu> ThuongHieus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source= LAPTOP-PH9VPOUT\\SQLEXPRESS;Initial Catalog= QuanLyBanHang113;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSp })
                    .HasName("PK__ChiTietH__F557F6619D86D84B");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietHoa__MaHD__52593CB8");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietHoa__MaSP__534D60F1");
            });

            modelBuilder.Entity<ChiTietSanPham>(entity =>
            {
                entity.HasKey(e => e.MaChiTietSp)
                    .HasName("PK__ChiTietS__651D9057BD9A33F8");

                entity.HasOne(d => d.MaKichCoSpNavigation)
                    .WithMany(p => p.ChiTietSanPhams)
                    .HasForeignKey(d => d.MaKichCoSp)
                    .HasConstraintName("FK__ChiTietSa__MaKic__49C3F6B7");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietSanPhams)
                    .HasForeignKey(d => d.MaSanPham)
                    .HasConstraintName("FK__ChiTietSa__MaSan__48CFD27E");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__ChucVu__D46395334694525C");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B99545315");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK__HoaDon__MaNhanVi__4F7CD00D");

                entity.HasOne(d => d.SdtNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.Sdt)
                    .HasConstraintName("FK__HoaDon__SDT__4E88ABD4");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.Sdt)
                    .HasName("PK__KhachHan__CA1930A4FC9ABF04");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.MaKhuyenMai)
                    .HasName("PK__KhuyenMa__6F56B3BD15F7D7C2");
            });

            modelBuilder.Entity<KichCo>(entity =>
            {
                entity.HasKey(e => e.MaKichCoSp)
                    .HasName("PK__KichCo__75335AFF8098F172");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasKey(e => e.MaMauSp)
                    .HasName("PK__MauSac__487A0E4C2091563F");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA474A53A691");

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("FK__NhanVien__MaChuc__403A8C7D");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D2AC5E9AA");

                entity.HasOne(d => d.MaKhuyenMaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaKhuyenMai)
                    .HasConstraintName("FK__SanPham__MaKhuye__44FF419A");

                entity.HasOne(d => d.MaKichCoSpNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaKichCoSp)
                    .HasConstraintName("FK__SanPham__MaKichC__440B1D61");

                entity.HasOne(d => d.MaMauSpNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaMauSp)
                    .HasConstraintName("FK__SanPham__MaMauSP__4316F928");

                entity.HasOne(d => d.MaThuongHieuNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaThuongHieu)
                    .HasConstraintName("FK__SanPham__MaThuon__45F365D3");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.Idtk)
                    .HasName("PK__TaiKhoan__B87C3A83ED5D08B2");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK__TaiKhoan__MaNhan__5629CD9C");
            });

            modelBuilder.Entity<ThuongHieu>(entity =>
            {
                entity.HasKey(e => e.MaThuongHieu)
                    .HasName("PK__ThuongHi__A3733E2CE980BEC6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
