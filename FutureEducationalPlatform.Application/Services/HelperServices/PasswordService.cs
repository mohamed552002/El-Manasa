using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Services.HelperServices
{
    public class PasswordService : IPasswordService
    {
        private readonly int Size = 16;
        private readonly int Iteration = 10000;

        public string HashPassword(string password)
        {
            byte[] salt = new byte[Size];
            using(var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            byte[] hashed =  KeyDerivation.Pbkdf2(password, salt,KeyDerivationPrf.HMACSHA256,Iteration,256/8);
            byte[] combinedHashAndSaltBytes = new byte[Size+hashed.Length];
            Array.Copy(salt,0,combinedHashAndSaltBytes,0,Size);
            Array.Copy(hashed, 0,combinedHashAndSaltBytes,Size,hashed.Length);
            return Convert.ToBase64String(combinedHashAndSaltBytes);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            throw new NotImplementedException();
        }
    }
}
