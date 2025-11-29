using Npgsql;
using PROJEK_PBO.Database;
using PROJEK_PBO.Models;
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
        
        public PROJEK_PBO.Models.Lahan GetLahanById(int lahanId)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();
            string query = @"SELECT id, nama_lahan, luas_lahan, harga_per_tahun 
                    FROM lahan 
                    WHERE id = @lahanId";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@lahanId", lahanId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new PROJEK_PBO.Models.Lahan
                {
                    Id = reader.GetInt32(0),
                    NamaLahan = reader.GetString(1),
                    LuasLahan = reader.GetDecimal(2),
                    HargaPerTahun = reader.GetDecimal(3)
                };
            }
            return null;
        }

        public bool UpdateLahan(int lahanId, decimal luasLahan, decimal hargaPerTahun)
        {
            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();
                string query = @"UPDATE lahan 
                        SET luas_lahan = @luasLahan, 
                            harga_per_tahun = @hargaPerTahun 
                        WHERE id = @lahanId";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@luasLahan", luasLahan);
                cmd.Parameters.AddWithValue("@hargaPerTahun", hargaPerTahun);
                cmd.Parameters.AddWithValue("@lahanId", lahanId);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error update lahan: {ex.Message}");
            }
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
        public int InsertDetailPesanan(int idPemesanan, int idLahan, int jangkaWaktuTahun, decimal totalHarga)
        {
            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();
                string query = @"INSERT INTO detail_pemesanan (id_pemesanan, id_lahan, jangka_waktu, harga_sewa, status, tanggal_pemesanan) 
                             VALUES (@idPemesanan, @idLahan, @jangkaWaktu, @totalHarga, 'pending', NOW()) RETURNING id_detail;";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idPemesanan", idPemesanan);
                cmd.Parameters.AddWithValue("@idLahan", idLahan);
                cmd.Parameters.AddWithValue("@jangkaWaktu", jangkaWaktuTahun);
                cmd.Parameters.AddWithValue("@totalHarga", totalHarga);

                return (int)cmd.ExecuteScalar();
            }

            catch (Exception ex)
            {
                throw new Exception($"Error insert detail_pemesanan: {ex.Message}");
            }
        }
        public int InsertPesanan(int userId)
        {
            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();

                string query = @"INSERT INTO pemesanan (id_pengguna)
                         VALUES (@userId)
                         RETURNING id_pemesanan;";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error insert pesanan: {ex.Message}");
            }
        }
        public bool IsLahanDisewa(int idLahan)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            string query = @"SELECT COUNT(*) FROM detail_pemesanan 
                     WHERE id_lahan = @idLahan AND status IN ('pending', 'aktif')";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idLahan", idLahan);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0; // true jika lahan sedang disewa
        }

        public bool LahanSedangDisewa(int idLahan)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            string query = @"SELECT status_sewa, tanggal_sewa, jangka_waktu
                     FROM sewa
                     WHERE id_lahan = @idLahan AND status_sewa = 'berjalan'
                     ORDER BY tanggal_sewa DESC
                     LIMIT 1";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idLahan", idLahan);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                DateTime tanggalSewa = reader.GetDateTime(1); // tanggal_sewa
                int jangka = reader.GetInt32(2); // jangka_waktu, misal dalam tahun
                DateTime tanggalAkhir = tanggalSewa.AddYears(jangka); // sesuaikan satuan jangka

                if (DateTime.Now <= tanggalAkhir)
                    return true; // masih disewa
                else
                    return false; // masa sewa habis
            }

            return false; // tidak ada sewa berjalan
        }

        public void KonfirmasiPesanan(int idDetailPesanan)
        {
            using (var conn = new NpgsqlConnection(_dbContext.connStr))
            {
                conn.Open();
                string updateQuery = @"UPDATE detail_pemesanan
                               SET status = 'terkonfirmasi'
                               WHERE id_detail = @idDetailPesanan";
                using var cmdUpdate = new NpgsqlCommand(updateQuery, conn);
                cmdUpdate.Parameters.AddWithValue("@idDetailPesanan", idDetailPesanan);
                cmdUpdate.ExecuteNonQuery();
            }

            using (var conn = new NpgsqlConnection(_dbContext.connStr))
            {
                conn.Open();
                string selectQuery = @"SELECT id_pemesanan, id_lahan, jangka_waktu, harga_sewa
                               FROM detail_pemesanan
                               WHERE id_detail = @idDetailPesanan";
                using var cmdSelect = new NpgsqlCommand(selectQuery, conn);
                cmdSelect.Parameters.AddWithValue("@idDetailPesanan", idDetailPesanan);
                using var reader = cmdSelect.ExecuteReader();
                if (reader.Read())
                {
                    int idPemesanan = reader.GetInt32(0);
                    int idLahan = reader.GetInt32(1);
                    int jangkaWaktu = reader.GetInt32(2);

                    reader.Close();

                    string userQuery = @"SELECT id_pengguna FROM pemesanan WHERE id_pemesanan = @idPemesanan";
                    using var cmdUser = new NpgsqlCommand(userQuery, conn);
                    cmdUser.Parameters.AddWithValue("@idPemesanan", idPemesanan);
                    int idUser = (int)cmdUser.ExecuteScalar();

                    string insertQuery = @"INSERT INTO sewa (status_sewa, tanggal_sewa, jangka_waktu, id_user, id_lahan)
                                   VALUES ('berjalan', NOW(), @jangka, @idUser, @idLahan)";
                    using var cmdInsert = new NpgsqlCommand(insertQuery, conn);
                    cmdInsert.Parameters.AddWithValue("@jangka", jangkaWaktu);
                    cmdInsert.Parameters.AddWithValue("@idUser", idUser);
                    cmdInsert.Parameters.AddWithValue("@idLahan", idLahan);
                    cmdInsert.ExecuteNonQuery();
                }
            }
        }

        public void BatalkanPesanan(int pesananId)
        {
            try
            {
                using var conn = new NpgsqlConnection(_dbContext.connStr);
                conn.Open();

                // Update status detail_pemesanan menjadi 'dibatalkan'
                string query = @"UPDATE detail_pemesanan 
                        SET status = 'dibatalkan' 
                        WHERE id_detail = @idDetail AND status = 'pending'";

                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idDetail", pesananId);

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    throw new Exception("Pesanan tidak dapat dibatalkan. Hanya pesanan dengan status 'pending' yang bisa dibatalkan.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error batalkan pesanan: {ex.Message}");
            }
        }

        public DataTable GetAllDetailPesanan()
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            string query = @"SELECT 
                    dp.id_detail,
                    dp.id_pemesanan,
                    dp.id_lahan,
                    dp.tanggal_pemesanan,
                    dp.jangka_waktu,
                    dp.harga_sewa,
                    dp.status,
                    u.nama AS nama_pemesan
                FROM detail_pemesanan dp
                INNER JOIN pemesanan p ON dp.id_pemesanan = p.id_pemesanan
                INNER JOIN users u ON p.id_pengguna = u.id
                ORDER BY dp.tanggal_pemesanan DESC";  

            using var cmd = new NpgsqlCommand(query, conn);
            using var adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public Detail_Pesanan GetDetailPesananById(int idDetail)
        {
            using var conn = new NpgsqlConnection(_dbContext.connStr);
            conn.Open();

            string query = @"SELECT 
                        dp.id_detail AS id_detail,
                        dp.id_pemesanan,
                        dp.id_lahan AS id_lahan,
                        dp.tanggal_pemesanan,
                        dp.jangka_waktu AS jangka_waktu,
                        dp.harga_sewa AS harga_sewa,
                        dp.status,
                        u.nama AS nama_pemesan,
                        l.nama_lahan AS nama_lahan,
                        dp.harga_sewa * dp.jangka_waktu AS total_harga
                    FROM detail_pemesanan dp
                    INNER JOIN pemesanan p ON dp.id_pemesanan = p.id_pemesanan
                    INNER JOIN users u ON p.id_pengguna = u.id
                    INNER JOIN lahan l ON dp.id_lahan = l.id
                    WHERE dp.id_detail = @idDetail";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idDetail", idDetail);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Detail_Pesanan
                {
                    Id = Convert.ToInt32(reader["id_detail"]),
                    IdLahan = Convert.ToInt32(reader["id_lahan"]),
                    TotalHarga = Convert.ToDecimal(reader["total_harga"]),
                    JangkaWaktuTahun = Convert.ToInt32(reader["jangka_waktu"]),
                    NamaPenyewa = reader["nama_pemesan"].ToString(),
                    HargaPerTahun = Convert.ToDecimal(reader["harga_sewa"])
                };
            }
            else
            {
                return null;
            }
        }

        public void showDetailSewa(Form form, int lahanId, int userId)
        {
            form.Hide();
            DetailSewa detailSewa = new DetailSewa(lahanId, userId);
            detailSewa.FormClosed += (s, e) => form.Show();
            detailSewa.Show();
        }
        public void showLaporan(Form form, int adminUserId)
        {
            form.Hide();
            Laporan laporanLahan = new Laporan(adminUserId);
            laporanLahan.Show();
        }
        public void showPembayaran(Form form, int userId)
        {
            form.Hide();
            Pembayaran pembayaran = new Pembayaran(userId);
            pembayaran.Show();
        }
        public void showDetailPesanan(Form form, int detailPesananId, int userId)
        {
            form.Hide();
            DetailPesanan detailPesanan = new DetailPesanan(detailPesananId, userId);
            detailPesanan.Show();
        }

        public void showRiwayatPembayaran(Form form, int userId)
        {
            form.Hide();
            RiwayatPembayaran riwayatPembayaran = new RiwayatPembayaran(userId);
            riwayatPembayaran.Show();
        }

        public void showSewaLahan(Form form, int userId)
        {
            form.Hide();
            SewaLahan sewaLahan = new SewaLahan(userId);
            sewaLahan.Show();
        }

        public void showDetailLahan(Form form, int lahanId, int userId)
        {
            form.Hide();
            DetailLahan detailLahan = new DetailLahan(lahanId, userId);
            detailLahan.FormClosed += (s, e) => form.Show();
            detailLahan.Show();
        }

        public void showAkunPenyewa(Form form, int adminUserId)
        {
            form.Hide();
            AkunPenyewa akunPenyewa = new AkunPenyewa(adminUserId);
            akunPenyewa.Show();
        }


        public void showLahan(Form form, int userId)
        {
            form.Hide();
            PROJEK_PBO.Views.Lahan lahan = new PROJEK_PBO.Views.Lahan(userId);
            lahan.Show();
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
        public void showDetailPesananAdmin(Form form, int detailPesananId, int adminUserId)
        {
            form.Hide();
            DetailPesananAdmin detailPesananAdmin = new DetailPesananAdmin(detailPesananId, adminUserId);
            detailPesananAdmin.Show();
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
            landingPageAdmin.FormClosed += (s, e) => form.Close();
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
