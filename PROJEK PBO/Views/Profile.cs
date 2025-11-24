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

            // Load data profile
            LoadUserProfile();
        }

        private void SetTextBoxProperties()
        {
            try
            {
                // Set ReadOnly untuk semua TextBox (sudah ada di Designer)
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
                // Get user data dari controller
                currentUser = _authController.GetUserById(_userId);

                if (currentUser != null)
                {
                    // Tampilkan data ke TextBox
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

                btnedit.BackColor = System.Drawing.Color.FromArgb(76, 175, 80); // Hijau
                btnedit.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                // Mode Save - Simpan perubahan
                if (SaveProfileChanges())
                {
                    // Kembali ke mode ReadOnly
                    txtnama.ReadOnly = true;
                    txtalamat.ReadOnly = true;
                    txtnotelp.ReadOnly = true;
                    txtemail.ReadOnly = true;

                    // Ganti text button
                    btnedit.Text = "EDIT";

                    // Kembalikan warna button
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

                // Validasi format email sederhana
                if (!txtemail.Text.Contains("@") || !txtemail.Text.Contains("."))
                {
                    MessageBox.Show("Format email tidak valid!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemail.Focus();
                    return false;
                }

                // Validasi nomor telepon (hanya angka)
                if (!IsNumeric(txtnotelp.Text))
                {
                    MessageBox.Show("Nomor telepon hanya boleh berisi angka!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnotelp.Focus();
                    return false;
                }

                // Update ke database menggunakan controller
                bool success = _authController.UpdateProfile(
                    _userId,
                    txtnama.Text.Trim(),
                    txtalamat.Text.Trim(),
                    txtnotelp.Text.Trim(),
                    txtemail.Text.Trim()
                );

                if (success)
                {
                    // Update object currentUser
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
            // Jika sedang mode edit (button text = SIMPAN), tanyakan konfirmasi
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
                    e.Cancel = true; // Batalkan close
                    return;
                }
                else
                {
                    // Jika user pilih Yes, kembalikan ReadOnly sebelum close
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
