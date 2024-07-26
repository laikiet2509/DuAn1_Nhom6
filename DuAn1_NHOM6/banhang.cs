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

namespace PRL
{
    public partial class banhang : Form
    {
        
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

        
        private bool daThanhToanDu = false;
        private string maNhanVien;
        public banhang()
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
            dataTableSPCT = new DataTable();
            dataTableHDCT = new DataTable();
            
        }
        private decimal TinhTongTienHoaDon(string maHoaDon)
        {
            var listHDCT = serviceHDCT.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal tongTien = 0;

            foreach (var hdct in listHDCT)
            {
                tongTien += hdct.GiaBan * hdct.SoLuong;
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

            foreach (var hdct in hoaDonChiTiets)
            {
                DataRow dr = dataTableHDCT.NewRow();
                dr["MaSPCT"] = hdct.MaSp;
                dr["MaHoaDon"] = hdct.MaHd;
                dr["DonGia"] = hdct.GiaBan;
                dr["SoLuong"] = hdct.SoLuong;
                dataTableHDCT.Rows.Add(dr);
            }
            dtgView_hoadon.DataSource = dataTableHDCT;
            if (cmbx_hoadoncho.SelectedValue != null)
            {
                lblTongTien.Text = TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString()).ToString("#,##0.00 'VND'");
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
                DataRow dr = dataTableSPCT.NewRow();
                dr["MaSPCT"] = spct.MaSanPham;
                dr["TenSP"] = spct.TenSanPham;
                dr["MauSac"] = serviceMS.GetMauSacById(spct.MaMauSp).MauSac1;
                dr["KichCo"] = serviceKC.GetKichCoById(spct.MaKichCoSp).KichCo1;
                dr["DonGia"] = spct.GiaBan;
                dr["SoLuong"] = spct.SoLuongTon;
                dataTableSPCT.Rows.Add(dr);
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
                //hoaDon.MaNhanVien = _nhanVien.MaNhanVien;
                hoaDon.Sdt = txt_SDT.Text;
                hoaDon.NgayLapHoaDon = DateTime.Now;
                hoaDon.TrangThai = 0; // 0: hóa đơn chờ, 1: đã thanh toán, 2: đã hủy (tự quy định)

                serviceHD.TaoHoaDonCho(hoaDon);

                MessageBox.Show("Tạo hóa đơn chờ thành công!");

                LoadData_cbbHoaDonCho();
            }
        }

        private void txt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            decimal tienKhachDua = 0;
            var tongSoTien = TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString());

            if (decimal.TryParse(txt_tienkhachdua.Text, out tienKhachDua))
            {
                lblTienThua.Text = (tienKhachDua - tongSoTien).ToString("#,##0.00 'VND'");
                if (tienKhachDua >= tongSoTien)
                {
                    daThanhToanDu = true;
                }
                else
                {
                    daThanhToanDu = false;
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng số tiền!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            var listHDCT = serviceHDCT.GetAllHoaDonCTByMaHoaDon(cmbx_hoadoncho.SelectedValue.ToString());
            foreach (var hdct in listHDCT)
            {
                var spct = serviceSP.GetAllSanPhamChiTietById(hdct.MaSp);
                // hoàn lại số lượng sản phẩm đã chọn trong hóa đơn vào lại danh sách sản phẩm
                spct.SoLuongTon += hdct.SoLuong;

                serviceSP.UpdateSoLuong(spct);
            }

            serviceHD.SuaTrangThai(cmbx_hoadoncho.SelectedValue.ToString(), 2);
            MessageBox.Show("Đã hủy hóa đơn!");
            RefreshToanBoForm();
        }
        private void RefreshToanBoForm()
        {
            txt_SDT.Text = string.Empty;
            txt_tenkhachhang.Text = string.Empty;
            txt_search.Text = string.Empty;
            txt_tienkhachdua.Text = "0";
            lblTienThua.Text = "Tiền thừa";
            lblTongTien.Text = "Tổng tiền";

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
            if (TinhTongTienHoaDon(cmbx_hoadoncho.SelectedValue.ToString()) > 0)
            {
                if (daThanhToanDu)
                {
                    serviceHD.SuaTrangThai(cmbx_hoadoncho.SelectedValue.ToString(), 1);
                    MessageBox.Show("Đã thanh toán hóa đơn!");
                    RefreshToanBoForm();
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
        private void dtgView_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgView_danhsachsanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowHienTai = dtgView_danhsachsanpham.Rows[e.RowIndex];
            var maSPCTDangTao = rowHienTai.Cells[0].Value.ToString();
            var spctDangTao = serviceSP.GetAllSanPhamChiTietById(maSPCTDangTao);

            var hoaDonDangChon = cmbx_hoadoncho.SelectedItem as HoaDon;

            NhapSoLuongSanPham formSoLuongMua = new NhapSoLuongSanPham();
            formSoLuongMua.ShowDialog();

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
            var listSPTimKiem = serviceSP.GetSanPhams()
            .Where(sp => sp.TenSanPham.ToLower().Contains(txt_search.Text.ToLower())).ToList();

            var listSPCTTimKiem = serviceSP.GetSanPhams()
                .Where(spct => listSPTimKiem.Any(sp => sp.MaSanPham == spct.MaSanPham)).ToList();

            LoadData_dgvSanPhamChiTiet(listSPCTTimKiem);
        }

        private void cmbx_hoadoncho_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
