using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.HelperMethods
{
    public static class RandomCodeGenerator
    {
        public static string GenerateRandomCode()
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            const string numbers = "0123456789";
            const int codeLength = 6;

            Random random = new Random();
            char[] code = new char[codeLength];
            code[0] = characters[random.Next(characters.Length)];
            code[1] = numbers[random.Next(numbers.Length)];

            for (int i = 2; i < codeLength; i++)
            {
                code[i] = characters[random.Next(characters.Length)];
            }

            for (int i = 0; i < codeLength; i++)
            {
                int j = random.Next(i, codeLength);
                char temp = code[i];
                code[i] = code[j];
                code[j] = temp;
            }

            string randomCode = new string(code);

            return randomCode;
        }
    }
}
