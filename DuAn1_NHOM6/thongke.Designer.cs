namespace PRL
{
    partial class thongke
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
            btn_Tim = new Button();
            btn_DTHomNay = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            dtp_TGDen = new DateTimePicker();
            dtp_TGTu = new DateTimePicker();
            groupBox2 = new GroupBox();
            cbx_LocTheoThang = new ComboBox();
            groupBox1 = new GroupBox();
            cbx_LocTheoNam = new ComboBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            lbl_KhachHang = new Label();
            lbl_SoKhachHang = new Label();
            label6 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            lbl_DonHuy = new Label();
            lbl_SoDonHuy = new Label();
            label5 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lbl_HoaDon = new Label();
            lbl_SoHoaDon = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_SoDoanhThu = new Label();
            lbl_DoanhThu = new Label();
            label3 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Tim
            // 
            btn_Tim.BackColor = SystemColors.Control;
            btn_Tim.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btn_Tim.Image = Properties.Resources.Search4;
            btn_Tim.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Tim.Location = new Point(961, 525);
            btn_Tim.Name = "btn_Tim";
            btn_Tim.Size = new Size(113, 47);
            btn_Tim.TabIndex = 24;
            btn_Tim.Text = "Tìm";
            btn_Tim.UseVisualStyleBackColor = false;
            btn_Tim.Click += btn_Tim_Click;
            // 
            // btn_DTHomNay
            // 
            btn_DTHomNay.BackColor = SystemColors.Control;
            btn_DTHomNay.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            btn_DTHomNay.Location = new Point(1114, 528);
            btn_DTHomNay.Name = "btn_DTHomNay";
            btn_DTHomNay.Size = new Size(144, 47);
            btn_DTHomNay.TabIndex = 32;
            btn_DTHomNay.Text = "DT hôm nay";
            btn_DTHomNay.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dtp_TGDen);
            groupBox3.Controls.Add(dtp_TGTu);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(79, 498);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(823, 97);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lọc theo khoảng thời gian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(429, 40);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "Đến";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 42);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 2;
            label1.Text = "Từ";
            // 
            // dtp_TGDen
            // 
            dtp_TGDen.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_TGDen.Location = new Point(477, 38);
            dtp_TGDen.Name = "dtp_TGDen";
            dtp_TGDen.Size = new Size(325, 27);
            dtp_TGDen.TabIndex = 1;
            // 
            // dtp_TGTu
            // 
            dtp_TGTu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_TGTu.Location = new Point(76, 38);
            dtp_TGTu.Name = "dtp_TGTu";
            dtp_TGTu.Size = new Size(324, 27);
            dtp_TGTu.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbx_LocTheoThang);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(506, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 74);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc theo tháng";
            // 
            // cbx_LocTheoThang
            // 
            cbx_LocTheoThang.FormattingEnabled = true;
            cbx_LocTheoThang.Location = new Point(6, 27);
            cbx_LocTheoThang.Name = "cbx_LocTheoThang";
            cbx_LocTheoThang.Size = new Size(344, 28);
            cbx_LocTheoThang.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbx_LocTheoNam);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(79, 376);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 74);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc theo năm";
            // 
            // cbx_LocTheoNam
            // 
            cbx_LocTheoNam.FormattingEnabled = true;
            cbx_LocTheoNam.Location = new Point(15, 27);
            cbx_LocTheoNam.Name = "cbx_LocTheoNam";
            cbx_LocTheoNam.Size = new Size(343, 28);
            cbx_LocTheoNam.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lime;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lbl_KhachHang);
            panel4.Controls.Add(lbl_SoKhachHang);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(883, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 268);
            panel4.TabIndex = 28;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.khachhang;
            pictureBox4.Location = new Point(210, 95);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // lbl_KhachHang
            // 
            lbl_KhachHang.AutoSize = true;
            lbl_KhachHang.BackColor = Color.Lime;
            lbl_KhachHang.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_KhachHang.Location = new Point(127, 108);
            lbl_KhachHang.Name = "lbl_KhachHang";
            lbl_KhachHang.Size = new Size(19, 20);
            lbl_KhachHang.TabIndex = 2;
            lbl_KhachHang.Text = "0";
            // 
            // lbl_SoKhachHang
            // 
            lbl_SoKhachHang.AutoSize = true;
            lbl_SoKhachHang.Location = new Point(87, 61);
            lbl_SoKhachHang.Name = "lbl_SoKhachHang";
            lbl_SoKhachHang.Size = new Size(0, 20);
            lbl_SoKhachHang.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 12);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 0;
            label6.Text = "Số Khách Hàng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lbl_DonHuy);
            panel3.Controls.Add(lbl_SoDonHuy);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(1281, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 268);
            panel3.TabIndex = 27;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hoadonhuy;
            pictureBox3.Location = new Point(219, 95);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // lbl_DonHuy
            // 
            lbl_DonHuy.AutoSize = true;
            lbl_DonHuy.BackColor = Color.Yellow;
            lbl_DonHuy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DonHuy.Location = new Point(118, 108);
            lbl_DonHuy.Name = "lbl_DonHuy";
            lbl_DonHuy.Size = new Size(19, 20);
            lbl_DonHuy.TabIndex = 2;
            lbl_DonHuy.Text = "0";
            // 
            // lbl_SoDonHuy
            // 
            lbl_SoDonHuy.AutoSize = true;
            lbl_SoDonHuy.Location = new Point(57, 76);
            lbl_SoDonHuy.Name = "lbl_SoDonHuy";
            lbl_SoDonHuy.Size = new Size(0, 20);
            lbl_SoDonHuy.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 12);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 0;
            label5.Text = "Số Hoá Đơn Huỷ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lbl_HoaDon);
            panel2.Controls.Add(lbl_SoHoaDon);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(478, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 268);
            panel2.TabIndex = 26;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hoadon;
            pictureBox2.Location = new Point(219, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lbl_HoaDon
            // 
            lbl_HoaDon.AutoSize = true;
            lbl_HoaDon.BackColor = Color.Coral;
            lbl_HoaDon.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_HoaDon.Location = new Point(118, 105);
            lbl_HoaDon.Name = "lbl_HoaDon";
            lbl_HoaDon.Size = new Size(19, 20);
            lbl_HoaDon.TabIndex = 2;
            lbl_HoaDon.Text = "0";
            // 
            // lbl_SoHoaDon
            // 
            lbl_SoHoaDon.AutoSize = true;
            lbl_SoHoaDon.Location = new Point(39, 66);
            lbl_SoHoaDon.Name = "lbl_SoHoaDon";
            lbl_SoHoaDon.Size = new Size(0, 20);
            lbl_SoHoaDon.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 12);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 0;
            label4.Text = "Số Hoá Đơn";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_SoDoanhThu);
            panel1.Controls.Add(lbl_DoanhThu);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(68, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 268);
            panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.doanhthu;
            pictureBox1.Location = new Point(210, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl_SoDoanhThu
            // 
            lbl_SoDoanhThu.AutoSize = true;
            lbl_SoDoanhThu.BackColor = Color.DeepSkyBlue;
            lbl_SoDoanhThu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SoDoanhThu.Location = new Point(56, 105);
            lbl_SoDoanhThu.Name = "lbl_SoDoanhThu";
            lbl_SoDoanhThu.Size = new Size(19, 20);
            lbl_SoDoanhThu.TabIndex = 2;
            lbl_SoDoanhThu.Text = "0";
            // 
            // lbl_DoanhThu
            // 
            lbl_DoanhThu.AutoSize = true;
            lbl_DoanhThu.Location = new Point(56, 63);
            lbl_DoanhThu.Name = "lbl_DoanhThu";
            lbl_DoanhThu.Size = new Size(0, 20);
            lbl_DoanhThu.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 12);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 0;
            label3.Text = "Doanh Thu";
            // 
            // thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 883);
            Controls.Add(btn_Tim);
            Controls.Add(btn_DTHomNay);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "thongke";
            Text = "thongke";
            Load += thongke_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Tim;
        private Button btn_DTHomNay;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtp_TGDen;
        private DateTimePicker dtp_TGTu;
        private GroupBox groupBox2;
        private ComboBox cbx_LocTheoThang;
        private GroupBox groupBox1;
        private ComboBox cbx_LocTheoNam;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label lbl_KhachHang;
        private Label lbl_SoKhachHang;
        private Label label6;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label lbl_DonHuy;
        private Label lbl_SoDonHuy;
        private Label label5;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label lbl_HoaDon;
        private Label lbl_SoHoaDon;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl_SoDoanhThu;
        private Label lbl_DoanhThu;
        private Label label3;
    }
}