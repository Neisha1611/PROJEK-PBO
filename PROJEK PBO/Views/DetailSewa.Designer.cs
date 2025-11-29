namespace PROJEK_PBO.Views
{
    partial class DetailSewa
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
            pictureBox1 = new PictureBox();
            btnKembali = new Button();
            btnPesan = new Button();
            tbLuasLahan = new TextBox();
            tbHargaPerTahun = new TextBox();
            tbJangkaWaktu = new TextBox();
            labelNamaLahan = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Detail_Lahan_Penyewa;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.Image = Properties.Resources.Group_235__2_;
            btnKembali.Location = new Point(80, 46);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(118, 31);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnPesan
            // 
            btnPesan.Image = Properties.Resources.Group_235__2_;
            btnPesan.Location = new Point(330, 302);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(141, 32);
            btnPesan.TabIndex = 2;
            btnPesan.Text = "PESAN";
            btnPesan.UseVisualStyleBackColor = true;
            btnPesan.Click += btnPesan_Click;
            // 
            // tbLuasLahan
            // 
            tbLuasLahan.Location = new Point(325, 180);
            tbLuasLahan.Name = "tbLuasLahan";
            tbLuasLahan.Size = new Size(159, 27);
            tbLuasLahan.TabIndex = 3;
            // 
            // tbHargaPerTahun
            // 
            tbHargaPerTahun.Location = new Point(408, 216);
            tbHargaPerTahun.Name = "tbHargaPerTahun";
            tbHargaPerTahun.Size = new Size(159, 27);
            tbHargaPerTahun.TabIndex = 4;
            // 
            // tbJangkaWaktu
            // 
            tbJangkaWaktu.Location = new Point(362, 254);
            tbJangkaWaktu.Name = "tbJangkaWaktu";
            tbJangkaWaktu.Size = new Size(159, 27);
            tbJangkaWaktu.TabIndex = 5;
            // 
            // labelNamaLahan
            // 
            labelNamaLahan.AutoSize = true;
            labelNamaLahan.BackColor = Color.FromArgb(193, 230, 151);
            labelNamaLahan.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNamaLahan.Location = new Point(289, 120);
            labelNamaLahan.Name = "labelNamaLahan";
            labelNamaLahan.Size = new Size(199, 34);
            labelNamaLahan.TabIndex = 6;
            labelNamaLahan.Text = "Nama Lahan";
            // 
            // DetailSewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNamaLahan);
            Controls.Add(tbJangkaWaktu);
            Controls.Add(tbHargaPerTahun);
            Controls.Add(tbLuasLahan);
            Controls.Add(btnPesan);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox1);
            Name = "DetailSewa";
            Text = "DetailSewa";
            Load += DetailSewa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnKembali;
        private Button btnPesan;
        private TextBox tbLuasLahan;
        private TextBox tbHargaPerTahun;
        private TextBox tbJangkaWaktu;
        private Label labelNamaLahan;
    }
}