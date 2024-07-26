using BUS.Services;
using DAL.DomainClass;
using PRL;

namespace DuAn1_NHOM6
{
    public partial class dangnhap : Form
    {
        private readonly TaiKhoanServices service;
        public string idWhenClick;
        public dangnhap()
        {
            InitializeComponent();
            service = new TaiKhoanServices();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            //string username = txt_taikhoan.Text;
            //string password = txt_matkhau.Text;

            //bool isValid = service.Login(username, password);

            //if (isValid)
            //{
            //    MessageBox.Show("Đăng nhập thành công!");
            //    // Điều hướng đến form chính
            //    home formMoi = new home();
            //    formMoi.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            //}
            string username = txt_taikhoan.Text;
            string password = txt_matkhau.Text;

            bool isValid = service.Login(username, password);

            if (isValid)
            {
                string role = service.GetUserRole(username);
                string fullName = service.GetUserFullName(username);
                string userId = service.GetUserId(username); // Retrieve user ID

                // gọi gàm get MaNhanVien by id của nhân viên            
                 NhanVienDangNhap.MaNhanVien = "NV01";   //như kiểu hằng số  

                MessageBox.Show("Đăng nhập thành công!");
                
                home formHome = new home(role, fullName, userId);
                formHome.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }   
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
