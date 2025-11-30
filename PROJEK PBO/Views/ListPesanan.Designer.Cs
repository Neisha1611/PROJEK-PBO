namespace PROJEK_PBO.Views
{
    partial class ListPesanan
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
            dataGridView1 = new DataGridView();
            idPesanan = new DataGridViewTextBoxColumn();
            lahan = new DataGridViewTextBoxColumn();
            waktu = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            tanggal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_33;
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(797, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Group_235__2_;
            button1.Location = new Point(101, 59);
            button1.Name = "button1";
            button1.Size = new Size(113, 29);
            button1.TabIndex = 1;
            button1.Text = "KEMBALI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(193, 230, 151);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idPesanan, lahan, waktu, total, status, tanggal });
            dataGridView1.Location = new Point(101, 109);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(591, 284);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // idPesanan
            // 
            idPesanan.HeaderText = "ID";
            idPesanan.MinimumWidth = 6;
            idPesanan.Name = "idPesanan";
            idPesanan.ReadOnly = true;
            idPesanan.Width = 125;
            // 
            // lahan
            // 
            lahan.HeaderText = "Nama Lahan";
            lahan.MinimumWidth = 6;
            lahan.Name = "lahan";
            lahan.ReadOnly = true;
            lahan.Width = 125;
            // 
            // waktu
            // 
            waktu.HeaderText = "Jangka Waktu";
            waktu.MinimumWidth = 6;
            waktu.Name = "waktu";
            waktu.ReadOnly = true;
            waktu.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "Harga Sewa";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 125;
            // 
            // tanggal
            // 
            tanggal.HeaderText = "Tanggal Pemesanan";
            tanggal.MinimumWidth = 6;
            tanggal.Name = "tanggal";
            tanggal.ReadOnly = true;
            tanggal.Width = 125;
            // 
            // ListPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "ListPesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListPesanan";
            Load += ListPesanan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idPesanan;
        private DataGridViewTextBoxColumn lahan;
        private DataGridViewTextBoxColumn waktu;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn tanggal;
    }
}