namespace PROJEK_PBO.Views
{
    partial class AkunPenyewa
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            linkLabelKembali = new LinkLabel();
            dbContextBindingSource = new BindingSource(components);
            dgvPenyewa = new DataGridView();
            id_penyewa = new DataGridViewTextBoxColumn();
            nama_penyewa = new DataGridViewTextBoxColumn();
            nomor_telepon = new DataGridViewTextBoxColumn();
            alamat_penyewa = new DataGridViewTextBoxColumn();
            email_penyewa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPenyewa).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_38;
            pictureBox1.Location = new Point(-1, -108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(838, 811);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // linkLabelKembali
            // 
            linkLabelKembali.AutoSize = true;
            linkLabelKembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelKembali.Image = Properties.Resources.Group_254;
            linkLabelKembali.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelKembali.LinkColor = Color.Black;
            linkLabelKembali.Location = new Point(111, 102);
            linkLabelKembali.Name = "linkLabelKembali";
            linkLabelKembali.Size = new Size(75, 20);
            linkLabelKembali.TabIndex = 1;
            linkLabelKembali.TabStop = true;
            linkLabelKembali.Text = "KEMBALI";
            linkLabelKembali.LinkClicked += linkLabelKembali_LinkClicked;
            // 
            // dbContextBindingSource
            // 
            dbContextBindingSource.DataSource = typeof(Database.DbContext);
            // 
            // dgvPenyewa
            // 
            dgvPenyewa.AllowUserToAddRows = false;
            dgvPenyewa.AutoGenerateColumns = false;
            dgvPenyewa.BackgroundColor = Color.FromArgb(193, 230, 151);
            dgvPenyewa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenyewa.Columns.AddRange(new DataGridViewColumn[] { id_penyewa, nama_penyewa, nomor_telepon, alamat_penyewa, email_penyewa });
            dgvPenyewa.DataSource = dbContextBindingSource;
            dgvPenyewa.Location = new Point(129, 147);
            dgvPenyewa.Name = "dgvPenyewa";
            dgvPenyewa.RowHeadersVisible = false;
            dgvPenyewa.RowHeadersWidth = 51;
            dgvPenyewa.Size = new Size(566, 243);
            dgvPenyewa.TabIndex = 2;
            // 
            // id_penyewa
            // 
            id_penyewa.DataPropertyName = "id";
            id_penyewa.HeaderText = "ID";
            id_penyewa.MinimumWidth = 6;
            id_penyewa.Name = "id_penyewa";
            id_penyewa.Width = 125;
            // 
            // nama_penyewa
            // 
            nama_penyewa.DataPropertyName = "nama";
            nama_penyewa.HeaderText = "Nama";
            nama_penyewa.MinimumWidth = 6;
            nama_penyewa.Name = "nama_penyewa";
            nama_penyewa.Width = 125;
            // 
            // nomor_telepon
            // 
            nomor_telepon.DataPropertyName = "nomor_telepon";
            nomor_telepon.HeaderText = "No.Telp";
            nomor_telepon.MinimumWidth = 6;
            nomor_telepon.Name = "nomor_telepon";
            nomor_telepon.Width = 125;
            // 
            // alamat_penyewa
            // 
            alamat_penyewa.DataPropertyName = "alamat";
            alamat_penyewa.HeaderText = "Alamat";
            alamat_penyewa.MinimumWidth = 6;
            alamat_penyewa.Name = "alamat_penyewa";
            alamat_penyewa.Width = 125;
            // 
            // email_penyewa
            // 
            email_penyewa.DataPropertyName = "email";
            email_penyewa.HeaderText = "Email";
            email_penyewa.MinimumWidth = 6;
            email_penyewa.Name = "email_penyewa";
            email_penyewa.Width = 125;
            // 
            // AkunPenyewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 595);
            Controls.Add(dgvPenyewa);
            Controls.Add(linkLabelKembali);
            Controls.Add(pictureBox1);
            Name = "AkunPenyewa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AkunPenyewa";
            Load += AkunPenyewa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPenyewa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabelKembali;
        private BindingSource dbContextBindingSource;
        private DataGridView dgvPenyewa;
        private DataGridViewTextBoxColumn id_penyewa;
        private DataGridViewTextBoxColumn nama_penyewa;
        private DataGridViewTextBoxColumn nomor_telepon;
        private DataGridViewTextBoxColumn alamat_penyewa;
        private DataGridViewTextBoxColumn email_penyewa;
    }
}