namespace PRL
{
    partial class kichco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kichco));
            dtgView_ms = new GroupBox();
            dtgView_kco = new DataGridView();
            groupBox1 = new GroupBox();
            btn_sua = new Button();
            btn_them = new Button();
            txt_makco = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_kco = new TextBox();
            dtgView_ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_kco).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgView_ms
            // 
            dtgView_ms.BackColor = Color.MistyRose;
            dtgView_ms.Controls.Add(dtgView_kco);
            dtgView_ms.Dock = DockStyle.Fill;
            dtgView_ms.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dtgView_ms.Location = new Point(391, 0);
            dtgView_ms.Name = "dtgView_ms";
            dtgView_ms.Size = new Size(409, 450);
            dtgView_ms.TabIndex = 9;
            dtgView_ms.TabStop = false;
            dtgView_ms.Text = "Danh Sách Kích Cỡ";
            // 
            // dtgView_kco
            // 
            dtgView_kco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView_kco.BackgroundColor = Color.Pink;
            dtgView_kco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_kco.Dock = DockStyle.Fill;
            dtgView_kco.Location = new Point(3, 26);
            dtgView_kco.Name = "dtgView_kco";
            dtgView_kco.RowHeadersWidth = 51;
            dtgView_kco.RowTemplate.Height = 29;
            dtgView_kco.Size = new Size(403, 421);
            dtgView_kco.TabIndex = 0;
            dtgView_kco.CellClick += dtgView_kco_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(txt_makco);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_kco);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 450);
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
            // txt_makco
            // 
            txt_makco.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_makco.Location = new Point(137, 121);
            txt_makco.Name = "txt_makco";
            txt_makco.Size = new Size(229, 27);
            txt_makco.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(33, 201);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 3;
            label2.Text = "Kích Cỡ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(16, 123);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã Kích Cỡ";
            // 
            // txt_kco
            // 
            txt_kco.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_kco.Location = new Point(137, 199);
            txt_kco.Name = "txt_kco";
            txt_kco.Size = new Size(229, 27);
            txt_kco.TabIndex = 2;
            // 
            // kichco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgView_ms);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "kichco";
            Text = "kickco";
            dtgView_ms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_kco).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox dtgView_ms;
        private DataGridView dtgView_kco;
        private GroupBox groupBox1;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_makco;
        private Label label2;
        private Label label1;
        private TextBox txt_kco;
    }
}