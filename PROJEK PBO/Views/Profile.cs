using PROJEK_PBO.Controllers;
using PROJEK_PBO.Models;
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
    public partial class Profile : Form
    {
        private AuthController _authController;
        private int _userId;
        private User currentUser;
        public Profile(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            this._authController = new AuthController();

            LoadUserProfile();
        }

        private void SetTextBoxProperties()
        {
            try
            {
                txtnama.ReadOnly = true;
                txtalamat.ReadOnly = true;
                txtnotelp.ReadOnly = true;
                txtemail.ReadOnly = true;
                txtpassword.ReadOnly = true;
                txtpassword.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Warning: {ex.Message}");
            }
        }
        private void LoadUserProfile()
        {
            try
            {
                currentUser = _authController.GetUserById(_userId);

                if (currentUser != null)
                {
                    txtnama.Text = currentUser.Nama;
                    txtalamat.Text = currentUser.Alamat;
                    txtnotelp.Text = currentUser.Nomor_Telpon;
                    txtemail.Text = currentUser.Email;
                    txtpassword.Text = currentUser.Password;
                }
                else
                {
                    MessageBox.Show("Data user tidak ditemukan!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentUser != null && currentUser.IsAdmin)
            {
                _authController.showLandingPageAdmin(this, _userId);
            }
            else
            {
                _authController.showLandingPage(this, _userId);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            bool isReadOnly = txtnama.ReadOnly;

            if (isReadOnly)
            {
                txtnama.ReadOnly = false;
                txtalamat.ReadOnly = false;
                txtnotelp.ReadOnly = false;
                txtemail.ReadOnly = false;

                btnedit.Text = "SIMPAN";

                btnedit.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
                btnedit.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                if (SaveProfileChanges())
                {
                    txtnama.ReadOnly = true;
                    txtalamat.ReadOnly = true;
                    txtnotelp.ReadOnly = true;
                    txtemail.ReadOnly = true;

                    btnedit.BackColor = System.Drawing.SystemColors.Control;
                    btnedit.ForeColor = System.Drawing.Color.Black;

                    MessageBox.Show("Profile berhasil diperbarui!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool SaveProfileChanges()
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(txtnama.Text))
                {
                    MessageBox.Show("Nama tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnama.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtalamat.Text))
                {
                    MessageBox.Show("Alamat tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtalamat.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtnotelp.Text))
                {
                    MessageBox.Show("Nomor telepon tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnotelp.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtemail.Text))
                {
                    MessageBox.Show("Email tidak boleh kosong!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemail.Focus();
                    return false;
                }

                if (!txtemail.Text.Contains("@") || !txtemail.Text.Contains("."))
                {
                    MessageBox.Show("Format email tidak valid!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemail.Focus();
                    return false;
                }

                if (!IsNumeric(txtnotelp.Text))
                {
                    MessageBox.Show("Nomor telepon hanya boleh berisi angka!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnotelp.Focus();
                    return false;
                }

                bool success = _authController.UpdateProfile(
                    _userId,
                    txtnama.Text.Trim(),
                    txtalamat.Text.Trim(),
                    txtnotelp.Text.Trim(),
                    txtemail.Text.Trim()
                );

                if (success)
                {
                    currentUser.Nama = txtnama.Text.Trim();
                    currentUser.Alamat = txtalamat.Text.Trim();
                    currentUser.Nomor_Telpon = txtnotelp.Text.Trim();
                    currentUser.Email = txtemail.Text.Trim();

                    return true;
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan perubahan!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c) && c != '+' && c != '-' && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (btnedit.Text == "SIMPAN")
            {
                DialogResult result = MessageBox.Show(
                    "Ada perubahan yang belum disimpan. Keluar tanpa menyimpan?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    txtnama.ReadOnly = true;
                    txtalamat.ReadOnly = true;
                    txtnotelp.ReadOnly = true;
                    txtemail.ReadOnly = true;
                }
            }

            base.OnFormClosing(e);
        }
    }
}
