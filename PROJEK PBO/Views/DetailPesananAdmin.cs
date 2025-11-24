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
        private AuthController _authController;
        private int _pesananId;
        private int _adminUserId;
        private string _currentStatus;
        public DetailPesananAdmin(int pesananId, int adminUserId)
        {

            InitializeComponent();
            this._pesananId = pesananId;
            this._adminUserId = adminUserId;
            this._authController = new AuthController();

            // Setup ComboBox Status

            // Load detail pesanan
            LoadDetailPesanan();

        }
        private void LoadDetailPesanan()
        {
            try
            {
                // Get detail pesanan dari controller
                DataTable dt = _authController.GetDetailPesanan(_pesananId);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Tampilkan data ke TextBox
                    txtNama.Text = row["nama_penyewa"].ToString();
                    txtLahan.Text = row["nama_lahan"].ToString();
                    txtWaktu.Text = $"{row["jangka_waktu_tahun"]} Tahun";
                    txtHargaPerTahun.Text = $"Rp {Convert.ToDecimal(row["harga_per_tahun"]):N0}";
                    txtTotal.Text = $"Rp {Convert.ToDecimal(row["total_harga"]):N0}";

                    // Set status di ComboBox
                    _currentStatus = row["status"].ToString();
                    cmbStatus.SelectedItem = _currentStatus;

                    // Styling ComboBox berdasarkan status
                    UpdateStatusComboBoxStyle();
                }
                else
                {
                    MessageBox.Show("Data pesanan tidak ditemukan!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading detail pesanan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatusComboBoxStyle()
        {
            if (cmbStatus.SelectedItem != null)
            {
                string status = cmbStatus.SelectedItem.ToString();

                if (status == "pending")
                {
                    cmbStatus.BackColor = Color.FromArgb(255, 243, 224); // Orange
                    cmbStatus.ForeColor = Color.FromArgb(230, 81, 0);
                }
                else if (status == "Dikonfirmasi")
                {
                    cmbStatus.BackColor = Color.FromArgb(232, 245, 233); // Hijau
                    cmbStatus.ForeColor = Color.FromArgb(27, 94, 32);
                }
            }
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update styling saat status berubah
            UpdateStatusComboBoxStyle();

            // Cek apakah status berubah
            if (cmbStatus.SelectedItem != null)
            {
                string newStatus = cmbStatus.SelectedItem.ToString();

                // Jika status berubah dari pending ke Dikonfirmasi
                if (_currentStatus == "pending" && newStatus == "Dikonfirmasi")
                {
                    // Konfirmasi perubahan
                    DialogResult result = MessageBox.Show(
                        $"Apakah Anda yakin ingin mengubah status pesanan ini menjadi 'Dikonfirmasi'?\n\n" +
                        $"Penyewa: {txtNama.Text}\n" +
                        $"Lahan: {txtLahan.Text}\n" +
                        $"Total: {txtTotal.Text}\n\n" +
                        $"Setelah dikonfirmasi, status tidak dapat diubah lagi.",
                        "Konfirmasi Perubahan Status",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Simpan perubahan ke database
                        SaveStatusChange(newStatus);
                    }
                    else
                    {
                        // Kembalikan ke status lama
                        cmbStatus.SelectedItem = _currentStatus;
                    }
                }
                // Jika sudah Dikonfirmasi, tidak bisa diubah lagi
                else if (_currentStatus == "Dikonfirmasi" && newStatus != "Dikonfirmasi")
                {
                    MessageBox.Show(
                        "Status yang sudah 'Dikonfirmasi' tidak dapat diubah kembali!",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Kembalikan ke status lama
                    cmbStatus.SelectedItem = _currentStatus;
                }
            }
        }

        private void SaveStatusChange(string newStatus)
        {
            try
            {
                bool success = _authController.KonfirmasiPesanan(_pesananId);

                if (success)
                {
                    MessageBox.Show(
                        "Status pesanan berhasil diubah menjadi 'Dikonfirmasi'!",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Update current status
                    _currentStatus = newStatus;

                    // Disable ComboBox agar tidak bisa diubah lagi
                    cmbStatus.Enabled = false;
                }
                else
                {
                    MessageBox.Show(
                        "Gagal mengubah status pesanan!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    // Kembalikan ke status lama
                    cmbStatus.SelectedItem = _currentStatus;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Kembalikan ke status lama
                cmbStatus.SelectedItem = _currentStatus;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentStatus != "pending")
            {
                MessageBox.Show(
                    "Hanya pesanan dengan status 'pending' yang dapat dibatalkan!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Konfirmasi pembatalan
            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin MEMBATALKAN dan MENGHAPUS pesanan ini?\n\n" +
                $"Penyewa: {txtNama.Text}\n" +
                $"Lahan: {txtLahan.Text}\n" +
                $"Total: {txtTotal.Text}\n\n" +
                $"⚠️ PERINGATAN: Data pesanan akan dihapus permanen!",
                "Batalkan Pesanan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = _authController.TolakPesanan(_pesananId);

                    if (success)
                    {
                        MessageBox.Show(
                            "Pesanan berhasil dibatalkan dan dihapus!",
                            "Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // Tutup form dan kembali
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Gagal membatalkan pesanan!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
        }
    }
}
