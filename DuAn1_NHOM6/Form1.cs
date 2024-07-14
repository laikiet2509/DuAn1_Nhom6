namespace DuAn1_NHOM6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool TaiKhoan(string username, string password)
        {
            string defaultUsername = "Admin";
            string defaultPassword = "1";
            return username == defaultUsername && password == defaultPassword;
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan.Text;
            string password = txt_matkhau.Text;


            if (TaiKhoan(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                Form2 formMoi = new Form2();
                formMoi.ShowDialog();

            }

            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, Vui lòng thử lại! ");

                txt_taikhoan.Text = "";
                txt_matkhau.Text = "";
                txt_taikhoan.Focus();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
