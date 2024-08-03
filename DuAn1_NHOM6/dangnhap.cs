using BUS.Services;
using DAL.DomainClass;
using PRL;

namespace DuAn1_NHOM6
{
    public partial class dangnhap : Form
    {
        private readonly NhanVienServices service;
        public string idWhenClick;
        public dangnhap()
        {
            InitializeComponent();
            service = new NhanVienServices();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            var username = txt_taikhoan.Text;
            var password = txt_matkhau.Text;

            var nhanVien = service.DangNhap(username, password);

            if (nhanVien != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                home home = new home(nhanVien);
                home.FormClosed += home_FormClosed;
                home.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng hoặc tài khoản của bạn ngưng hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            dangky registerForm = new dangky();
            registerForm.FormClosed += dangky_FormClosed;
            registerForm.ShowDialog();
        }
        private void dangky_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
