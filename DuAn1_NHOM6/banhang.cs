using Aspose.Words;
using BUS.Services;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using ThuVienWinform.Report.AsposeWordExtension;
using static System.Windows.Forms.AxHost;
using Aspose.Words.Tables;
using DAL.Context;

namespace PRL
{
    public partial class banhang : Form
    {
        DBContext dbContext = new DBContext();
        private NhanVien _nhanVien;
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
        public DataTable dataTableSPCT;
        public DataTable dataTableHDCT;
        public ThuongHieuServices serviceTH; // Thêm dịch vụ cho thương hiệu
        private string tenTep = "";
        private bool daThanhToanDu = false;
        private string maNhanVien;
        private HoaDon _hoaDon;
        public banhang(NhanVien nhanVien)
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
            serviceTH = new ThuongHieuServices(); // Khởi tạo dịch vụ cho thương hiệu
            dataTableSPCT = new DataTable();
            dataTableHDCT = new DataTable();
            _nhanVien = nhanVien;
            cbb_mausac.DropDown += new EventHandler(cbb_hang_DropDown);
            cbb_size.DropDown += new EventHandler(cbb_hang_DropDown);
            cbb_hang.DropDown += new EventHandler(cbb_hang_DropDown);
        }
        private decimal TinhTongTienHoaDon(string maHoaDon, string maVoucher)
        {
            var listHDCT = serviceHDCT.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal tongTien = 0;

            foreach (var hdct in listHDCT)
            {
                tongTien += hdct.GiaBan * hdct.SoLuong;
            }
            if (!string.IsNullOrEmpty(maVoucher))
            {
                KhuyenMai khuyenMai = LayThongTinKhuyenMai(maVoucher);
                if (khuyenMai != null && khuyenMai.NgayBatDau <= DateTime.Now && khuyenMai.NgayKetThuc >= DateTime.Now)
                {
                    decimal tienGiam = tongTien * khuyenMai.GiamGia / 100;
                    // Tổng hóa đơn sau khi áp dụng khuyến mãi
                    tongTien = tongTien - tienGiam;
                }
            }
            return tongTien;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void banhang_Load(object sender, EventArgs e)
        {
            // create datatable SPCT
            dataTableSPCT.Columns.Add("MaSPCT", typeof(string));
            dataTableSPCT.Columns.Add("TenSP", typeof(string));
            dataTableSPCT.Columns.Add("MauSac", typeof(string));
            dataTableSPCT.Columns.Add("KichCo", typeof(string));
            dataTableSPCT.Columns.Add("DonGia", typeof(decimal));
            dataTableSPCT.Columns.Add("SoLuong", typeof(int));
            dataTableSPCT.Columns.Add("ThuongHieu", typeof(string)); // Thêm cột thương hiệu
            dataTableSPCT.Columns.Add("ChatLieu", typeof(string)); // Thêm cột chất liệu

            LoadData_dgvSanPhamChiTiet(serviceSP.GetSanPhams());
            LoadData_cbbHoaDonCho();

            // create datatable HDCT


            dataTableHDCT.Columns.Add("MaSPCT", typeof(string));
            dataTableHDCT.Columns.Add("MaHoaDon", typeof(string));
            dataTableHDCT.Columns.Add("DonGia", typeof(decimal));
            dataTableHDCT.Columns.Add("SoLuong", typeof(int));

            if (cmbx_hoadoncho.SelectedValue != null)
            {
                LoadData_dgvHoaDonChiTiet(serviceHDCT.GetAllHoaDonCTByMaHoaDon(cmbx_hoadoncho.SelectedValue.ToString()));
            }
        }
        private void LoadData_dgvHoaDonChiTiet(List<ChiTietHoaDon> hoaDonChiTiets)
        {
            dataTableHDCT.Rows.Clear();

            var dt = new DataTable();
            dt.Columns.Add("MaSPCT", typeof(string));
            dt.Columns.Add("MaHoaDon", typeof(string));
            dt.Columns.Add("DonGia", typeof(decimal));
            dt.Columns.Add("SoLuong", typeof(int));

            foreach (var hdct in hoaDonChiTiets)
            {
                if (hdct.SoLuong > 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaSPCT"] = hdct.MaSp;
                    dr["MaHoaDon"] = hdct.MaHd;
                    dr["DonGia"] = hdct.GiaBan;
                    dr["SoLuong"] = hdct.SoLuong;
                    dt.Rows.Add(dr);
                }
            }
            dtgView_hoadon.DataSource = dt;
            if (cmbx_hoadoncho.SelectedValue != null)
            {
                lblTongTien.Text = TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString(), "").ToString("#,##0.00 'VND'");
            }
        }

