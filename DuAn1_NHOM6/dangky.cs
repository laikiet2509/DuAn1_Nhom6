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
    public partial class dangky : Form
    {
        public NhanVienServices nhanVienServices;
        public ChucVuServices chucVuServices;
        public dangky()
        {
            InitializeComponent();
            nhanVienServices = new NhanVienServices();
            chucVuServices = new ChucVuServices();
            LoadChucVu();
            LoadTrangThai();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
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
            if (nhanVienServices.GetNhanViens().Any(kc => kc.MaNhanVien.ToLower() == txt_manhanvien.Text.ToLower()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã khác.");
                return;
            }
            if (nhanVienServices.GetNhanViens().Any(kc => kc.TaiKhoan.ToLower() == txt_taikhoan.Text.ToLower()))
            {
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng nhập tài khoản khác.");
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
                MessageBox.Show(nhanVienServices.Them(nv));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
        private void LoadChucVu()
        {
            var chucVus = chucVuServices.GetChucVus();
            cmbx_chucvu.DataSource = chucVus;
            cmbx_chucvu.DisplayMember = "TenChucVu";
            cmbx_chucvu.ValueMember = "MaChucVu";
        }
        private void dangky_Load(object sender, EventArgs e)
        {

        }

        private void dangky_FormClosed(object sender, FormClosedEventArgs e)
        {

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

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
