using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.HelperMethods;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Services.HelperServices
{
    public class OTPServices : IOTPServices
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IEmailSender _emailSender;

        public OTPServices(IMemoryCache memoryCache, IEmailSender emailSender)
        {
            _memoryCache = memoryCache;
            _emailSender = emailSender;
        }

        public void SendOTP(string email,string entity)
        {
            try
            {
                var code = RandomCodeGenerator.GenerateRandomCode();
                _memoryCache.Set($"{entity} OTP", code, TimeSpan.FromMinutes(10));
                _emailSender.SendEmail(email, "رمز التحقق", $"Your OTP Is {code}");
            }
            catch
            {
                new BadRequestException("Something went wrong Please try again");
            }
        }
    }
}
