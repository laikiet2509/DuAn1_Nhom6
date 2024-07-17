namespace DuAn1_NHOM6
{
    partial class Form1
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
            rdb_GTNu = new RadioButton();
            txt_DiaChi = new TextBox();
            txt_SDT = new TextBox();
            btn_Them = new Button();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            groupBox2 = new GroupBox();
            dtp_NgaySinh = new DateTimePicker();
            rdb_Nam = new RadioButton();
            cbb_TrangThai = new ComboBox();
            txt_Email = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            btn_TimKiem = new Button();
            txt_TimKiemNV = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            dgv_DanhSachNV = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
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
            label4.Location = new Point(41, 305);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 378);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 8;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 443);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 9;
            label6.Text = "Số điện thoại";
            // 
            // rdb_GTNu
            // 
            rdb_GTNu.AutoSize = true;
            rdb_GTNu.Location = new Point(380, 183);
            rdb_GTNu.Name = "rdb_GTNu";
            rdb_GTNu.Size = new Size(50, 24);
            rdb_GTNu.TabIndex = 17;
            rdb_GTNu.TabStop = true;
            rdb_GTNu.Text = "Nữ";
            rdb_GTNu.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(164, 364);
            txt_DiaChi.Multiline = true;
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(367, 34);
            txt_DiaChi.TabIndex = 18;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(164, 436);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(367, 27);
            txt_SDT.TabIndex = 19;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(44, 588);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 20;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(240, 588);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 21;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(437, 588);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 22;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtp_NgaySinh);
            groupBox2.Controls.Add(rdb_Nam);
            groupBox2.Controls.Add(cbb_TrangThai);
            groupBox2.Controls.Add(txt_Email);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_TenNV);
            groupBox2.Controls.Add(txt_SDT);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_MaNV);
            groupBox2.Controls.Add(txt_DiaChi);
            groupBox2.Controls.Add(rdb_GTNu);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(573, 664);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin nhân viên";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.Location = new Point(164, 298);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(367, 27);
            dtp_NgaySinh.TabIndex = 28;
            dtp_NgaySinh.ValueChanged += dtp_NgaySinh_ValueChanged;
            // 
            // rdb_Nam
            // 
            rdb_Nam.AutoSize = true;
            rdb_Nam.Location = new Point(164, 182);
            rdb_Nam.Name = "rdb_Nam";
            rdb_Nam.Size = new Size(62, 24);
            rdb_Nam.TabIndex = 27;
            rdb_Nam.TabStop = true;
            rdb_Nam.Text = "Nam";
            rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // cbb_TrangThai
            // 
            cbb_TrangThai.FormattingEnabled = true;
            cbb_TrangThai.Location = new Point(164, 236);
            cbb_TrangThai.Name = "cbb_TrangThai";
            cbb_TrangThai.Size = new Size(367, 28);
            cbb_TrangThai.TabIndex = 26;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(164, 509);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(367, 27);
            txt_Email.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 242);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 24;
            label8.Text = "Trạng thái";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 516);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 23;
            label7.Text = "Email";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_TimKiem);
            groupBox3.Controls.Add(txt_TimKiemNV);
            groupBox3.Controls.Add(label9);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(573, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(649, 125);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bộ lọc";
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(514, 50);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(94, 29);
            btn_TimKiem.TabIndex = 2;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
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
            label9.Size = new Size(97, 20);
            label9.TabIndex = 0;
            label9.Text = "Mã nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_DanhSachNV);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(573, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(649, 539);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgv_DanhSachNV
            // 
            dgv_DanhSachNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachNV.Dock = DockStyle.Fill;
            dgv_DanhSachNV.Location = new Point(3, 23);
            dgv_DanhSachNV.Name = "dgv_DanhSachNV";
            dgv_DanhSachNV.RowHeadersWidth = 51;
            dgv_DanhSachNV.RowTemplate.Height = 29;
            dgv_DanhSachNV.Size = new Size(643, 513);
            dgv_DanhSachNV.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 664);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Nhân viên";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private RadioButton rdb_GTNu;
        private TextBox txt_MaNV;
        private TextBox txt_TenNV;
        private Label label4;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton rdb_Nam;
        private ComboBox cbb_TrangThai;
        private TextBox txt_Email;
        private Label label8;
        private Label label7;
        private DateTimePicker dtp_NgaySinh;
        private GroupBox groupBox3;
        private Button btn_TimKiem;
        private TextBox txt_TimKiemNV;
        private Label label9;
        private GroupBox groupBox1;
        private DataGridView dgv_DanhSachNV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
