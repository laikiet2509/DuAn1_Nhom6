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
    public partial class sanpham : Form
    {
        public SanPhamServices service;
        public string idWhenClick;
        public sanpham()
        {
            InitializeComponent();
            service = new SanPhamServices();
            LoadGird();
        }
        public void LoadGird()
        {
            dtgView_sp.ColumnCount = 9;
            dtgView_sp.Columns[0].Name = "Mã Sản Phẩm";
            dtgView_sp.Columns[1].Name = "Tên Sản Phẩm";
            dtgView_sp.Columns[2].Name = "Màu Sắc";
            dtgView_sp.Columns[3].Name = "Chất Liệu";
            dtgView_sp.Columns[4].Name = "Giá Tiền";
            dtgView_sp.Columns[5].Name = "Ngày Nhập";
            dtgView_sp.Columns[6].Name = "Số Lượng";
            dtgView_sp.Columns[7].Name = "Kích Thước";
            dtgView_sp.Columns[8].Name = "Thương Hiệu";
            dtgView_sp.Rows.Clear();
            foreach (var sp in service.GetSanPhams(txt_search.Text))
            {
                dtgView_sp.Rows.Add(sp.MaSanPham, sp.TenSanPham, sp.MaMauSp, sp.ChatLieu, sp.GiaBan, sp.NgayNhap, sp.SoLuongTon, sp.MaKichCoSp, sp.ThuongHieu);
            }
        }
        public void FillData()
        {
            var sp = service.GetSanPhams(txt_search.Text).Find(x => x.MaSanPham.ToString() == idWhenClick);
            txt_masanpham.Text = sp.MaSanPham;
            txt_tensanpham.Text = sp.TenSanPham;
            cmbx_mausac.Text = sp.MaMauSp;
            txt_giatien.Text = sp.GiaBan.ToString();
            cmbx_chatlieu.Text = sp.ChatLieu;
            dtp_ngaynhap.Text = sp.NgayNhap.ToString();
            txt_soluong.Text = sp.SoLuongTon.ToString();
            cmbx_kichthuoc.Text = sp.MaKichCoSp;
            txt_Thuonghieu.Text = sp.ThuongHieu;
        }
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSanPham = txt_masanpham.Text;
            sp.TenSanPham = txt_tensanpham.Text;
            sp.MaMauSp = cmbx_mausac.Text;
            sp.GiaBan = decimal.Parse(txt_giatien.Text);
            sp.ChatLieu = cmbx_chatlieu.Text;
            sp.NgayNhap = DateTime.Parse(dtp_ngaynhap.Text);
            sp.SoLuongTon = int.Parse(txt_soluong.Text);
            sp.MaKichCoSp = cmbx_kichthuoc.Text;
            sp.ThuongHieu = txt_Thuonghieu.Text;
            MessageBox.Show(service.Them(sp));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var sp = service.GetSanPhams(txt_search.Text).Find(x => x.MaSanPham == idWhenClick);
            sp.MaSanPham = txt_masanpham.Text;
            sp.TenSanPham = txt_tensanpham.Text;
            sp.MaMauSp = cmbx_mausac.Text;
            sp.GiaBan = decimal.Parse(txt_giatien.Text);
            sp.ChatLieu = cmbx_chatlieu.Text;
            sp.NgayNhap = DateTime.Parse(dtp_ngaynhap.Text);
            sp.SoLuongTon = int.Parse(txt_soluong.Text);
            sp.MaKichCoSp = cmbx_kichthuoc.Text;
            sp.ThuongHieu = txt_Thuonghieu.Text;
            MessageBox.Show(service.Sua(sp));
            LoadGird();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(service.Xoa(idWhenClick));
            LoadGird();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_masanpham.Clear();
            txt_tensanpham.Clear();
            cmbx_mausac.Items.Clear();
            txt_giatien.Clear();
            cmbx_chatlieu.Items.Clear();
            txt_soluong.Clear();
            cmbx_kichthuoc.Items.Clear();
            txt_Thuonghieu.Clear();
        }

        private void dtgView_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetSanPhams(txt_search.Text).Count)
            {
                return;
            }
            idWhenClick = dtgView_sp.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            LoadGird();
        }
    }
}
