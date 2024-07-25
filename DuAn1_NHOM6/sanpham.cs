using BUS.Services;
using DAL.DomainClass;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
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
    public partial class sanpham : Form
    {
        public SanPhamServices service;
        public MauSacServices servicesMS;
        public KichCoServices servicesKC;
        public ThuongHieuServices servicesTH;
        public string idWhenClick;
        public sanpham()
        {
            InitializeComponent();
            service = new SanPhamServices();
            servicesMS = new MauSacServices();
            servicesKC = new KichCoServices();
            servicesTH = new ThuongHieuServices();
            LoadGird();
            LoadMauSac();
            LoadKichCo();
            LoadThuongHieu();
            LoadTrangThai();

        }
        public void LoadGird()
        {
            dtgView_sp.ColumnCount = 10;
            dtgView_sp.Columns[0].Name = "Mã Sản Phẩm";
            dtgView_sp.Columns[1].Name = "Tên Sản Phẩm";
            dtgView_sp.Columns[2].Name = "Màu Sắc";
            dtgView_sp.Columns[3].Name = "Chất Liệu";
            dtgView_sp.Columns[4].Name = "Giá Tiền";
            dtgView_sp.Columns[5].Name = "Ngày Nhập";
            dtgView_sp.Columns[6].Name = "Số Lượng";
            dtgView_sp.Columns[7].Name = "Kích Thước";
            dtgView_sp.Columns[8].Name = "Thương Hiệu";
            dtgView_sp.Columns[9].Name = "Trạng Thái";
            dtgView_sp.Rows.Clear();
     

            foreach (var sp in service.GetSanPhams())
            {
                dtgView_sp.Rows.Add(sp.MaSanPham, sp.TenSanPham, servicesMS.GetMauSacById(sp.MaMauSp).MauSac1, sp.ChatLieu, sp.GiaBan, sp.NgayNhap, sp.SoLuongTon, servicesKC.GetKichCoById(sp.MaKichCoSp).KichCo1, servicesTH.GetThuongHieuById(sp.MaThuongHieu).TenThuongHieu, sp.TrangThai);
            }
        }
        public void FillData()
        {
                var sp = service.GetSanPhams().Find(x => x.MaSanPham.ToString() == idWhenClick);
                if (sp != null)
                {
                    txt_masanpham.Text = sp.MaSanPham;
                    txt_tensanpham.Text = sp.TenSanPham;
                    cmbx_mausac.SelectedValue = sp.MaMauSp;
                    txt_giatien.Text = sp.GiaBan.ToString();
                    txt_chatlieu.Text = sp.ChatLieu;
                    dtp_ngaynhap.Value = sp.NgayNhap;
                    txt_soluong.Text = sp.SoLuongTon.ToString();
                    cmbx_kichthuoc.SelectedValue = sp.MaKichCoSp;
                    cmbx_thuonghieu.SelectedValue = sp.MaThuongHieu;
                    cmbx_trangthai.Text = sp.TrangThai;
                }
        }
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham
            {
                MaSanPham = txt_masanpham.Text,
                TenSanPham = txt_tensanpham.Text,
                MaMauSp = (string)cmbx_mausac.SelectedValue,
                GiaBan = decimal.Parse(txt_giatien.Text),
                ChatLieu = txt_chatlieu.Text,
                NgayNhap = DateTime.Parse(dtp_ngaynhap.Text),
                SoLuongTon = int.Parse(txt_soluong.Text),
                MaKichCoSp = (string)cmbx_kichthuoc.SelectedValue,
                MaThuongHieu = (string)cmbx_thuonghieu.SelectedValue,
                TrangThai = cmbx_trangthai.Text
            };
            MessageBox.Show(service.Them(sp));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var sp = service.GetSanPhams().Find(x => x.MaSanPham == idWhenClick);
            if (sp != null)
            {
                sp.MaSanPham = txt_masanpham.Text;
                sp.TenSanPham = txt_tensanpham.Text;
                sp.MaMauSp = (string)cmbx_mausac.SelectedValue;
                sp.GiaBan = decimal.Parse(txt_giatien.Text);
                sp.ChatLieu = txt_chatlieu.Text;
                sp.NgayNhap = DateTime.Parse(dtp_ngaynhap.Text);
                sp.SoLuongTon = int.Parse(txt_soluong.Text);
                sp.MaKichCoSp = (string)cmbx_kichthuoc.SelectedValue;
                sp.MaThuongHieu = (string)cmbx_thuonghieu.SelectedValue;
                sp.TrangThai = cmbx_trangthai.Text; // Lưu trạng thái
                MessageBox.Show(service.Sua(sp));
                LoadGird();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_masanpham.Clear();
            txt_tensanpham.Clear();
            cmbx_mausac.SelectedIndex = -1; // Đặt lại giá trị của combobox Màu Sắc
            txt_giatien.Clear();
            txt_chatlieu.Clear();
            dtp_ngaynhap.Value = DateTime.Now; // Đặt lại giá trị ngày nhập về ngày hiện tại
            txt_soluong.Clear();
            cmbx_kichthuoc.SelectedIndex = -1; // Đặt lại giá trị của combobox Kích Thước
            cmbx_thuonghieu.SelectedIndex = -1; // Đặt lại giá trị của combobox Thương Hiệu
            cmbx_trangthai.SelectedIndex = 0; // Đặt lại giá trị của combobox Trạng Thái về "Kích hoạt"
        }

        private void dtgView_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị tìm kiếm từ textbox
            string searchTerm = txt_search.Text.Trim();

            // Nếu giá trị tìm kiếm rỗng, hiển thị tất cả sản phẩm
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadGird();
                return;
            }

            // Lấy tất cả sản phẩm
            var allSanPhams = service.GetSanPhams();

            // Tìm kiếm sản phẩm dựa trên mã sản phẩm hoặc tên sản phẩm
            var filteredSanPhams = allSanPhams
                .Where(sp => sp.MaSanPham.Contains(searchTerm) || sp.TenSanPham.Contains(searchTerm))
                .ToList();

            // Xóa tất cả các dòng hiện tại trong DataGridView
            dtgView_sp.Rows.Clear();

            // Thêm các dòng tìm thấy vào DataGridView
            foreach (var sp in filteredSanPhams)
            {
                dtgView_sp.Rows.Add(
                    sp.MaSanPham,
                    sp.TenSanPham,
                    servicesMS.GetMauSacById(sp.MaMauSp).MauSac1,
                    sp.ChatLieu,
                    sp.GiaBan,
                    sp.NgayNhap,
                    sp.SoLuongTon,
                    servicesKC.GetKichCoById(sp.MaKichCoSp).KichCo1,
                    servicesTH.GetThuongHieuById(sp.MaThuongHieu).TenThuongHieu,
                    sp.TrangThai
                );
            }
        }

        private void btn_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Ảnh";
            openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void sanpham_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dtgView_sp_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetSanPhams().Count)
            {
                return;
            }
            idWhenClick = dtgView_sp.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }
        private void LoadMauSac()
        {
            var mauSacs = servicesMS.GetMauSacs();
            cmbx_mausac.DataSource = mauSacs;
            cmbx_mausac.DisplayMember = "MauSac1";
            cmbx_mausac.ValueMember = "MaMauSp";
        }

        private void LoadKichCo()
        {
            var kichCos = servicesKC.GetKichCos();
            cmbx_kichthuoc.DataSource = kichCos;
            cmbx_kichthuoc.DisplayMember = "KichCo1";
            cmbx_kichthuoc.ValueMember = "MaKichCoSp";
        }
        private void LoadThuongHieu()
        {
            var thuongHieus = servicesTH.GetThuongHieus();
            cmbx_thuonghieu.DataSource = thuongHieus;
            cmbx_thuonghieu.DisplayMember = "TenThuongHieu";
            cmbx_thuonghieu.ValueMember = "MaThuongHieu";
        }
        private void LoadTrangThai()
        {
            cmbx_trangthai.Items.Add("Còn Hàng");
            cmbx_trangthai.Items.Add("Hết Hàng");
            cmbx_trangthai.SelectedIndex = 0; // Mặc định chọn trạng thái đầu tiên
        }
    }
}
