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
            tbxTenvc = new TextBox();
            tbxDieuKien = new TextBox();
            tbxGiatri = new TextBox();
            tbxMavc = new TextBox();
            lblMota = new Label();
            lblTenvc = new Label();
            lblGiatri = new Label();
            lblDieuKien = new Label();
            lblNAP = new Label();
            lblMaVC = new Label();
            grbChucNang = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            grbDataVc = new GroupBox();
            dgvDataVC = new DataGridView();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            grbDataVc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataVC).BeginInit();
            SuspendLayout();
            // 
            // lblQLVoucher
            // 
            lblQLVoucher.AutoSize = true;
            lblQLVoucher.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblQLVoucher.Location = new Point(431, 9);
            lblQLVoucher.Name = "lblQLVoucher";
            lblQLVoucher.Size = new Size(401, 67);
            lblQLVoucher.TabIndex = 0;
            lblQLVoucher.Text = "Quản Lý Voucher";
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(dtpkNKT);
            grbThongTin.Controls.Add(dtpkNgayapdung);
            grbThongTin.Controls.Add(lblNgayketthuc);
            grbThongTin.Controls.Add(tbcMota);
            grbThongTin.Controls.Add(tbxTenvc);
            grbThongTin.Controls.Add(tbxDieuKien);
            grbThongTin.Controls.Add(tbxGiatri);
            grbThongTin.Controls.Add(tbxMavc);
            grbThongTin.Controls.Add(lblMota);
            grbThongTin.Controls.Add(lblTenvc);
            grbThongTin.Controls.Add(lblGiatri);
            grbThongTin.Controls.Add(lblDieuKien);
            grbThongTin.Controls.Add(lblNAP);
            grbThongTin.Controls.Add(lblMaVC);
            grbThongTin.Location = new Point(26, 94);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1103, 272);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông tin";
            // 
            // dtpkNKT
            // 
            dtpkNKT.Location = new Point(778, 209);
            dtpkNKT.Name = "dtpkNKT";
            dtpkNKT.Size = new Size(250, 27);
            dtpkNKT.TabIndex = 13;
            // 
            // dtpkNgayapdung
            // 
            dtpkNgayapdung.Location = new Point(152, 226);
            dtpkNgayapdung.Name = "dtpkNgayapdung";
            dtpkNgayapdung.Size = new Size(250, 27);
            dtpkNgayapdung.TabIndex = 12;
            // 
            // lblNgayketthuc
            // 
            lblNgayketthuc.AutoSize = true;
            lblNgayketthuc.Location = new Point(649, 216);
            lblNgayketthuc.Name = "lblNgayketthuc";
            lblNgayketthuc.Size = new Size(100, 20);
            lblNgayketthuc.TabIndex = 11;
            lblNgayketthuc.Text = "Ngày kết thúc";
            // 
            // tbcMota
            // 
            tbcMota.Location = new Point(778, 97);
            tbcMota.Multiline = true;
            tbcMota.Name = "tbcMota";
            tbcMota.Size = new Size(301, 54);
            tbcMota.TabIndex = 10;
            // 
            // tbxTenvc
            // 
            tbxTenvc.Location = new Point(778, 43);
            tbxTenvc.Name = "tbxTenvc";
            tbxTenvc.Size = new Size(301, 27);
            tbxTenvc.TabIndex = 9;
            // 
            // tbxDieuKien
            // 
            tbxDieuKien.Location = new Point(152, 163);
            tbxDieuKien.Name = "tbxDieuKien";
            tbxDieuKien.Size = new Size(277, 27);
            tbxDieuKien.TabIndex = 8;
            // 
            // tbxGiatri
            // 
            tbxGiatri.Location = new Point(152, 107);
            tbxGiatri.Name = "tbxGiatri";
            tbxGiatri.Size = new Size(277, 27);
            tbxGiatri.TabIndex = 7;
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
            lblMota.Location = new Point(649, 107);
            lblMota.Name = "lblMota";
            lblMota.Size = new Size(48, 20);
            lblMota.TabIndex = 5;
            lblMota.Text = "Mô tả";
            // 
            // lblTenvc
            // 
            lblTenvc.AutoSize = true;
            lblTenvc.Location = new Point(649, 50);
            lblTenvc.Name = "lblTenvc";
            lblTenvc.Size = new Size(88, 20);
            lblTenvc.TabIndex = 4;
            lblTenvc.Text = "Tên voucher";
            // 
            // lblGiatri
            // 
            lblGiatri.AutoSize = true;
            lblGiatri.Location = new Point(34, 110);
            lblGiatri.Name = "lblGiatri";
            lblGiatri.Size = new Size(51, 20);
            lblGiatri.TabIndex = 3;
            lblGiatri.Text = "Giá Trị";
            // 
            // lblDieuKien
            // 
            lblDieuKien.AutoSize = true;
            lblDieuKien.Location = new Point(34, 170);
            lblDieuKien.Name = "lblDieuKien";
            lblDieuKien.Size = new Size(73, 20);
            lblDieuKien.TabIndex = 2;
            lblDieuKien.Text = "Điều Kiện";
            // 
            // lblNAP
            // 
            lblNAP.AutoSize = true;
            lblNAP.Location = new Point(34, 231);
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
            grbChucNang.Location = new Point(1156, 94);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(183, 272);
            grbChucNang.TabIndex = 2;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(25, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 44);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(25, 107);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 44);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 44);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
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
            // QuanLyVoucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 714);
            Controls.Add(grbDataVc);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            Controls.Add(lblQLVoucher);
            Name = "QuanLyVoucher";
            Text = "Quản Lý Voucher";
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            grbDataVc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDataVC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQLVoucher;
        private GroupBox grbThongTin;
        private Label lblMaVC;
        private GroupBox grbChucNang;
        private GroupBox grbDataVc;
        private Label lblGiatri;
        private Label lblDieuKien;
        private Label lblNAP;
        private DateTimePicker dtpkNKT;
        private DateTimePicker dtpkNgayapdung;
        private Label lblNgayketthuc;
        private TextBox tbcMota;
        private TextBox tbxTenvc;
        private TextBox tbxDieuKien;
        private TextBox tbxGiatri;
        private TextBox tbxMavc;
        private Label lblMota;
        private Label lblTenvc;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dgvDataVC;
    }
}
