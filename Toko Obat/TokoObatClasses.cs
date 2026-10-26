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
