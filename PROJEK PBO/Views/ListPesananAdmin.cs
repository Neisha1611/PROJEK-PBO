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
        public ListPesananAdmin(int userId)
        {
            InitializeComponent();
            this._authController = new AuthController();
            this._userId = userId;
            LoadPesanan();
        }

        private void LoadPesanan()
        {
            try
            {
                dgvPesanan.AutoGenerateColumns = false;
                DataTable dt = _authController.GetAllDetailPesanan();
                dgvPesanan.Columns["id_detail"].DataPropertyName = "id_detail";
                dgvPesanan.Columns["nama_pemesan"].DataPropertyName = "nama_pemesan";
                dgvPesanan.Columns["id_pemesanan"].DataPropertyName = "id_pemesanan";
                dgvPesanan.Columns["id_lahan"].DataPropertyName = "id_lahan";
                dgvPesanan.Columns["tanggal"].DataPropertyName = "tanggal_pemesanan";
                dgvPesanan.Columns["jangka_waktu"].DataPropertyName = "jangka_waktu";
                dgvPesanan.Columns["harga"].DataPropertyName = "harga_sewa";
                dgvPesanan.Columns["status"].DataPropertyName = "status";

                dgvPesanan.DataSource = dt;
                dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data pesanan: " + ex.Message);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            _authController.showLandingPageAdmin(this, _userId);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadPesanan();
        }

        private void dgvPesanan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idDetail = Convert.ToInt32(dgvPesanan.Rows[e.RowIndex].Cells["id_detail"].Value);
                _authController.showDetailPesananAdmin(this, idDetail, _userId);
            }
        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
