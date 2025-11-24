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
            button2 = new Button();
            cmbStatus = new ComboBox();
            txtNama = new TextBox();
            txtLahan = new TextBox();
            txtWaktu = new TextBox();
            txtHargaPerTahun = new TextBox();
            txtTotal = new TextBox();
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
            // button2
            // 
            button2.Image = Properties.Resources.Group_256;
            button2.Location = new Point(606, 370);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 2;
            button2.Text = "BATALKAN";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Terkonfirmasi" });
            cmbStatus.Location = new Point(381, 370);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 28);
            cmbStatus.TabIndex = 3;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged_1;
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
            // DetailPesananAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(txtHargaPerTahun);
            Controls.Add(txtWaktu);
            Controls.Add(txtLahan);
            Controls.Add(txtNama);
            Controls.Add(cmbStatus);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "DetailPesananAdmin";
            Text = "DetailPesananAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private ComboBox cmbStatus;
        private TextBox txtNama;
        private TextBox txtLahan;
        private TextBox txtWaktu;
        private TextBox txtHargaPerTahun;
        private TextBox txtTotal;
    }
}