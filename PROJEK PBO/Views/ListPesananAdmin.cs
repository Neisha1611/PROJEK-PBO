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
    public partial class ListPesananAdmin : Form
    {
        private AuthController _authController;
        private int _userId;
        private DataTable dtPesanan;

        public ListPesananAdmin(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            this._authController = new AuthController();

            // Load semua data pesanan
            LoadAllPesananData();
        }
        private void LoadAllPesananData()
        {
            try
            {
                // Get SEMUA pesanan untuk Admin
                dtPesanan = _authController.GetAllPesananForAdmin();

                // Bind ke DataGridView
                dataGridView1.DataSource = dtPesanan;

                // Style rows berdasarkan status
                StyleRowsByStatus();

                // Cek jika tidak ada data
                if (dtPesanan.Rows.Count == 0)
                {
                    MessageBox.Show("Belum ada pesanan dalam sistem.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data pesanan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Styling rows berdasarkan status
        private void StyleRowsByStatus()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["colStatus"].Value != null)
                {
                    string status = row.Cells["colStatus"].Value.ToString();

                    // Warna berbeda untuk status berbeda
                    if (status == "pending")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224); // Orange terang
                        row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(230, 81, 0); // Orange tua
                        row.Cells["colStatus"].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    }
                    else if (status == "Dikonfirmasi")
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233); // Hijau terang
                        row.Cells["colStatus"].Style.ForeColor = Color.FromArgb(27, 94, 32); // Hijau tua
                        row.Cells["colStatus"].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    }
                }
            }
        }

        // Event handler untuk format Rupiah
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Format kolom Total Harga
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colTotal" && e.Value != null)
            {
                decimal nilai = Convert.ToDecimal(e.Value);
                e.Value = $"Rp {nilai:N0}";
                e.FormattingApplied = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // Get ID pesanan dari row yang diklik
                int pesananId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["colId"].Value);

                // Buka form Detail Pesanan
                DetailPesananAdmin detailForm = new DetailPesananAdmin(pesananId, _userId);
                detailForm.ShowDialog(); // Modal dialog

                // Refresh data setelah tutup detail form
                LoadAllPesananData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _authController.showLandingPageAdmin(this, _userId);
        }
    }
}
