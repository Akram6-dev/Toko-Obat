using System.Collections.Generic;
using System.Linq;
using Toko_Obat.Models;

namespace Toko_Obat.Services
{
    public class UserService
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Username = "admin", Password = "admin123", FullName = "Budi Santoso", Role = "Admin" },
            new User { Id = 2, Username = "kasir", Password = "kasir123", FullName = "Siti Rahma", Role = "Kasir" },
            new User { Id = 3, Username = "owner", Password = "owner123", FullName = "Hendra Wijaya", Role = "Owner" }
        };

        public User Login(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
            user.Id = users.Max(u => u.Id) + 1;
            users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Username = user.Username;
                existingUser.Password = user.Password;
                existingUser.FullName = user.FullName;
                existingUser.Role = user.Role;
            }
        }

        public void DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
            }
        }
    }
}