﻿namespace DuAn1_NHOM6
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            panel_left = new Panel();
            btn_thietlap = new Button();
            btn_khachhang = new Button();
            btn_nhanvien = new Button();
            btn_thongke = new Button();
            btn_khuyenmai = new Button();
            btn_sanpham = new Button();
            btn_hoadon = new Button();
            btn_banhang = new Button();
            pictureBox1 = new PictureBox();
            panel_top = new Panel();
            label1 = new Label();
            panel_body = new Panel();
            pictureBox2 = new PictureBox();
            panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_top.SuspendLayout();
            panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.FromArgb(50, 52, 77);
            panel_left.Controls.Add(btn_thietlap);
            panel_left.Controls.Add(btn_khachhang);
            panel_left.Controls.Add(btn_nhanvien);
            panel_left.Controls.Add(btn_thongke);
            panel_left.Controls.Add(btn_khuyenmai);
            panel_left.Controls.Add(btn_sanpham);
            panel_left.Controls.Add(btn_hoadon);
            panel_left.Controls.Add(btn_banhang);
            panel_left.Controls.Add(pictureBox1);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(213, 809);
            panel_left.TabIndex = 0;
            // 
            // btn_thietlap
            // 
            btn_thietlap.BackColor = Color.FromArgb(50, 52, 77);
            btn_thietlap.Dock = DockStyle.Top;
            btn_thietlap.FlatAppearance.BorderSize = 0;
            btn_thietlap.FlatStyle = FlatStyle.Flat;
            btn_thietlap.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thietlap.ForeColor = SystemColors.Control;
            btn_thietlap.Image = PRL.Properties.Resources.banhxe;
            btn_thietlap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thietlap.Location = new Point(0, 723);
            btn_thietlap.Name = "btn_thietlap";
            btn_thietlap.Size = new Size(213, 77);
            btn_thietlap.TabIndex = 7;
            btn_thietlap.Text = "Thiết Lập";
            btn_thietlap.UseVisualStyleBackColor = false;
            // 
            // btn_khachhang
            // 
            btn_khachhang.BackColor = Color.FromArgb(50, 52, 77);
            btn_khachhang.Dock = DockStyle.Top;
            btn_khachhang.FlatAppearance.BorderSize = 0;
            btn_khachhang.FlatStyle = FlatStyle.Flat;
            btn_khachhang.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khachhang.ForeColor = SystemColors.Control;
            btn_khachhang.Image = PRL.Properties.Resources.multiple_users_silhouette;
            btn_khachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_khachhang.Location = new Point(0, 646);
            btn_khachhang.Name = "btn_khachhang";
            btn_khachhang.Size = new Size(213, 77);
            btn_khachhang.TabIndex = 6;
            btn_khachhang.Text = "Khách Hàng";
            btn_khachhang.UseVisualStyleBackColor = false;
            btn_khachhang.Click += btn_khachhang_Click;
            // 
            // btn_nhanvien
            // 
            btn_nhanvien.BackColor = Color.FromArgb(50, 52, 77);
            btn_nhanvien.Dock = DockStyle.Top;
            btn_nhanvien.FlatAppearance.BorderSize = 0;
            btn_nhanvien.FlatStyle = FlatStyle.Flat;
            btn_nhanvien.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nhanvien.ForeColor = SystemColors.Control;
            btn_nhanvien.Image = PRL.Properties.Resources.user__1_;
            btn_nhanvien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nhanvien.Location = new Point(0, 569);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Size = new Size(213, 77);
            btn_nhanvien.TabIndex = 5;
            btn_nhanvien.Text = "Nhân Viên";
            btn_nhanvien.UseVisualStyleBackColor = false;
            btn_nhanvien.Click += btn_nhanvien_Click;
            // 
            // btn_thongke
            // 
            btn_thongke.BackColor = Color.FromArgb(50, 52, 77);
            btn_thongke.Dock = DockStyle.Top;
            btn_thongke.FlatAppearance.BorderSize = 0;
            btn_thongke.FlatStyle = FlatStyle.Flat;
            btn_thongke.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thongke.ForeColor = SystemColors.Control;
            btn_thongke.Image = PRL.Properties.Resources.icons8_sales_50;
            btn_thongke.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thongke.Location = new Point(0, 492);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new Size(213, 77);
            btn_thongke.TabIndex = 4;
            btn_thongke.Text = "Thông Kê";
            btn_thongke.UseVisualStyleBackColor = false;
            btn_thongke.Click += btn_thongke_Click;
            // 
            // btn_khuyenmai
            // 
            btn_khuyenmai.BackColor = Color.FromArgb(50, 52, 77);
            btn_khuyenmai.Dock = DockStyle.Top;
            btn_khuyenmai.FlatAppearance.BorderSize = 0;
            btn_khuyenmai.FlatStyle = FlatStyle.Flat;
            btn_khuyenmai.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khuyenmai.ForeColor = SystemColors.Control;
            btn_khuyenmai.Image = PRL.Properties.Resources.discount;
            btn_khuyenmai.ImageAlign = ContentAlignment.MiddleLeft;
            btn_khuyenmai.Location = new Point(0, 415);
            btn_khuyenmai.Name = "btn_khuyenmai";
            btn_khuyenmai.Size = new Size(213, 77);
            btn_khuyenmai.TabIndex = 3;
            btn_khuyenmai.Text = "Khuyến Mãi";
            btn_khuyenmai.UseVisualStyleBackColor = false;
            btn_khuyenmai.Click += button3_Click;
            // 
            // btn_sanpham
            // 
            btn_sanpham.BackColor = Color.FromArgb(50, 52, 77);
            btn_sanpham.Dock = DockStyle.Top;
            btn_sanpham.FlatAppearance.BorderSize = 0;
            btn_sanpham.FlatStyle = FlatStyle.Flat;
            btn_sanpham.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sanpham.ForeColor = SystemColors.Control;
            btn_sanpham.Image = PRL.Properties.Resources.package;
            btn_sanpham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sanpham.Location = new Point(0, 338);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(213, 77);
            btn_sanpham.TabIndex = 2;
            btn_sanpham.Text = "Sản Phẩm";
            btn_sanpham.UseVisualStyleBackColor = false;
            btn_sanpham.Click += btn_sanpham_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.BackColor = Color.FromArgb(50, 52, 77);
            btn_hoadon.Dock = DockStyle.Top;
            btn_hoadon.FlatAppearance.BorderSize = 0;
            btn_hoadon.FlatStyle = FlatStyle.Flat;
            btn_hoadon.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hoadon.ForeColor = SystemColors.Control;
            btn_hoadon.Image = PRL.Properties.Resources.bill;
            btn_hoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hoadon.Location = new Point(0, 261);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(213, 77);
            btn_hoadon.TabIndex = 1;
            btn_hoadon.Text = "Hóa Đơn";
            btn_hoadon.UseVisualStyleBackColor = false;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_banhang
            // 
            btn_banhang.BackColor = Color.FromArgb(50, 52, 77);
            btn_banhang.Dock = DockStyle.Top;
            btn_banhang.FlatAppearance.BorderSize = 0;
            btn_banhang.FlatStyle = FlatStyle.Flat;
            btn_banhang.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_banhang.ForeColor = SystemColors.Control;
            btn_banhang.Image = (Image)resources.GetObject("btn_banhang.Image");
            btn_banhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_banhang.Location = new Point(0, 184);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(213, 77);
            btn_banhang.TabIndex = 0;
            btn_banhang.Text = "Bán Hàng";
            btn_banhang.UseVisualStyleBackColor = false;
            btn_banhang.Click += btn_banhang_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.MenuHighlight;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(0, 135, 137);
            panel_top.Controls.Add(label1);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(213, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1237, 89);
            panel_top.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(86, 35);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // panel_body
            // 
            panel_body.BackColor = SystemColors.Control;
            panel_body.BackgroundImageLayout = ImageLayout.Stretch;
            panel_body.Controls.Add(pictureBox2);
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(213, 89);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1237, 720);
            panel_body.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = PRL.Properties.Resources.z5660617933883_a7cda1dc270fe23f65dc73ec3cbb81c1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1237, 720);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 809);
            Controls.Add(panel_body);
            Controls.Add(panel_top);
            Controls.Add(panel_left);
            Name = "home";
            Text = "Form2";
            panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_left;
        private Panel panel_top;
        private PictureBox pictureBox1;
        private Button button7;
        private Button btn_banhang;
        private Button btn_nhanvien;
        private Button btn_thongke;
        private Button btn_khuyenmai;
        private Button btn_sanpham;
        private Button btn_hoadon;
        private Button btn_khachhang;
        private Label label1;
        private Button btn_thietlap;
        private Panel panel_body;
        private PictureBox pictureBox2;
    }
}