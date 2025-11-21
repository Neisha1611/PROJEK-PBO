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
    public partial class Profile : Form
    {
        private AuthController _authController;
        private int _userId;
        public Profile(int userId)
        {
            InitializeComponent();
            _authController = new AuthController();
            _userId = userId;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            dataGridViewProfile.DataSource = _authController.ProfileUser(_userId);
        }

        private void linkLabelKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showLandingPage(this, _userId);
        }
    }
}
