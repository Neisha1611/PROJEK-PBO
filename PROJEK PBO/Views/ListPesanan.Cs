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
        public ListPesanan(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            this._authController = new AuthController();
        }

        private void LoadPesanan()
        {
            try
            {
                DataTable dt = _authController.GetPesananByUserId(_userId);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Anda belum memiliki pesanan.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error load pesanan: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void setupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.Columns["idPesanan"].DataPropertyName = "id_detail";
            dataGridView1.Columns["lahan"].DataPropertyName = "nama_lahan";
            dataGridView1.Columns["waktu"].DataPropertyName = "jangka_waktu";
            dataGridView1.Columns["total"].DataPropertyName = "total_harga";
            dataGridView1.Columns["status"].DataPropertyName = "status";
            dataGridView1.Columns["tanggal"].DataPropertyName = "tanggal_pemesanan";

            dataGridView1.Columns["total"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["tanggal"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (!dataGridView1.Columns.Contains("btnBatal"))
            {
                DataGridViewButtonColumn btnBatal = new DataGridViewButtonColumn
                {
                    Name = "btnBatal",
                    HeaderText = "Aksi",
                    Text = "Batalkan",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dataGridView1.Columns.Add(btnBatal);
            }
        }
        private void ListPesanan_Load(object sender, EventArgs e)
        {
            setupDataGridView();
            LoadPesanan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _authController.showLandingPage(this, _userId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnBatal")
            {
                int idDetail = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idPesanan"].Value);
                string status = dataGridView1.Rows[e.RowIndex].Cells["status"].Value?.ToString();
                string namaLahan = dataGridView1.Rows[e.RowIndex].Cells["lahan"].Value?.ToString();

                if (status != "pending")
                {
                    MessageBox.Show(
                        "Hanya pesanan dengan status 'pending' yang dapat dibatalkan.",
                        "Tidak Dapat Dibatalkan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Apakah Anda yakin ingin membatalkan pesanan lahan '{namaLahan}'?",
                    "Konfirmasi Pembatalan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _authController.BatalkanPesananUser(idDetail, _userId);
                        MessageBox.Show(
                            "Pesanan berhasil dibatalkan.",
                            "Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadPesanan();
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
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnBatal" && e.RowIndex >= 0)
            {
                string status = dataGridView1.Rows[e.RowIndex].Cells["status"].Value?.ToString();

                if (status != "pending")
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gray;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.DarkGray;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(220, 53, 69); // Merah
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                }
            }
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "status")
            {
                string status = e.Value?.ToString();

                switch (status)
                {
                    case "pending":
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case "terkonfirmasi":
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "dibatalkan":
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                        break;
                }
            }
        }
    }
}
