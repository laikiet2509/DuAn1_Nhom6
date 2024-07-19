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
                dtgView_khachhang.Rows.Add(kh.TenKhachHang, kh.GioiTinh, kh.NgayDangKy, kh.Sdt, kh.DiaChi, kh.GhiChu);
            }
        }
        public void FillData()
        {
            var sp = service.GetKhachHangs(txt_search.Text).Find(x => x.TenKhachHang.ToString() == idWhenClick);
            txt_tenkhachhang.Text = sp.TenKhachHang;
            cmbx_gioitinh.Text = sp.GioiTinh;
            dtp_ngaydangky.Text = sp.NgayDangKy.ToString();
            txt_sdt.Text = sp.Sdt;
            txt_diachi.Text = sp.DiaChi;
            rtxt_ghichu.Text = sp.GhiChu;
        }

        private void dtgView_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetKhachHangs(txt_search.Text).Count)
            {
                return;
            }
            idWhenClick = dtgView_khachhang.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.TenKhachHang = txt_tenkhachhang.Text;
            kh.GioiTinh = cmbx_gioitinh.Text;
            kh.NgayDangKy = DateTime.Parse(dtp_ngaydangky.Text);
            kh.Sdt = txt_sdt.Text;
            kh.DiaChi = txt_diachi.Text;
            kh.GhiChu = rtxt_ghichu.Text;
            MessageBox.Show(service.Them(kh));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var kh = service.GetKhachHangs(txt_search.Text).Find(x => x.TenKhachHang == idWhenClick);
            kh.TenKhachHang = txt_tenkhachhang.Text;
            kh.GioiTinh = cmbx_gioitinh.Text;
            kh.NgayDangKy = DateTime.Parse(dtp_ngaydangky.Text);
            kh.Sdt = txt_sdt.Text;
            kh.DiaChi = txt_diachi.Text;
            kh.GhiChu = rtxt_ghichu.Text;
            MessageBox.Show(service.Sua(kh));
            LoadGird();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(service.Xoa(idWhenClick));
            LoadGird();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_tenkhachhang.Clear();
            cmbx_gioitinh.Items.Clear();
            cmbx_gioitinh.Text = string.Empty;
            txt_sdt.Clear();
            txt_diachi.Clear();
            rtxt_ghichu.Clear();
        }

        private void cmbx_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            cmbx_gioitinh.Items.Add("Nam");
            cmbx_gioitinh.Items.Add("Nữ");
            cmbx_gioitinh.Items.Add("Khác");
        }
    }
}
