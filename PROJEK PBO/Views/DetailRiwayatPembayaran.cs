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
    public partial class DetailRiwayatPembayaran : Form
    {
        private AuthController _authController;
        private int _detailpesananId;
        private int _userId;
        public DetailRiwayatPembayaran(int DetailPesananId, int UserId)
        {
            InitializeComponent();
            _authController = new AuthController();
            _userId = UserId;
            _detailpesananId = DetailPesananId;

            LoadDetailPembayaran();
        }

        private void LoadDetailPembayaran()
        {
            var detail = _authController.GetDetailPembayaranById(_detailpesananId);

            if (detail != null)
            {
                tbNamaPenyewa.Text = detail.NamaPenyewa;
                tbNamaLahan.Text = detail.NamaLahan;
                tbWaktuSewa.Text = detail.JangkaWaktuTahun + " Tahun";
                tbHarga.Text = detail.HargaPerTahun.ToString("N0");
                tbTanggalPembayaran.Text = detail.TanggalPesan.ToString("dd MMMM yyyy");
            }
            else
            {
                MessageBox.Show("Detail pembayaran tidak ditemukan.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            _authController.showRiwayatPembayaran(this, _userId);
        }
    }
}
