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
    public partial class DetailPesanan : Form
    {
        private AuthController _authcontroller;
        private int _detailPesananId;
        private int _userId;
        public DetailPesanan(int DetailPesananId, int UserId )
        {
            InitializeComponent();
            _authcontroller = new AuthController();
            _userId = UserId;
            _detailPesananId = DetailPesananId;

            LoadDetailPesanan();
        }

        private void LoadDetailPesanan()
        {
            try
            {
                var detail = _authcontroller.GetDetailPesananById(_detailPesananId);

                if (detail != null)
                {
                    tbJangkaWaktu.Text = detail.JangkaWaktuTahun.ToString() + " Tahun";
                    tbHargaPerTahun.Text = detail.HargaPerTahun.ToString("N0");
                    tbTotalHarga.Text = detail.TotalHarga.ToString("N0");
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

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            _authcontroller.showListPesanan(this, _userId);
        }
    }
}
