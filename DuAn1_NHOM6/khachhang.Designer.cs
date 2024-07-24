namespace PRL
{
    partial class khachhang
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
            rbtn_nu = new RadioButton();
            rbtn_nam = new RadioButton();
            label4 = new Label();
            dtp_ngaydangky = new DateTimePicker();
            txt_sdt = new TextBox();
            btn_lammoi = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            rtxt_ghichu = new RichTextBox();
            label5 = new Label();
            txt_diachi = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txt_tenkhachhang = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_loc = new Button();
            txt_search = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            dtgView_khachhang = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_khachhang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(rbtn_nu);
            groupBox1.Controls.Add(rbtn_nam);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtp_ngaydangky);
            groupBox1.Controls.Add(txt_sdt);
            groupBox1.Controls.Add(btn_lammoi);
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(rtxt_ghichu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_diachi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txt_tenkhachhang);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 883);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // rbtn_nu
            // 
            rbtn_nu.AutoSize = true;
            rbtn_nu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_nu.Location = new Point(332, 310);
            rbtn_nu.Name = "rbtn_nu";
            rbtn_nu.Size = new Size(51, 24);
            rbtn_nu.TabIndex = 40;
            rbtn_nu.TabStop = true;
            rbtn_nu.Text = "Nữ";
            rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_nam
            // 
            rbtn_nam.AutoSize = true;
            rbtn_nam.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_nam.Location = new Point(175, 310);
            rbtn_nam.Name = "rbtn_nam";
            rbtn_nam.Size = new Size(65, 24);
            rbtn_nam.TabIndex = 39;
            rbtn_nam.TabStop = true;
            rbtn_nam.Text = "Nam";
            rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 388);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 33;
            label4.Text = "Ngày Đăng Ký";
            // 
            // dtp_ngaydangky
            // 
            dtp_ngaydangky.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_ngaydangky.Location = new Point(166, 383);
            dtp_ngaydangky.Name = "dtp_ngaydangky";
            dtp_ngaydangky.Size = new Size(266, 27);
            dtp_ngaydangky.TabIndex = 32;
            dtp_ngaydangky.Value = new DateTime(2024, 7, 16, 22, 59, 26, 0);
            // 
            // txt_sdt
            // 
            txt_sdt.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sdt.Location = new Point(166, 461);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(299, 27);
            txt_sdt.TabIndex = 18;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoi.Image = Properties.Resources.update;
            btn_lammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_lammoi.Location = new Point(357, 762);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(128, 47);
            btn_lammoi.TabIndex = 17;
            btn_lammoi.Text = "Làm Mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.Image = Properties.Resources.Edit1;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(207, 762);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(109, 47);
            btn_sua.TabIndex = 16;
            btn_sua.Text = "Sửa ";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.Image = Properties.Resources.Add2;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(58, 762);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(109, 47);
            btn_them.TabIndex = 14;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // rtxt_ghichu
            // 
            rtxt_ghichu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtxt_ghichu.Location = new Point(166, 611);
            rtxt_ghichu.Name = "rtxt_ghichu";
            rtxt_ghichu.Size = new Size(299, 93);
            rtxt_ghichu.TabIndex = 13;
            rtxt_ghichu.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 611);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 12;
            label5.Text = "Ghi Chú";
            // 
            // txt_diachi
            // 
            txt_diachi.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_diachi.Location = new Point(166, 533);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(299, 27);
            txt_diachi.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(71, 536);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 9;
            label6.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 464);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 8;
            label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 310);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Giới Tính";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(166, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 150);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txt_tenkhachhang
            // 
            txt_tenkhachhang.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tenkhachhang.Location = new Point(166, 231);
            txt_tenkhachhang.Name = "txt_tenkhachhang";
            txt_tenkhachhang.Size = new Size(299, 27);
            txt_tenkhachhang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 234);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Khách Hàng";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(btn_loc);
            groupBox2.Controls.Add(txt_search);
            groupBox2.Controls.Add(label7);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(538, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bộ Lọc";
            // 
            // btn_loc
            // 
            btn_loc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loc.Image = Properties.Resources.Search2;
            btn_loc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_loc.Location = new Point(404, 71);
            btn_loc.Name = "btn_loc";
            btn_loc.Size = new Size(111, 43);
            btn_loc.TabIndex = 18;
            btn_loc.Text = "Lọc";
            btn_loc.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(97, 79);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(253, 27);
            txt_search.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(97, 45);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 2;
            label7.Text = "Tên Khách Hàng";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonShadow;
            groupBox3.Controls.Add(dtgView_khachhang);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(538, 158);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(808, 725);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh Sách Khách Hàng";
            // 
            // dtgView_khachhang
            // 
            dtgView_khachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_khachhang.Dock = DockStyle.Fill;
            dtgView_khachhang.Location = new Point(3, 23);
            dtgView_khachhang.Name = "dtgView_khachhang";
            dtgView_khachhang.RowHeadersWidth = 51;
            dtgView_khachhang.RowTemplate.Height = 29;
            dtgView_khachhang.Size = new Size(802, 699);
            dtgView_khachhang.TabIndex = 0;
            dtgView_khachhang.CellClick += dtgView_khachhang_CellClick_1;
            // 
            // khachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 883);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "khachhang";
            Text = "Khách Hàng";
            Load += khachhang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_khachhang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TextBox txt_tenkhachhang;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txt_sdt;
        private Button btn_sua;
        private Button btn_them;
        private RichTextBox rtxt_ghichu;
        private Label label5;
        private TextBox txt_diachi;
        private Label label6;
        private Label label3;
        private Label label2;
        private Button btn_lammoi;
        private Button btn_loc;
        private TextBox txt_search;
        private Label label7;
        private Label label4;
        private DateTimePicker dtp_ngaydangky;
        private RadioButton rbtn_nu;
        private RadioButton rbtn_nam;
        private DataGridView dtgView_khachhang;
    }
}