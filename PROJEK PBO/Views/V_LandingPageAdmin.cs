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
            _authController.showLahan(this, _userId);
        }

        private void linkLabelAkunPenyewa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showAkunPenyewa(this, _userId);
        }

        private void linkLabelListPesanan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showListPesananAdmin(this, _userId);
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
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void linkLabelLaporan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showLaporan(this, _userId);
        }

        private void V_LandingPageAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                int updated = _authController.CekDanUpdateSewaKadaluarsa();

                if (updated > 0)
                {
                    MessageBox.Show($"{updated} sewa telah berakhir dan statusnya diupdate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine($"{updated} sewa telah berakhir dan statusnya diupdate");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error update status sewa: {ex.Message}");
            }
        }
    }
}
