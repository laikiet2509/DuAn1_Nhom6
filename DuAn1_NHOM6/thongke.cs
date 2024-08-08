using DAL.Context;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class thongke : Form
    {
        private DBContext _dbContext = new DBContext();
        public thongke()
        {
            InitializeComponent();
            this.Load += new EventHandler(thongke_Load);

            // Gắn sự kiện SelectedIndexChanged với các ComboBox
            cbx_LocTheoNam.SelectedIndexChanged += new EventHandler(this.ComboBox_SelectedIndexChanged);
            cbx_LocTheoThang.SelectedIndexChanged += new EventHandler(this.ComboBox_SelectedIndexChanged);

            // Gắn sự kiện Click với nút Tìm
            btn_Tim.Click += new EventHandler(this.btn_Tim_Click);

            // Gắn sự kiện Click với nút Doanh Thu Hôm Nay
            btn_DTHomNay.Click += new EventHandler(this.btn_DTHomNay_Click);


            // Gắn sự kiện Click với nút Sản phẩm sắp hết hàng
            btn_SanPhamSapHetHang.Click += new EventHandler(this.btn_SanPhamSapHetHang_Click);

        }

        private void thongke_Load(object sender, EventArgs e)
        {
            // Xóa tất cả các mục cũ trước khi thêm mới
            cbx_LocTheoNam.Items.Clear();
            cbx_LocTheoThang.Items.Clear();

            // Thêm các giá trị năm vào ComboBox
            for (int year = 2020; year <= DateTime.Now.Year; year++)
            {
                cbx_LocTheoNam.Items.Add(year.ToString());
            }

            // Thêm các giá trị tháng vào ComboBox
            for (int month = 1; month <= 12; month++)
            {
                cbx_LocTheoThang.Items.Add(month.ToString());
            }

            // Đặt năm hiện tại
            int currentYear = DateTime.Now.Year;
            cbx_LocTheoNam.SelectedItem = currentYear.ToString();

            // Đặt tháng hiện tại
            int currentMonth = DateTime.Now.Month;
            cbx_LocTheoThang.SelectedItem = currentMonth.ToString();
        }
        private void UpdateDataByYear(int selectedYear)
        {
            DateTime tu = new DateTime(selectedYear, 1, 1);
            DateTime den = new DateTime(selectedYear, 12, 31);

            using (var context = new DBContext())
            {
                // 1. Tính doanh thu (chỉ tính hóa đơn không bị hủy)
                var doanhThu = context.HoaDons
                    .Where(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den &&
                                 hd.TrangThai != 2)  // Thêm điều kiện lọc hóa đơn không bị hủy
                    .Sum(hd => hd.TongTien);
                lbl_SoDoanhThu.Text = $"{doanhThu:N0} VND"; // Sử dụng định dạng N0 để không có phần thập phân

                // 2. Tính số hóa đơn
                var soHoaDon = context.HoaDons
                    .Count(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den && hd.TrangThai != 2);
                lbl_HoaDon.Text = soHoaDon.ToString();

                // 3. Tính số hóa đơn hủy
                var soDonHuy = context.HoaDons
                    .Count(hd => hd.TrangThai == 2 &&
                                 hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den);
                lbl_DonHuy.Text = soDonHuy.ToString();

                // 4. Tính số khách hàng
                var soKhachHang = context.KhachHangs
                    .Count(kh => kh.HoaDons.Any(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den && hd.TrangThai != 2));
                lbl_KhachHang.Text = soKhachHang.ToString();
            }
        }

        private void UpdateDataByYearAndMonth(int selectedYear, int selectedMonth)
        {
            DateTime tu = new DateTime(selectedYear, selectedMonth, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            using (var context = new DBContext())
            {
                // 1. Tính doanh thu (chỉ tính hóa đơn không bị hủy)
                var doanhThu = context.HoaDons
                    .Where(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den &&
                                 hd.TrangThai != 2)  // Thêm điều kiện lọc hóa đơn không bị hủy
                    .Sum(hd => hd.TongTien);
                lbl_SoDoanhThu.Text = $"{doanhThu:N0} VND"; // Sử dụng định dạng N0 để không có phần thập phân

                // 2. Tính số hóa đơn
                var soHoaDon = context.HoaDons
                    .Count(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den && hd.TrangThai != 2);
                lbl_HoaDon.Text = soHoaDon.ToString();

                // 3. Tính số hóa đơn hủy
                var soDonHuy = context.HoaDons
                    .Count(hd => hd.TrangThai == 2 &&
                                 hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den);
                lbl_DonHuy.Text = soDonHuy.ToString();

                // 4. Tính số khách hàng
                var soKhachHang = context.KhachHangs
                    .Count(kh => kh.HoaDons.Any(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den));
                lbl_KhachHang.Text = soKhachHang.ToString();
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu sự kiện là từ ComboBox năm
            if (sender == cbx_LocTheoNam)
            {
                // Lấy giá trị năm được chọn
                int selectedYear = int.Parse(cbx_LocTheoNam.SelectedItem.ToString());

                // Cập nhật số liệu dựa trên năm được chọn
                UpdateDataByYear(selectedYear);

                // Cập nhật sản phẩm bán chạy cho năm được chọn
                var sanPhamBanChay = LaySanPhamBanChayTheoNam(selectedYear);
                HienThiSanPhamBanChay(sanPhamBanChay);
            }
            else if (sender == cbx_LocTheoThang)
            {
                // Kiểm tra nếu năm đã được chọn
                if (cbx_LocTheoNam.SelectedItem != null)
                {
                    // Lấy giá trị năm và tháng được chọn
                    int selectedYear = int.Parse(cbx_LocTheoNam.SelectedItem.ToString());
                    int selectedMonth = int.Parse(cbx_LocTheoThang.SelectedItem.ToString());

                    // Cập nhật số liệu dựa trên năm và tháng được chọn
                    UpdateDataByYearAndMonth(selectedYear, selectedMonth);

                    // Cập nhật sản phẩm bán chạy cho tháng và năm được chọn
                    var sanPhamBanChay = LaySanPhamBanChayTheoThang(selectedYear, selectedMonth);
                    HienThiSanPhamBanChay(sanPhamBanChay); // Gọi phương thức để hiển thị sản phẩm bán chạy
                }
            }

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            DateTime tu = dtp_TGTu.Value;
            DateTime den = dtp_TGDen.Value;

            using (var context = new DBContext())
            {
                // 1. Tính doanh thu (chỉ tính hóa đơn không bị hủy)
                var doanhThu = context.HoaDons
                    .Where(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den && hd.TrangThai != 2)  // Thêm điều kiện lọc hóa đơn không bị hủy
                    .Sum(hd => hd.TongTien);
                lbl_SoDoanhThu.Text = $"{doanhThu:N0} VND"; // Sử dụng định dạng N0 để không có phần thập phân

                // 2. Tính số hóa đơn
                var soHoaDon = context.HoaDons
                    .Count(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den && hd.TrangThai != 2);
                lbl_HoaDon.Text = soHoaDon.ToString();

                // 3. Tính số hóa đơn hủy
                var soDonHuy = context.HoaDons
                    .Count(hd => hd.TrangThai == 2 && hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den);
                lbl_DonHuy.Text = soDonHuy.ToString();

                // 4. Tính số khách hàng
                var soKhachHang = context.KhachHangs
                    .Count(kh => kh.HoaDons.Any(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den));
                lbl_KhachHang.Text = soKhachHang.ToString();

                // Cập nhật số liệu dựa trên khoảng thời gian cụ thể
                var sanPhamBanChay = LaySanPhamBanChayTrongKhoangThoiGian(tu, den);
                HienThiSanPhamBanChay(sanPhamBanChay); // Gọi phương thức để hiển thị sản phẩm bán chạy
            }

        }
        private void ThongKeHomNay()
        {
            DateTime today = DateTime.Today;

            using (var context = new DBContext())
            {
                // 1. Tính doanh thu (chỉ tính hóa đơn không bị hủy)
                var doanhThu = context.HoaDons
                    .Where(hd => hd.NgayLapHoaDon.Value.Date == today && hd.TrangThai != 2)  // Thêm điều kiện lọc hóa đơn không bị hủy
                    .Sum(hd => hd.TongTien);
                lbl_SoDoanhThu.Text = $"{doanhThu:N0} VND"; // Sử dụng định dạng N0 để không có phần thập phân

                // 2. Tính số hóa đơn
                var soHoaDon = context.HoaDons
                    .Count(hd => hd.NgayLapHoaDon.Value.Date == today && hd.TrangThai != 2);
                lbl_HoaDon.Text = soHoaDon.ToString();

                // 3. Tính số hóa đơn hủy
                var soDonHuy = context.HoaDons
                    .Count(hd => hd.TrangThai == 2 && hd.NgayLapHoaDon.Value.Date == today);
                lbl_DonHuy.Text = soDonHuy.ToString();

                // 4. Tính số khách hàng
                var soKhachHang = context.KhachHangs
                    .Count(kh => kh.HoaDons.Any(hd => hd.NgayLapHoaDon.Value.Date == today));
                lbl_KhachHang.Text = soKhachHang.ToString();


            }

        }

        private void btn_DTHomNay_Click(object sender, EventArgs e)
        {
            ThongKeHomNay();
            // Lấy và hiển thị sản phẩm bán chạy trong ngày hôm nay
            var sanPhamBanChayHomNay = LaySanPhamBanChayHomNay();
            HienThiSanPhamBanChay(sanPhamBanChayHomNay); // Hiển thị sản phẩm bán chạy
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private List<SanPham> LaySanPhamBanChayHomNay()
        {
            DateTime today = DateTime.Today;

            using (var context = new DBContext())
            {
                return context.ChiTietHoaDons
                    .Include(cthd => cthd.MaHdNavigation)
                    .Where(cthd => cthd.MaHdNavigation != null && cthd.MaHdNavigation.NgayLapHoaDon.Value.Date == today && cthd.MaHdNavigation.TrangThai != 2)
                    .GroupBy(cthd => cthd.MaSp)
                    .Select(g => new
                    {
                        MaSanPham = g.Key,
                        TongSoLuongBan = g.Sum(x => x.SoLuong)
                    })
                    .Where(x => x.TongSoLuongBan >= 10) // Lọc sản phẩm bán chạy, điều chỉnh nếu cần
                    .OrderByDescending(x => x.TongSoLuongBan)
                    .Take(10)
                    .Join(context.SanPhams,
                          x => x.MaSanPham,
                          sp => sp.MaSanPham,
                          (x, sp) => sp)
                    .ToList();
            }
        }
        private List<SanPham> LaySanPhamBanChayTheoNam(int selectedYear)
        {
            DateTime tu = new DateTime(selectedYear, 1, 1);
            DateTime den = new DateTime(selectedYear, 12, 31);

            return LaySanPhamBanChayTrongKhoangThoiGian(tu, den);
        }
        private List<SanPham> LaySanPhamBanChayTheoThang(int selectedYear, int selectedMonth)
        {
            DateTime tu = new DateTime(selectedYear, selectedMonth, 1);
            DateTime den = tu.AddMonths(1).AddDays(-1);

            return LaySanPhamBanChayTrongKhoangThoiGian(tu, den);
        }
        private List<SanPham> LaySanPhamBanChayTrongKhoangThoiGian(DateTime tu, DateTime den)
        {
            using (var context = new DBContext())
            {

                // Tính tổng số lượng bán được của từng sản phẩm
                var sanPhamBanChay = context.ChiTietHoaDons
                    .Include(cthd => cthd.MaHdNavigation)
                    .Where(cthd => cthd.MaHdNavigation != null && cthd.MaHdNavigation.NgayLapHoaDon >= tu && cthd.MaHdNavigation.NgayLapHoaDon <= den && cthd.MaHdNavigation.TrangThai != 2)
                    .GroupBy(cthd => cthd.MaSp)
                    .Select(g => new
                    {
                        MaSanPham = g.Key,
                        TongSoLuongBan = g.Sum(x => x.SoLuong)
                    })
                    .Where(x => x.TongSoLuongBan >= 10)
                    .OrderByDescending(x => x.TongSoLuongBan)
                    .Take(10)
                    .Join(context.SanPhams,
                          x => x.MaSanPham,
                          sp => sp.MaSanPham,
                          (x, sp) => sp)
                    .ToList();

                return sanPhamBanChay;
            }
        }
        public List<SanPham> LaySanPhamSapHetHang(int nguongSoLuongTon)
        {
            using (var context = new DBContext())
            {
                return context.SanPhams
                    .Where(sp => sp.SoLuongTon <= nguongSoLuongTon)
                    .ToList();
            }
        }

        private void btn_SanPhamSapHetHang_Click(object sender, EventArgs e)
        {
            int nguongSoLuongTon = 10; // Sản phẩm có số lượng tồn nhỏ hơn hoặc bằng 10 sẽ được coi là sắp hết hàng

            using (var context = new DBContext())
            {
                var sanPhamSapHetHang = context.SanPhams
                    .Where(sp => sp.SoLuongTon <= nguongSoLuongTon)
                    .ToList();

                dgv_SanPhamSapHetHang.DataSource = sanPhamSapHetHang;

                // Kiểm tra và ẩn các cột không cần thiết
                if (dgv_SanPhamSapHetHang.Columns["MaKichCoSpNavigation"] != null)
                    dgv_SanPhamSapHetHang.Columns["MaKichCoSpNavigation"].Visible = false;
                if (dgv_SanPhamSapHetHang.Columns["MaMauSpNavigation"] != null)
                    dgv_SanPhamSapHetHang.Columns["MaMauSpNavigation"].Visible = false;
                if (dgv_SanPhamSapHetHang.Columns["MaThuongHieuNavigation"] != null)
                    dgv_SanPhamSapHetHang.Columns["MaThuongHieuNavigation"].Visible = false;
                if (dgv_SanPhamSapHetHang.Columns["ChiTietHoaDons"] != null)
                    dgv_SanPhamSapHetHang.Columns["ChiTietHoaDons"].Visible = false;
                if (dgv_SanPhamSapHetHang.Columns["HinhAnh"] != null)
                    dgv_SanPhamSapHetHang.Columns["HinhAnh"].Visible = false;

            }
        }
        private void HienThiSanPhamBanChay(List<SanPham> sanPhamBanChay)
        {
            dgv_SanPhamBanChay.DataSource = sanPhamBanChay;

            // Kiểm tra và ẩn các cột không cần thiết
            if (dgv_SanPhamBanChay.Columns["MaKichCoSpNavigation"] != null)
                dgv_SanPhamBanChay.Columns["MaKichCoSpNavigation"].Visible = false;
            if (dgv_SanPhamBanChay.Columns["MaMauSpNavigation"] != null)
                dgv_SanPhamBanChay.Columns["MaMauSpNavigation"].Visible = false;
            if (dgv_SanPhamBanChay.Columns["MaThuongHieuNavigation"] != null)
                dgv_SanPhamBanChay.Columns["MaThuongHieuNavigation"].Visible = false;
            if (dgv_SanPhamBanChay.Columns["ChiTietHoaDons"] != null)
                dgv_SanPhamBanChay.Columns["ChiTietHoaDons"].Visible = false;
            if (dgv_SanPhamBanChay.Columns["HinhAnh"] != null)
                dgv_SanPhamBanChay.Columns["HinhAnh"].Visible = false;
        }
    }
}
