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
            panel1 = new Panel();
            rdb_GTNu = new RadioButton();
            rdb_GTNam = new RadioButton();
            txt_NgaySinh = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_TenNV = new TextBox();
            txt_MaNV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgv_ThongTin = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ThongTin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(rdb_GTNu);
            panel1.Controls.Add(rdb_GTNam);
            panel1.Controls.Add(txt_NgaySinh);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_TenNV);
            panel1.Controls.Add(txt_MaNV);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 246);
            panel1.TabIndex = 3;
            // 
            // rdb_GTNu
            // 
            rdb_GTNu.AutoSize = true;
            rdb_GTNu.Location = new Point(257, 162);
            rdb_GTNu.Name = "rdb_GTNu";
            rdb_GTNu.Size = new Size(50, 24);
            rdb_GTNu.TabIndex = 17;
            rdb_GTNu.TabStop = true;
            rdb_GTNu.Text = "Nữ";
            rdb_GTNu.UseVisualStyleBackColor = true;
            // 
            // rdb_GTNam
            // 
            rdb_GTNam.AutoSize = true;
            rdb_GTNam.Location = new Point(149, 162);
            rdb_GTNam.Name = "rdb_GTNam";
            rdb_GTNam.Size = new Size(62, 24);
            rdb_GTNam.TabIndex = 16;
            rdb_GTNam.TabStop = true;
            rdb_GTNam.Text = "Nam";
            rdb_GTNam.UseVisualStyleBackColor = true;
            // 
            // txt_NgaySinh
            // 
            txt_NgaySinh.Location = new Point(597, 29);
            txt_NgaySinh.Multiline = true;
            txt_NgaySinh.Name = "txt_NgaySinh";
            txt_NgaySinh.Size = new Size(199, 34);
            txt_NgaySinh.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 164);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 9;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 103);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 8;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 36);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày sinh";
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(149, 96);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(158, 27);
            txt_TenNV.TabIndex = 4;
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(149, 32);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(158, 27);
            txt_MaNV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 164);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 99);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên NV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_ThongTin);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1111, 344);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // dgv_ThongTin
            // 
            dgv_ThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ThongTin.Dock = DockStyle.Fill;
            dgv_ThongTin.Location = new Point(3, 23);
            dgv_ThongTin.Name = "dgv_ThongTin";
            dgv_ThongTin.RowHeadersWidth = 51;
            dgv_ThongTin.RowTemplate.Height = 29;
            dgv_ThongTin.Size = new Size(1105, 318);
            dgv_ThongTin.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(597, 92);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 34);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(597, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(921, 32);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(921, 97);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 21;
            button2.Text = "Xoá";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(921, 164);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 22;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 605);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ThongTin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton rdb_GTNu;
        private RadioButton rdb_GTNam;
        private TextBox txt_NgaySinh;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_TenNV;
        private TextBox txt_MaNV;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgv_ThongTin;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
