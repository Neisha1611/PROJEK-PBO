namespace PROJEK_PBO.Views
{
    partial class DetailRiwayatPembayaran
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
            tbNamaPenyewa = new TextBox();
            tbNamaLahan = new TextBox();
            tbWaktuSewa = new TextBox();
            tbHarga = new TextBox();
            tbTanggalPembayaran = new TextBox();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Detail_Riwayat_Pembayaran;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbNamaPenyewa
            // 
            tbNamaPenyewa.Location = new Point(214, 134);
            tbNamaPenyewa.Name = "tbNamaPenyewa";
            tbNamaPenyewa.Size = new Size(420, 27);
            tbNamaPenyewa.TabIndex = 1;
            // 
            // tbNamaLahan
            // 
            tbNamaLahan.Location = new Point(214, 186);
            tbNamaLahan.Name = "tbNamaLahan";
            tbNamaLahan.Size = new Size(420, 27);
            tbNamaLahan.TabIndex = 2;
            // 
            // tbWaktuSewa
            // 
            tbWaktuSewa.Location = new Point(214, 235);
            tbWaktuSewa.Name = "tbWaktuSewa";
            tbWaktuSewa.Size = new Size(420, 27);
            tbWaktuSewa.TabIndex = 3;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(214, 286);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(420, 27);
            tbHarga.TabIndex = 4;
            // 
            // tbTanggalPembayaran
            // 
            tbTanggalPembayaran.Location = new Point(214, 336);
            tbTanggalPembayaran.Name = "tbTanggalPembayaran";
            tbTanggalPembayaran.Size = new Size(420, 27);
            tbTanggalPembayaran.TabIndex = 5;
            // 
            // btnKembali
            // 
            btnKembali.Image = Properties.Resources.Group_235__2_;
            btnKembali.Location = new Point(99, 54);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 33);
            btnKembali.TabIndex = 6;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // DetailRiwayatPembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKembali);
            Controls.Add(tbTanggalPembayaran);
            Controls.Add(tbHarga);
            Controls.Add(tbWaktuSewa);
            Controls.Add(tbNamaLahan);
            Controls.Add(tbNamaPenyewa);
            Controls.Add(pictureBox1);
            Name = "DetailRiwayatPembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailRiwayatPembayaran";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbNamaPenyewa;
        private TextBox tbNamaLahan;
        private TextBox tbWaktuSewa;
        private TextBox tbHarga;
        private TextBox tbTanggalPembayaran;
        private Button btnKembali;
    }
}