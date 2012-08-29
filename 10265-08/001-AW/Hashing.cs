using System;
using System.Security.Cryptography;
using System.Text;

namespace _001_AW
{
    static class Hashing
    {
        static readonly UTF8Encoding encoder = new UTF8Encoding();

        public static string CreateSalt(int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buffer = new byte[size];
            rng.GetBytes(buffer);

            return Convert.ToBase64String(buffer);
        }

        public static string CreatePasswordHash(string password, string salt)
        {
            var saltAndPassword = String.Concat(password, salt);
            HashAlgorithm ha = new SHA256Managed();

            return Convert.ToBase64String(ha.ComputeHash(encoder.GetBytes(saltAndPassword)));
        }
    }
}
