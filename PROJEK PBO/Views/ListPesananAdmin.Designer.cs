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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNama = new DataGridViewTextBoxColumn();
            colLahan = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colWaktu = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTanggal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colNama, colLahan, colTotal, colWaktu, colStatus, colTanggal });
            dataGridView1.Location = new Point(72, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(661, 297);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "id_pesanan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colId.DefaultCellStyle = dataGridViewCellStyle1;
            colId.Frozen = true;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 50;
            // 
            // colNama
            // 
            colNama.DataPropertyName = "nama_penyewa";
            colNama.Frozen = true;
            colNama.HeaderText = "Nama";
            colNama.MinimumWidth = 6;
            colNama.Name = "colNama";
            colNama.ReadOnly = true;
            colNama.Width = 130;
            // 
            // colLahan
            // 
            colLahan.DataPropertyName = "nama_lahan";
            colLahan.Frozen = true;
            colLahan.HeaderText = "Nama Lahan";
            colLahan.MinimumWidth = 6;
            colLahan.Name = "colLahan";
            colLahan.ReadOnly = true;
            colLahan.Width = 120;
            // 
            // colTotal
            // 
            colTotal.DataPropertyName = "total_harga";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "NO";
            dataGridViewCellStyle2.NullValue = null;
            colTotal.DefaultCellStyle = dataGridViewCellStyle2;
            colTotal.HeaderText = "Total Harga";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 120;
            // 
            // colWaktu
            // 
            colWaktu.DataPropertyName = "jangka_waktu_tahun";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colWaktu.DefaultCellStyle = dataGridViewCellStyle3;
            colWaktu.HeaderText = "Waktu Sewa (Tahun)";
            colWaktu.MinimumWidth = 6;
            colWaktu.Name = "colWaktu";
            colWaktu.ReadOnly = true;
            colWaktu.Width = 80;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "status";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStatus.DefaultCellStyle = dataGridViewCellStyle4;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 80;
            // 
            // colTanggal
            // 
            colTanggal.DataPropertyName = "tanggal_pesan";
            colTanggal.HeaderText = "Tanggal";
            colTanggal.MinimumWidth = 6;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            colTanggal.Width = 125;
            // 
            // ListPesananAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "ListPesananAdmin";
            Text = "ListPesananAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colLahan;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colWaktu;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTanggal;
    }
}