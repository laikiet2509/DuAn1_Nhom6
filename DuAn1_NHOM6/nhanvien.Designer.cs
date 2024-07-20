namespace DuAn1_NHOM6
{
    partial class nhanvien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_MaNV = new TextBox();
            txt_TenNV = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_DiaChi = new TextBox();
            txt_SDT = new TextBox();
            btn_Them = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            grb_ThongTin = new GroupBox();
            btn_Show = new Button();
            txt_GioiTinh = new TextBox();
            txt_ChucVu = new TextBox();
            label10 = new Label();
            dtp_NgaySinh = new DateTimePicker();
            cbx_TrangThai = new ComboBox();
            txt_Email = new TextBox();
            label8 = new Label();
            label7 = new Label();
            grb_BoLoc = new GroupBox();
            btn_TimKiem = new Button();
            txt_TimKiemNV = new TextBox();
            label9 = new Label();
            grb_DanhSach = new GroupBox();
            dgv_DanhSachNV = new DataGridView();
            grb_ThongTin.SuspendLayout();
            grb_BoLoc.SuspendLayout();
            grb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachNV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 58);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 118);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên NV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 183);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(164, 51);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(367, 27);
            txt_MaNV.TabIndex = 3;
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(164, 111);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(367, 27);
            txt_TenNV.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 243);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 451);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 8;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 311);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 9;
            label6.Text = "Số điện thoại";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(166, 437);
            txt_DiaChi.Multiline = true;
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(367, 34);
            txt_DiaChi.TabIndex = 18;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(164, 304);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(367, 27);
            txt_SDT.TabIndex = 19;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Them.Location = new Point(177, 658);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(98, 31);
            btn_Them.TabIndex = 20;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Xoa.Location = new Point(306, 658);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(98, 31);
            btn_Xoa.TabIndex = 21;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sua.Location = new Point(441, 658);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(98, 31);
            btn_Sua.TabIndex = 22;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // grb_ThongTin
            // 
            grb_ThongTin.Controls.Add(btn_Show);
            grb_ThongTin.Controls.Add(txt_GioiTinh);
            grb_ThongTin.Controls.Add(txt_ChucVu);
            grb_ThongTin.Controls.Add(label10);
            grb_ThongTin.Controls.Add(dtp_NgaySinh);
            grb_ThongTin.Controls.Add(cbx_TrangThai);
            grb_ThongTin.Controls.Add(txt_Email);
            grb_ThongTin.Controls.Add(label8);
            grb_ThongTin.Controls.Add(label7);
            grb_ThongTin.Controls.Add(btn_Sua);
            grb_ThongTin.Controls.Add(btn_Xoa);
            grb_ThongTin.Controls.Add(label5);
            grb_ThongTin.Controls.Add(label6);
            grb_ThongTin.Controls.Add(btn_Them);
            grb_ThongTin.Controls.Add(label4);
            grb_ThongTin.Controls.Add(label1);
            grb_ThongTin.Controls.Add(txt_TenNV);
            grb_ThongTin.Controls.Add(txt_SDT);
            grb_ThongTin.Controls.Add(label2);
            grb_ThongTin.Controls.Add(txt_MaNV);
            grb_ThongTin.Controls.Add(txt_DiaChi);
            grb_ThongTin.Controls.Add(label3);
            grb_ThongTin.Dock = DockStyle.Left;
            grb_ThongTin.Location = new Point(0, 0);
            grb_ThongTin.Name = "grb_ThongTin";
            grb_ThongTin.Size = new Size(573, 729);
            grb_ThongTin.TabIndex = 3;
            grb_ThongTin.TabStop = false;
            grb_ThongTin.Text = "Thông tin nhân viên";
            grb_ThongTin.Enter += groupBox2_Enter;
            // 
            // btn_Show
            // 
            btn_Show.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Show.Location = new Point(43, 658);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(98, 31);
            btn_Show.TabIndex = 32;
            btn_Show.Text = "Show";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // txt_GioiTinh
            // 
            txt_GioiTinh.Location = new Point(164, 177);
            txt_GioiTinh.Name = "txt_GioiTinh";
            txt_GioiTinh.Size = new Size(367, 27);
            txt_GioiTinh.TabIndex = 31;
            // 
            // txt_ChucVu
            // 
            txt_ChucVu.Location = new Point(164, 578);
            txt_ChucVu.Name = "txt_ChucVu";
            txt_ChucVu.Size = new Size(367, 27);
            txt_ChucVu.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 585);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 29;
            label10.Text = "Chức vụ";
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.Location = new Point(164, 238);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(367, 27);
            dtp_NgaySinh.TabIndex = 28;
            dtp_NgaySinh.ValueChanged += dtp_NgaySinh_ValueChanged;
            // 
            // cbx_TrangThai
            // 
            cbx_TrangThai.FormattingEnabled = true;
            cbx_TrangThai.Location = new Point(164, 515);
            cbx_TrangThai.Name = "cbx_TrangThai";
            cbx_TrangThai.Size = new Size(367, 28);
            cbx_TrangThai.TabIndex = 26;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(166, 373);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(367, 27);
            txt_Email.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 521);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 24;
            label8.Text = "Trạng thái";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 380);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 23;
            label7.Text = "Email";
            // 
            // grb_BoLoc
            // 
            grb_BoLoc.Controls.Add(btn_TimKiem);
            grb_BoLoc.Controls.Add(txt_TimKiemNV);
            grb_BoLoc.Controls.Add(label9);
            grb_BoLoc.Dock = DockStyle.Top;
            grb_BoLoc.Location = new Point(573, 0);
            grb_BoLoc.Name = "grb_BoLoc";
            grb_BoLoc.Size = new Size(649, 125);
            grb_BoLoc.TabIndex = 4;
            grb_BoLoc.TabStop = false;
            grb_BoLoc.Text = "Bộ lọc";
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(514, 50);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(94, 29);
            btn_TimKiem.TabIndex = 2;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // txt_TimKiemNV
            // 
            txt_TimKiemNV.Location = new Point(174, 52);
            txt_TimKiemNV.Name = "txt_TimKiemNV";
            txt_TimKiemNV.Size = new Size(305, 27);
            txt_TimKiemNV.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 58);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 0;
            label9.Text = "Tên nhân viên";
            // 
            // grb_DanhSach
            // 
            grb_DanhSach.Controls.Add(dgv_DanhSachNV);
            grb_DanhSach.Dock = DockStyle.Fill;
            grb_DanhSach.Location = new Point(573, 125);
            grb_DanhSach.Name = "grb_DanhSach";
            grb_DanhSach.Size = new Size(649, 604);
            grb_DanhSach.TabIndex = 5;
            grb_DanhSach.TabStop = false;
            grb_DanhSach.Text = "Danh sách nhân viên";
            // 
            // dgv_DanhSachNV
            // 
            dgv_DanhSachNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachNV.Dock = DockStyle.Fill;
            dgv_DanhSachNV.Location = new Point(3, 23);
            dgv_DanhSachNV.Name = "dgv_DanhSachNV";
            dgv_DanhSachNV.RowHeadersWidth = 51;
            dgv_DanhSachNV.RowTemplate.Height = 29;
            dgv_DanhSachNV.Size = new Size(643, 578);
            dgv_DanhSachNV.TabIndex = 0;
            dgv_DanhSachNV.CellClick += dgv_DanhSachNV_CellClick;
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 729);
            Controls.Add(grb_DanhSach);
            Controls.Add(grb_BoLoc);
            Controls.Add(grb_ThongTin);
            Name = "nhanvien";
            Text = "Nhân viên";
            Load += Form1_Load;
            grb_ThongTin.ResumeLayout(false);
            grb_ThongTin.PerformLayout();
            grb_BoLoc.ResumeLayout(false);
            grb_BoLoc.PerformLayout();
            grb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachNV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Them;
        private Label label1;
        private TextBox txt_SDT;
        private Label label2;
        private TextBox txt_DiaChi;
        private Label label3;
        private TextBox txt_MaNV;
        private TextBox txt_TenNV;
        private Label label4;
        private Label label6;
        private Label label5;
        private GroupBox grb_ThongTin;
        private ComboBox cbx_TrangThai;
        private TextBox txt_Email;
        private Label label8;
        private Label label7;
        private DateTimePicker dtp_NgaySinh;
        private GroupBox grb_BoLoc;
        private Button btn_TimKiem;
        private TextBox txt_TimKiemNV;
        private Label label9;
        private GroupBox grb_DanhSach;
        private DataGridView dgv_DanhSachNV;
//<<<<<<< HEAD
        private TextBox txt_ChucVu;
        private Label label10;
        private Button btn_Show;
        private TextBox txt_GioiTinh;
        //=======
        //        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //>>>>>>> 899a5feebe9cef5523a8094616fa28d1635ac3b5
    }
}
