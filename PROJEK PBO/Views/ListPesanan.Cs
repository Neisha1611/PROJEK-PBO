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
    public partial class ListPesanan : Form
    {
        private AuthController _authController;
        private int _userId;
        private DataTable dtPesanan;
        public ListPesanan(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            this._authController = new AuthController();

            SetupDataGridView();
            LoadPesananData();
        }

        private void SetupDataGridView()
        {
            // Clear columns jika ada
            dataGridView1.Columns.Clear();

            // Set properties DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 35;

            // Column ID Pesanan
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "colId";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "id_pesanan";
            colId.Width = 50;
            colId.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(colId);

            // Column Nama Penyewa
            DataGridViewTextBoxColumn colNama = new DataGridViewTextBoxColumn();
            colNama.Name = "colNama";
            colNama.HeaderText = "Nama Penyewa";
            colNama.DataPropertyName = "nama_penyewa";
            colNama.Width = 130;
            dataGridView1.Columns.Add(colNama);

            // Column Nama Lahan
            DataGridViewTextBoxColumn colLahan = new DataGridViewTextBoxColumn();
            colLahan.Name = "colLahan";
            colLahan.HeaderText = "Nama Lahan";
            colLahan.DataPropertyName = "nama_lahan";
            colLahan.Width = 120;
            dataGridView1.Columns.Add(colLahan);

            // Column Total Harga
            DataGridViewTextBoxColumn colHarga = new DataGridViewTextBoxColumn();
            colHarga.Name = "colHarga";
            colHarga.HeaderText = "Total Harga";
            colHarga.DataPropertyName = "total_harga";
            colHarga.Width = 120;
            colHarga.DefaultCellStyle.Format = "N0"; // Format ribuan
            colHarga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(colHarga);

            // Column Jangka Waktu
            DataGridViewTextBoxColumn colWaktu = new DataGridViewTextBoxColumn();
            colWaktu.Name = "colWaktu";
            colWaktu.HeaderText = "Waktu (Tahun)";
            colWaktu.DataPropertyName = "jangka_waktu_tahun";
            colWaktu.Width = 80;
            colWaktu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(colWaktu);

            // Column Button Batalkan
            DataGridViewButtonColumn colBatal = new DataGridViewButtonColumn();
            colBatal.Name = "colBatal";
            colBatal.HeaderText = "Aksi";
            colBatal.Text = "Batalkan";
            colBatal.UseColumnTextForButtonValue = true;
            colBatal.Width = 90;
            colBatal.DefaultCellStyle.BackColor = Color.FromArgb(244, 67, 54); // Merah
            colBatal.DefaultCellStyle.ForeColor = Color.White;
            colBatal.DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            colBatal.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.Add(colBatal);

            // Event handler untuk button click
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // Event handler untuk styling alternating rows
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void LoadPesananData()
        {
            try
            {
                // Get data pesanan berdasarkan userId (hanya status pending)
                dtPesanan = _authController.GetPesananByUserId(_userId);

                // Bind ke DataGridView
                dataGridView1.DataSource = dtPesanan;

                // Cek jika tidak ada data
                if (dtPesanan.Rows.Count == 0)
                {
                    MessageBox.Show("Anda belum memiliki pesanan yang pending.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data pesanan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler untuk button Batalkan di DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cek apakah yang diklik adalah button Batalkan
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["colBatal"].Index)
            {
                // Konfirmasi pembatalan
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin membatalkan pesanan ini?",
                    "Konfirmasi Pembatalan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Get ID pesanan dari row yang diklik
                        int pesananId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["colId"].Value);

                        // Batalkan pesanan via controller
                        bool success = _authController.BatalkanPesanan(pesananId);

                        if (success)
                        {
                            MessageBox.Show("Pesanan berhasil dibatalkan!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload data
                            LoadPesananData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal membatalkan pesanan. Pesanan mungkin sudah dikonfirmasi.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error membatalkan pesanan: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Alternating row colors
            if (e.RowIndex % 2 == 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }

            // Styling untuk kolom Total Harga
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colHarga" && e.Value != null)
            {
                // Format Rupiah
                decimal nilai = Convert.ToDecimal(e.Value);
                e.Value = $"Rp {nilai:N0}";
                e.FormattingApplied = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _authController.showLandingPage(this, _userId);
        }
    }
}
