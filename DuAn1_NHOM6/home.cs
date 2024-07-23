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

namespace DuAn1_NHOM6
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
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
            OpenChildForm(new banhang());
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
            label1.Text = btn_khuyenmai.Text;
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {

        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new nhanvien());
            label1.Text = btn_nhanvien.Text;
        }
    }
}
