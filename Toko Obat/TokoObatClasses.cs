using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Security.Cryptography.Pkcs;

namespace Toko_Obat
{
    public static class Databases
    {
        private static readonly string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TokoObat;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConn()
        {
            return new SqlConnection(connString);
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
