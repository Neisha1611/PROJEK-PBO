namespace PROJEK_PBO
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDaftarAkun = new Label();
            pictureBox1 = new PictureBox();
            linkLabelDaftarAkun = new LinkLabel();
            btnLogin = new Button();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDaftarAkun
            // 
            lblDaftarAkun.Location = new Point(0, 0);
            lblDaftarAkun.Name = "lblDaftarAkun";
            lblDaftarAkun.Size = new Size(100, 23);
            lblDaftarAkun.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Group_2;
            pictureBox1.Image = Properties.Resources.Login1;
            pictureBox1.Location = new Point(-23, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(824, 553);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // linkLabelDaftarAkun
            // 
            linkLabelDaftarAkun.AutoSize = true;
            linkLabelDaftarAkun.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelDaftarAkun.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelDaftarAkun.LinkColor = Color.FromArgb(0, 192, 0);
            linkLabelDaftarAkun.Location = new Point(430, 364);
            linkLabelDaftarAkun.Name = "linkLabelDaftarAkun";
            linkLabelDaftarAkun.Size = new Size(76, 17);
            linkLabelDaftarAkun.TabIndex = 19;
            linkLabelDaftarAkun.TabStop = true;
            linkLabelDaftarAkun.Text = "Daftar Akun";
            linkLabelDaftarAkun.LinkClicked += linkLabelDaftarAkun_LinkClicked_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = Properties.Resources.Group_2;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(326, 328);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 27);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(326, 295);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(180, 27);
            tbPassword.TabIndex = 16;
            // 
            // tbEmail
            // 
            tbEmail.ForeColor = Color.Black;
            tbEmail.Location = new Point(326, 241);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(180, 27);
            tbEmail.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(316, 364);
            label3.Name = "label3";
            label3.Size = new Size(119, 17);
            label3.TabIndex = 18;
            label3.Text = "Belum punya akun?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 551);
            Controls.Add(linkLabelDaftarAkun);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(pictureBox1);
            Controls.Add(lblDaftarAkun);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDaftarAkun;
        private PictureBox pictureBox1;
        private LinkLabel linkLabelDaftarAkun;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label label3;
    }
}
