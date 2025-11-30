using System;
using System.Collections.Generic;
using PROJEK_PBO.Controllers;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_PBO.Views
{
    public partial class SewaLahan : Form
    {
        private AuthController _authController;
        private int _userId;
        private int _pesananId;
        public SewaLahan(int userId)
        {
            InitializeComponent();
            this._authController = new AuthController();
            this._userId = userId;
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                if (int.TryParse(panel.Name.Replace("panel", ""), out int lahanId))
                {
                    if (LahanSedangDisewa(lahanId))
                    {
                        panel.BackColor = Color.Red; 
                        panel.Enabled = false;         
                        panel.Cursor = Cursors.No;    
                    }
                    else
                    {
                        panel.BackColor = Color.LawnGreen;
                        panel.Enabled = true;
                        panel.Cursor = Cursors.Hand;
                        panel.Click += Panel_Click;
                    }
                }
            }
        }
        public void Panel_Click(object sender, EventArgs e)
        {

            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null && int.TryParse(clickedPanel.Name.Replace("panel", ""), out int lahanId))
            {
                if (_authController == null)
                {
                    MessageBox.Show("AuthController tidak diinisialisasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    _authController.showDetailSewa(this, lahanId, _userId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error membuka Detail Sewa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Panel tidak valid atau ID lahan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool LahanSedangDisewa(int idLahan)
        {
            try
            {
                return _authController.IsLahanDisewa(idLahan);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cek status lahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            _authController.showLandingPage(this, _userId);
        }

        private void panel_click(object sender, EventArgs e)
        {

        }
    }
}
