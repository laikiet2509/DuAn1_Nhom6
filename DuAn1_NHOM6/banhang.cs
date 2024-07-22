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
                dtgView_hoadon.Rows.Add(hd.MaHoaDon, hd.NgayLapHoaDon, hd.TrangThai, hd.MaKhachHang, hd.MaNhanVien);
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
            dtgView_danhsachsanpham.Columns[7].Name = "Kích Thước";
            dtgView_danhsachsanpham.Columns[8].Name = "Thương Hiệu";
            dtgView_danhsachsanpham.Columns[9].Name = "Hình Ảnh";
            dtgView_danhsachsanpham.Rows.Clear();
            foreach (var sp in serviceSP.GetSanPhams(txt_search.Text))
            {
                dtgView_danhsachsanpham.Rows.Add(sp.MaSanPham, sp.TenSanPham, sp.MaMauSp, sp.ChatLieu, sp.GiaBan, sp.NgayNhap, sp.SoLuongTon, sp.MaKichCoSp, sp.ThuongHieu, sp.HinhAnh);
            }
        }
        public void FillDataSP()
        {
            var sp = serviceSP.GetSanPhams(txt_search.Text).Find(x => x.MaSanPham.ToString() == idWhenClick);
            var ms = serviceMS.GetMauSacs(txt_search.Text).Find(x => x.MaMauSp.ToString() == idWhenClick);
            var kc = serviceKC.GetKichCos(txt_search.Text).Find(x => x.MaKichCoSp.ToString() == idWhenClick);
            var nv = serviceNV.GetNhanViens(txt_search.Text).Find(x => x.MaNhanVien.ToString() == idWhenClick);
            var hd = serviceBH.GetHoaDons(txt_search.Text).Find(x => x.MaHoaDon.ToString() == idWhenClick);
            var km = serviceKM.GetKhuyenMais(txt_search.Text).Find(x => x.MaKhuyenMai.ToString() == idWhenClick);
            txt_manhanvien.Text = nv.MaNhanVien;
            txt_mahoadon.Text = hd.MaHoaDon;
            txt_khuyenmai.Text = km.MaKhuyenMai;
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
            FillDataSP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            KhuyenMai km = new KhuyenMai();
            NhanVien nv = new NhanVien();
            hd.MaHoaDon = "HĐ" + (serviceHD.GetAllHoaDons().Count + 1);
            hd.MaKhachHang = txt_makhachhang.Text;
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
    }
}
