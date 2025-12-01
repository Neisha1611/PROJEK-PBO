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
    public partial class DetailLahan : Form
    {
        private AuthController _authcontroller;
        private int _userId;
        private int _lahanId;
        private bool isEditing = false;
        public DetailLahan(int lahanId, int userId)
        {
            InitializeComponent();
            this._authcontroller = new AuthController();
            this._lahanId = lahanId;
            this._userId = userId;
        }

        private void DetailLahan_Load(object sender, EventArgs e)
        {
            LoadDetailLahan(sender, e);
            tbLuasLahan.ReadOnly = true;
            tbHargaPerTahun.ReadOnly = true;
            btnSave.Enabled = false;
        }
        private void LoadDetailLahan(object sender, EventArgs e)
        {
            PROJEK_PBO.Models.Lahan lahan = _authcontroller.GetLahanById(_lahanId);
            if (lahan != null)
            {
                labelNamaLahan.Text = lahan.NamaLahan;
                tbLuasLahan.Text = lahan.LuasLahan.ToString() + " m²";
                tbHargaPerTahun.Text = "Rp " + lahan.HargaPerTahun.ToString("N0");
            }
            else
            {
                MessageBox.Show("Data lahan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isEditing = true;
            tbLuasLahan.ReadOnly = false; 
            tbHargaPerTahun.ReadOnly = false;
            btnSave.Enabled = true;
            MessageBox.Show("Mode edit aktif. Klik TextBox untuk mengubah nilai.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    decimal luas = decimal.Parse(tbLuasLahan.Text);
                    decimal harga = decimal.Parse(tbHargaPerTahun.Text);
                    bool success = _authcontroller.UpdateLahan(_lahanId, luas, harga);  // Tambahkan metode ini di AuthController
                    if (success)
                    {
                        MessageBox.Show("Data lahan berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isEditing = false;
                        tbLuasLahan.ReadOnly = true;
                        tbHargaPerTahun.ReadOnly = true;
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui data lahan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
