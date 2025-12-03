namespace PROJEK_PBO.Views
{
    partial class RiwayatPembayaran
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
            dgvRiwayatPembayaran = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nama_penyewa = new DataGridViewTextBoxColumn();
            lahan = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            waktu = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPembayaran).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Riwayat_Pembayaran;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.Image = Properties.Resources.Group_235__2_;
            btnKembali.Location = new Point(90, 74);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(104, 30);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // dgvRiwayatPembayaran
            // 
            dgvRiwayatPembayaran.AllowUserToAddRows = false;
            dgvRiwayatPembayaran.BackgroundColor = Color.FromArgb(193, 230, 151);
            dgvRiwayatPembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatPembayaran.Columns.AddRange(new DataGridViewColumn[] { id, nama_penyewa, lahan, total, waktu, tanggal });
            dgvRiwayatPembayaran.Location = new Point(90, 122);
            dgvRiwayatPembayaran.Name = "dgvRiwayatPembayaran";
            dgvRiwayatPembayaran.RowHeadersVisible = false;
            dgvRiwayatPembayaran.RowHeadersWidth = 51;
            dgvRiwayatPembayaran.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRiwayatPembayaran.Size = new Size(615, 275);
            dgvRiwayatPembayaran.TabIndex = 2;
            dgvRiwayatPembayaran.CellDoubleClick += dgvRiwayatPembayaran_CellDoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "id_detail";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // nama_penyewa
            // 
            nama_penyewa.DataPropertyName = "nama_penyewa";
            nama_penyewa.HeaderText = "Nama";
            nama_penyewa.MinimumWidth = 6;
            nama_penyewa.Name = "nama_penyewa";
            nama_penyewa.Width = 125;
            // 
            // lahan
            // 
            lahan.DataPropertyName = "lahan";
            lahan.HeaderText = "Lahan";
            lahan.MinimumWidth = 6;
            lahan.Name = "lahan";
            lahan.Width = 125;
            // 
            // total
            // 
            total.DataPropertyName = "total";
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // waktu
            // 
            waktu.DataPropertyName = "waktu";
            waktu.HeaderText = "Waktu";
            waktu.MinimumWidth = 6;
            waktu.Name = "waktu";
            waktu.Width = 125;
            // 
            // tanggal
            // 
            tanggal.DataPropertyName = "tanggal";
            tanggal.HeaderText = "Tanggal";
            tanggal.MinimumWidth = 6;
            tanggal.Name = "tanggal";
            tanggal.Width = 125;
            // 
            // RiwayatPembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvRiwayatPembayaran);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox1);
            Name = "RiwayatPembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RiwayatPembayaran";
            Load += RiwayatPembayaran_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPembayaran).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnKembali;
        private DataGridView dgvRiwayatPembayaran;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nama_penyewa;
        private DataGridViewTextBoxColumn lahan;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn waktu;
        private DataGridViewTextBoxColumn tanggal;
    }
}