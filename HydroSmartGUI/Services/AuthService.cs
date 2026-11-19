using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using HydroSmart.Models;

namespace HydroSmart.Services
{
    /// <summary>Menangani login. Password disimpan sebagai hash SHA-256, bukan teks asli.</summary>
    public class AuthService
    {
        private readonly List<User> _users = new List<User>();
        private int _nextId = 1;

        public User UserAktif { get; private set; }

        public bool SudahLogin
        {
            get { return UserAktif != null; }
        }

        public AuthService()
        {
            // Akun bawaan untuk demo
            Daftar("admin", "admin123", "Administrator", "Admin");
            Daftar("petani", "petani123", "Petani Hydro", "Petani");
        }

        public User Daftar(string username, string password, string namaLengkap, string role)
        {
            User u = new User();
            u.Id = _nextId++;
            u.Username = username.Trim().ToLower();
            u.PasswordHash = Hash(password);
            u.NamaLengkap = namaLengkap;
            u.Role = role;
            _users.Add(u);
            return u;
        }

        public bool Login(string username, string password)
        {
            string uname = (username ?? "").Trim().ToLower();
            string hash = Hash(password ?? "");
            User u = _users.Find(x => x.Username == uname && x.PasswordHash == hash);
            if (u == null) return false;
            UserAktif = u;
            return true;
        }

        private static string Hash(string teks)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(teks));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
