using System;
using System.Security.Cryptography;
using System.Text;

namespace Driving_school_BusinessLayer.Utilities
{
    public static class clsHash
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

    }
}
