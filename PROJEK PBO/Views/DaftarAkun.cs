using Npgsql;
using PROJEK_PBO.Controllers;
using PROJEK_PBO.Models;
using PROJEK_PBO.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROJEK_PBO.Views
{
    public partial class DaftarAkun : Form
    {
        private AuthController _authController;
        public DaftarAkun()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showLogin(this);
        }

        private void btnDaftar_Click_1(object sender, EventArgs e)
        {
            {
                User user = new User();
                user.Nama = tbNama.Text;
                user.Nomor_Telpon = tbNoTelepon.Text;
                user.Alamat = tbAlamat.Text;
                user.Email = tbEmail.Text;
                user.Password = tbPassword.Text;

                if (string.IsNullOrWhiteSpace(user.Nama) || string.IsNullOrWhiteSpace(user.Nomor_Telpon) || string.IsNullOrWhiteSpace(user.Alamat) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
                {
                    MessageBox.Show("Semua harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_authController.IsEmailOrPhoneExists(user.Email, user.Nomor_Telpon))
                {
                    MessageBox.Show("Email atau Nomor HP sudah terdaftar. Gunakan yang lain.");
                    return; 
                }

                if (!long.TryParse(user.Nomor_Telpon, out _))
                {
                    MessageBox.Show("Nomor telepon harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (user.Nomor_Telpon.Length > 13)
                {
                    MessageBox.Show("Nomor telepon maksimal 13 angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var valid = _authController.DaftarAkun(user);

                if (valid)
                {
                    MessageBox.Show("Daftar akun berhasil. Silahkan Login", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _authController.showLogin(this);
                }
                else
                {
                    MessageBox.Show("Daftar akun Gagal. Silahkan coba lagi!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DaftarAkun_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }
    }
}
