namespace PROJEK_PBO.Views
{
    partial class DaftarAkun
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
            tbPassword = new TextBox();
            label2 = new Label();
            label6 = new Label();
            btnDaftar = new Button();
            tbNama = new TextBox();
            tbNoTelepon = new TextBox();
            tbAlamat = new TextBox();
            tbEmail = new TextBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Register1;
            pictureBox1.Location = new Point(-207, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(308, 327);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(171, 20);
            tbPassword.TabIndex = 23;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 96);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 310);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 17;
            // 
            // btnDaftar
            // 
            btnDaftar.BackgroundImage = Properties.Resources.Group_2;
            btnDaftar.Location = new Point(308, 360);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(171, 29);
            btnDaftar.TabIndex = 18;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            btnDaftar.Click += btnDaftar_Click_1;
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(308, 181);
            tbNama.Multiline = true;
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(171, 20);
            tbNama.TabIndex = 19;
            // 
            // tbNoTelepon
            // 
            tbNoTelepon.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNoTelepon.Location = new Point(308, 221);
            tbNoTelepon.Multiline = true;
            tbNoTelepon.Name = "tbNoTelepon";
            tbNoTelepon.Size = new Size(171, 20);
            tbNoTelepon.TabIndex = 20;
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAlamat.Location = new Point(308, 257);
            tbAlamat.Multiline = true;
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(171, 20);
            tbAlamat.TabIndex = 21;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(308, 294);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(171, 20);
            tbEmail.TabIndex = 22;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(0, 192, 0);
            linkLabel1.Location = new Point(421, 392);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 17);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DaftarAkun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 560);
            Controls.Add(linkLabel1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbAlamat);
            Controls.Add(tbNoTelepon);
            Controls.Add(tbNama);
            Controls.Add(btnDaftar);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "DaftarAkun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DaftarAkun";
            Load += DaftarAkun_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbPassword;
        private Label label2;
        private Label label6;
        private Button btnDaftar;
        private TextBox tbNama;
        private TextBox tbNoTelepon;
        private TextBox tbAlamat;
        private TextBox tbEmail;
        private LinkLabel linkLabel1;
    }
}