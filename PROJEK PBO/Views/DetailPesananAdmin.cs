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
    public partial class DetailPesananAdmin : Form
    {
        private int _pesananId;
        private int _adminUserId;
        private AuthController _authController;
        public DetailPesananAdmin(int pesananId, int adminUserId)
        {
            InitializeComponent();
            this._pesananId = pesananId;
            this._adminUserId = adminUserId;
            this._authController = new AuthController();
            LoadDetailPesanan();
        }
        private void LoadDetailPesanan()
        {
            try
            {
                var detail = _authController.GetDetailPesananById(_pesananId);

                if (detail != null)
                {
                    txtNama.Text = detail.NamaPenyewa;
                    txtLahan.Text = detail.IdLahan.ToString();
                    txtWaktu.Text = detail.JangkaWaktuTahun.ToString() + " Tahun";
                    txtHargaPerTahun.Text = detail.HargaPerTahun.ToString("N0");
                    txtTotal.Text = detail.TotalHarga.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Detail pesanan tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal load detail pesanan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            try
            {
                _authController.KonfirmasiPesanan(_pesananId);
                MessageBox.Show("Pesanan berhasil dikonfirmasi dan sewa dibuat.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _authController.showListPesananAdmin(this, _adminUserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal konfirmasi pesanan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatalPesanan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Apakah Anda yakin ingin membatalkan pesanan ini?",
                    "Konfirmasi Pembatalan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    _authController.BatalkanPesanan(_pesananId);
                    MessageBox.Show(
                        "Pesanan berhasil dibatalkan.",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    _authController.showListPesananAdmin(this, _adminUserId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Gagal membatalkan pesanan: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _authController.showListPesananAdmin(this, _adminUserId);
        }
    }
}
