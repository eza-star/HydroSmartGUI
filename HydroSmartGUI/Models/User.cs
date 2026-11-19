using System;

namespace HydroSmart.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string NamaLengkap { get; set; }
        public string Role { get; set; }   // contoh: "Admin" atau "Petani"
    }
}
