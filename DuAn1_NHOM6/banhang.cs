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

        public string idWhenClick;
        private bool daThanhToanDu = false;
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
            LoadGirdSP();
            LoadGirdHD();
        }
        public void LoadGirdHD()
        {
            dtgView_hoadon.ColumnCount = 6;
            dtgView_hoadon.Columns[0].Name = "Mã Hóa Đơn";
            dtgView_hoadon.Columns[1].Name = "Mã Khách Hàng";
            dtgView_hoadon.Columns[2].Name = "Mã Nhân Viên";
            dtgView_hoadon.Columns[3].Name = "Giá Tiền";
            dtgView_hoadon.Columns[4].Name = "Ngày Lập";
            dtgView_hoadon.Columns[5].Name = "Trạng Thái";
            dtgView_hoadon.Rows.Clear();
            foreach (var hd in serviceBH.GetHoaDons(txt_search.Text))
            {
                dtgView_hoadon.Rows.Add(hd.MaHoaDon, hd.NgayLapHoaDon, hd.TrangThai, hd.Sdt, hd.MaNhanVien);
            }
        }
        public void LoadGirdSP()
        {
            dtgView_danhsachsanpham.ColumnCount = 10;
            dtgView_danhsachsanpham.Columns[0].Name = "Mã Sản Phẩm";
            dtgView_danhsachsanpham.Columns[1].Name = "Tên Sản Phẩm";
            dtgView_danhsachsanpham.Columns[2].Name = "Màu Sắc";
            dtgView_danhsachsanpham.Columns[3].Name = "Chất Liệu";
            dtgView_danhsachsanpham.Columns[4].Name = "Giá Tiền";
            dtgView_danhsachsanpham.Columns[5].Name = "Ngày Nhập";
            dtgView_danhsachsanpham.Columns[6].Name = "Số Lượng";
            dtgView_danhsachsanpham.Columns[7].Name = "Thương Hiệu";
            dtgView_danhsachsanpham.Columns[8].Name = "Kích Thước";
            dtgView_danhsachsanpham.Columns[9].Name = "Hình Ảnh";
            dtgView_danhsachsanpham.Rows.Clear();
            foreach (var sp in serviceSP.GetSanPhams(txt_search.Text))
            {
                dtgView_danhsachsanpham.Rows.Add(sp.MaSanPham, sp.TenSanPham, sp.MaMauSp, sp.ChatLieu, sp.GiaBan, sp.NgayNhap, sp.SoLuongTon, sp.MaThuongHieu, sp.MaKichCoSp, sp.HinhAnh);
            }
        }
        private decimal TinhTongTienHoaDon(string maHoaDon)
        {
            var listHDCT = serviceHDCT.GetAllHoaDonCTByMaHoaDon(maHoaDon);
            decimal tongTien = 0;

            foreach (var hdct in listHDCT)
            {
                //tongTien += hdct.GiaBan * hdct.SoLuong;
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

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgView_danhsachsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= serviceSP.GetSanPhams(txt_search.Text).Count)
            {
                return;
            }
            idWhenClick = dtgView_danhsachsanpham.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            KhuyenMai km = new KhuyenMai();
            NhanVien nv = new NhanVien();
            hd.MaHoaDon = "HĐ" + (serviceHD.GetAllHoaDons().Count + 1);
            hd.Sdt = txt_SDT.Text;
            hd.NgayLapHoaDon = DateTime.Now;
            hd.TrangThai = 0;
            serviceHD.TaoHoaDonCho(hd);
            MessageBox.Show(serviceBH.ThemHD(hd));
            LoadGirdHD();
        }

        private void txt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            decimal tienKhachDua = 0;
            var tongSoTien = TinhTongTienHoaDon(txt_tienkhachdua.Text);

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
            //var listHDCT = serviceHDCT.GetAllHoaDonCTByMaHoaDon(txt_tienkhachdua.Text);
            //foreach (var hdct in listHDCT)
            //{
            //    var spct = serviceSP.GetSanPhams(hdct.MaSp);
            //    // hoàn lại số lượng sản phẩm đã chọn trong hóa đơn vào lại danh sách sản phẩm
            //    spct.SoLuongTon += hdct.SoLuong;

            //    sanPhamChiTietBLL.UpdateSoLuong(spct);
            //}

            //hoaDonBLL.SuaTrangThai(cbbHoaDonCho.SelectedValue.ToString(), 2);
            //MessageBox.Show("Đã hủy hóa đơn!");
            //RefreshToanBoForm();
        }
        //private void RefreshToanBoForm()
        //{
        //    txt_SDT.Text = string.Empty;
        //    txt_tenkhachhang.Text = string.Empty;
        //    txt_search.Text = string.Empty;
        //    txt_tienkhachdua.Text = "0";
        //    lblTienThua.Text = "Tiền thừa";
        //    lblTongTien.Text = "Tổng tiền";

        //    LoadData_cbbHoaDonCho();
        //    LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
        //    if (cbbHoaDonCho.SelectedValue != null)
        //    {
        //        LoadData_dgvHoaDonChiTiet(hoaDonChiTietBLL.GetAllHoaDonCTByMaHoaDon(cbbHoaDonCho.SelectedValue.ToString()));
        //    }
        //    else
        //    {
        //        LoadData_dgvHoaDonChiTiet(new List<HoaDonChiTiet>());
        //    }
        //}

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            //if (TinhTongTienHoaDon(cbb_hoadoncho.SelectedValue.ToString()) > 0)
            //{
            //    if (daThanhToanDu)
            //    {
            //        serviceHD.SuaTrangThai(cbb_hoadoncho.SelectedValue.ToString(), 1);
            //        MessageBox.Show("Đã thanh toán hóa đơn!");
            //        RefreshToanBoForm();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tiền khách đưa chưa đủ!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Hóa đơn trống!");
            //}
        }
        //private void RefreshToanBoForm()
        //{
        //    txt_SDT.Text = string.Empty;
        //    txt_tenkhachhang.Text = string.Empty;
        //    txt_search.Text = string.Empty;
        //    txt_tienkhachdua.Text = "0";
        //    lblTienThua.Text = "Tiền thừa";
        //    lblTongTien.Text = "Tổng tiền";

        //    LoadData_cbbHoaDonCho();
        //    LoadData_dgvSanPhamChiTiet(sanPhamChiTietBLL.GetAllSanPhamChiTiets());
        //    if (cbb_hoadoncho.SelectedValue != null)
        //    {
        //        LoadData_dgvHoaDonChiTiet(serviceHDCT.GetAllHoaDonCTByMaHoaDon(cbb_hoadoncho.SelectedValue.ToString()));
        //    }
        //    else
        //    {
        //        LoadData_dgvHoaDonChiTiet(new List<ChiTietHoaDon>());
        //    }
        //}
        //private void LoadData_dgvSanPhamChiTiet(List<SanPhamChiTiet> sanPhamChiTiets)
        //{
        //    dataTableSPCT.Rows.Clear();

        //    foreach (var spct in sanPhamChiTiets)
        //    {
        //        DataRow dr = dataTableSPCT.NewRow();
        //        dr["MaSPCT"] = spct.MaSpct;
        //        dr["TenSP"] = serviceSP.GetSanPhams(spct.MaSanPham).TenSanPham;
        //        dr["MauSac"] = serviceMS.GetMauSacs(spct.MaMauSac).TenMauSac;
        //        dr["KichCo"] = serviceKC.GetKichCos(spct.MaKichCo).TenKichCo;
        //        dr["DonGia"] = spct.DonGia;
        //        dr["SoLuong"] = spct.SoLuong;
        //        dataTableSPCT.Rows.Add(dr);
        //    }
        //    dtgView_danhsachsanpham.DataSource = dataTableSPCT;
        //}
        //private void LoadData_cbbHoaDonCho()
        //{
        //    cbb_hoadoncho.DataSource = null;
        //    cbb_hoadoncho.Items.Clear();

        //    // Load dữ liệu lên combobox
        //    var listHoaDonCho = serviceHD.GetAllHoaDonChos();
        //    cbb_hoadoncho.DataSource = listHoaDonCho; // nguồn dữ liệu combobox
        //    cbb_hoadoncho.DisplayMember = "MaHoaDon"; // mỗi item hiển thị mã hóa đơn
        //    cbb_hoadoncho.ValueMember = "MaHoaDon"; // mỗi item có giá trị là mã hóa đơn
        //    cbb_hoadoncho.SelectedItem = listHoaDonCho.FirstOrDefault();

        //    if (listHoaDonCho.Count == 0)
        //    {
        //        cbb_hoadoncho.SelectedIndex = -1; // Không chọn mục nào cả
        //    }
        //}

        private void dtgView_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
