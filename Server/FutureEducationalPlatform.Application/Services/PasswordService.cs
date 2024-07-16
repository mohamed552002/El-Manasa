using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace FutureEducationalPlatform.Application.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly int Size = 16;
        private readonly int Iteration = 10000;
        public string HashPassword(string password)
        {
            byte[] salt = new byte[Size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            byte[] hashed = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA256, Iteration, 256 / 8);
            byte[] combinedHashAndSaltBytes = new byte[Size + hashed.Length];
            Array.Copy(salt, 0, combinedHashAndSaltBytes, 0, Size);
            Array.Copy(hashed, 0, combinedHashAndSaltBytes, Size, hashed.Length);
            return Convert.ToBase64String(combinedHashAndSaltBytes);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            byte[] combinedBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[Size];
            byte[] storedHash = new byte[combinedBytes.Length - Size];
            Array.Copy(combinedBytes, 0, salt, 0, Size);
            Array.Copy(combinedBytes, Size, storedHash, 0, storedHash.Length);
            byte[] computedHash = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA256, Iteration, storedHash.Length);
            for (int i = 0; i < storedHash.Length; i++)
            {
                if (storedHash[i] != computedHash[i])
                    return false;
            }
            return true;
        }
        public void ChangePassword(User user, string oldPassword, string newPassword)
        {
            var passwordVerfication = VerifyPassword(oldPassword, user.PasswordHash);
            if (!passwordVerfication)
                throw new BadRequestException("Old Password is wrong");
            user.PasswordHash = HashPassword(newPassword);
        }
    }
}
