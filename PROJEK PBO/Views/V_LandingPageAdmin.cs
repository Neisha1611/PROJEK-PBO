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
    public partial class V_LandingPageAdmin : Form
    {
        private AuthController _authController;
        private int _userId;
        public V_LandingPageAdmin(int userId)
        {
            InitializeComponent();
            _authController = new AuthController();
            _userId = userId;
        }

        private void linkLabelProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showProfile(this, _userId);
        }

        private void linkLabelLahan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelAkunPenyewa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelListPesanan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthController authController = new AuthController();
            _authController.showListPesananAdmin(this, _userId);
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _authController.showLogin(this);
            }
        }
    }
}
