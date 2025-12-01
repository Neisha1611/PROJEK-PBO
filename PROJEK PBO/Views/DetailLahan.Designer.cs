namespace PROJEK_PBO.Views
{
    partial class DetailLahan
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
            btnKembali = new Button();
            btnEdit = new Button();
            tbLuasLahan = new TextBox();
            tbHargaPerTahun = new TextBox();
            labelNamaLahan = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Detail_Lahan;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnKembali
            // 
            btnKembali.Image = Properties.Resources.Group_235__2_;
            btnKembali.Location = new Point(87, 40);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(101, 34);
            btnKembali.TabIndex = 1;
            btnKembali.Text = "KEMBALI";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.Group_235__2_;
            btnEdit.Location = new Point(319, 257);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(156, 34);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
            // 
            // tbLuasLahan
            // 
            tbLuasLahan.Location = new Point(323, 177);
            tbLuasLahan.Name = "tbLuasLahan";
            tbLuasLahan.Size = new Size(202, 27);
            tbLuasLahan.TabIndex = 3;
            // 
            // tbHargaPerTahun
            // 
            tbHargaPerTahun.Location = new Point(409, 214);
            tbHargaPerTahun.Name = "tbHargaPerTahun";
            tbHargaPerTahun.Size = new Size(202, 27);
            tbHargaPerTahun.TabIndex = 4;
            // 
            // labelNamaLahan
            // 
            labelNamaLahan.AutoSize = true;
            labelNamaLahan.BackColor = Color.FromArgb(193, 230, 151);
            labelNamaLahan.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNamaLahan.Location = new Point(296, 116);
            labelNamaLahan.Name = "labelNamaLahan";
            labelNamaLahan.Size = new Size(199, 34);
            labelNamaLahan.TabIndex = 5;
            labelNamaLahan.Text = "Nama Lahan";
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.Group_235__2_;
            btnSave.Location = new Point(525, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "SIMPAN";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // DetailLahan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(labelNamaLahan);
            Controls.Add(tbHargaPerTahun);
            Controls.Add(tbLuasLahan);
            Controls.Add(btnEdit);
            Controls.Add(btnKembali);
            Controls.Add(pictureBox1);
            Name = "DetailLahan";
            Text = "DetailLahan";
            Load += LoadDetailLahan;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnKembali;
        private Button btnEdit;
        private TextBox tbLuasLahan;
        private TextBox tbHargaPerTahun;
        private Label labelNamaLahan;
        private Button btnSave;
    }
}