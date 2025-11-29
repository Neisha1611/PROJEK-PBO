namespace PROJEK_PBO.Views
{
    partial class DetailPesananAdmin
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
            button1 = new Button();
            txtNama = new TextBox();
            txtLahan = new TextBox();
            txtWaktu = new TextBox();
            txtHargaPerTahun = new TextBox();
            txtTotal = new TextBox();
            btnKonfirmasi = new Button();
            btnBatalPesanan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DetailPesananAdmin;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Group_235__2_;
            button1.Location = new Point(105, 58);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 1;
            button1.Text = "KEMBALI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(210, 135);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(426, 27);
            txtNama.TabIndex = 4;
            // 
            // txtLahan
            // 
            txtLahan.Location = new Point(210, 188);
            txtLahan.Name = "txtLahan";
            txtLahan.Size = new Size(426, 27);
            txtLahan.TabIndex = 5;
            // 
            // txtWaktu
            // 
            txtWaktu.Location = new Point(210, 235);
            txtWaktu.Name = "txtWaktu";
            txtWaktu.Size = new Size(426, 27);
            txtWaktu.TabIndex = 6;
            // 
            // txtHargaPerTahun
            // 
            txtHargaPerTahun.Location = new Point(210, 286);
            txtHargaPerTahun.Name = "txtHargaPerTahun";
            txtHargaPerTahun.Size = new Size(426, 27);
            txtHargaPerTahun.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(210, 337);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(426, 27);
            txtTotal.TabIndex = 8;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Image = Properties.Resources.Group_235__2_;
            btnKonfirmasi.Location = new Point(320, 370);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(216, 29);
            btnKonfirmasi.TabIndex = 9;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // btnBatalPesanan
            // 
            btnBatalPesanan.ForeColor = Color.White;
            btnBatalPesanan.Image = Properties.Resources.Group_2;
            btnBatalPesanan.Location = new Point(612, 370);
            btnBatalPesanan.Name = "btnBatalPesanan";
            btnBatalPesanan.Size = new Size(104, 29);
            btnBatalPesanan.TabIndex = 10;
            btnBatalPesanan.Text = "Batalkan";
            btnBatalPesanan.UseVisualStyleBackColor = true;
            btnBatalPesanan.Click += btnBatalPesanan_Click;
            // 
            // DetailPesananAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatalPesanan);
            Controls.Add(btnKonfirmasi);
            Controls.Add(txtTotal);
            Controls.Add(txtHargaPerTahun);
            Controls.Add(txtWaktu);
            Controls.Add(txtLahan);
            Controls.Add(txtNama);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "DetailPesananAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetailPesananAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtNama;
        private TextBox txtLahan;
        private TextBox txtWaktu;
        private TextBox txtHargaPerTahun;
        private TextBox txtTotal;
        private Button btnKonfirmasi;
        private Button btnBatalPesanan;
    }
}