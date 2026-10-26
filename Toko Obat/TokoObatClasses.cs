using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;
using System.Security.Cryptography.Pkcs;
using MySqlConnector;

namespace Toko_Obat
{
    public static class Databases
    {
        private static readonly string connString = "Server=localhost;Port=3306;Database=tokoobat;User ID=root;Password=;";

        public static MySqlConnection GetConn()
        {
            return new MySqlConnection(connString);
        }

        public static void CatatLog(string pesanAktivitas)
        {
            using (SqlConnection conn = GetConn())
            {
                conn.Open();
                // Jika belum login, default pakai Id = 1 (Admin)
                int idUser = UserSession.Id > 0 ? UserSession.Id : 1;

                string query = "INSERT INTO LogAktivitas (IdUser, Aktivitas) VALUES (@idUser, @pesan)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.Parameters.AddWithValue("@pesan", pesanAktivitas);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public static class UserSession
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static bool IsLoggedIn => Id > 0;

        public static void SetUser(int id, string username, string role)
        {
            Id = id;
            Username = username;
            Role = role;
        }

        public static void Logout()
        {
            Id = 0;
            Username = null;
            Role = null;
        }
    }
}
