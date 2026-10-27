using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public static class Databases
    {
        // Kalimat koneksi yang sudah bersih dan aman
        private static readonly string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TokoObat;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConn()
        {
            return new SqlConnection(connString);
        }

        public static void CatatLog(string pesanAktivitas)
        {
            using (SqlConnection conn = GetConn())
            {
                conn.Open();
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
        public static string? Username { get; set; }
        public static string? Role { get; set; }

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

        public static void LakukanLogout(Form currentForm)
        {
            DialogResult dialog = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog == DialogResult.Yes)
            {
                Databases.CatatLog("Logout dari sistem");
                Logout();

                Halaman_Login? loginForm = null;
                foreach (Form f in Application.OpenForms)
                {
                    if (f is Halaman_Login login)
                    {
                        loginForm = login;
                        break;
                    }
                }

                if (loginForm != null)
                {
                    loginForm.Show();
                }
                else
                {
                    new Halaman_Login().Show();
                }

                currentForm.Close();
            }
        }
    }
}