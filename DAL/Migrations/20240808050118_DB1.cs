using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class DB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChucVu__D46395332EEC50B7", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    SDT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgayDangKy = table.Column<DateTime>(type: "datetime", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__CA1930A44F24CFA0", x => x.SDT);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    MaVoucher = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GiamGia = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime", nullable: true),
                    MoTaVoucher = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhuyenMa__0AAC5B1196A6763A", x => x.MaVoucher);
                });

            migrationBuilder.CreateTable(
                name: "KichCo",
                columns: table => new
                {
                    MaKichCoSP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    KichCo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KichCo__75335AFF2C57021E", x => x.MaKichCoSP);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    MaMauSP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MauSac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MauSac__487A0E4C3255AAA2", x => x.MaMauSP);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieu",
                columns: table => new
                {
                    MaThuongHieu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ThuongHi__A3733E2CB3011A42", x => x.MaThuongHieu);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    MaChucVu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__77B2CA47A51640EF", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK__NhanVien__MaChuc__403A8C7D",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaMauSP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MaKichCoSP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ChatLieu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "datetime", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: true),
                    MaThuongHieu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__FAC7442D90ED2440", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK__SanPham__MaKichC__440B1D61",
                        column: x => x.MaKichCoSP,
                        principalTable: "KichCo",
                        principalColumn: "MaKichCoSP");
                    table.ForeignKey(
                        name: "FK__SanPham__MaMauSP__4316F928",
                        column: x => x.MaMauSP,
                        principalTable: "MauSac",
                        principalColumn: "MaMauSP");
                    table.ForeignKey(
                        name: "FK__SanPham__MaThuon__44FF419A",
                        column: x => x.MaThuongHieu,
                        principalTable: "ThuongHieu",
                        principalColumn: "MaThuongHieu");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NgayLapHoaDon = table.Column<DateTime>(type: "datetime", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MaNhanVien = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MaVoucher = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TienKhachDua = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDon__835ED13B0DB74B94", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK__HoaDon__MaNhanVi__4AB81AF0",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                    table.ForeignKey(
                        name: "FK__HoaDon__MaVouche__4BAC3F29",
                        column: x => x.MaVoucher,
                        principalTable: "KhuyenMai",
                        principalColumn: "MaVoucher");
                    table.ForeignKey(
                        name: "FK__HoaDon__SDT__49C3F6B7",
                        column: x => x.SDT,
                        principalTable: "KhachHang",
                        principalColumn: "SDT");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChiTietH__F557F66148B7DE1B", x => new { x.MaHD, x.MaSP });
                    table.ForeignKey(
                        name: "FK__ChiTietHoa__MaHD__4E88ABD4",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon");
                    table.ForeignKey(
                        name: "FK__ChiTietHoa__MaSP__4F7CD00D",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_MaSP",
                table: "ChiTietHoaDon",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaVoucher",
                table: "HoaDon",
                column: "MaVoucher");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_SDT",
                table: "HoaDon",
                column: "SDT");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "NhanVien",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaKichCoSP",
                table: "SanPham",
                column: "MaKichCoSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaMauSP",
                table: "SanPham",
                column: "MaMauSP");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaThuongHieu",
                table: "SanPham",
                column: "MaThuongHieu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "KichCo");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "ThuongHieu");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
