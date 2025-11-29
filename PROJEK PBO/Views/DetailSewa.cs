using System;
using PROJEK_PBO.Controllers;
using PROJEK_PBO.Models;
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
    public partial class DetailSewa : Form
    {
        private AuthController _authcontroller;
        private int _lahanId;
        private int _userId;
        private PROJEK_PBO.Models.Lahan lahan;
        public DetailSewa(int lahanId, int userId)
        {
            InitializeComponent();
            this._authcontroller = new AuthController();
            this._lahanId = lahanId;
            this._userId = userId;
        }

        private void DetailSewa_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDetailLahan();
                tbLuasLahan.ReadOnly = true;
                tbHargaPerTahun.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Detail Sewa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadDetailLahan()
        {
            lahan = _authcontroller.GetLahanById(_lahanId);
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

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (lahan == null)
            {
                MessageBox.Show("Data lahan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbJangkaWaktu.Text))
            {
                MessageBox.Show("Jangka waktu harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse jangka waktu dari textbox
            if (!int.TryParse(tbJangkaWaktu.Text, out int jangkawaktu) || jangkawaktu <= 0)
            {
                MessageBox.Show("Jangka waktu harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalHarga = lahan.HargaPerTahun * jangkawaktu;

            try
            {
                int idPemesanan = _authcontroller.InsertPesanan(_userId);
                int detailId = _authcontroller.InsertDetailPesanan(idPemesanan, _lahanId, jangkawaktu, totalHarga);

                MessageBox.Show($"Pesanan berhasil dibuat!\nTotal Harga: Rp {totalHarga:N0}",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
