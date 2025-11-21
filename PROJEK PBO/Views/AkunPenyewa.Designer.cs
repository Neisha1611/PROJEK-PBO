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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            linkLabelKembali.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelKembali.LinkColor = Color.Black;
            linkLabelKembali.Location = new Point(111, 102);
            linkLabelKembali.Name = "linkLabelKembali";
            linkLabelKembali.Size = new Size(75, 20);
            linkLabelKembali.TabIndex = 1;
            linkLabelKembali.TabStop = true;
            linkLabelKembali.Text = "KEMBALI";
            // 
            // dbContextBindingSource
            // 
            dbContextBindingSource.DataSource = typeof(Database.DbContext);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = dbContextBindingSource;
            dataGridView1.Location = new Point(268, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 2;
            // 
            // AkunPenyewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 595);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabelKembali);
            Controls.Add(pictureBox1);
            Name = "AkunPenyewa";
            Text = "AkunPenyewa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabelKembali;
        private BindingSource dbContextBindingSource;
        private DataGridView dataGridView1;
    }
}