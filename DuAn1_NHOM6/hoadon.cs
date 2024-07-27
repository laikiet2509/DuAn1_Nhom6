using Aspose.Words;
using Aspose.Words.Tables;
using BUS.Services;
using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienWinform.Report.AsposeWordExtension;
using static System.Windows.Forms.AxHost;

namespace PRL
{
    public partial class hoadon : Form
    {
        DBContext dbContext;
        private string tenTep = "";
        public BanHangServices serviceBH;
        public HoaDonServices serviceHD;
        public KhachHangServices serviceKH;
        public NhanVienServices serviceNV;
        public KhuyenMaiServices serviceKM;
        public MauSacServices serviceMS;
        public KichCoServices serviceKC;
        public ChucVuServices serviceCV;
        public SanPhamServices serviceSP;
        public HoaDonChiTietServices serviceHDCT;

        public hoadon _hoadon;

        public hoadon()
        {
            InitializeComponent();
            serviceBH = new BanHangServices();
            serviceHD = new HoaDonServices();
            serviceKH = new KhachHangServices();
            serviceNV = new NhanVienServices();
            serviceKM = new KhuyenMaiServices();
            serviceMS = new MauSacServices();
            serviceKC = new KichCoServices();
            serviceCV = new ChucVuServices();
            serviceSP = new SanPhamServices();
            serviceHDCT = new HoaDonChiTietServices();

            LoadGirdHD();
            LoadGirdHDCT();
            dbContext = new DBContext();//khoi tao db
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
            dtgView_hoadon.Columns[3].Name = "Tên Nhân Viên";
            dtgView_hoadon.Columns[4].Name = "Trạng Thái";
            dtgView_hoadon.Rows.Clear();
            var lst = serviceNV.GetNhanViens().ToList();
            foreach (var hd in serviceHD.GetAllHoaDons())
            {
                dtgView_hoadon.Rows.Add(hd.MaHoaDon, hd.NgayLapHoaDon, hd.TongTien, lst.First(x => x.MaNhanVien.ToLower() == hd.MaNhanVien!.ToLower()).Ten, ConvertTrangThai(hd.TrangThai));
            }
        }
        // tạo 1 hàm convert trạng thái dùng switch case 
        public string ConvertTrangThai(int? trangThai)
        {
            string status = string.Empty;
            switch (trangThai)
            {
                case 1:
                    status = "Thành công";
                    break;
                case 2:
                    status = "Thất bại";
                    break;
                default:
                    break;
            }
            return status;

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

        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            if (dtgView_hoadon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để tạo báo cáo.");
                return;
            }

            string selectedHoaDonId = dtgView_hoadon.SelectedRows[0].Cells[0].Value.ToString();
            var hoadon = serviceHD.GetAllHoaDons().FirstOrDefault(x => x.MaHoaDon == selectedHoaDonId);
            if (hoadon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn.");
                return;
            }

            var khachhang = serviceKH.GetKhachHangs(btn_timkiem.Text).FirstOrDefault(x => x.Sdt == hoadon.Sdt);
            var nhanvien = serviceNV.GetNhanViens().FirstOrDefault(x => x.MaNhanVien == hoadon.MaNhanVien);
            var hdcts = serviceHDCT.GetChiTietHoaDons().Where(x => x.MaHd == hoadon.MaHoaDon).ToList();
            var km = serviceKM.GetKhuyenMais(btn_timkiem.Text).FirstOrDefault(x => x.MaKhuyenMai == hoadon.MaKhuyenMai);
            var homNay = DateTime.Now;


            Document baoCao = new Document("C:\\Users\\ADMIN\\OneDrive\\Máy tính\\Final2\\DuAn1_Nhom6\\DuAn1_NHOM6\\template\\Hoa_don.docx");

            baoCao.MailMerge.Execute(new[] { "Ma_Hoa_Don" }, new[] { hoadon.MaHoaDon });
            baoCao.MailMerge.Execute(new[] { "Ma_NhanVien" }, new[] { nhanvien.MaNhanVien });
            baoCao.MailMerge.Execute(new[] { "Khuyen_Mai" }, new[] { km != null ? km.MoTaKhuyenMai + " %" : "Không áp dụng" });
            baoCao.MailMerge.Execute(new[] { "Ten_KhachHang" }, new[] { khachhang.TenKhachHang });
            baoCao.MailMerge.Execute(new[] { "Ngay_ThanhToan" }, new[] { hoadon.NgayLapHoaDon.Value.ToString("dd/MM/yyyy") });
            baoCao.MailMerge.Execute(new[] { "So_Dien_Thoai" }, new[] { khachhang.Sdt });
            baoCao.MailMerge.Execute(new[] { "Dia_Chi" }, new[] { khachhang.DiaChi });

            Table maHoaDonvsKhachHang = baoCao.GetChild(NodeType.Table, 1, true) as Table;
            int hanghientai = 1;
            maHoaDonvsKhachHang.InsertRows(hanghientai, hanghientai, hdcts.Count);

            int stt = 1;
            foreach (var item in hdcts)
            {
                var ctxe = serviceSP.GetSanPhams().FirstOrDefault(x => x.MaSanPham == item.MaSp);
                maHoaDonvsKhachHang.PutValue(hanghientai, 0, stt++.ToString());
                maHoaDonvsKhachHang.PutValue(hanghientai, 1, ctxe.TenSanPham);
                maHoaDonvsKhachHang.PutValue(hanghientai, 2, item.GiaBan.ToString());
                maHoaDonvsKhachHang.PutValue(hanghientai, 3, item.SoLuong.ToString());
                maHoaDonvsKhachHang.PutValue(hanghientai, 4, (item.GiaBan * item.SoLuong).ToString());
                hanghientai++;
            }

            var tongTien = hdcts.Sum(x => x.GiaBan * x.SoLuong);
            //var tongTienSauKm = km != null ? tongTien * (1 - ((decimal)km.MoTaKhuyenMai / 100)) : tongTien;
            baoCao.MailMerge.Execute(new[] { "Tong" }, new[] { tongTien.ToString() });

            // Bước 4: Lưu và mở file
            string path = @"C:\Users\ADMIN\OneDrive\Máy tính\hoadon"; // đường dẫn folder có tên hoá đơn
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path); // tạo folder (Hóa đơn) mới nếu chưa có
            string filename = $"{hoadon.MaHoaDon}.pdf";
            tenTep = $@"{path}\{filename}";

            baoCao.Save(tenTep);
            MessageBox.Show("Xuất Hóa Đơn Thành Công");
        }
    }
}
