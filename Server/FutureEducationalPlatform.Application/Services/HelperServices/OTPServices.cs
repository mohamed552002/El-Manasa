using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.HelperMethods;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using Microsoft.Extensions.Caching.Memory;

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

        public bool VerifyOTP(string entity,string OTP)
        {
            if (!_memoryCache.TryGetValue($"{entity} OTP", out string cashedCode)) throw new NoDataFoundException("Verification code was not found or has expired");
            if (OTP != cashedCode) throw new BadRequestException("Please enter valid verificationcode");
            return true;
        }
    }
}
