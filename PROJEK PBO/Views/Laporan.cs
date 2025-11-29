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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