        private void LoadData_cbbHoaDonCho()
        {
            cmbx_hoadoncho.DataSource = null;
            cmbx_hoadoncho.Items.Clear();

            // Load dữ liệu lên combobox
            var listHoaDonCho = serviceHD.GetAllHoaDonChos();
            cmbx_hoadoncho.DataSource = listHoaDonCho; // nguồn dữ liệu combobox
            cmbx_hoadoncho.DisplayMember = "MaHoaDon"; // mỗi item hiển thị mã hóa đơn
            cmbx_hoadoncho.ValueMember = "MaHoaDon"; // mỗi item có giá trị là mã hóa đơn
            cmbx_hoadoncho.SelectedItem = listHoaDonCho.FirstOrDefault();

            if (listHoaDonCho.Count == 0)
            {
                cmbx_hoadoncho.SelectedIndex = -1; // Không chọn mục nào cả
            }
        }
        private void LoadData_dgvSanPhamChiTiet(List<SanPham> sanPhamChiTiets)
        {
            dataTableSPCT.Rows.Clear();

            foreach (var spct in sanPhamChiTiets)
            {
                // Kiểm tra nếu số lượng tồn kho > 0 thì mới thêm vào dataTableSPCT
                if (spct.TrangThai == 1)
                {
                    DataRow dr = dataTableSPCT.NewRow();
                    dr["MaSPCT"] = spct.MaSanPham;
                    dr["TenSP"] = spct.TenSanPham;
                    dr["MauSac"] = serviceMS.GetMauSacById(spct.MaMauSp).MauSac1;
                    dr["KichCo"] = serviceKC.GetKichCoById(spct.MaKichCoSp).KichCo1;
                    dr["DonGia"] = spct.GiaBan;
                    dr["SoLuong"] = spct.SoLuongTon;
                    dr["ThuongHieu"] = serviceTH.GetThuongHieuById(spct.MaThuongHieu).TenThuongHieu; // Lấy dữ liệu thương hiệu
                    dr["ChatLieu"] = spct.ChatLieu; // Lấy dữ liệu chất liệu
                    dataTableSPCT.Rows.Add(dr);
                }
            }
            dtgView_danhsachsanpham.DataSource = dataTableSPCT;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgView_danhsachsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var khachHang = serviceKH.GetKhachHangBySDT(txt_SDT.Text);
            if (khachHang == null)
            {
                MessageBox.Show("SĐT khách hàng không hợp lệ!");
            }
            else
            {

                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = "HD" + (serviceHD.GetAllHoaDons().Count + 1);

                //hoaDon.MaNhanVien = NhanVienDangNhap.MaNhanVien;
                hoaDon.MaNhanVien = _nhanVien.MaNhanVien;
                hoaDon.Sdt = txt_SDT.Text;
                hoaDon.NgayLapHoaDon = DateTime.Now;
                hoaDon.TrangThai = 0; // 0: hóa đơn chờ, 1: đã thanh toán, 2: đã hủy (tự quy định)

                serviceHD.TaoHoaDonCho(hoaDon);

                MessageBox.Show("Tạo hóa đơn chờ thành công!");
                _hoaDon = hoaDon;
                LoadData_cbbHoaDonCho();
            }
        }

        private void txt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            // decimal tienKhachDua = 0;
            // var tongSoTien = TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString());

