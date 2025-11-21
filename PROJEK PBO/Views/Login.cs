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

namespace PROJEK_PBO
{
    public partial class Login : Form
    {
        private AuthController _authController;

        public Login()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void linkLabelDaftarAkun_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showDaftarAkun(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                User user = new User();
                user.Email = tbEmail.Text;
                user.Password = tbPassword.Text;

                if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
                {
                    MessageBox.Show("Email dan Password harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var login = _authController.Login(user);

                string role = login.Role;
                int userId = login.UserId;

                if (role == "admin")
                {
                    MessageBox.Show($"Login admin berhasil! Selamat datang {user.Nama}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _authController.showLandingPageAdmin(this, userId);
                }
                else if (role == "user")
                {
                    MessageBox.Show($"Login user berhasil! Selamat datang {user.Nama}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _authController.showLandingPage(this, userId);
                }
                else
                {
                    MessageBox.Show("Email atau Password salah. Silahkan periksa kredensial akun anda!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
