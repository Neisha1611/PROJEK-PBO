using PROJEK_PBO.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_PBO.Views
{
    public partial class AkunPenyewa : Form
    {
        private AuthController _authController;
        private int _userId;
        private DataTable dtUsers;
        public AkunPenyewa(int userId)
        {
            InitializeComponent();
            _authController = new AuthController();
            _userId = userId;

            LoadPenyewa();
        }

        private void LoadPenyewa()
        {
            try
            {
                dtUsers = _authController.GetAllPenyewa();

                dgvPenyewa.DataSource = dtUsers;

                if (dtUsers.Rows.Count == 0)
                {
                    MessageBox.Show("Belum ada akun penyewa.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AkunPenyewa_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            _authController.showLandingPageAdmin(this, _userId);
        }
    }
}
