using BUS.Services;
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
    public partial class hoadon : Form
    {
        public HoaDonServices serviceHD;
        public HoaDonChiTietServices serviceHDCT;
        public hoadon()
        {
            InitializeComponent();
            serviceHD = new HoaDonServices();
            serviceHDCT = new HoaDonChiTietServices();
            LoadGirdHD();
            LoadGirdHDCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            // Make sure the end date is at the end of the day
            endDate = endDate.AddDays(1).AddTicks(-1);

            // Filter invoices based on the selected date range
            var filteredInvoices = serviceHD.GetAllHoaDons()
                .Where(hd => hd.NgayLapHoaDon >= startDate && hd.NgayLapHoaDon <= endDate)
                .ToList();

            // Load the filtered invoices into the DataGridView
            dtgView_hoadon.Rows.Clear();
            foreach (var hd in filteredInvoices)
            {
                dtgView_hoadon.Rows.Add(hd.MaHoaDon, hd.NgayLapHoaDon, hd.TongTien, hd.MaNhanVien, hd.TrangThai);
            }
        }
        public void LoadGirdHD()
        {
            dtgView_hoadon.ColumnCount = 5;
            dtgView_hoadon.Columns[0].Name = "Mã Hóa Đơn";
            dtgView_hoadon.Columns[1].Name = "Ngày Lập Hóa Đơn";
            dtgView_hoadon.Columns[2].Name = "Tổng Tiền";
            dtgView_hoadon.Columns[3].Name = "Mã Nhân Viên";
            dtgView_hoadon.Columns[4].Name = "Trạng Thái";
            dtgView_hoadon.Rows.Clear();
            foreach (var hd in serviceHD.GetAllHoaDons())
            {
                dtgView_hoadon.Rows.Add(hd.MaHoaDon, hd.NgayLapHoaDon, hd.TongTien, hd.MaNhanVien, hd.TrangThai);
            }
        }
        public void LoadGirdHDCT()
        {
            dtgView_chitiethoadon.ColumnCount = 4;
            dtgView_chitiethoadon.Columns[0].Name = "Mã Hóa Đơn";
            dtgView_chitiethoadon.Columns[1].Name = "Mã Sản Phẩm";
            dtgView_chitiethoadon.Columns[2].Name = "Số Lượng";
            dtgView_chitiethoadon.Columns[3].Name = "Giá Bán";
            dtgView_chitiethoadon.Rows.Clear();
            foreach (var hd in serviceHDCT.GetChiTietHoaDons())
            {
                dtgView_chitiethoadon.Rows.Add(hd.MaHd, hd.MaSp, hd.SoLuong, hd.GiaBan);
            }
        }
    }
}
