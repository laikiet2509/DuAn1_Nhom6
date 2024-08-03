namespace PRL
{
    partial class mausac
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
            grb = new GroupBox();
            dtgView_ms = new DataGridView();
            groupBox1 = new GroupBox();
            btn_sua = new Button();
            btn_them = new Button();
            txt_mmau = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_tenmau = new TextBox();
            grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView_ms).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grb
            // 
            grb.Controls.Add(dtgView_ms);
            grb.Dock = DockStyle.Fill;
            grb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grb.Location = new Point(391, 0);
            grb.Name = "grb";
            grb.Size = new Size(409, 450);
            grb.TabIndex = 7;
            grb.TabStop = false;
            grb.Text = "Danh Sách Màu";
            // 
            // dtgView_ms
            // 
            dtgView_ms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgView_ms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView_ms.Dock = DockStyle.Fill;
            dtgView_ms.Location = new Point(3, 26);
            dtgView_ms.Name = "dtgView_ms";
            dtgView_ms.RowHeadersWidth = 51;
            dtgView_ms.RowTemplate.Height = 29;
            dtgView_ms.Size = new Size(403, 421);
            dtgView_ms.TabIndex = 0;
            dtgView_ms.CellClick += dtgView_ms_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(btn_them);
            groupBox1.Controls.Add(txt_mmau);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_tenmau);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 450);
            groupBox1.TabIndex = 6;
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
            // txt_mmau
            // 
            txt_mmau.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mmau.Location = new Point(137, 121);
            txt_mmau.Name = "txt_mmau";
            txt_mmau.Size = new Size(229, 27);
            txt_mmau.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(33, 201);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên Màu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(33, 123);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã Màu";
            // 
            // txt_tenmau
            // 
            txt_tenmau.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tenmau.Location = new Point(137, 199);
            txt_tenmau.Name = "txt_tenmau";
            txt_tenmau.Size = new Size(229, 27);
            txt_tenmau.TabIndex = 2;
            // 
            // mausac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grb);
            Controls.Add(groupBox1);
            Name = "mausac";
            Text = "mausac";
            grb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView_ms).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb;
        private DataGridView dtgView_ms;
        private GroupBox groupBox1;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_mmau;
        private Label label2;
        private Label label1;
        private TextBox txt_tenmau;
    }
}