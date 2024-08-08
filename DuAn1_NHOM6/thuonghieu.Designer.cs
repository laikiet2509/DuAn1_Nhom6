namespace PRL
{
    partial class thuonghieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thuonghieu));
            dtgView_ms = new GroupBox();
            dtgView_TH = new DataGridView();
            groupBox1 = new GroupBox();
            btn_sua = new Button();
            btn_them = new Button();
            txt_mthuonghieu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_tenthuonghieu = new TextBox();
            dtgView_ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_TH).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgView_ms
            // 
            dtgView_ms.BackColor = Color.MistyRose;
            dtgView_ms.Controls.Add(dtgView_TH);
            dtgView_ms.Dock = DockStyle.Fill;
            dtgView_ms.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dtgView_ms.Location = new Point(408, 0);
            dtgView_ms.Name = "dtgView_ms";
            dtgView_ms.Size = new Size(392, 450);
            dtgView_ms.TabIndex = 9;
            dtgView_ms.TabStop = false;
            dtgView_ms.Text = "Danh Sách Thương Hiệu";
            // 
            // dtgView_TH
            // 
            dtgView_TH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView_TH.BackgroundColor = Color.Pink;
            dtgView_TH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_TH.Dock = DockStyle.Fill;
            dtgView_TH.Location = new Point(3, 26);
            dtgView_TH.Name = "dtgView_TH";
            dtgView_TH.RowHeadersWidth = 51;
            dtgView_TH.RowTemplate.Height = 29;
            dtgView_TH.Size = new Size(386, 421);
            dtgView_TH.TabIndex = 0;
            dtgView_TH.CellClick += dtgView_TH_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(txt_mthuonghieu);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_tenthuonghieu);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 450);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.Image = Properties.Resources.Edit;
            btn_sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sua.Location = new Point(227, 303);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(117, 41);
            btn_sua.TabIndex = 29;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.Image = Properties.Resources.Add;
            btn_them.ImageAlign = ContentAlignment.MiddleLeft;
            btn_them.Location = new Point(59, 303);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(117, 41);
            btn_them.TabIndex = 28;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // txt_mthuonghieu
            // 
            txt_mthuonghieu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mthuonghieu.Location = new Point(82, 114);
            txt_mthuonghieu.Name = "txt_mthuonghieu";
            txt_mthuonghieu.Size = new Size(229, 27);
            txt_mthuonghieu.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(82, 176);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên Thương Hiệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(82, 68);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã Thương Hiệu";
            // 
            // txt_tenthuonghieu
            // 
            txt_tenthuonghieu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tenthuonghieu.Location = new Point(82, 218);
            txt_tenthuonghieu.Name = "txt_tenthuonghieu";
            txt_tenthuonghieu.Size = new Size(229, 27);
            txt_tenthuonghieu.TabIndex = 2;
            // 
            // thuonghieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgView_ms);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "thuonghieu";
            Text = "thuonghieu";
            dtgView_ms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_TH).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox dtgView_ms;
        private DataGridView dtgView_TH;
        private GroupBox groupBox1;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_mthuonghieu;
        private Label label2;
        private Label label1;
        private TextBox txt_tenthuonghieu;
    }
}