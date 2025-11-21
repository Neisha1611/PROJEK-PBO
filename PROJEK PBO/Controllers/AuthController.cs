using Npgsql;
using PROJEK_PBO.Database;
using PROJEK_PBO.Models;
using PROJEK_PBO.Views;
using PROJEK_PBO.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_PBO.Controllers
{
    public class AuthController
    {
        private DbContext _dbContext;

        public AuthController()
        {
            _dbContext = new DbContext();
        }

        public (string Role, int UserId) Login(User user)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();
            string query = "SELECT id, is_admin FROM users WHERE email = @email AND password = @password LIMIT 1";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);

            using var read = cmd.ExecuteReader();
            if (read.Read())
            {
                int id = read.GetInt32(0);
                bool isAdmin = read.GetBoolean(1);
                return (isAdmin ? "admin" : "user",id);
            }

            return ("invalid",0);
        }


        public bool DaftarAkun(User user)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();
            string query = "INSERT INTO users(nama, nomor_telepon, alamat, email, password) VALUES(@nama, @nomor_telepon, @alamat, @email, @password)";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama", user.Nama);
            cmd.Parameters.AddWithValue("@nomor_telepon", user.Nomor_Telpon);
            cmd.Parameters.AddWithValue("@alamat", user.Alamat);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ProfileUser(int Id)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            string query = @"SELECT id, nama, nomor_telepon, alamat, email 
                     FROM users
                     WHERE id = @Id";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            using var adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }


        public void showLogin(Form form)
        {
            form.Hide();
            Login login = new Login();
            login.Show();
        }

        public void showDaftarAkun(Form form)
        {
            form.Hide();
            DaftarAkun daftarAkun = new DaftarAkun();
            daftarAkun.Show();
        }

        public void showLandingPage(Form form, int userId)
        {
            form.Hide();
            V_LandingPage landingPage = new V_LandingPage(userId);
            landingPage.Show();
        }

        public void showLandingPageAdmin(Form form, int userId)
        {
            form.Hide();
            V_LandingPageAdmin landingPageAdmin = new V_LandingPageAdmin(userId);
            landingPageAdmin.Show();
        }

        public void showProfile(Form form, int userId)
        {
            form.Hide();
            Profile profile = new Profile(userId);
            profile.Show();
        }
    }
}
