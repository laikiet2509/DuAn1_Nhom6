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
        public voucher()
        {
            InitializeComponent();
            service = new KhuyenMaiServices();
            LoadGrid();
        }

        public KhuyenMaiServices service;
        public string idWhenClick;

        public void LoadGrid()
        {
            dgvDataVC.ColumnCount = 5;
            dgvDataVC.Columns[0].Name = "Mã Khuyến Mãi";
            dgvDataVC.Columns[1].Name = "Điều Kiện Áp Dụng";
            dgvDataVC.Columns[2].Name = "Ngày Bắt Đầu";
            dgvDataVC.Columns[3].Name = "Ngày Kết Thúc";
            dgvDataVC.Columns[4].Name = "Mô Tả Khuyến Mãi";
            dgvDataVC.Rows.Clear();
            foreach (var sp in service.GetKhuyenMais(txt_search.Text))
            {
                dgvDataVC.Rows.Add(sp.MaKhuyenMai, sp.DieuKienApDung, sp.NgayBatDau, sp.NgayKetThuc, sp.MoTaKhuyenMai);
            }
        }

        public void FillData()
        {
            var sp = service.GetKhuyenMais(txt_search.Text).Find(x => x.MaKhuyenMai.ToString() == idWhenClick);
            tbxMavc.Text = sp.MaKhuyenMai;
            tbxDieuKien.Text = sp.DieuKienApDung;
            tbcMota.Text = sp.MoTaKhuyenMai;
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
            km.MaKhuyenMai = tbxMavc.Text;
            km.DieuKienApDung = tbxDieuKien.Text;
            km.MoTaKhuyenMai = tbcMota.Text;
            km.NgayBatDau = DateTime.Parse(dtpkNgayapdung.Text);
            km.NgayKetThuc = DateTime.Parse(dtpkNKT.Text);
            LoadGrid();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var km = service.GetKhuyenMais(txt_search.Text).Find(x => x.MaKhuyenMai.ToString() == idWhenClick);
            km.MaKhuyenMai = tbxMavc.Text;
            km.DieuKienApDung = tbxDieuKien.Text;
            km.MoTaKhuyenMai = tbcMota.Text;
            km.NgayBatDau = DateTime.Parse(dtpkNgayapdung.Text);
            km.NgayKetThuc = DateTime.Parse(dtpkNKT.Text);
            LoadGrid();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(service.XoaKM(idWhenClick));
            LoadGrid();
        }
    }
}
