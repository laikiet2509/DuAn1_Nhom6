using DAL.Context;
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
                    .Count(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den);
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
                    .Count(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den);
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
                    .Count(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den);
                lbl_HoaDon.Text = soHoaDon.ToString();

                // 3. Tính số hóa đơn hủy
                var soDonHuy = context.HoaDons
                    .Count(hd => hd.TrangThai == 2 && hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den);
                lbl_DonHuy.Text = soDonHuy.ToString();

                // 4. Tính số khách hàng
                var soKhachHang = context.KhachHangs
                    .Count(kh => kh.HoaDons.Any(hd => hd.NgayLapHoaDon >= tu && hd.NgayLapHoaDon <= den));
                lbl_KhachHang.Text = soKhachHang.ToString();
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
                    .Count(hd => hd.NgayLapHoaDon.Value.Date == today);
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
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
