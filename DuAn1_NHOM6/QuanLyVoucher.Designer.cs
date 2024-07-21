namespace DuAn1_NHOM6
{
    partial class QuanLyVoucher
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
            lblQLVoucher = new Label();
            grbThongTin = new GroupBox();
            dtpkNKT = new DateTimePicker();
            dtpkNgayapdung = new DateTimePicker();
            lblNgayketthuc = new Label();
            tbcMota = new TextBox();
            tbxDieuKien = new TextBox();
            tbxMavc = new TextBox();
            lblMota = new Label();
            lblDieuKien = new Label();
            lblNAP = new Label();
            lblMaVC = new Label();
            grbChucNang = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            grbDataVc = new GroupBox();
            dgvDataVC = new DataGridView();
            groupBox1 = new GroupBox();
            lbngoiy = new Label();
            txbTimkiem = new TextBox();
            BtnTimkiem = new Button();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            grbDataVc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataVC).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblQLVoucher
            // 
            lblQLVoucher.AutoSize = true;
            lblQLVoucher.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblQLVoucher.Location = new Point(511, 9);
            lblQLVoucher.Name = "lblQLVoucher";
            lblQLVoucher.Size = new Size(495, 67);
            lblQLVoucher.TabIndex = 0;
            lblQLVoucher.Text = "Quản Lý Khuyến Mãi ";
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(dtpkNKT);
            grbThongTin.Controls.Add(dtpkNgayapdung);
            grbThongTin.Controls.Add(lblNgayketthuc);
            grbThongTin.Controls.Add(tbcMota);
            grbThongTin.Controls.Add(tbxDieuKien);
            grbThongTin.Controls.Add(tbxMavc);
            grbThongTin.Controls.Add(lblMota);
            grbThongTin.Controls.Add(lblDieuKien);
            grbThongTin.Controls.Add(lblNAP);
            grbThongTin.Controls.Add(lblMaVC);
            grbThongTin.Location = new Point(26, 94);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(477, 272);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông tin";
            // 
            // dtpkNKT
            // 
            dtpkNKT.Location = new Point(152, 220);
            dtpkNKT.Name = "dtpkNKT";
            dtpkNKT.Size = new Size(250, 27);
            dtpkNKT.TabIndex = 13;
            // 
            // dtpkNgayapdung
            // 
            dtpkNgayapdung.Location = new Point(152, 161);
            dtpkNgayapdung.Name = "dtpkNgayapdung";
            dtpkNgayapdung.Size = new Size(250, 27);
            dtpkNgayapdung.TabIndex = 12;
            // 
            // lblNgayketthuc
            // 
            lblNgayketthuc.AutoSize = true;
            lblNgayketthuc.Location = new Point(37, 227);
            lblNgayketthuc.Name = "lblNgayketthuc";
            lblNgayketthuc.Size = new Size(100, 20);
            lblNgayketthuc.TabIndex = 11;
            lblNgayketthuc.Text = "Ngày kết thúc";
            // 
            // tbcMota
            // 
            tbcMota.Location = new Point(152, 80);
            tbcMota.Multiline = true;
            tbcMota.Name = "tbcMota";
            tbcMota.Size = new Size(277, 28);
            tbcMota.TabIndex = 10;
            // 
            // tbxDieuKien
            // 
            tbxDieuKien.Location = new Point(152, 119);
            tbxDieuKien.Name = "tbxDieuKien";
            tbxDieuKien.Size = new Size(277, 27);
            tbxDieuKien.TabIndex = 8;
            // 
            // tbxMavc
            // 
            tbxMavc.Location = new Point(152, 39);
            tbxMavc.Name = "tbxMavc";
            tbxMavc.Size = new Size(277, 27);
            tbxMavc.TabIndex = 6;
            // 
            // lblMota
            // 
            lblMota.AutoSize = true;
            lblMota.Location = new Point(37, 88);
            lblMota.Name = "lblMota";
            lblMota.Size = new Size(48, 20);
            lblMota.TabIndex = 5;
            lblMota.Text = "Mô tả";
            // 
            // lblDieuKien
            // 
            lblDieuKien.AutoSize = true;
            lblDieuKien.Location = new Point(34, 126);
            lblDieuKien.Name = "lblDieuKien";
            lblDieuKien.Size = new Size(73, 20);
            lblDieuKien.TabIndex = 2;
            lblDieuKien.Text = "Điều Kiện";
            // 
            // lblNAP
            // 
            lblNAP.AutoSize = true;
            lblNAP.Location = new Point(34, 168);
            lblNAP.Name = "lblNAP";
            lblNAP.Size = new Size(103, 20);
            lblNAP.TabIndex = 1;
            lblNAP.Text = "Ngày áp dụng";
            // 
            // lblMaVC
            // 
            lblMaVC.AutoSize = true;
            lblMaVC.Location = new Point(34, 46);
            lblMaVC.Name = "lblMaVC";
            lblMaVC.Size = new Size(83, 20);
            lblMaVC.TabIndex = 0;
            lblMaVC.Text = "MaVoucher";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Location = new Point(525, 94);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(370, 272);
            grbChucNang.TabIndex = 2;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(263, 34);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 54);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(152, 34);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(86, 54);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 54);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grbDataVc
            // 
            grbDataVc.Controls.Add(dgvDataVC);
            grbDataVc.Location = new Point(26, 395);
            grbDataVc.Name = "grbDataVc";
            grbDataVc.Size = new Size(1313, 307);
            grbDataVc.TabIndex = 2;
            grbDataVc.TabStop = false;
            grbDataVc.Text = "DataVoucher";
            // 
            // dgvDataVC
            // 
            dgvDataVC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataVC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataVC.Location = new Point(6, 26);
            dgvDataVC.Name = "dgvDataVC";
            dgvDataVC.RowHeadersWidth = 51;
            dgvDataVC.RowTemplate.Height = 29;
            dgvDataVC.Size = new Size(1301, 275);
            dgvDataVC.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbngoiy);
            groupBox1.Controls.Add(txbTimkiem);
            groupBox1.Controls.Add(BtnTimkiem);
            groupBox1.Location = new Point(934, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 268);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bộ Lọc";
            // 
            // lbngoiy
            // 
            lbngoiy.AutoSize = true;
            lbngoiy.ForeColor = Color.Red;
            lbngoiy.Location = new Point(6, 173);
            lbngoiy.Name = "lbngoiy";
            lbngoiy.Size = new Size(117, 20);
            lbngoiy.TabIndex = 4;
            lbngoiy.Text = "Nhập mã để tìm";
            // 
            // txbTimkiem
            // 
            txbTimkiem.Location = new Point(6, 34);
            txbTimkiem.Multiline = true;
            txbTimkiem.Name = "txbTimkiem";
            txbTimkiem.Size = new Size(339, 136);
            txbTimkiem.TabIndex = 3;
            // 
            // BtnTimkiem
            // 
            BtnTimkiem.Location = new Point(6, 223);
            BtnTimkiem.Name = "BtnTimkiem";
            BtnTimkiem.Size = new Size(92, 32);
            BtnTimkiem.TabIndex = 2;
            BtnTimkiem.Text = "Tìm";
            BtnTimkiem.UseVisualStyleBackColor = true;
            // 
            // QuanLyVoucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 714);
            Controls.Add(groupBox1);
            Controls.Add(grbDataVc);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            Controls.Add(lblQLVoucher);
            Name = "QuanLyVoucher";
            Text = "Quản Lý Voucher";
            Load += QuanLyVoucher_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            grbDataVc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataVC).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQLVoucher;
        private GroupBox grbThongTin;
        private Label lblMaVC;
        private GroupBox grbChucNang;
        private GroupBox grbDataVc;
        private Label lblDieuKien;
        private Label lblNAP;
        private DateTimePicker dtpkNKT;
        private DateTimePicker dtpkNgayapdung;
        private Label lblNgayketthuc;
        private TextBox tbcMota;
        private TextBox tbxDieuKien;
        private TextBox tbxMavc;
        private Label lblMota;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvDataVC;
        private GroupBox groupBox1;
        private TextBox txbTimkiem;
        private Button BtnTimkiem;
        private Label lbngoiy;
    }
}
