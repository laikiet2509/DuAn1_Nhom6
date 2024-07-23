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
        public string idWhenClick;
        public nhanvien()
        {
            InitializeComponent();
            service = new NhanVienServices();
            LoadGird();
        }
        public void LoadGird()
        {
            dtgView_nhanvien.ColumnCount = 8;
            dtgView_nhanvien.Columns[0].Name = "Tên Nhân Viên";
            dtgView_nhanvien.Columns[1].Name = "Giới tính";
            dtgView_nhanvien.Columns[2].Name = "Ngày Sinh";
            dtgView_nhanvien.Columns[3].Name = "Gmail";
            dtgView_nhanvien.Columns[4].Name = "Số Điện Thoại";
            dtgView_nhanvien.Columns[5].Name = "Địa Chỉ";
            dtgView_nhanvien.Columns[6].Name = "Chức Vụ";
            dtgView_nhanvien.Columns[7].Name = "Trạng Thái";
            dtgView_nhanvien.Rows.Clear();
            foreach (var kh in service.GetNhanViens(txt_search.Text))
            {
                dtgView_nhanvien.Rows.Add(kh.Ten, kh.GioiTinh == true ? "Nam" : "Nữ", kh.Email ,kh.NgaySinh, kh.Sdt, kh.DiaChi, kh.MaChucVu, kh.TrangThai);
            }
        }
        public void FillData()
        {
            var sp = service.GetNhanViens(txt_search.Text).Find(x => x.Ten == idWhenClick);
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
            cmbx_chucvu.Text = sp.MaChucVu;
            cmbx_trangthai.Text = sp.TrangThai;
        }

        private void dtgView_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Ten = txt_tennhanvien.Text;
            if (nv.GioiTinh == true)
            {
                rbtn_nam.Checked = true;
            }
            else
            {
                rbtn_nu.Checked = true;
            }
            nv.NgaySinh = DateTime.Parse(dtp_ngaydangky.Text);
            nv.Sdt = txt_sdt.Text;
            nv.DiaChi = txt_diachi.Text;
            nv.MaChucVu = cmbx_chucvu.Text;
            nv.TrangThai = cmbx_trangthai.Text;
            MessageBox.Show(service.Them(nv));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var nv = service.GetNhanViens(txt_search.Text).Find(x => x.Ten == idWhenClick);
            nv.Ten = txt_tennhanvien.Text;
            if (nv.GioiTinh == true)
            {
                rbtn_nam.Checked = true;
            }
            else
            {
                rbtn_nu.Checked = true;
            }
            nv.NgaySinh = DateTime.Parse(dtp_ngaydangky.Text);
            nv.Sdt = txt_sdt.Text;
            nv.DiaChi = txt_diachi.Text;
            nv.MaChucVu = cmbx_chucvu.Text;
            nv.TrangThai = cmbx_trangthai.Text;
            MessageBox.Show(service.Sua(nv));
            LoadGird();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_tennhanvien.Clear();
            //cmbx_gioitinh.Items.Clear();
            //cmbx_gioitinh.Text = string.Empty;
            txt_sdt.Clear();
            txt_diachi.Clear();
            cmbx_chucvu.Items.Clear();
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void dtgView_nhanvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetNhanViens(txt_search.Text).Count)
            {
                return;
            }
            idWhenClick = dtgView_nhanvien.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }
    }
}
