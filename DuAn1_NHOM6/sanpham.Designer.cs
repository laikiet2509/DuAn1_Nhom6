namespace PRL
{
    partial class sanpham
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
            btn_chonanh = new Button();
            txt_Thuonghieu = new TextBox();
            cmbx_kichthuoc = new ComboBox();
            dtp_ngaynhap = new DateTimePicker();
            btn_lammoi = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            pictureBox1 = new PictureBox();
            cmbx_chatlieu = new ComboBox();
            cmbx_mausac = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_soluong = new TextBox();
            label9 = new Label();
            txt_giatien = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_tensanpham = new TextBox();
            label1 = new Label();
            txt_masanpham = new TextBox();
            groupBox2 = new GroupBox();
            btn_timkiem = new Button();
            label11 = new Label();
            txt_search = new TextBox();
            groupBox3 = new GroupBox();
            dtgView_sp = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_sp).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(btn_chonanh);
            groupBox1.Controls.Add(txt_Thuonghieu);
            groupBox1.Controls.Add(cmbx_kichthuoc);
            groupBox1.Controls.Add(dtp_ngaynhap);
            groupBox1.Controls.Add(btn_lammoi);
            groupBox1.Controls.Add(btn_xoa);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cmbx_chatlieu);
            groupBox1.Controls.Add(cmbx_mausac);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txt_soluong);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_giatien);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_tensanpham);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_masanpham);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 883);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sản Phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btn_chonanh
            // 
            btn_chonanh.ImageAlign = ContentAlignment.MiddleLeft;
            btn_chonanh.Location = new Point(489, 299);
            btn_chonanh.Name = "btn_chonanh";
            btn_chonanh.Size = new Size(117, 41);
            btn_chonanh.TabIndex = 34;
            btn_chonanh.Text = "Chọn Ảnh";
            btn_chonanh.UseVisualStyleBackColor = true;
            btn_chonanh.Click += btn_chonanh_Click;
            // 
            // txt_Thuonghieu
            // 
            txt_Thuonghieu.Location = new Point(129, 611);
            txt_Thuonghieu.Name = "txt_Thuonghieu";
            txt_Thuonghieu.Size = new Size(266, 24);
            txt_Thuonghieu.TabIndex = 33;
            // 
            // cmbx_kichthuoc
            // 
            cmbx_kichthuoc.FormattingEnabled = true;
            cmbx_kichthuoc.Location = new Point(129, 537);
            cmbx_kichthuoc.Name = "cmbx_kichthuoc";
            cmbx_kichthuoc.Size = new Size(266, 26);
            cmbx_kichthuoc.TabIndex = 32;
            // 
            // dtp_ngaynhap
            // 
            dtp_ngaynhap.Location = new Point(129, 396);
            dtp_ngaynhap.Name = "dtp_ngaynhap";
            dtp_ngaynhap.Size = new Size(266, 24);
            dtp_ngaynhap.TabIndex = 31;
            dtp_ngaynhap.Value = new DateTime(2024, 7, 16, 22, 59, 26, 0);
            // 
            // btn_lammoi
            // 
            btn_lammoi.Image = Properties.Resources.update1;
            btn_lammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi.Location = new Point(489, 604);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(117, 41);
            btn_lammoi.TabIndex = 29;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Image = Properties.Resources.Delete;
            btn_xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_xoa.Location = new Point(489, 530);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(117, 41);
            btn_xoa.TabIndex = 28;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Image = Properties.Resources.Edit;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(489, 461);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(117, 41);
            btn_sua.TabIndex = 27;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Image = Properties.Resources.Add;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(489, 391);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(117, 41);
            btn_them.TabIndex = 26;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(428, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // cmbx_chatlieu
            // 
            cmbx_chatlieu.FormattingEnabled = true;
            cmbx_chatlieu.Location = new Point(129, 264);
            cmbx_chatlieu.Name = "cmbx_chatlieu";
            cmbx_chatlieu.Size = new Size(266, 26);
            cmbx_chatlieu.TabIndex = 23;
            // 
            // cmbx_mausac
            // 
            cmbx_mausac.FormattingEnabled = true;
            cmbx_mausac.Location = new Point(129, 190);
            cmbx_mausac.Name = "cmbx_mausac";
            cmbx_mausac.Size = new Size(266, 26);
            cmbx_mausac.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 614);
            label6.Name = "label6";
            label6.Size = new Size(92, 18);
            label6.TabIndex = 16;
            label6.Text = "Thương Hiệu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 540);
            label7.Name = "label7";
            label7.Size = new Size(83, 18);
            label7.TabIndex = 15;
            label7.Text = "Kích Thước";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 464);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 14;
            label8.Text = "Số Lượng";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(129, 461);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(266, 24);
            txt_soluong.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 394);
            label9.Name = "label9";
            label9.Size = new Size(81, 18);
            label9.TabIndex = 11;
            label9.Text = "Ngày Nhập";
            // 
            // txt_giatien
            // 
            txt_giatien.Location = new Point(129, 333);
            txt_giatien.Name = "txt_giatien";
            txt_giatien.Size = new Size(266, 24);
            txt_giatien.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 333);
            label5.Name = "label5";
            label5.Size = new Size(63, 18);
            label5.TabIndex = 8;
            label5.Text = "Giá Tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 267);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 6;
            label4.Text = "Chất Liệu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 193);
            label3.Name = "label3";
            label3.Size = new Size(67, 18);
            label3.TabIndex = 5;
            label3.Text = "Mảu Sắc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 117);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 4;
            label2.Text = "Tên Sản Phẩm";
            // 
            // txt_tensanpham
            // 
            txt_tensanpham.Location = new Point(129, 114);
            txt_tensanpham.Name = "txt_tensanpham";
            txt_tensanpham.Size = new Size(266, 24);
            txt_tensanpham.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 47);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 1;
            label1.Text = "Mã Sản Phẩm";
            // 
            // txt_masanpham
            // 
            txt_masanpham.Location = new Point(129, 44);
            txt_masanpham.Name = "txt_masanpham";
            txt_masanpham.RightToLeft = RightToLeft.No;
            txt_masanpham.Size = new Size(266, 24);
            txt_masanpham.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(btn_timkiem);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txt_search);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(672, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(674, 116);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bộ Lọc";
            // 
            // btn_timkiem
            // 
            btn_timkiem.Image = Properties.Resources.Search;
            btn_timkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btn_timkiem.Location = new Point(336, 60);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.RightToLeft = RightToLeft.No;
            btn_timkiem.Size = new Size(98, 36);
            btn_timkiem.TabIndex = 7;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.TextAlign = ContentAlignment.MiddleRight;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(76, 33);
            label11.Name = "label11";
            label11.Size = new Size(106, 18);
            label11.TabIndex = 6;
            label11.Text = "Tên Sản Phẩm";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(76, 65);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(226, 24);
            txt_search.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.WhiteSmoke;
            groupBox3.Controls.Add(dtgView_sp);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(672, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(674, 767);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Sản Phẩm";
            // 
            // dtgView_sp
            // 
            dtgView_sp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_sp.Dock = DockStyle.Fill;
            dtgView_sp.Location = new Point(3, 20);
            dtgView_sp.Name = "dtgView_sp";
            dtgView_sp.RowHeadersWidth = 51;
            dtgView_sp.RowTemplate.Height = 29;
            dtgView_sp.Size = new Size(668, 744);
            dtgView_sp.TabIndex = 0;
            dtgView_sp.CellClick += dtgView_sp_CellClick;
            // 
            // sanpham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 883);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "sanpham";
            Text = "Sản Phẩm";
            Load += sanpham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_sp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_giatien;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_tensanpham;
        private Label label1;
        private TextBox txt_masanpham;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_soluong;
        private Label label9;
        private ComboBox cmbx_mausac;
        private ComboBox cmbx_chatlieu;
        private PictureBox pictureBox1;
        private Button btn_lammoi;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private Button btn_timkiem;
        private Label label11;
        private TextBox txt_search;
        private GroupBox groupBox3;
        private DataGridView dtgView_sp;
        private DateTimePicker dtp_ngaynhap;
        private ComboBox cmbx_kichthuoc;
        private TextBox txt_Thuonghieu;
        private Button btn_chonanh;
    }
}