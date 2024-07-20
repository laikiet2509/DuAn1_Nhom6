using BUS.Services;
using DAL.Models;

namespace DuAn1_NHOM6
{
    public partial class nhanvien : Form
    {
        NhanVienServices _services = new NhanVienServices();
        public nhanvien()
        {
            _services = new NhanVienServices();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtp_NgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            List<NhanVien> nhanViens = _services.CNShow();
            ShowDaTa(nhanViens);
        }
        public void ShowDaTa(List<NhanVien> nv)
        {
            dgv_DanhSachNV.Rows.Clear();
            dgv_DanhSachNV.ColumnCount = 9;
            //int stt = 1;
            //dgv_DanhSachNV.Columns[0].HeaderText = "Số thứ tự";
            dgv_DanhSachNV.Columns[0].HeaderText = "Mã NV";
            dgv_DanhSachNV.Columns[1].HeaderText = "Tên NV";
            dgv_DanhSachNV.Columns[2].HeaderText = "Giới tính";
            dgv_DanhSachNV.Columns[3].HeaderText = "Ngày sinh";
            dgv_DanhSachNV.Columns[4].HeaderText = "SĐT";
            dgv_DanhSachNV.Columns[5].HeaderText = "Email";
            dgv_DanhSachNV.Columns[6].HeaderText = "Địa chỉ";
            dgv_DanhSachNV.Columns[7].HeaderText = "Trạng thái";
            dgv_DanhSachNV.Columns[8].HeaderText = "Chức vụ";
            foreach (var item in nv)
            {
                dgv_DanhSachNV.Rows.Add(item.MaNhanVien, item.Ten, item.GioiTinh, item.NgaySinh, item.Sdt, item.Email, item.DiaChi, item.TrangThai, item.MaChucVu);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string ma = txt_MaNV.Text;
            string ten = txt_TenNV.Text;
            string gioitinh = txt_GioiTinh.Text;
            DateTime ngaysinh = Convert.ToDateTime(dtp_NgaySinh.Text);
            string sdt = txt_SDT.Text;
            string email = txt_Email.Text;
            string diachi = txt_DiaChi.Text;
            string trangthai = cbx_TrangThai.Text;
            string machucvu = txt_ChucVu.Text;
            if (!_services.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại sai"); return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _services.CNThem(ma, ten, gioitinh, ngaysinh, sdt, email, diachi, trangthai, machucvu);
                MessageBox.Show(kq);
                List<NhanVien> nhanViens = _services.CNShow();
                ShowDaTa(nhanViens);
                return;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá không?", "Xoá", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes && txt_MaNV.Text.Trim() != "")
            {
                MessageBox.Show(_services.CNXoa(txt_MaNV.Text));
                List<NhanVien> nhanViens = _services.CNShow();
                ShowDaTa(nhanViens);
                return;
            }
        }

        private void dgv_DanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0 && row < dgv_DanhSachNV.Rows.Count)
            {
                var rowData = dgv_DanhSachNV.Rows[row];
                txt_MaNV.Text = rowData.Cells[0].Value.ToString();
                txt_TenNV.Text = rowData.Cells[1].Value.ToString();
                txt_GioiTinh.Text = rowData.Cells[2].Value.ToString();
                dtp_NgaySinh.Text = rowData.Cells[3].Value.ToString();
                txt_SDT.Text = rowData.Cells[4].Value.ToString();
                txt_Email.Text = rowData.Cells[5].Value.ToString();
                txt_DiaChi.Text = rowData.Cells[6].Value.ToString();
                cbx_TrangThai.Text = rowData.Cells[7].Value.ToString();
                txt_ChucVu.Text = rowData.Cells[8].Value.ToString();
            }
            else
            {
                MessageBox.Show("Hãy click vào đúng mục");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string ma = txt_MaNV.Text;
            string ten = txt_TenNV.Text;
            string gioitinh = txt_GioiTinh.Text;
            DateTime ngaysinh = DateTime.Parse(dtp_NgaySinh.Text);
            string sdt = txt_SDT.Text;
            string email = txt_Email.Text;
            string diachi = txt_DiaChi.Text;
            string trangthai = cbx_TrangThai.Text;
            string machucvu = txt_ChucVu.Text;
            if (!_services.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại sai"); return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = _services.CNSua(ma, ten, gioitinh, ngaysinh, sdt, email, diachi, trangthai, machucvu);
                MessageBox.Show(kq);
                List<NhanVien> nhanViens = _services.CNShow();
                ShowDaTa(nhanViens);
                return;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            List<NhanVien> nv = _services.CNTim(txt_TimKiemNV.Text);
            ShowDaTa(nv);
        }
    }
}
