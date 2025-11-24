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
        public User GetUserById(int userId)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();
            string query = @"SELECT id, nama, nomor_telepon, alamat, email, password, is_admin 
                    FROM users 
                    WHERE id = @userId";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new User
                {
                    Id = reader.GetInt32(0),
                    Nama = reader.GetString(1),
                    Nomor_Telpon = reader.GetString(2),
                    Alamat = reader.GetString(3),
                    Email = reader.GetString(4),
                    Password = reader.GetString(5),
                    IsAdmin = reader.GetBoolean(6)
                };
            }
            return null;
        }

        // Update profile user (nama, alamat, telepon, email)
        public bool UpdateProfile(int userId, string nama, string alamat, string nomorTelepon, string email)
        {
            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();
                string query = @"UPDATE users 
                        SET nama = @nama, 
                            alamat = @alamat, 
                            nomor_telepon = @nomorTelepon, 
                            email = @email 
                        WHERE id = @userId";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@nomorTelepon", nomorTelepon);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@userId", userId);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error update profile: {ex.Message}");
            }
        }
        public DataTable GetPesananByUserId(int userId)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            string query = @"SELECT 
                        p.id AS id_pesanan,
                        u.nama AS nama_penyewa,
                        l.nama_lahan,
                        p.total_harga,
                        p.jangka_waktu_tahun,
                        p.status,
                        p.tanggal_pesan
                    FROM pesanan p
                    JOIN users u ON p.id_akun = u.id
                    JOIN lahan l ON p.id_lahan = l.id
                    WHERE p.id_akun = @userId 
                    AND p.status = 'pending'
                    ORDER BY p.tanggal_pesan DESC";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userId", userId);

            using var adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        // Delete/batalkan pesanan
        public bool BatalkanPesanan(int pesananId)
        {
            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();

                string query = "DELETE FROM pesanan WHERE id = @pesananId AND status = 'pending'";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pesananId", pesananId);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error batalkan pesanan: {ex.Message}");
            }
        }
        public DataTable GetDetailPesanan(int pesananId)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            string query = @"SELECT 
                        p.id AS id_pesanan,
                        u.nama AS nama_penyewa,
                        u.nomor_telepon,
                        u.email,
                        l.nama_lahan,
                        l.lokasi,
                        l.luas_lahan,
                        l.harga_per_tahun,
                        p.jangka_waktu_tahun,
                        p.total_harga,
                        p.status,
                        p.tanggal_pesan
                    FROM pesanan p
                    JOIN users u ON p.id_akun = u.id
                    JOIN lahan l ON p.id_lahan = l.id
                    WHERE p.id = @pesananId";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@pesananId", pesananId);

            using var adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void showListPesananAdmin(Form form, int adminUserId)
        {
            form.Hide();
            ListPesananAdmin listPesananAdmin = new ListPesananAdmin(adminUserId);
            listPesananAdmin.Show();
        }
        public void showListPesanan(Form form, int userId)
        {
            form.Hide();
            ListPesanan listPesanan = new ListPesanan(userId);
            listPesanan.Show();
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
