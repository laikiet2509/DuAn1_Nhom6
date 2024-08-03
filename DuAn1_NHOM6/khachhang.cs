using BUS.Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL
{
    public partial class khachhang : Form
    {
        public KhachHangServices service;
        public string idWhenClick;
        public khachhang()
        {
            InitializeComponent();
            service = new KhachHangServices();
            LoadGird();
            txt_search.TextChanged += txt_search_TextChanged; // Event handler for search text change
            btn_loc.Click += btn_loc_Click; // Event handler for search button click
        }
        public void LoadGird()
        {
            dtgView_khachhang.ColumnCount = 6;
            dtgView_khachhang.Columns[0].Name = "Tên Khách Hàng";
            dtgView_khachhang.Columns[1].Name = "Giới tính";
            dtgView_khachhang.Columns[2].Name = "Ngày Đăng Ký";
            dtgView_khachhang.Columns[3].Name = "Số Điện Thoại";
            dtgView_khachhang.Columns[4].Name = "Địa Chỉ";
            dtgView_khachhang.Columns[5].Name = "Ghi Chú";
            dtgView_khachhang.Rows.Clear();
            foreach (var kh in service.GetKhachHangs(txt_search.Text))
            {
                dtgView_khachhang.Rows.Add(kh.TenKhachHang, kh.GioiTinh == true ? "Nam" : "Nữ", kh.NgayDangKy, kh.Sdt, kh.DiaChi, kh.GhiChu);
            }
        }
        public void FillData()
        {
            var sp = service.GetKhachHangs(txt_search.Text).Find(x => x.TenKhachHang == idWhenClick);
            txt_tenkhachhang.Text = sp.TenKhachHang;
            dtp_ngaydangky.Text = sp.NgayDangKy.ToString();
            txt_sdt.Text = sp.Sdt;
            txt_diachi.Text = sp.DiaChi;
            rtxt_ghichu.Text = sp.GhiChu;
            if (sp.GioiTinh == true)
            {
                rbtn_nam.Checked = true;
            }
            else
            {
                rbtn_nu.Checked = true;
            }

        }

        private void dtgView_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();
            if (!regexServices.RegexChu(txt_tenkhachhang.Text))
            {
                MessageBox.Show("Tên khách hàng không được chứa số, Mời nhập lại");
                return;
            }
            if (!regexServices.Regex10so(txt_sdt.Text))
            {
                MessageBox.Show("SĐT nhân viên chỉ được ghi 10 số và bắt đầu bằng 09");
                return;
            }
            KhachHang kh = new KhachHang
            {
                TenKhachHang = txt_tenkhachhang.Text,
                GioiTinh = rbtn_nam.Checked,
                NgayDangKy = DateTime.Parse(dtp_ngaydangky.Text),
                Sdt = txt_sdt.Text,
                DiaChi = txt_diachi.Text,
                GhiChu = rtxt_ghichu.Text,
            };
            MessageBox.Show(service.Them(kh));
            LoadGird();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();
            if (!regexServices.RegexChu(txt_tenkhachhang.Text))
            {
                MessageBox.Show("Tên khách hàng không được chứa số, Mời nhập lại");
                return;
            }
            if (!regexServices.Regex10so(txt_sdt.Text))
            {
                MessageBox.Show("SĐT nhân viên chỉ được ghi 10 số và bắt đầu bằng 09");
                return;
            }
            var kh = service.GetKhachHangs(txt_search.Text).Find(x => x.TenKhachHang == idWhenClick);
            if (kh != null)
            {
                kh.TenKhachHang = txt_tenkhachhang.Text;
                kh.GioiTinh = rbtn_nam.Checked;
                kh.NgayDangKy = DateTime.Parse(dtp_ngaydangky.Text);
                kh.Sdt = txt_sdt.Text;
                kh.DiaChi = txt_diachi.Text;
                kh.GhiChu = rtxt_ghichu.Text;
                MessageBox.Show(service.Sua(kh));
                LoadGird();
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_tenkhachhang.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            rtxt_ghichu.Clear();
            rbtn_nam.Checked = false;
            rbtn_nu.Checked = false;
        }

        private void cmbx_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void khachhang_Load(object sender, EventArgs e)
        {
        }

        private void dtgView_khachhang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetKhachHangs(txt_search.Text).Count)
            {
                return;
            }
            idWhenClick = dtgView_khachhang.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }
        private void LoadFilteredData(string searchQuery)
        {
            dtgView_khachhang.Rows.Clear();
            var filteredKhachHangs = service.GetKhachHangs(searchQuery)
                .Where(kh => kh.TenKhachHang.Contains(searchQuery) || kh.Sdt.Contains(searchQuery))
                .ToList();

            foreach (var kh in filteredKhachHangs)
            {
                dtgView_khachhang.Rows.Add(kh.TenKhachHang, kh.GioiTinh ? "Nam" : "Nữ", kh.NgayDangKy, kh.Sdt, kh.DiaChi, kh.GhiChu);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadFilteredData(txt_search.Text);
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            LoadFilteredData(txt_search.Text);
        }
    }
}
