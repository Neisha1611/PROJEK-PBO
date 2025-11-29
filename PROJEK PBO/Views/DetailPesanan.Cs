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
            this._authcontroller = new AuthController();
            this._userId = UserId;
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            _authcontroller.showListPesanan(this, _userId);
        }
    }
}
