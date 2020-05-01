using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace ThePub.Data
{
    public class Hasher
    {
        public static string Create(string password)
        {
            return Hash(password);
        }

        public static bool Compare(string givenPassword, string savedPasswordHash)
        {
            return Hash(givenPassword) == savedPasswordHash;
        }

        private static string Hash(string password)
        {
            // copied from -> https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/consumer-apis/password-hashing?view=aspnetcore-3.1
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
        }
    }
}
