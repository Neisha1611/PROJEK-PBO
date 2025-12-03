namespace PROJEK_PBO.Views
{
    partial class Laporan
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
            dgvPendapatanAdmin = new DataGridView();
            tahun = new DataGridViewTextBoxColumn();
            total_pendapatan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPendapatanAdmin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Laporan_Penjualan;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Group_235__2_;
            button1.Location = new Point(91, 67);
            button1.Name = "button1";
            button1.Size = new Size(112, 33);
            button1.TabIndex = 1;
            button1.Text = "KEMBALI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvPendapatanAdmin
            // 
            dgvPendapatanAdmin.AllowUserToAddRows = false;
            dgvPendapatanAdmin.BackgroundColor = Color.FromArgb(193, 230, 151);
            dgvPendapatanAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendapatanAdmin.Columns.AddRange(new DataGridViewColumn[] { tahun, total_pendapatan });
            dgvPendapatanAdmin.Location = new Point(147, 120);
            dgvPendapatanAdmin.Name = "dgvPendapatanAdmin";
            dgvPendapatanAdmin.RowHeadersVisible = false;
            dgvPendapatanAdmin.RowHeadersWidth = 51;
            dgvPendapatanAdmin.Size = new Size(513, 265);
            dgvPendapatanAdmin.TabIndex = 2;
            // 
            // tahun
            // 
            tahun.DataPropertyName = "tahun";
            tahun.HeaderText = "Tahun";
            tahun.MinimumWidth = 6;
            tahun.Name = "tahun";
            tahun.Width = 125;
            // 
            // total_pendapatan
            // 
            total_pendapatan.DataPropertyName = "total_pendapatan";
            total_pendapatan.HeaderText = "Total Pendapatan";
            total_pendapatan.MinimumWidth = 6;
            total_pendapatan.Name = "total_pendapatan";
            total_pendapatan.Width = 125;
            // 
            // Laporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPendapatanAdmin);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Laporan";
            Text = "Laporan";
            Load += Laporan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPendapatanAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView dgvPendapatanAdmin;
        private DataGridViewTextBoxColumn tahun;
        private DataGridViewTextBoxColumn total_pendapatan;
    }
}