namespace PRL
{
    partial class hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadon));
            groupBox1 = new GroupBox();
            btn_inhoadon = new Button();
            btn_timkiem = new Button();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtgView_hoadon = new DataGridView();
            groupBox3 = new GroupBox();
            dtgView_chitiethoadon = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_hoadon).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_chitiethoadon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(btn_inhoadon);
            groupBox1.Controls.Add(btn_timkiem);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1346, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btn_inhoadon
            // 
            btn_inhoadon.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_inhoadon.Image = Properties.Resources._3;
            btn_inhoadon.Location = new Point(1065, 51);
            btn_inhoadon.Name = "btn_inhoadon";
            btn_inhoadon.Size = new Size(76, 61);
            btn_inhoadon.TabIndex = 5;
            btn_inhoadon.UseVisualStyleBackColor = true;
            btn_inhoadon.Click += btn_inhoadon_Click;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Image = Properties.Resources.Search1;
            btn_timkiem.Location = new Point(914, 51);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(76, 61);
            btn_timkiem.TabIndex = 4;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dateTimePicker2.ImeMode = ImeMode.NoControl;
            dateTimePicker2.Location = new Point(599, 71);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(298, 27);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.Value = new DateTime(2024, 7, 20, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(479, 71);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Đến Ngày :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(168, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(298, 27);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2024, 7, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(77, 71);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ Ngày :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonShadow;
            groupBox2.Controls.Add(dtgView_hoadon);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1346, 352);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Hóa Đơn";
            // 
            // dtgView_hoadon
            // 
            dtgView_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView_hoadon.BackgroundColor = SystemColors.Control;
            dtgView_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_hoadon.Dock = DockStyle.Fill;
            dtgView_hoadon.Location = new Point(3, 23);
            dtgView_hoadon.Name = "dtgView_hoadon";
            dtgView_hoadon.RowHeadersWidth = 51;
            dtgView_hoadon.RowTemplate.Height = 29;
            dtgView_hoadon.Size = new Size(1340, 326);
            dtgView_hoadon.TabIndex = 0;
            dtgView_hoadon.CellClick += dtgView_hoadon_CellClick;
            dtgView_hoadon.CellDoubleClick += dtgView_hoadon_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonShadow;
            groupBox3.Controls.Add(dtgView_chitiethoadon);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 497);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1346, 386);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chi Tiết Hóa Đơn";
            // 
            // dtgView_chitiethoadon
            // 
            dtgView_chitiethoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView_chitiethoadon.BackgroundColor = SystemColors.Control;
            dtgView_chitiethoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_chitiethoadon.Dock = DockStyle.Fill;
            dtgView_chitiethoadon.Location = new Point(3, 23);
            dtgView_chitiethoadon.Name = "dtgView_chitiethoadon";
            dtgView_chitiethoadon.RowHeadersWidth = 51;
            dtgView_chitiethoadon.RowTemplate.Height = 29;
            dtgView_chitiethoadon.Size = new Size(1340, 360);
            dtgView_chitiethoadon.TabIndex = 1;
            // 
            // hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 883);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "hoadon";
            Text = "hoadon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_hoadon).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_chitiethoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_inhoadon;
        private Button btn_timkiem;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dtgView_hoadon;
        private GroupBox groupBox3;
        private DataGridView dtgView_chitiethoadon;
    }
}