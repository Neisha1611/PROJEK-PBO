using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_PBO.Models
{
    public class User
    {
        private int _id;
        private string _nama;
        private string _email;
        private string _password;
        private string _noTelp;
        private string _alamat;
        private bool isadmin;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Nomor_Telpon
        {
            get { return _noTelp; }
            set { _noTelp = value; }
        }

        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool IsAdmin
        {
            get { return isadmin; }
            set { isadmin = value; }
        }
    }
}