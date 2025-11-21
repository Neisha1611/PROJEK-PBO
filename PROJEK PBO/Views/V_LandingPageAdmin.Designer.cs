namespace PROJEK_PBO.Views
{
    partial class V_LandingPageAdmin
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
            linkLabelProfile = new LinkLabel();
            linkLabelLogout = new LinkLabel();
            linkLabelAkunPenyewa = new LinkLabel();
            linkLabelLahan = new LinkLabel();
            linkLabelListPesanan = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_43;
            pictureBox1.Location = new Point(-102, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(903, 497);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // linkLabelProfile
            // 
            linkLabelProfile.AutoSize = true;
            linkLabelProfile.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelProfile.Image = Properties.Resources.Group_235__2_;
            linkLabelProfile.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelProfile.LinkColor = Color.Black;
            linkLabelProfile.Location = new Point(559, 123);
            linkLabelProfile.Name = "linkLabelProfile";
            linkLabelProfile.Size = new Size(112, 27);
            linkLabelProfile.TabIndex = 8;
            linkLabelProfile.TabStop = true;
            linkLabelProfile.Text = "PROFILE";
            linkLabelProfile.LinkClicked += linkLabelProfile_LinkClicked;
            // 
            // linkLabelLogout
            // 
            linkLabelLogout.AutoSize = true;
            linkLabelLogout.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelLogout.Image = Properties.Resources.Group_235__2_;
            linkLabelLogout.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelLogout.LinkColor = Color.Black;
            linkLabelLogout.Location = new Point(559, 317);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(117, 27);
            linkLabelLogout.TabIndex = 9;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "LOG OUT";
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // linkLabelAkunPenyewa
            // 
            linkLabelAkunPenyewa.AutoSize = true;
            linkLabelAkunPenyewa.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelAkunPenyewa.Image = Properties.Resources.Group_235__2_;
            linkLabelAkunPenyewa.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelAkunPenyewa.LinkColor = Color.Black;
            linkLabelAkunPenyewa.Location = new Point(543, 224);
            linkLabelAkunPenyewa.Name = "linkLabelAkunPenyewa";
            linkLabelAkunPenyewa.Size = new Size(149, 20);
            linkLabelAkunPenyewa.TabIndex = 10;
            linkLabelAkunPenyewa.TabStop = true;
            linkLabelAkunPenyewa.Text = "AKUN PENYEWA";
            linkLabelAkunPenyewa.LinkClicked += linkLabelAkunPenyewa_LinkClicked;
            // 
            // linkLabelLahan
            // 
            linkLabelLahan.AutoSize = true;
            linkLabelLahan.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelLahan.Image = Properties.Resources.Group_235__2_;
            linkLabelLahan.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelLahan.LinkColor = Color.Black;
            linkLabelLahan.Location = new Point(577, 172);
            linkLabelLahan.Name = "linkLabelLahan";
            linkLabelLahan.Size = new Size(94, 27);
            linkLabelLahan.TabIndex = 11;
            linkLabelLahan.TabStop = true;
            linkLabelLahan.Text = "LAHAN";
            linkLabelLahan.LinkClicked += linkLabelLahan_LinkClicked;
            // 
            // linkLabelListPesanan
            // 
            linkLabelListPesanan.AutoSize = true;
            linkLabelListPesanan.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelListPesanan.Image = Properties.Resources.Group_235__2_;
            linkLabelListPesanan.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelListPesanan.LinkColor = Color.Black;
            linkLabelListPesanan.Location = new Point(543, 272);
            linkLabelListPesanan.Name = "linkLabelListPesanan";
            linkLabelListPesanan.Size = new Size(145, 21);
            linkLabelListPesanan.TabIndex = 12;
            linkLabelListPesanan.TabStop = true;
            linkLabelListPesanan.Text = "LIST PESANAN";
            linkLabelListPesanan.LinkClicked += linkLabelListPesanan_LinkClicked;
            // 
            // V_LandingPageAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 496);
            Controls.Add(linkLabelListPesanan);
            Controls.Add(linkLabelLahan);
            Controls.Add(linkLabelAkunPenyewa);
            Controls.Add(linkLabelLogout);
            Controls.Add(linkLabelProfile);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_LandingPageAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_LandingPageAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblProfile;
        private Label lblLahan;
        private Label lblAkunPenyewa;
        private Label lblListPesanan;
        private Label lblLogout;
        private LinkLabel linkLabelProfile;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabelLogout;
        private LinkLabel linkLabelAkunPenyewa;
        private LinkLabel linkLabelLahan;
        private LinkLabel linkLabelListPesanan;
    }
}