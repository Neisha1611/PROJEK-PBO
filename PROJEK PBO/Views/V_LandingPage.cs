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
    public partial class V_LandingPage : Form
    {
        private AuthController _authController;
        private int _userId;
        public V_LandingPage(int userId)
        {
            InitializeComponent();
            _authController = new AuthController();
            _userId = userId;
        }

        private void V_LandingPage_Load(object sender, EventArgs e)
        {
            try
            {
                _authController.CekDanUpdateSewaKadaluarsa();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error update status sewa: {ex.Message}");
            }
        }

        private void linkLabelProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showProfile(this, _userId);
        }

        private void linkLabelSewaLahan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showSewaLahan(this, _userId);
        }

        private void linkLabelPembayaran_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showListPesanan(this, _userId);
        }

        private void linkLabelRiwayatPembayaran_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showRiwayatPembayaran(this, _userId);
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form != this)
                    {
                        form.Close();
                    }
                }
                _authController.showLogin(this);
            }
        }

        private void linkLabelCari_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showSewaLahan(this, _userId);
        }

        private void linklabelLaporan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showLaporan(this, _userId);
        }
    }
}
