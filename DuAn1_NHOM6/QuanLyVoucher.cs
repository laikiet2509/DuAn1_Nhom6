using BUS.Service;
using DAL.DomainClass;

namespace DuAn1_NHOM6
{
    public partial class QuanLyVoucher : Form
    {
        public QuanLyVoucher()
        {
            InitializeComponent();
            service = new KhuyenMaiService();
            LoadGrid();
        }

        private void QuanLyVoucher_Load(object sender, EventArgs e)
        {

        }
        public KhuyenMaiService service;
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
            foreach (var sp in service.GetKhuyenMais(txbTimkiem.Text))
            {
                dgvDataVC.Rows.Add(sp.MaKhuyenMai, sp.DieuKienApDung, sp.NgayBatDau, sp.NgayKetThuc, sp.MoTaKhuyenMai);
            }
        }

        public void FillData()
        {
            var sp = service.GetKhuyenMais(txbTimkiem.Text).Find(x => x.MaKhuyenMai.ToString() == idWhenClick);
            tbxMavc.Text = sp.MaKhuyenMai;
            tbxDieuKien.Text = sp.DieuKienApDung;
            tbcMota.Text = sp.MoTaKhuyenMai;
            dtpkNgayapdung.Text = sp.NgayBatDau.ToString();
            dtpkNKT.Text = sp.NgayKetThuc.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            km.MaKhuyenMai = tbxMavc.Text;
            km.DieuKienApDung = tbxDieuKien.Text;
            km.MoTaKhuyenMai = tbcMota.Text;
            km.NgayBatDau = DateTime.Parse(dtpkNgayapdung.Text);
            km.NgayKetThuc = DateTime.Parse(dtpkNKT.Text);
            LoadGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var km = service.GetKhuyenMais(txbTimkiem.Text).Find(x => x.MaKhuyenMai.ToString() == idWhenClick);
            km.MaKhuyenMai = tbxMavc.Text;
            km.DieuKienApDung = tbxDieuKien.Text;
            km.MoTaKhuyenMai = tbcMota.Text;
            km.NgayBatDau = DateTime.Parse(dtpkNgayapdung.Text);
            km.NgayKetThuc = DateTime.Parse(dtpkNKT.Text);
            LoadGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(service.Xoa(idWhenClick));
            //LoadGrid();
        }
    }
}
