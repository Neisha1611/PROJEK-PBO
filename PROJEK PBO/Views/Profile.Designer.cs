namespace PROJEK_PBO.Views
{
    partial class Profile
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
            btnKembali = new LinkLabel();
            userBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            dbContextBindingSource = new BindingSource(components);
            txtnama = new TextBox();
            txtalamat = new TextBox();
            txtnotelp = new TextBox();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            btnedit = new Button();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.AutoSize = true;
            btnKembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.Image = Properties.Resources.Group_254;
            btnKembali.LinkBehavior = LinkBehavior.NeverUnderline;
            btnKembali.LinkColor = Color.Black;
            btnKembali.Location = new Point(131, 93);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(75, 20);
            btnKembali.TabIndex = 1;
            btnKembali.TabStop = true;
            btnKembali.Text = "KEMBALI";
            btnKembali.LinkClicked += linkLabelKembali_LinkClicked;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_9;
            pictureBox1.Location = new Point(-142, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1169, 628);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dbContextBindingSource
            // 
            dbContextBindingSource.DataSource = typeof(Database.DbContext);
            // 
            // txtnama
            // 
            txtnama.Location = new Point(282, 183);
            txtnama.Name = "txtnama";
            txtnama.ReadOnly = true;
            txtnama.Size = new Size(319, 27);
            txtnama.TabIndex = 2;
            // 
            // txtalamat
            // 
            txtalamat.Location = new Point(282, 247);
            txtalamat.Name = "txtalamat";
            txtalamat.ReadOnly = true;
            txtalamat.Size = new Size(319, 27);
            txtalamat.TabIndex = 3;
            // 
            // txtnotelp
            // 
            txtnotelp.Location = new Point(282, 309);
            txtnotelp.Name = "txtnotelp";
            txtnotelp.ReadOnly = true;
            txtnotelp.Size = new Size(319, 27);
            txtnotelp.TabIndex = 4;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(282, 375);
            txtemail.Name = "txtemail";
            txtemail.ReadOnly = true;
            txtemail.Size = new Size(319, 27);
            txtemail.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(282, 438);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.ReadOnly = true;
            txtpassword.Size = new Size(319, 27);
            txtpassword.TabIndex = 6;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.White;
            btnedit.Image = Properties.Resources.Group_235__2_;
            btnedit.Location = new Point(638, 498);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(112, 29);
            btnedit.TabIndex = 7;
            btnedit.Text = "EDIT";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 624);
            Controls.Add(btnedit);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(txtnotelp);
            Controls.Add(txtalamat);
            Controls.Add(txtnama);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox1);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel btnKembali;
        private BindingSource userBindingSource;
        private PictureBox pictureBox1;
        private BindingSource dbContextBindingSource;
        private TextBox txtnama;
        private TextBox txtalamat;
        private TextBox txtnotelp;
        private TextBox txtemail;
        private TextBox txtpassword;
        private Button btnedit;
    }
}