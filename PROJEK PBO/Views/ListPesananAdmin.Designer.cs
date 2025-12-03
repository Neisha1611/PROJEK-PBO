namespace PROJEK_PBO.Views
{
    partial class ListPesananAdmin
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
            pictureBox2 = new PictureBox();
            dgvPesanan = new DataGridView();
            id_detail = new DataGridViewTextBoxColumn();
            nama_pemesan = new DataGridViewTextBoxColumn();
            id_pemesanan = new DataGridViewTextBoxColumn();
            id_lahan = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            jangka_waktu = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            btnrefresh = new Button();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_33;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Group_235__2_;
            button1.Location = new Point(101, 60);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 1;
            button1.Text = "KEMBALI";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Frame_33;
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(803, 451);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dgvPesanan
            // 
            dgvPesanan.AllowUserToAddRows = false;
            dgvPesanan.AllowUserToDeleteRows = false;
            dgvPesanan.BackgroundColor = Color.FromArgb(193, 230, 151);
            dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPesanan.Columns.AddRange(new DataGridViewColumn[] { id_detail, nama_pemesan, id_pemesanan, id_lahan, tanggal, jangka_waktu, harga, status });
            dgvPesanan.Location = new Point(72, 105);
            dgvPesanan.Name = "dgvPesanan";
            dgvPesanan.RowHeadersVisible = false;
            dgvPesanan.RowHeadersWidth = 51;
            dgvPesanan.Size = new Size(652, 280);
            dgvPesanan.TabIndex = 2;
            dgvPesanan.CellContentClick += dgvPesanan_CellContentClick;
            dgvPesanan.CellDoubleClick += dgvPesanan_CellDoubleClick;
            // 
            // id_detail
            // 
            id_detail.HeaderText = "id_detail";
            id_detail.MinimumWidth = 6;
            id_detail.Name = "id_detail";
            id_detail.ReadOnly = true;
            id_detail.Width = 125;
            // 
            // nama_pemesan
            // 
            nama_pemesan.HeaderText = "nama_penyewa";
            nama_pemesan.MinimumWidth = 6;
            nama_pemesan.Name = "nama_pemesan";
            nama_pemesan.Width = 125;
            // 
            // id_pemesanan
            // 
            id_pemesanan.HeaderText = "id_pemesanan";
            id_pemesanan.MinimumWidth = 6;
            id_pemesanan.Name = "id_pemesanan";
            id_pemesanan.ReadOnly = true;
            id_pemesanan.Width = 125;
            // 
            // id_lahan
            // 
            id_lahan.HeaderText = "id_lahan";
            id_lahan.MinimumWidth = 6;
            id_lahan.Name = "id_lahan";
            id_lahan.ReadOnly = true;
            id_lahan.Width = 125;
            // 
            // tanggal
            // 
            tanggal.HeaderText = "tanggal_pemesanan";
            tanggal.MinimumWidth = 6;
            tanggal.Name = "tanggal";
            tanggal.Width = 125;
            // 
            // jangka_waktu
            // 
            jangka_waktu.HeaderText = "jangka_waktu";
            jangka_waktu.MinimumWidth = 6;
            jangka_waktu.Name = "jangka_waktu";
            jangka_waktu.Width = 125;
            // 
            // harga
            // 
            harga.HeaderText = "harga_sewa";
            harga.MinimumWidth = 6;
            harga.Name = "harga";
            harga.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.FromArgb(193, 230, 151);
            btnrefresh.Location = new Point(595, 59);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(109, 29);
            btnrefresh.TabIndex = 3;
            btnrefresh.Text = "REFRESH";
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnKembali
            // 
            btnKembali.Image = Properties.Resources.Group_235__2_;
            btnKembali.Location = new Point(100, 55);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 33);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // ListPesananAdmin
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnrefresh);
            Controls.Add(dgvPesanan);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox2);
            Name = "ListPesananAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
        private DataGridView dgvPesanan;
        private Button btnrefresh;
        private DataGridViewTextBoxColumn id_detail;
        private DataGridViewTextBoxColumn nama_pemesan;
        private DataGridViewTextBoxColumn id_pemesanan;
        private DataGridViewTextBoxColumn id_lahan;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn jangka_waktu;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn status;
        private Button btnKembali;
    }
}