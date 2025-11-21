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
            linkLabelKembali = new LinkLabel();
            userBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            dataGridViewProfile = new DataGridView();
            dbContextBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // linkLabelKembali
            // 
            linkLabelKembali.AutoSize = true;
            linkLabelKembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelKembali.Image = Properties.Resources.Group_254;
            linkLabelKembali.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabelKembali.LinkColor = Color.Black;
            linkLabelKembali.Location = new Point(131, 93);
            linkLabelKembali.Name = "linkLabelKembali";
            linkLabelKembali.Size = new Size(75, 20);
            linkLabelKembali.TabIndex = 1;
            linkLabelKembali.TabStop = true;
            linkLabelKembali.Text = "KEMBALI";
            linkLabelKembali.LinkClicked += linkLabelKembali_LinkClicked;
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
            // dataGridViewProfile
            // 
            dataGridViewProfile.AutoGenerateColumns = false;
            dataGridViewProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfile.DataSource = dbContextBindingSource;
            dataGridViewProfile.Location = new Point(262, 141);
            dataGridViewProfile.Name = "dataGridViewProfile";
            dataGridViewProfile.RowHeadersWidth = 51;
            dataGridViewProfile.Size = new Size(370, 343);
            dataGridViewProfile.TabIndex = 2;
            // 
            // dbContextBindingSource
            // 
            dbContextBindingSource.DataSource = typeof(Database.DbContext);
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 624);
            Controls.Add(dataGridViewProfile);
            Controls.Add(linkLabelKembali);
            Controls.Add(pictureBox1);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabelKembali;
        private BindingSource userBindingSource;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewProfile;
        private BindingSource dbContextBindingSource;
    }
}