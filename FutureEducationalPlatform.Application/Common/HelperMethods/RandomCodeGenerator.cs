using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.HelperMethods
{
    public static class RandomCodeGenerator
    {
        public static string GenerateRandomCode() =>
            new string(Enumerable.Repeat("0123456789", 6).Select(s => s[new Random().Next(s.Length)]).ToArray());


    }
}
