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
        public string idWhenClick;
        public sanpham()
        {
            InitializeComponent();
            service = new SanPhamServices();
            LoadGird();
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
            dtgView_sp.Columns[9].Name = "Hình Ảnh";
            dtgView_sp.Rows.Clear();
            foreach (var sp in service.GetSanPhams())
            {
                dtgView_sp.Rows.Add(sp.MaSanPham, sp.TenSanPham, sp.MaMauSp, sp.ChatLieu, sp.GiaBan, sp.NgayNhap, sp.SoLuongTon, sp.MaKichCoSp, sp.MaThuongHieu, sp.HinhAnh);
            }
        }
        public void FillData()
        {
            var sp = service.GetSanPhams().Find(x => x.MaSanPham.ToString() == idWhenClick);
            txt_masanpham.Text = sp.MaSanPham;
            txt_tensanpham.Text = sp.TenSanPham;
            cmbx_mausac.Text = sp.MaMauSp;
            txt_giatien.Text = sp.GiaBan.ToString();
            txt_chatlieu.Text = sp.ChatLieu;
            dtp_ngaynhap.Text = sp.NgayNhap.ToString();
            txt_soluong.Text = sp.SoLuongTon.ToString();
            cmbx_kichthuoc.Text = sp.MaKichCoSp;
            cmbx_thuonghieu.Text = sp.MaThuongHieu;
            //if (sp.HinhAnh != null)
            //{
            //    // Chuyển đổi hinhAnh sang Image
            //    Image image = Image.FromStream(new MemoryStream(sp.HinhAnh));

            //    // Hiển thị hình ảnh trên pictureBox
            //    pictureBox1.Image = image;
            //}
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
            sp.ChatLieu = txt_chatlieu.Text;
            sp.NgayNhap = DateTime.Parse(dtp_ngaynhap.Text);
            sp.SoLuongTon = int.Parse(txt_soluong.Text);
            sp.MaKichCoSp = cmbx_kichthuoc.Text;
            sp.MaThuongHieu = cmbx_thuonghieu.Text;
            //sp.HinhAnh = pictureBox1.Image;
            MessageBox.Show(service.Them(sp));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var sp = service.GetSanPhams().Find(x => x.MaSanPham == idWhenClick);
            sp.MaSanPham = txt_masanpham.Text;
            sp.TenSanPham = txt_tensanpham.Text;
            sp.MaMauSp = cmbx_mausac.Text;
            sp.GiaBan = decimal.Parse(txt_giatien.Text);
            sp.ChatLieu = cmbx_thuonghieu.Text;
            sp.NgayNhap = DateTime.Parse(dtp_ngaynhap.Text);
            sp.SoLuongTon = int.Parse(txt_soluong.Text);
            sp.MaKichCoSp = cmbx_kichthuoc.Text;
            sp.MaThuongHieu = cmbx_thuonghieu.Text;
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
            txt_chatlieu.Clear();
            txt_soluong.Clear();
            cmbx_kichthuoc.Items.Clear();
            cmbx_thuonghieu.Items.Clear();
        }

        private void dtgView_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetSanPhams().Count)
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
    }
}