            string maVoucher = txt_maVoucher.Text;
            decimal tongSoTien = TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString(), "");
            lblTongTien.Text = tongSoTien.ToString("#,##0.00 'VND'");
            decimal tongSoTienSauGiam = tongSoTien;
            lbl_TienAddVoucher.Text = tongSoTien.ToString("#,##0.00 'VND'");

            if (!string.IsNullOrEmpty(maVoucher))
            {
                KhuyenMai khuyenMai = LayThongTinKhuyenMai(maVoucher);
                if (khuyenMai != null && khuyenMai.NgayBatDau <= DateTime.Now && khuyenMai.NgayKetThuc >= DateTime.Now)
                {
                    decimal tienGiam = tongSoTien * khuyenMai.GiamGia / 100;
                    lbl_TienAddVoucher.Text = tienGiam.ToString("#,##0.00 'VND'");

                    // Tổng hóa đơn sau khi áp dụng khuyến mãi
                    tongSoTienSauGiam = tongSoTien - tienGiam;
                    lbl_TienAddVoucher.Text = tongSoTienSauGiam.ToString("#,##0.00 'VND'");
                }
                else
                {
                    MessageBox.Show("Mã Voucher không hợp lệ hoặc đã hết hạn!");
                }
            }

            decimal tienKhachDua;
            if (decimal.TryParse(txt_tienkhachdua.Text, out tienKhachDua))
            {
                if (tienKhachDua < 0)
                {
                    MessageBox.Show("Số tiền khách đưa không được là số âm!");
                    txt_tienkhachdua.Text = string.Empty; // Xóa nội dung trong ô nhập liệu
                    lblTienThua.Text = "0.00 VND"; // Đặt lại nhãn tiền thừa
                    daThanhToanDu = false; // Đặt lại trạng thái thanh toán
                    return;
                }
                decimal tienThua = tienKhachDua - tongSoTienSauGiam;
                lblTienThua.Text = tienThua.ToString("#,##0.00 'VND'");

                if (tienKhachDua >= tongSoTienSauGiam)
                {
                    daThanhToanDu = true;
                    NhanVienDangNhap.TienKhachDua = tienKhachDua;
                }
                else
                {
                    daThanhToanDu = false;
                }
            }
            else
            {
                lblTienThua.Text = "0.00 VND";  
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hóa đơn chờ không
            if (cmbx_hoadoncho.SelectedValue == null || string.IsNullOrEmpty(cmbx_hoadoncho.SelectedValue.ToString()))
            {
                MessageBox.Show("Không có hóa đơn chờ, vui lòng tạo hóa đơn chờ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var listHDCT = serviceHDCT.GetAllHoaDonCTByMaHoaDon(cmbx_hoadoncho.SelectedValue.ToString());
            foreach (var hdct in listHDCT)
            {
                var spct = serviceSP.GetAllSanPhamChiTietById(hdct.MaSp);
                // hoàn lại số lượng sản phẩm đã chọn trong hóa đơn vào lại danh sách sản phẩm
                spct.SoLuongTon += hdct.SoLuong;

                serviceSP.UpdateSoLuong(spct);
            }

            serviceHD.SuaTrangThai(cmbx_hoadoncho.SelectedValue.ToString(), 2, "");
            MessageBox.Show("Đã hủy hóa đơn!");
            RefreshToanBoForm();
        }
        private void RefreshToanBoForm()
        {
            txt_SDT.Text = string.Empty;
            txt_tenkhachhang.Text = string.Empty;
            txt_search.Text = string.Empty;
            txt_tienkhachdua.Text = string.Empty;
            lblTienThua.Text = "0.00 VNĐ";
            lblTongTien.Text = "0.00 VNĐ";
            lbl_TienAddVoucher.Text = "0.00 VNĐ";
            //txt_maVoucher.Text = string.Empty;

            LoadData_cbbHoaDonCho();
            LoadData_dgvSanPhamChiTiet(serviceSP.GetSanPhams());
            if (cmbx_hoadoncho.SelectedValue != null)
            {
                LoadData_dgvHoaDonChiTiet(serviceHDCT.GetAllHoaDonCTByMaHoaDon(cmbx_hoadoncho.SelectedValue.ToString()));
            }
            else
            {
                LoadData_dgvHoaDonChiTiet(new List<ChiTietHoaDon>());
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (cmbx_hoadoncho.SelectedValue == null)
            {
                MessageBox.Show("Không có hóa đơn chờ, vui lòng tạo hóa đơn chờ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString(), txt_maVoucher.Text) > 0)
            {
                if (daThanhToanDu)
                {
                    serviceHD.SuaTrangThai(cmbx_hoadoncho.SelectedValue.ToString(), 1, txt_maVoucher.Text);
                    serviceHD.SuaTongTien(cmbx_hoadoncho.SelectedValue.ToString(), TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString(), txt_maVoucher.Text));
                    MessageBox.Show("Đã thanh toán hóa đơn!");
                    RefreshToanBoForm();
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn in hóa đơn không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //MessageBox.Show("Ok nhé");
                        inhoaDon();
                        
                    }
                    txt_maVoucher.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Tiền khách đưa chưa đủ!");
                }
            }
            else
            {
                MessageBox.Show("Hóa đơn trống!");
            }
            
        }
        public void inhoaDon()
        {
            //if (dtgView_hoadon.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn một hóa đơn để tạo báo cáo.");
            //    return;
            //}

            //string selectedHoaDonId = dtgView_hoadon.SelectedRows[0].Cells[0].Value.ToString();
            //var hoadon = serviceHD.GetAllHoaDons().FirstOrDefault(x => x.MaHoaDon == selectedHoaDonId);
            //if (hoadon == null)
            //{
            //    MessageBox.Show("Không tìm thấy hóa đơn.");
            //    return;
            //}

            var khachhang = serviceKH.GetKhachHangs(btn_timkiem.Text).FirstOrDefault(x => x.Sdt == _hoaDon.Sdt);
            //var nhanvien = serviceNV.GetNhanViens().FirstOrDefault(x => x.MaNhanVien == hoadon.MaNhanVien);
            var hdcts = serviceHDCT.GetChiTietHoaDons().Where(x => x.MaHd == _hoaDon.MaHoaDon).ToList();
            var km = serviceKM.GetKhuyenMais(btn_timkiem.Text).FirstOrDefault(x => x.MaVoucher == _hoaDon.MaVoucher);
            //var homNay = DateTime.Now;


            Document baoCao = new Document("C:\\Users\\pc\\Desktop\\New folder\\DuAn1_Nhom6\\DuAn1_NHOM6\\template\\Hoa_don.docx");

            baoCao.MailMerge.Execute(new[] { "MA_HOA_DON" }, new[] { _hoaDon.MaHoaDon });
            baoCao.MailMerge.Execute(new[] { "MA_NHANVIEN" }, new[] { _hoaDon.MaNhanVien });
            baoCao.MailMerge.Execute(new[] { "Khuyen_Mai" }, new[] { km != null ? km.MoTaVoucher + " %" : "Không áp dụng" });
            baoCao.MailMerge.Execute(new[] { "Ten_KhachHang" }, new[] { khachhang.TenKhachHang });
            baoCao.MailMerge.Execute(new[] { "NGAY_THANHTOAN" }, new[] { _hoaDon.NgayLapHoaDon.Value.ToString("dd/MM/yyyy") });
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

            var tongTien = TinhTongTienHoaDon(_hoaDon.MaHoaDon, txt_maVoucher.Text);
            //var tongTienSauKm = km != null ? tongTien * (1 - ((decimal)km.MaVoucher / 100)) : tongTien;
            baoCao.MailMerge.Execute(new[] { "Tong" }, new[] { tongTien.ToString() });

            var tienkhachdua = NhanVienDangNhap.TienKhachDua;
            baoCao.MailMerge.Execute(new[] { "Tienkhachdua" }, new[] { tienkhachdua.ToString() });
            //Tính tiền thừa
            var tienthua = NhanVienDangNhap.TienKhachDua - (tongTien);
            baoCao.MailMerge.Execute(new[] { "Tienthua" }, new[] { tienthua.ToString() });

            // Bước 4: Lưu và mở file
            string path = @"C:\Users\pc\Desktop\hoa_don_bh"; // đường dẫn folder có tên hoá đơn
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path); // tạo folder (Hóa đơn) mới nếu chưa có
            string filename = $"{_hoaDon.MaHoaDon}.pdf";
            tenTep = $@"{path}\{filename}";

            baoCao.Save(tenTep);
            MessageBox.Show("Xuất Hóa Đơn Thành Công");
        }
        private void dtgView_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgView_danhsachsanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dtgView_danhsachsanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (obj == string.Empty)
            {
                MessageBox.Show("Ô bạn chọn không chứa dữ liệu.");
                return;
            }

            var rowHienTai = dtgView_danhsachsanpham.Rows[e.RowIndex];
            var maSPCTDangTao = rowHienTai.Cells[0].Value.ToString();
            var spctDangTao = serviceSP.GetAllSanPhamChiTietById(maSPCTDangTao);

            var hoaDonDangChon = cmbx_hoadoncho.SelectedItem as HoaDon;

            NhapSoLuongSanPham formSoLuongMua = new NhapSoLuongSanPham();
            formSoLuongMua.ShowDialog();
            if (formSoLuongMua.SoLuongMua < 0) // Kiểm tra xem số lượng nhập vào có âm không
            {
                MessageBox.Show("Không được nhập số âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hiển thị thông báo lỗi
                return; // Thoát khỏi phương thức nếu số lượng nhập vào là âm
            }

            if (formSoLuongMua.SoLuongMua > spctDangTao.SoLuongTon) // Kiểm tra xem số lượng nhập vào có vượt quá số lượng tồn kho không
            {
                MessageBox.Show("Số lượng tồn kho không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hiển thị thông báo lỗi
                return; // Thoát khỏi phương thức nếu số lượng nhập vào vượt quá số lượng tồn kho
            }

            var hoaDonChiTietTonTai = serviceHDCT.GetHDCTById(hoaDonDangChon.MaHoaDon, maSPCTDangTao);

            // chưa tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> thêm mới
            if (hoaDonChiTietTonTai == null)
            {
                ChiTietHoaDon hoaDonChiTietDangTao = new ChiTietHoaDon();
                hoaDonChiTietDangTao.MaSp = maSPCTDangTao;
                hoaDonChiTietDangTao.MaHd = hoaDonDangChon.MaHoaDon;
                hoaDonChiTietDangTao.GiaBan = spctDangTao.GiaBan;
                hoaDonChiTietDangTao.SoLuong = formSoLuongMua.SoLuongMua;

                serviceHDCT.ThemMoiHDCT(hoaDonChiTietDangTao);
            }
            // nếu đã tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> cập nhật số lượng
            else
            {
                ChiTietHoaDon hoaDonChiTietDangUpdate = new ChiTietHoaDon();
                hoaDonChiTietDangUpdate.MaSp = maSPCTDangTao;
                hoaDonChiTietDangUpdate.MaHd = hoaDonDangChon.MaHoaDon;
                hoaDonChiTietDangUpdate.GiaBan = spctDangTao.GiaBan;
                hoaDonChiTietDangUpdate.SoLuong = hoaDonChiTietTonTai.SoLuong + formSoLuongMua.SoLuongMua;

                serviceHDCT.UpdateSoLuong(hoaDonChiTietDangUpdate);
            }

            spctDangTao.SoLuongTon -= formSoLuongMua.SoLuongMua;
            serviceSP.UpdateSoLuong(spctDangTao);
            // update tổng tiền cho hóa đơn chờ
            var tien = TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString(), txt_maVoucher.Text);
            //serviceHD.SuaTongTien(cmbx_hoadoncho.SelectedValue.ToString(), TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString(), txt_maVoucher.Text));

            // load lại dữ liệu trên 2 data grid view
            txt_search.Text = string.Empty;
            LoadData_dgvSanPhamChiTiet(serviceSP.GetSanPhams());
            LoadData_dgvHoaDonChiTiet(serviceHDCT.GetAllHoaDonCTByMaHoaDon(cmbx_hoadoncho.SelectedValue.ToString()));
        }


        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //var listSPTimKiem = serviceSP.GetSanPhams()
            //    .Where(sp => sp.TenSanPham.ToLower().Contains(txt_search.Text.ToLower())).ToList();

            //var listSPCTTimKiem = serviceSP.GetSanPhams()
            //    .Where(spct => listSPTimKiem.Contains(serviceSP.GetSanPhams(spct.MaSanPham))).ToList();
            //var listSPTimKiem = serviceSP.GetSanPhams()
            //.Where(sp => sp.TenSanPham.ToLower().Contains(txt_search.Text.ToLower())).ToList();

            //var listSPCTTimKiem = serviceSP.GetSanPhams()
            //    .Where(spct => listSPTimKiem.Any(sp => sp.MaSanPham == spct.MaSanPham)).ToList();

            //LoadData_dgvSanPhamChiTiet(listSPCTTimKiem);
        }

        private void cmbx_hoadoncho_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tienkhachdua.Text = string.Empty;
            lblTienThua.Text = "0.00 VNĐ";
            lblTongTien.Text = "0.00 VNĐ";
            lbl_TienAddVoucher.Text = "0.00 VNĐ";

            var hoaDonDangChon = cmbx_hoadoncho.SelectedItem as HoaDon;

            if (hoaDonDangChon != null)
            {
                txt_SDT.Text = hoaDonDangChon.Sdt;
                txt_tenkhachhang.Text = serviceKH.GetKhachHangBySDT(hoaDonDangChon.Sdt).TenKhachHang;
                LoadData_dgvHoaDonChiTiet(serviceHDCT.GetAllHoaDonCTByMaHoaDon(hoaDonDangChon.MaHoaDon));
            }
        }

        private void txt_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var khachHang = serviceKH.GetKhachHangBySDT(txt_SDT.Text);
                if (khachHang == null)
                {
                    MessageBox.Show("SĐT khách hàng không hợp lệ!");
                }
                else
                {
                    txt_tenkhachhang.Text = khachHang.TenKhachHang;
                }
            }
        }

        private void dtgView_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = dtgView_hoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (obj == string.Empty)
            {
                MessageBox.Show("Ô bạn chọn không chứa dữ liệu.");
                return;
            }

            if (e.RowIndex >= 0) // Kiểm tra xem chỉ số hàng có hợp lệ không
            {
                var rowHienTai = dtgView_danhsachsanpham.Rows[e.RowIndex]; // Lấy hàng hiện tại từ DataGridView
                var maSPCTDangTao = rowHienTai.Cells[0].Value.ToString(); // Lấy mã sản phẩm chi tiết từ cột đầu tiên của hàng
                var spctDangTao = serviceSP.GetAllSanPhamChiTietById(maSPCTDangTao); // Lấy thông tin sản phẩm chi tiết từ service

                var hoaDonDangChon = cmbx_hoadoncho.SelectedItem as HoaDon; // Lấy hóa đơn đang chọn từ ComboBox


                NhapSoLuongSanPham formSoLuongMua = new NhapSoLuongSanPham(); // Khởi tạo form nhập số lượng sản phẩm
                formSoLuongMua.ShowDialog(); // Hiển thị form nhập số lượng sản phẩm

                if (formSoLuongMua.SoLuongMua < 0) // Kiểm tra xem số lượng nhập vào có âm không
                {
                    MessageBox.Show("Không được nhập số âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hiển thị thông báo lỗi
                    return; // Thoát khỏi phương thức nếu số lượng nhập vào là âm
                }



                var hoaDonChiTietTonTai = serviceHDCT.GetHDCTById(hoaDonDangChon.MaHoaDon, maSPCTDangTao); // Lấy thông tin chi tiết hóa đơn nếu đã tồn tại

                // chưa tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> thêm mới
                if (hoaDonChiTietTonTai == null)
                {
                    if (formSoLuongMua.SoLuongMua > spctDangTao.SoLuongTon) // Kiểm tra xem số lượng nhập vào có vượt quá số lượng tồn kho không
                    {
                        MessageBox.Show("Số lượng tồn kho không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hiển thị thông báo lỗi
                        return; // Thoát khỏi phương thức nếu số lượng nhập vào vượt quá số lượng tồn kho
                    }

                    ChiTietHoaDon hoaDonChiTietDangTao = new ChiTietHoaDon(); // Khởi tạo chi tiết hóa đơn mới
                    hoaDonChiTietDangTao.MaSp = maSPCTDangTao; // Gán mã sản phẩm
                    hoaDonChiTietDangTao.MaHd = hoaDonDangChon.MaHoaDon; // Gán mã hóa đơn
                    hoaDonChiTietDangTao.GiaBan = spctDangTao.GiaBan; // Gán giá bán của sản phẩm
                    hoaDonChiTietDangTao.SoLuong = formSoLuongMua.SoLuongMua; // Gán số lượng mua từ form nhập

                    serviceHDCT.ThemMoiHDCT(hoaDonChiTietDangTao); // Thêm mới chi tiết hóa đơn vào service

                    // Giảm số lượng tồn kho
                    spctDangTao.SoLuongTon -= formSoLuongMua.SoLuongMua; // Giảm số lượng tồn kho của sản phẩm
                }
                // nếu đã tồn tại sản phẩm chi tiết này trong hóa đơn chi tiết -> cập nhật số lượng
                else
                {
                    int soLuongCu = hoaDonChiTietTonTai.SoLuong; // Lấy số lượng cũ của sản phẩm trong hóa đơn chi tiết
                    int soLuongMoi = formSoLuongMua.SoLuongMua; // Lấy số lượng mới từ form nhập
                    int chenhLechSoLuong = soLuongMoi - soLuongCu; // Tính toán chênh lệch số lượng

                    if (chenhLechSoLuong > 0 && chenhLechSoLuong > spctDangTao.SoLuongTon) // Kiểm tra nếu chênh lệch số lượng là dương và vượt quá số lượng tồn kho
                    {
                        MessageBox.Show("Số lượng tồn kho không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Hiển thị thông báo lỗi
                        return; // Thoát khỏi phương thức nếu số lượng tồn kho không đủ
                    }

                    if (chenhLechSoLuong != 0) // Kiểm tra nếu có sự thay đổi số lượng
                    {
                        if (chenhLechSoLuong > 0) // Nếu tăng số lượng trong hóa đơn chi tiết
                        {
                            spctDangTao.SoLuongTon -= chenhLechSoLuong; // Giảm số lượng tồn kho
                        }
                        else // Nếu giảm số lượng trong hóa đơn chi tiết
                        {
                            spctDangTao.SoLuongTon += Math.Abs(chenhLechSoLuong); // Tăng số lượng tồn kho
                        }

                        hoaDonChiTietTonTai.SoLuong = soLuongMoi; // Cập nhật số lượng mới cho chi tiết hóa đơn
                        serviceHDCT.UpdateSoLuong(hoaDonChiTietTonTai); // Cập nhật số lượng trong service
                    }
                }

                serviceSP.UpdateSoLuong(spctDangTao); // Cập nhật số lượng tồn kho trong service

                // load lại dữ liệu trên 2 data grid view
                txt_search.Text = string.Empty; // Xóa nội dung tìm kiếm
                LoadData_dgvSanPhamChiTiet(serviceSP.GetSanPhams()); // Tải lại dữ liệu cho DataGridView sản phẩm chi tiết
                LoadData_dgvHoaDonChiTiet(serviceHDCT.GetAllHoaDonCTByMaHoaDon(cmbx_hoadoncho.SelectedValue.ToString())); // Tải lại dữ liệu cho DataGridView hóa đơn chi tiết
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_maVoucher_TextChanged(object sender, EventArgs e)
        {

        }
        private KhuyenMai LayThongTinKhuyenMai(string maKhuyenMai)
        {
            // Giả sử serviceKM đã được khởi tạo và có phương thức để lấy thông tin khuyến mãi
            KhuyenMai khuyenMai = serviceKM.GetKhuyenMaiByMa(maKhuyenMai);
            return khuyenMai;
        }

        private void txt_maVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string maVoucher = txt_maVoucher.Text;
                KhuyenMai khuyenMai = LayThongTinKhuyenMai(maVoucher);

                decimal tongSoTien = TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString(), "");
                lblTongTien.Text = tongSoTien.ToString("#,##0.00 'VND'");

                decimal tongSoTienSauGiam = tongSoTien;
                if (khuyenMai != null && khuyenMai.NgayBatDau <= DateTime.Now && khuyenMai.NgayKetThuc >= DateTime.Now)
                {
                    decimal tienGiam = tongSoTien * khuyenMai.GiamGia / 100;
                    lbl_TienAddVoucher.Text = tienGiam.ToString("#,##0.00 'VND'");

                    // Tổng hóa đơn sau khi áp dụng khuyến mãi
                    tongSoTienSauGiam = tongSoTien - tienGiam;
                    lbl_TienAddVoucher.Text = tongSoTienSauGiam.ToString("#,##0.00 'VND'");
                }
                else
                {
                    lbl_TienAddVoucher.Text = "";
                    lbl_TienAddVoucher.Text = tongSoTien.ToString("#,##0.00 'VND'");
                    MessageBox.Show("Mã Voucher không hợp lệ hoặc đã hết hạn!");
                }

            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.ToLower();

            // Tìm kiếm theo tên sản phẩm hoặc mã sản phẩm
            var listSPTimKiem = serviceSP.GetSanPhams()
                .Where(sp => sp.TenSanPham.ToLower().Contains(searchText) || sp.MaSanPham.ToLower().Contains(searchText))
                .ToList();

            var listSPCTTimKiem = serviceSP.GetSanPhams()
                .Where(spct => listSPTimKiem.Any(sp => sp.MaSanPham == spct.MaSanPham))
                .ToList();

            LoadData_dgvSanPhamChiTiet(listSPCTTimKiem);
        }

        private void cbb_hang_DropDown(object sender, EventArgs e)
        {
            if (cbb_hang.Items.Count == 0)
            {
                var thuongHieus = serviceTH.GetThuongHieus();
                cbb_hang.DataSource = thuongHieus;
                cbb_hang.DisplayMember = "TenThuongHieu";
                cbb_hang.ValueMember = "MaThuongHieu";
            }
        }

        private void cbb_mausac_DropDown(object sender, EventArgs e)
        {
            if (cbb_mausac.Items.Count == 0)
            {
                var mauSacs = serviceMS.GetMauSacs();
                cbb_mausac.DataSource = mauSacs;
                cbb_mausac.DisplayMember = "MauSac1";
                cbb_mausac.ValueMember = "MaMauSp";
            }
        }

        private void cbb_size_DropDown(object sender, EventArgs e)
        {
            if (cbb_size.Items.Count == 0)
            {
                var kichCos = serviceKC.GetKichCos();
                cbb_size.DataSource = kichCos;
                cbb_size.DisplayMember = "KichCo1";
                cbb_size.ValueMember = "MaKichCoSp";
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cbb_hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_hang.SelectedValue != null)
            {
                // Lấy mã thương hiệu được chọn từ ComboBox
                string maThuongHieu = cbb_hang.SelectedValue.ToString();

                // Tìm kiếm các sản phẩm thuộc thương hiệu đó
                var listSPTheoThuongHieu = serviceSP.GetSanPhams()
                    .Where(sp => sp.MaThuongHieu == maThuongHieu)
                    .ToList();

                // Hiển thị danh sách sản phẩm trong DataGridView
                LoadData_dgvSanPhamChiTiet(listSPTheoThuongHieu);
            }
        }

        private void cbb_mausac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_mausac.SelectedValue != null)
            {
                // Lấy mã màu sắc được chọn từ ComboBox
                string maMauSac = cbb_mausac.SelectedValue.ToString();

                // Tìm kiếm các sản phẩm thuộc màu sắc đó
                var listSPTheoMauSac = serviceSP.GetSanPhams()
                    .Where(sp => sp.MaMauSp == maMauSac)
                    .ToList();

                // Hiển thị danh sách sản phẩm trong DataGridView
                LoadData_dgvSanPhamChiTiet(listSPTheoMauSac);
            }
        }

        private void cbb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_size.SelectedValue != null)
            {
                // Lấy mã kích cỡ được chọn từ ComboBox
                string maSize = cbb_size.SelectedValue.ToString();

                // Tìm kiếm các sản phẩm thuộc kích cỡ đó
                var listSPTheoSize = serviceSP.GetSanPhams()
                    .Where(sp => sp.MaKichCoSp == maSize)
                    .ToList();

                // Hiển thị danh sách sản phẩm trong DataGridView
                LoadData_dgvSanPhamChiTiet(listSPTheoSize);
            }
        }
    }
}
