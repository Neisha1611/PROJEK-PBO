using System;
using PROJEK_PBO.Controllers;
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
    public partial class Laporan : Form
    {
        private AuthController _authController;
        private int _userId;
        public Laporan(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _authController = new AuthController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _authController.showLandingPageAdmin(this, _userId);
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            LoadPendapatan();
        }

        private void LoadPendapatan()
        {
            try
            {
                DataTable dt = _authController.GetPendapatanPerTahun();
                dgvPendapatanAdmin.DataSource = dt;

                dgvPendapatanAdmin.Columns["tahun"].HeaderText = "Tahun";
                dgvPendapatanAdmin.Columns["total_pendapatan"].HeaderText = "Total Pendapatan";

                dgvPendapatanAdmin.Columns["total_pendapatan"].DefaultCellStyle.Format = "N0"; 
                dgvPendapatanAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Belum ada transaksi terkonfirmasi!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
