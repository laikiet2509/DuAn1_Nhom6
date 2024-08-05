using DAL.DomainClass;
using PRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using BUS.Services;
using Microsoft.VisualBasic.Logging;

namespace DuAn1_NHOM6
{
    public partial class home : Form
    {
        NhanVien _nhanVien { get; set; }
        private readonly NhanVienServices nhanVienServices;
        ChucVuServices chucVuServices = new ChucVuServices();

        public home(NhanVien nhanVien)
        {
            _nhanVien = nhanVien;
            InitializeComponent();
            nhanVienServices = new NhanVienServices();
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            lblten.Text = "Tên: " + _nhanVien.Ten;
            lblquyen.Text = "Chức Vụ: " + chucVuServices.GetChucVuById(_nhanVien.MaChucVu).TenChucVu;
            
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new sanpham());
            label1.Text = btn_sanpham.Text;
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new khachhang());
            label1.Text = btn_khachhang.Text;
        }


        private void btn_banhang_Click(object sender, EventArgs e)
        {

            OpenChildForm(new banhang(_nhanVien));
            label1.Text = btn_banhang.Text;

        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new hoadon());
            label1.Text = btn_hoadon.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "Home";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new voucher());
            label1.Text = btn_voucher.Text;

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new thongke());
            label1.Text = btn_thongke.Text;
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            if (_nhanVien.MaChucVu == "CV01" && _nhanVien.TrangThai == 1)
            {
                OpenChildForm(new nhanvien());
                label1.Text = btn_nhanvien.Text;
            }
            else if (_nhanVien.MaChucVu == "CV01" && _nhanVien.TrangThai == 2)
            {
                MessageBox.Show("Bạn không còn quyền truy cập!");
            }
            else
            {
                MessageBox.Show("Bạn không phải ADMIN, không có quyền truy cập!");
            }

        }

        private void btn_thietlap_Click(object sender, EventArgs e)
        {

            // Đóng form home
            this.Close();

        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
