namespace DuAn1_NHOM6
{
    partial class BanHang
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
            groupBox1 = new GroupBox();
            cbb_TrangThai = new ComboBox();
            label14 = new Label();
            dtpk_NgayBan = new DateTimePicker();
            label13 = new Label();
            btn_Huy = new Button();
            btn_InHoaDon = new Button();
            btn_ThanhToan = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            label12 = new Label();
            cbb_PhuongThucThanhToan = new ComboBox();
            groupBox2 = new GroupBox();
            dgv_GioHang = new DataGridView();
            txt_TienThua = new TextBox();
            cbb_KhuyenMai = new ComboBox();
            txt_TongTien = new TextBox();
            txt_DonGia = new TextBox();
            txt_SoLuong = new TextBox();
            txt_MaSanPham = new TextBox();
            txt_TenNV = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            cbb_Size = new ComboBox();
            cbb_MauSac = new ComboBox();
            cbb_Hang = new ComboBox();
            txt_TimKiem = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dgv_DanhSachSanPham = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_GioHang).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbb_TrangThai);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(dtpk_NgayBan);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btn_Huy);
            groupBox1.Controls.Add(btn_InHoaDon);
            groupBox1.Controls.Add(btn_ThanhToan);
            groupBox1.Controls.Add(btn_Xoa);
            groupBox1.Controls.Add(btn_Sua);
            groupBox1.Controls.Add(btn_Them);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cbb_PhuongThucThanhToan);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txt_TienThua);
            groupBox1.Controls.Add(cbb_KhuyenMai);
            groupBox1.Controls.Add(txt_TongTien);
            groupBox1.Controls.Add(txt_DonGia);
            groupBox1.Controls.Add(txt_SoLuong);
            groupBox1.Controls.Add(txt_MaSanPham);
            groupBox1.Controls.Add(txt_TenNV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1267, 418);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Location = new Point(245, 377);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(151, 28);
            cbb_TrangThai.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 380);
            label14.Name = "label14";
            label14.Size = new Size(82, 20);
            label14.TabIndex = 24;
            label14.Text = "Trạng thái: ";
            // 
            // dtpk_NgayBan
            // 
            dtpk_NgayBan.Location = new Point(245, 115);
            dtpk_NgayBan.Name = "dtpk_NgayBan";
            dtpk_NgayBan.Size = new Size(275, 27);
            dtpk_NgayBan.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 338);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 22;
            label13.Text = "Số tiền trả lại: ";
            // 
            // btn_Huy
            // 
            btn_Huy.BackColor = Color.Red;
            btn_Huy.ForeColor = Color.White;
            btn_Huy.Location = new Point(1163, 368);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(94, 44);
            btn_Huy.TabIndex = 21;
            btn_Huy.Text = "Hủy";
            btn_Huy.UseVisualStyleBackColor = false;
            // 
            // btn_InHoaDon
            // 
            btn_InHoaDon.Location = new Point(1049, 368);
            btn_InHoaDon.Name = "btn_InHoaDon";
            btn_InHoaDon.Size = new Size(108, 44);
            btn_InHoaDon.TabIndex = 20;
            btn_InHoaDon.Text = "In Hóa Đơn";
            btn_InHoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Location = new Point(949, 368);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(94, 44);
            btn_ThanhToan.TabIndex = 19;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(849, 368);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 44);
            btn_Xoa.TabIndex = 18;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(749, 368);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 44);
            btn_Sua.TabIndex = 17;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += button2_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(649, 368);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 44);
            btn_Them.TabIndex = 16;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 301);
            label12.Name = "label12";
            label12.Size = new Size(175, 20);
            label12.TabIndex = 15;
            label12.Text = "Phương thức thanh toán: ";
            // 
            // cbb_PhuongThucThanhToan
            // 
            cbb_PhuongThucThanhToan.FormattingEnabled = true;
            cbb_PhuongThucThanhToan.Location = new Point(245, 298);
            cbb_PhuongThucThanhToan.Name = "cbb_PhuongThucThanhToan";
            cbb_PhuongThucThanhToan.Size = new Size(187, 28);
            cbb_PhuongThucThanhToan.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_GioHang);
            groupBox2.Location = new Point(649, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(608, 323);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giỏ Hàng";
            // 
            // dgv_GioHang
            // 
            dgv_GioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_GioHang.Location = new Point(6, 26);
            dgv_GioHang.Name = "dgv_GioHang";
            dgv_GioHang.RowHeadersWidth = 51;
            dgv_GioHang.RowTemplate.Height = 29;
            dgv_GioHang.Size = new Size(590, 287);
            dgv_GioHang.TabIndex = 0;
            // 
            // txt_TienThua
            // 
            txt_TienThua.Location = new Point(245, 335);
            txt_TienThua.Name = "txt_TienThua";
            txt_TienThua.Size = new Size(275, 27);
            txt_TienThua.TabIndex = 13;
            // 
            // cbb_KhuyenMai
            // 
            cbb_KhuyenMai.FormattingEnabled = true;
            cbb_KhuyenMai.Location = new Point(245, 227);
            cbb_KhuyenMai.Name = "cbb_KhuyenMai";
            cbb_KhuyenMai.Size = new Size(237, 28);
            cbb_KhuyenMai.TabIndex = 12;
            cbb_KhuyenMai.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txt_TongTien
            // 
            txt_TongTien.Location = new Point(245, 261);
            txt_TongTien.Name = "txt_TongTien";
            txt_TongTien.Size = new Size(275, 27);
            txt_TongTien.TabIndex = 11;
            // 
            // txt_DonGia
            // 
            txt_DonGia.Location = new Point(245, 193);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.Size = new Size(275, 27);
            txt_DonGia.TabIndex = 10;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(245, 157);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(275, 27);
            txt_SoLuong.TabIndex = 9;
            // 
            // txt_MaSanPham
            // 
            txt_MaSanPham.Location = new Point(245, 78);
            txt_MaSanPham.Name = "txt_MaSanPham";
            txt_MaSanPham.Size = new Size(275, 27);
            txt_MaSanPham.TabIndex = 8;
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(245, 39);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(275, 27);
            txt_TenNV.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 264);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 6;
            label7.Text = "Tổng tiền: ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 230);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Khuyến mãi: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 196);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 160);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 120);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày bán: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 81);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sản phẩm: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên: ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbb_Size);
            groupBox3.Controls.Add(cbb_MauSac);
            groupBox3.Controls.Add(cbb_Hang);
            groupBox3.Controls.Add(txt_TimKiem);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(dgv_DanhSachSanPham);
            groupBox3.Location = new Point(12, 427);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1267, 267);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // cbb_Size
            // 
            cbb_Size.FormattingEnabled = true;
            cbb_Size.Location = new Point(968, 30);
            cbb_Size.Name = "cbb_Size";
            cbb_Size.Size = new Size(151, 28);
            cbb_Size.TabIndex = 16;
            // 
            // cbb_MauSac
            // 
            cbb_MauSac.FormattingEnabled = true;
            cbb_MauSac.Location = new Point(725, 30);
            cbb_MauSac.Name = "cbb_MauSac";
            cbb_MauSac.Size = new Size(151, 28);
            cbb_MauSac.TabIndex = 11;
            // 
            // cbb_Hang
            // 
            cbb_Hang.FormattingEnabled = true;
            cbb_Hang.Location = new Point(462, 30);
            cbb_Hang.Name = "cbb_Hang";
            cbb_Hang.Size = new Size(151, 28);
            cbb_Hang.TabIndex = 10;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(110, 30);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(245, 27);
            txt_TimKiem.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(919, 33);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 4;
            label11.Text = "Size: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(649, 33);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 3;
            label10.Text = "Màu sắc: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(404, 33);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 2;
            label9.Text = "Hãng: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 33);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 1;
            label8.Text = "Tìm kiếm: \r\n";
            // 
            // dgv_DanhSachSanPham
            // 
            dgv_DanhSachSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachSanPham.Location = new Point(12, 73);
            dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            dgv_DanhSachSanPham.RowHeadersWidth = 51;
            dgv_DanhSachSanPham.RowTemplate.Height = 29;
            dgv_DanhSachSanPham.Size = new Size(1245, 186);
            dgv_DanhSachSanPham.TabIndex = 0;
            // 
            // BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 706);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "BanHang";
            Text = "BanHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_GioHang).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_TenNV;
        private TextBox txt_TienThua;
        private ComboBox cbb_KhuyenMai;
        private TextBox txt_TongTien;
        private TextBox txt_DonGia;
        private TextBox txt_SoLuong;
        private TextBox txt_MaSanPham;
        private GroupBox groupBox2;
        private DataGridView dgv_GioHang;
        private GroupBox groupBox3;
        private Label label8;
        private DataGridView dgv_DanhSachSanPham;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox cbb_MauSac;
        private ComboBox cbb_Hang;
        private ComboBox cbb_PhuongThucThanhToan;
        private TextBox txt_TimKiem;
        private Label label12;
        private Button btn_InHoaDon;
        private Button btn_ThanhToan;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private ComboBox cbb_Size;
        private Button btn_Huy;
        private Label label13;
        private DateTimePicker dtpk_NgayBan;
        private ComboBox cbb_TrangThai;
        private Label label14;
    }
}