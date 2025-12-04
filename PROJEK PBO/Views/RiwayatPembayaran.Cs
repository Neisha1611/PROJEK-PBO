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
    public partial class RiwayatPembayaran : Form
    {
        private AuthController _authController;
        private int _userId;
        public RiwayatPembayaran(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _authController = new AuthController();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            _authController.showLandingPage(this,_userId);
        }

        private void RiwayatPembayaran_Load(object sender, EventArgs e)
        {
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            try
            {
                DataTable dtRiwayat = _authController.GetPembayaranByUserId(_userId);
                dgvRiwayatPembayaran.DataSource = dtRiwayat;
                if (dtRiwayat.Rows.Count == 0)
                {
                    MessageBox.Show("Belum ada riwayat pembayaran.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRiwayatPembayaran_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idDetail = Convert.ToInt32(dgvRiwayatPembayaran.Rows[e.RowIndex].Cells["Id"].Value);
                _authController.showDetailRiwayatPembayaran(this, idDetail, _userId);
            }
        }
    }
}
