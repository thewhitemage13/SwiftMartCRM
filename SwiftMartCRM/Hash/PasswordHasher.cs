using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SwiftMart.Hash
{

    /// <summary>
    /// Provides methods for hashing passwords and verifying them.
    /// Uses PBKDF2 with SHA-256 for password hashing and salt to enhance security.
    /// </summary>
    public class PasswordHasher
    {
        private const int SaltSize = 16; 
        private const int HashSize = 32; 
        private const int Iterations = 100_000;

        /// <summary>
        /// Hashes a password using PBKDF2 with a salt.
        /// </summary>
        /// <param name="password">The password to hash.</param>
        /// <returns>A string containing the salt and hash encoded in Base64.</returns>
        /// <remarks>
        /// This method uses the Rfc2898DeriveBytes class to hash the password with a randomly generated salt.
        /// The resulting salt and hash are combined and returned as a Base64-encoded string.
        /// </remarks>
        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                byte[] hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// Verifies if the given password matches the stored hash.
        /// </summary>
        /// <param name="password">The entered password to verify.</param>
        /// <param name="storedHash">The stored hash of the password to compare against.</param>
        /// <returns>True if the password is correct, otherwise False.</returns>
        /// <remarks>
        /// This method decodes the stored hash, extracts the salt and hash, then re-hashes the entered password
        /// with the same salt and compares the results.
        /// </remarks>
        public static bool VerifyPassword(string password, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            byte[] storedPasswordHash = new byte[HashSize];
            Array.Copy(hashBytes, SaltSize, storedPasswordHash, 0, HashSize);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] computedHash = pbkdf2.GetBytes(HashSize);

                return CryptographicOperations.FixedTimeEquals(storedPasswordHash, computedHash);
            }
        }
    }
}
