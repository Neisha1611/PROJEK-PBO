namespace PROJEK_PBO.Views
{
    partial class DetailPesanan
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
            BtnKembali = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DetailPembayaran;
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnKembali
            // 
            BtnKembali.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKembali.Image = Properties.Resources.Group_235__2_;
            BtnKembali.Location = new Point(75, 62);
            BtnKembali.Name = "BtnKembali";
            BtnKembali.Size = new Size(117, 36);
            BtnKembali.TabIndex = 1;
            BtnKembali.Text = "KEMBALI";
            BtnKembali.UseVisualStyleBackColor = true;
            BtnKembali.Click += BtnKembali_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(389, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(389, 238);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 27);
            textBox3.TabIndex = 4;
            // 
            // DetailPesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BtnKembali);
            Controls.Add(pictureBox1);
            Name = "DetailPesanan";
            Text = "DetailPesanan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnKembali;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}