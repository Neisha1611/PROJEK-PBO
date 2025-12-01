namespace PROJEK_PBO.Views
{
    partial class DetailPesanan
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
            BtnKembali = new Button();
            tbJangkaWaktu = new TextBox();
            tbHargaPerTahun = new TextBox();
            tbTotalHarga = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DetailPembayaran;
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnKembali
            // 
            BtnKembali.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKembali.Image = Properties.Resources.Group_235__2_;
            BtnKembali.Location = new Point(75, 62);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(117, 36);
            BtnKembali.TabIndex = 1;
            BtnKembali.Text = "KEMBALI";
            BtnKembali.UseVisualStyleBackColor = true;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // tbJangkaWaktu
            // 
            tbJangkaWaktu.Location = new Point(389, 132);
            tbJangkaWaktu.Name = "tbJangkaWaktu";
            tbJangkaWaktu.Size = new Size(245, 27);
            tbJangkaWaktu.TabIndex = 2;
            // 
            // tbHargaPerTahun
            // 
            tbHargaPerTahun.Location = new Point(389, 183);
            tbHargaPerTahun.Name = "tbHargaPerTahun";
            tbHargaPerTahun.Size = new Size(245, 27);
            tbHargaPerTahun.TabIndex = 3;
            // 
            // tbTotalHarga
            // 
            tbTotalHarga.Location = new Point(389, 238);
            tbTotalHarga.Name = "tbTotalHarga";
            tbTotalHarga.Size = new Size(245, 27);
            tbTotalHarga.TabIndex = 4;
            // 
            // DetailPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbTotalHarga);
            Controls.Add(tbHargaPerTahun);
            Controls.Add(tbJangkaWaktu);
            Controls.Add(BtnKembali);
            Controls.Add(pictureBox1);
            Name = "DetailPesanan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetailPesanan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnKembali;
        private TextBox tbJangkaWaktu;
        private TextBox tbHargaPerTahun;
        private TextBox tbTotalHarga;
    }
}