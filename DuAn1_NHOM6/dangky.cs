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
            try
            {
                NhanVien nv = new NhanVien
                {
                    TaiKhoan = txt_taikhoan.Text,
                    MatKhau = txt_matkhau.Text,
                    MaNhanVien = txt_manhanvien.Text,
                    Ten = txt_tennhanvien.Text,
                    GioiTinh = rbtn_nam.Checked,
                    NgaySinh = dtp_ngaydangky.Value,
                    Sdt = txt_sdt.Text,
                    DiaChi = txt_diachi.Text,
                    Email = txt_gmail.Text,
                    MaChucVu = (string)cmbx_chucvu.SelectedValue,
                    TrangThai = cmbx_trangthai.Text
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
            cmbx_trangthai.Items.Add("Hoạt Động");
            cmbx_trangthai.Items.Add("Không Hoạt Động");
            cmbx_trangthai.SelectedIndex = 0; // Mặc định chọn trạng thái đầu tiên
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
