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
    public partial class nhanvien : Form
    {
        public NhanVienServices service;
        public ChucVuServices serviceCV;
        public string idWhenClick;
        public nhanvien()
        {
            InitializeComponent();
            service = new NhanVienServices();
            serviceCV = new ChucVuServices();
            LoadGird();
            LoadChucVu();
            LoadTrangThai();
            txt_search.TextChanged += txt_search_TextChanged; // Add event handler for search
            btn_loc.Click += btn_loc_Click; // Add event handler for search button
        }
        public void LoadGird()
        {
            dtgView_nhanvien.ColumnCount = 11;
            dtgView_nhanvien.Columns[0].Name = "Mã Nhân Viên";
            dtgView_nhanvien.Columns[1].Name = "Tên Nhân Viên";
            dtgView_nhanvien.Columns[2].Name = "Giới tính";
            dtgView_nhanvien.Columns[3].Name = "Ngày Sinh";
            dtgView_nhanvien.Columns[4].Name = "Gmail";
            dtgView_nhanvien.Columns[5].Name = "Số Điện Thoại";
            dtgView_nhanvien.Columns[6].Name = "Địa Chỉ";
            dtgView_nhanvien.Columns[7].Name = "Chức Vụ";
            dtgView_nhanvien.Columns[8].Name = "Tài Khoản";
            dtgView_nhanvien.Columns[9].Name = "Mật Khẩu";
            dtgView_nhanvien.Columns[10].Name = "Trạng Thái";
            dtgView_nhanvien.Rows.Clear();
            foreach (var kh in service.GetNhanViens())
            {
                dtgView_nhanvien.Rows.Add(kh.MaNhanVien, kh.Ten, kh.GioiTinh == true ? "Nam" : "Nữ", kh.Email, kh.NgaySinh, kh.Sdt, kh.DiaChi, serviceCV.GetChucVuById(kh.MaChucVu).TenChucVu, kh.TaiKhoan, kh.MatKhau, ConvertTrangThai(kh.TrangThai));
            }
        }
        public string ConvertTrangThai(int? trangThai)
        {
            string status = string.Empty;
            switch (trangThai)
            {
                case 1:
                    status = "Hoạt Động";
                    break;
                case 2:
                    status = "Ngưng Hoạt Động";
                    break;
                default:
                    break;
            }
            return status;

        }
        public void FillData()
        {
            var sp = service.GetNhanViens().Find(x => x.MaNhanVien.ToString() == idWhenClick);
            if (sp != null)
            {
                txt_manhanvien.Text = sp.MaNhanVien;
                txt_tennhanvien.Text = sp.Ten;
                if (sp.GioiTinh == true)
                {
                    rbtn_nam.Checked = true;
                }
                else
                {
                    rbtn_nu.Checked = true;
                }
                dtp_ngaydangky.Text = sp.NgaySinh.ToString();
                txt_sdt.Text = sp.Sdt;
                txt_diachi.Text = sp.DiaChi;
                txt_gmail.Text = sp.Email;
                cmbx_chucvu.SelectedValue = sp.MaChucVu;
                cmbx_trangthai.Text = ConvertTrangThai(sp.TrangThai);
                txt_taikhoan.Text = sp.TaiKhoan;
                txt_matkhau.Text = sp.MatKhau;
            }
        }

        private void dtgView_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();
            if (!regexServices.RegexMaSanPham(txt_manhanvien.Text))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexChu(txt_tennhanvien.Text))
            {
                MessageBox.Show("Tên nhân viên không được chứa số, Mời nhập lại");
                return;
            }
            if (!regexServices.Regex10so(txt_sdt.Text))
            {
                MessageBox.Show("SĐT nhân viên chỉ được ghi 10 số và bắt đầu bằng 09");
                return;
            }
            if (!regexServices.RegexEmail(txt_gmail.Text))
            {
                MessageBox.Show("Email không hợp lệ, Mời nhập lại");
                return;
            }
            if (service.GetNhanViens().Any(kc => kc.MaNhanVien == txt_manhanvien.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã khác.");
                return;
            }

            try
            {
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = txt_manhanvien.Text,
                    Ten = txt_tennhanvien.Text,
                    GioiTinh = rbtn_nam.Checked,
                    NgaySinh = dtp_ngaydangky.Value,
                    Sdt = txt_sdt.Text,
                    DiaChi = txt_diachi.Text,
                    Email = txt_gmail.Text,
                    MaChucVu = (string)cmbx_chucvu.SelectedValue,
                    TrangThai = (int)cmbx_trangthai.SelectedValue,
                    TaiKhoan = txt_taikhoan.Text,
                    MatKhau = txt_matkhau.Text
                };
                MessageBox.Show(service.Them(nv));
                LoadGird();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();
            if (!regexServices.RegexMaSanPham(txt_manhanvien.Text))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexChu(txt_tennhanvien.Text))
            {
                MessageBox.Show("Tên nhân viên không được chứa số, Mời nhập lại");
                return;
            }
            if (!regexServices.Regex10so(txt_sdt.Text))
            {
                MessageBox.Show("SĐT nhân viên chỉ được ghi 10 số và bắt đầu bằng 09");
                return;
            }
            if (!regexServices.RegexEmail(txt_gmail.Text))
            {
                MessageBox.Show("Email không hợp lệ, Mời nhập lại");
                return;
            }
            try
            {
                var nv = service.GetNhanViens().Find(x => x.MaNhanVien == idWhenClick);
                if (nv != null)
                {
                    nv.MaNhanVien = txt_manhanvien.Text;
                    nv.Ten = txt_tennhanvien.Text;
                    nv.GioiTinh = rbtn_nam.Checked;
                    nv.NgaySinh = dtp_ngaydangky.Value;
                    nv.Sdt = txt_sdt.Text;
                    nv.DiaChi = txt_diachi.Text;
                    nv.Email = txt_gmail.Text;
                    nv.MaChucVu = (string)cmbx_chucvu.SelectedValue;
                    nv.TrangThai = (int)cmbx_trangthai.SelectedValue;
                    nv.TaiKhoan = txt_taikhoan.Text;
                    nv.MatKhau = txt_matkhau.Text;
                    MessageBox.Show(service.Sua(nv));
                    LoadGird();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_tennhanvien.Clear();
            rbtn_nam.Checked = false;
            rbtn_nu.Checked = false;
            txt_sdt.Clear();
            txt_diachi.Clear();
            txt_gmail.Clear();
            txt_taikhoan.Clear();
            txt_matkhau.Clear();
            cmbx_chucvu.SelectedIndex = -1;
            cmbx_trangthai.SelectedIndex = 0;
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
        }

        private void dtgView_nhanvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetNhanViens().Count)
            {
                return;
            }
            idWhenClick = dtgView_nhanvien.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            SearchNhanVien(txt_search.Text);
        }
        private void LoadChucVu()
        {
            var chucVus = serviceCV.GetChucVus();
            cmbx_chucvu.DataSource = chucVus;
            cmbx_chucvu.DisplayMember = "TenChucVu";
            cmbx_chucvu.ValueMember = "MaChucVu";
        }
        private void LoadTrangThai()
        {
            var trangThaiItems = new List<KeyValuePair<int, string>>
        {
            new KeyValuePair<int, string>(1, "Hoạt Động"),
            new KeyValuePair<int, string>(2, "Ngưng Hoạt Động")
        };

            cmbx_trangthai.DataSource = trangThaiItems;
            cmbx_trangthai.DisplayMember = "Value";
            cmbx_trangthai.ValueMember = "Key";
            cmbx_trangthai.SelectedIndex = 0; // Mặc định chọn trạng thái đầu tiên
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchNhanVien(txt_search.Text);
        }
        private void SearchNhanVien(string searchQuery)
        {
            var filteredNhanViens = service.GetNhanViens()
                .Where(nv => nv.MaNhanVien.Contains(searchQuery) || nv.Ten.Contains(searchQuery))
                .ToList();

            dtgView_nhanvien.Rows.Clear();
            foreach (var nv in filteredNhanViens)
            {
                dtgView_nhanvien.Rows.Add(nv.MaNhanVien, nv.Ten, nv.GioiTinh == true ? "Nam" : "Nữ", nv.NgaySinh, nv.Email, nv.Sdt, nv.DiaChi, serviceCV.GetChucVuById(nv.MaChucVu).TenChucVu, ConvertTrangThai(nv.TrangThai));
            }
        }

        private void txt_manhanvien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
