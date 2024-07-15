namespace kietttt
{
    partial class SanPham
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
            panel_Left = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.BackColor = SystemColors.ActiveCaption;
            panel_Left.Controls.Add(pictureBox1);
            panel_Left.Controls.Add(panel1);
            panel_Left.Location = new Point(1, 1);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(241, 711);
            panel_Left.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.z5617964633251_d61a48bc7d803871b3e5c7fb4c38be69_removebg_preview;
            pictureBox1.Location = new Point(0, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 711);
            panel1.TabIndex = 1;
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 713);
            Controls.Add(panel_Left);
            Name = "SanPham";
            Text = " Phần Mềm Bán Giày Sneaker";
            panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Left;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
