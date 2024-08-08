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
    public partial class voucher : Form
    {
        public KhuyenMaiServices service;
        public string idWhenClick;
        public voucher()
        {
            InitializeComponent();
            service = new KhuyenMaiServices();
            LoadGrid();
            txt_search.TextChanged += txt_search_TextChanged;
        }



        public void LoadGrid()
        {
            dgvDataVC.ColumnCount = 5;
            dgvDataVC.Columns[0].Name = "Mã Voucher";
            dgvDataVC.Columns[1].Name = "Giảm Giá";
            dgvDataVC.Columns[2].Name = "Ngày Bắt Đầu";
            dgvDataVC.Columns[3].Name = "Ngày Kết Thúc";
            dgvDataVC.Columns[4].Name = "Mô Tả Voucher";
            dgvDataVC.Rows.Clear();
            foreach (var sp in service.GetKhuyenMais(txt_search.Text))
            {
                dgvDataVC.Rows.Add(sp.MaVoucher, sp.GiamGia, sp.NgayBatDau, sp.NgayKetThuc, sp.MoTaVoucher);
            }
        }

        public void FillData()
        {
            var sp = service.GetKhuyenMais(txt_search.Text).Find(x => x.MaVoucher.ToString() == idWhenClick);
            tbxMavc.Text = sp.MaVoucher;
            tbxDieuKien.Text = sp.GiamGia.ToString();
            tbcMota.Text = sp.MoTaVoucher;
            dtpkNgayapdung.Text = sp.NgayBatDau.ToString();
            dtpkNKT.Text = sp.NgayKetThuc.ToString();
        }

        private void dgvDataVC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDataVC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= service.GetKhuyenMais(txt_search.Text).Count)
            {
                return;
            }
            idWhenClick = dgvDataVC.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            RegexServices regexServices = new RegexServices();
            if (!regexServices.RegexMaSanPham(tbxMavc.Text))
            {
                MessageBox.Show("Mã voucher không hợp lệ, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexSo1_99(tbxDieuKien.Text))
            {
                MessageBox.Show("% giảm giá chỉ được nhập từ 1 - 99%, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexSoAm(tbxDieuKien.Text))
            {
                MessageBox.Show("% giảm giá không được nhập số âm, Mời nhập lại");
                return;
            }
            if (service.GetKhuyenMais(txt_search.Text).Any(kc => kc.MaVoucher.ToLower() == tbxMavc.Text.ToLower()))
            {
                MessageBox.Show("Mã voucher đã tồn tại, vui lòng nhập mã khác.");
                return;
            }

            km.MaVoucher = tbxMavc.Text;
            km.GiamGia = decimal.Parse(tbxDieuKien.Text);
            km.MoTaVoucher = tbcMota.Text;
            km.NgayBatDau = DateTime.Parse(dtpkNgayapdung.Text);
            km.NgayKetThuc = DateTime.Parse(dtpkNKT.Text);
            MessageBox.Show(service.ThemKM(km));
            LoadGrid();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();
            if (!regexServices.RegexMaSanPham(tbxMavc.Text))
            {
                MessageBox.Show("Mã voucher không hợp lệ, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexSo1_99(tbxDieuKien.Text))
            {
                MessageBox.Show("% giảm giá chỉ được nhập từ 1 - 99%, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexSoAm(tbxDieuKien.Text))
            {
                MessageBox.Show("% giảm giá không được nhập số âm, Mời nhập lại");
                return;
            }
            
            var km = service.GetKhuyenMais(txt_search.Text).Find(x => x.MaVoucher.ToString() == idWhenClick);
            km.MaVoucher = tbxMavc.Text;
            km.GiamGia = decimal.Parse(tbxDieuKien.Text);
            km.MoTaVoucher = tbcMota.Text;
            km.NgayBatDau = DateTime.Parse(dtpkNgayapdung.Text);
            km.NgayKetThuc = DateTime.Parse(dtpkNKT.Text);
            MessageBox.Show(service.SuaKM(km));
            LoadGrid();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            tbxMavc.Clear();
            tbxDieuKien.Clear();
            tbcMota.Clear();
        }
        //private void LoadFilteredData(string searchQuery)
        //{
        //    dgvDataVC.Rows.Clear();
        //    var filteredVouchers = service.GetKhuyenMais(searchQuery)
        //        .Where(km => km.MaVoucher.Contains(searchQuery))
        //        .ToList();

        //    foreach (var sp in filteredVouchers)
        //    {
        //        dgvDataVC.Rows.Add(sp.MaVoucher, sp.GiamGia, sp.NgayBatDau, sp.NgayKetThuc, sp.MoTaVoucher);
        //    }
        //}

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //LoadFilteredData(txt_search.Text);
            LoadGrid();
        }
    }
}
